using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Threading;
using System.IO;
using Emgu.CV.Structure;

namespace IMAGE_EDITOR_V2
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public BitmapImage bitmapImage;
        


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(DispatcherTimer_Tick);
            timer.Interval = TimeSpan.FromMilliseconds(100);
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            AdornerLayer.GetAdornerLayer(MyCanva).Add(new Resize_image(pic));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\Jingle-Bells.wav";
            player.PlayLooping();
            play.Visibility = Visibility.Hidden;
            mute.Visibility = Visibility.Visible;
            timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(filename);
                bitmapImage.EndInit();
                pic.Source = bitmapImage;
                

                //calculation image size
                float width = bitmapImage.PixelWidth;
                float height = bitmapImage.PixelHeight;
                float size = (width * height * 24) / (8 * 1024 * 1024);
                Imgsize.Text = "Image Size: " + size.ToString() + " MB";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Image"; // Default file name
            if (jpeg.IsCheckable == true)
            {
                dlg.DefaultExt = ".jpg";

            }
            else if (png.IsCheckable == true)
            {
                dlg.DefaultExt = ".png";
            }
            else if (bpm.IsCheckable == true)
            {
                dlg.DefaultExt = ".bpm";
            }

            // Default file extension
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"; // Filter files by extension
            Nullable<bool> result = dlg.ShowDialog();
            
            //Creates a new RenderTa
            //as a PNG image and saves it to a file specified rgetBitmap object and sets its width and
            //height to the actual width and height of the pic object.
            //It then encodes the RenderTargetBitmapby the filename variable,
            //which is obtained from the FileName property of a dlg object 
            if (result == true)
            {
                string filename = dlg.FileName;
                RenderTargetBitmap rtb = new RenderTargetBitmap((int)pic.ActualWidth, (int)pic.ActualHeight, 96d, 96d, PixelFormats.Pbgra32);
                rtb.Render(pic);
                BitmapEncoder pngEncoder = new PngBitmapEncoder();
                pngEncoder.Frames.Add(BitmapFrame.Create(rtb));
                using (System.IO.FileStream fs = System.IO.File.OpenWrite(filename))
                {
                    pngEncoder.Save(fs);
                }
            }
        }
        private void take_picture(object sender, RoutedEventArgs e)
        {
            Form1 picture_window = new Form1();
            picture_window.Show();
        }

        private void Background_Color_Click(object sender, RoutedEventArgs e)
        {

            //change window background color
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            colorDialog.ShowDialog();
            System.Drawing.Color color = colorDialog.Color;
            this.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(color.A, color.R, color.G, color.B));
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\Jingle-Bells.wav";
            player.Stop();
            mute.Visibility = Visibility.Hidden;
            play.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @".\Jingle-Bells.wav";
            player.PlayLooping();
            play.Visibility = Visibility.Hidden;
            mute.Visibility = Visibility.Visible;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            
        }
        public void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            double top1 = Canvas.GetTop(flake1);
            double top2 = Canvas.GetTop(flake2);
            double top3 = Canvas.GetTop(flake3);
            double top4 = Canvas.GetTop(flake4);
            double top5 = Canvas.GetTop(flake5);
            double top6 = Canvas.GetTop(flake6);
            double top7 = Canvas.GetTop(flake7);
            double top8 = Canvas.GetTop(flake8);
            double top9 = Canvas.GetTop(flake9);
            double top10 = Canvas.GetTop(flake10);
            double top11 = Canvas.GetTop(flake11);
            
            double[] mask = { top1, top2,top3,top4,top5,top6,top7,top8,top9,top10,top11 };
            System.Windows.Controls.Image[] flake = { flake1, flake2, flake3, flake4, flake5, flake6, flake7, flake8, flake9, flake10, flake11 };
            for (int i = 0; i < 11; i++)
            {
                if (mask[i] > 600)
                {
                    Canvas.SetTop(flake[i], -100);
                }
                else
                {
                    Canvas.SetTop(flake[i], mask[i] + 10);
                }
            }
            if (top1 > 500)
            {
                //Random r = new Random();
                //int x = 0;
                //while (true)
                //{
                //    if (x>11)
                //    {
                //        x = 0;
                //    }
                //    Canvas.SetTop(flake[x], r.Next(-10, -700));
                //    x++;
                //}
                Canvas.SetTop(flake1, -150);
                Canvas.SetTop(flake2, -340);
                Canvas.SetTop(flake3, -130);
                Canvas.SetTop(flake4, -33);
                Canvas.SetTop(flake4, -547);
                Canvas.SetTop(flake5, -660);
                Canvas.SetTop(flake6, 470);
                Canvas.SetTop(flake7, -290);
                Canvas.SetTop(flake8, -55);
                Canvas.SetTop(flake9, -213);
                Canvas.SetTop(flake10, -10);
                Canvas.SetTop(flake11, -545);
            }
        }
    }
}
