using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace IMAGE_EDITOR_V2
{
 
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;

        void StartCamera()
        {

            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_on);
                videoCapture.Start();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void rekinat()
        {
            int i = 0;
            while (i < 100)
            {
                i++;
                System.Threading.Thread.Sleep(100);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @".\Jingle-Bells.wav";
                player.PlayLooping();
            }
        }

        private void Camera_on(object sender, NewFrameEventArgs eventArgs)
        {
            PREVIEW.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                videoCapture.Stop();
            }
            catch 
            {

                return;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAPTURE.Image = PREVIEW.Image;
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                CAPTURE.Image.Save(save.FileName);
            }
            
        }

        
    }
}
