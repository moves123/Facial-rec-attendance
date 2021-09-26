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

namespace Facial_rec_attendance
{
    public partial class register : Form
    {
        int test2 = 0;
        private Capture camera = null;
        private Image<Bgr, Byte> current = null;
        Mat frame = new Mat();
        private bool faceenabled = false;
        CascadeClassifier fcascader = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> scanned = null;
        List<Image<Gray, Byte>> trainingdone = new List<Image<Gray, byte>>();
        List<int> labelsp = new List<int>();
        bool enableimage = false;
        private bool  traininginitiated = false;
        EigenFaceRecognizer recognizer;
        List<string> names1 = new List<string>();


        public register()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            //Dispose of Capture if it was created before
            if (camera != null) camera.Dispose();
            camera = new Capture();
            //camera.ImageGrabbed += pFrame;
            Application.Idle += pFrame;
            // camera.Start();
        }

        private void pFrame(object sender, EventArgs e)
        {
            // calling up the camera 
            if (camera != null && camera.Ptr != IntPtr.Zero)
            {
                camera.Retrieve(frame, 0);
                current = frame.ToImage<Bgr, Byte>().Resize(piccap.Width, piccap.Height, Inter.Cubic);

               
                if (faceenabled)
                {

                    //taking images from BGR to gray
                    Mat picsgray = new Mat();
                    CvInvoke.CvtColor(current, picsgray, ColorConversion.Bgr2Gray);
                    //Enhance the image to get better result
                    CvInvoke.EqualizeHist(picsgray, picsgray);

                    Rectangle[] features = fcascader.DetectMultiScale(picsgray, 1.1, 3, Size.Empty, Size.Empty);
                    
                    if (features.Length > 0)
                    {

                        foreach (var faces2 in features)
                        {
                            //Draw a box around each face 
                            CvInvoke.Rectangle(current, faces2, new Bgr(Color.Red).MCvScalar, 2);

                          
                            //Assign the face to the picture Box face picDetected
                            Image<Bgr, Byte> scannedimageoutcome = current.Convert<Bgr, Byte>();
                            scannedimageoutcome.ROI = faces2;
                            picdect1.SizeMode = PictureBoxSizeMode.StretchImage;
                            picdect1.Image = scannedimageoutcome.Bitmap;

                            if (enableimage)
                            {
                                // creating a directory if does not exist already
                                string filenamepath = Directory.GetCurrentDirectory() + @"\TrainedPictures";
                                if (!Directory.Exists(filenamepath))
                                    Directory.CreateDirectory(filenamepath); 
                                //to avoid hang, create a new task
                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        //resize the images before saving 
                                        scannedimageoutcome.Resize(200, 200, Inter.Cubic).Save(filenamepath + @"\" + txtPersonName.Text +"_"+  DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            enableimage = false;

                            if (btnadd1.InvokeRequired)
                            {
                                btnadd1.Invoke(new ThreadStart(delegate {
                                    btnadd1.Enabled = true;
                                }));
                            }
                            if (traininginitiated)
                            {
                                Image<Gray, Byte> pictureresults1 = scannedimageoutcome.Convert<Gray, Byte>().Resize(200,200,Inter.Cubic);
                                CvInvoke.EqualizeHist(pictureresults1,pictureresults1);
                                var didrection = recognizer.Predict(pictureresults1);
                                picboox1.Image = pictureresults1.Bitmap;//showing live image in gray
                                picboox2.Image = trainingdone[didrection.Label].Bitmap;//convert traing images to gray
                                if (didrection.Label != -1 && didrection.Distance < 2000)
                                {//if the face is recoGNISED  add the name plus a rectangle to be visible
                                    CvInvoke.PutText(current, names1[didrection.Label], new Point(faces2.X - 2, faces2.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(current, faces2, new Bgr(Color.Green).MCvScalar, 2);
                                }
                                else
                                {//if not then add unkown tag on the persons face 
                                    CvInvoke.PutText(current, "Undetected", new Point(faces2.X - 2, faces2.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);//
                                    CvInvoke.Rectangle(current, faces2, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }

                piccap.Image = current.Bitmap;
            }

            if (current != null)
                current.Dispose();
        }

        private void btnDetectFaces_Click(object sender, EventArgs e)
        {
            faceenabled = true;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            btnadd1.Enabled = false;
            enableimage = true;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            fromthedirectory();

        // using the datABASE  to get the student from the table
            SQLiteConnection con = new SQLiteConnection("Data Source = DB.db;version=3");
            {
                con.Open();
                SQLiteDataAdapter data = new SQLiteDataAdapter("SELECT * FROM Student ", con);
                DataTable dtbl = new DataTable();
                data.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
               

            }
        }
        //Step 4: training Images  
        private bool fromthedirectory()
        {
            int counts = 0;
            double threshold1 = 2000;
            trainingdone.Clear();
            labelsp.Clear();
            names1.Clear();
            try
            {
                string filenamepath = Directory.GetCurrentDirectory() + @"\TrainedPictures";//path of where the images are stored
                string[] lists = Directory.GetFiles(filenamepath, "*.jpg", SearchOption.AllDirectories);// format of the images

                foreach (var list in lists)
                {
                    Image<Gray, byte> ti = new Image<Gray, byte>(list).Resize(200,200,Inter.Cubic);// rezing the images lenght and width
                    CvInvoke.EqualizeHist(ti,ti);
                   trainingdone.Add(ti);
                    labelsp.Add(counts);
                    string name = list.Split('\\').Last().Split('_')[0]; 
                    names1.Add(name);//adding name to the detected face
                    counts++;
               

                }

                if (trainingdone.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(counts, threshold1);// eigenfacerecognizer classfier for face detection training
                
                    recognizer.Train(trainingdone.ToArray(), labelsp.ToArray());

                    traininginitiated = true;
                    return true;
                }
                // a negative detectin returns false with a error message
                else
                {
                    traininginitiated = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                traininginitiated = false;                
                MessageBox.Show(ex.Message);// error masg box
                return false;
            }
            
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {

        }

        private void btnclose1_Click(object sender, EventArgs e)
        {
            HomePage f2 = new HomePage();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
