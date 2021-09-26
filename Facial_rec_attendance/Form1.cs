using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Data.SQLite;
using Tulpep.NotificationWindow;

namespace Facial_rec_attendance
{
    public partial class Form1 : Form
    {
        
        
        private Capture camera = null;
        private Image<Bgr, Byte> frame1 = null;
        Mat frame2 = new Mat();
        private bool facedetectioninitiated = false;
        CascadeClassifier facecascader = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> detectoutcome = null;
        int test1 = 0;
        List<Image<Gray, Byte>> facetraining = new List<Image<Gray, byte>>();
        List<int> plabels = new List<int>();

        bool savepicture = false;
        private bool  trained = false;
        EigenFaceRecognizer identify;
        List<string> names = new List<string>();
        //string connectionstring;

       

        public Form1()
        {
            InitializeComponent();
           // connectionstring = @"Data Source = DB.db;version=3";
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (camera != null) camera.Dispose();
            camera = new Capture();
            Application.Idle += ProcessFrame;
            // camera.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (camera != null && camera.Ptr != IntPtr.Zero)
            {
                camera.Retrieve(frame2, 0);
                frame1 = frame2.ToImage<Bgr, Byte>().Resize(picDetect.Width, picDetect.Height, Inter.Cubic);

                if (facedetectioninitiated)
                {
                    Mat graypics = new Mat();
                    CvInvoke.CvtColor(frame1, graypics, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(graypics, graypics);

                    Rectangle[] people = facecascader.DetectMultiScale(graypics, 1.1, 3, Size.Empty, Size.Empty);
                    if (people.Length > 0)
                    {

                        foreach (var face in people)
                        {
                            
                          

                            Image<Bgr, Byte> detectedresults1 = frame1.Convert<Bgr, Byte>();
                            detectedresults1.ROI = face;
                            picDetected.SizeMode = PictureBoxSizeMode.StretchImage;
                            picDetected.Image = detectedresults1.Bitmap;

                            if (savepicture)
                            {
                                string filenamepath = Directory.GetCurrentDirectory() + @"\TrainedPictures";
                                if (!Directory.Exists(filenamepath))
                                    Directory.CreateDirectory(filenamepath);
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 15; i++)
                                    {
                                        //this line  needs changing
                                        detectedresults1.Resize(200, 200, Inter.Cubic).Save(filenamepath + @"\" + txtfirstname.Text +"_"+ txtsurname.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            savepicture = false;
                            // if the button is pressed it it will start the task thread
                            if (btnadd.InvokeRequired)
                            {
                                btnadd.Invoke(new ThreadStart(delegate {
                                    btnadd.Enabled = true;
                                }));
                            }

                            if (trained)
                            {//recognising the faces
                                Image<Gray, Byte> convertedimage = detectedresults1.Convert<Gray, Byte>().Resize(200,200,Inter.Cubic);
                                CvInvoke.EqualizeHist(convertedimage,convertedimage);
                                var pointer = identify.Predict(convertedimage);
                                picdetectedimg1.Image = convertedimage.Bitmap;//
                                picdetectedimg2.Image = facetraining[pointer.Label].Bitmap;
                                if (pointer.Label != -1 && pointer.Distance < 2000)
                                {
                                    CvInvoke.PutText(frame1, names[pointer.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Blue).MCvScalar);
                                    CvInvoke.Rectangle(frame1, face, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                else
                                {
                                    CvInvoke.PutText(frame1, "Undetected", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(frame1, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }

                picDetect.Image = frame1.Bitmap;
            }

            if (frame1 != null)
                frame1.Dispose();
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            facedetectioninitiated = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string name = txtfirstname.Text;
            string surname = txtsurname.Text;
            SQLiteConnection con = new SQLiteConnection("Data Source = DB.db; version = 3");
            con.Open();
            
                
               string query = "INSERT INTO Student (Name , Surname)  VALUES ('" + name + "', '" +surname + "')";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
            // might add the notification message box
            con.Close();
            PopupNotifier show = new PopupNotifier();
            show.TitleText = "System Message";
            show.ContentText = "Student added!!!!";
            show.Popup();

            btnadd.Enabled = false;
            savepicture = true;
            //con.Close;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            picturestraineddirectory();
        }
        //Step 4: train Images 
        private bool picturestraineddirectory()
        {
            int count = 0;
            double threshold = 2000;
            facetraining.Clear();
            plabels.Clear();
            names.Clear();
            try
            {
                string filenamepath = Directory.GetCurrentDirectory() + @"\TrainedPictures";
                string[] folders = Directory.GetFiles(filenamepath, "*.jpg", SearchOption.AllDirectories);

                foreach (var folder in folders)
                {
                    Image<Gray, byte> trained1 = new Image<Gray, byte>(folder).Resize(200,200,Inter.Cubic);
                    CvInvoke.EqualizeHist(trained1,trained1);
                    facetraining.Add(trained1);
                    plabels.Add(count);
                    string name = folder.Split('\\').Last().Split('_')[0]; 
                    names.Add(name);
                    count++;
                }

                if (facetraining.Count() > 0)
                {
                    identify = new EigenFaceRecognizer(count, threshold); //EigenFaceRecognizer for face training
                    identify.Train(facetraining.ToArray(), plabels.ToArray());
                    trained = true;
                    return true;
                }
                else
                {
                    trained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                trained = false;                
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            this.Hide();
            f2.ShowDialog();
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
