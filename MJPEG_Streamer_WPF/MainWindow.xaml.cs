using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using AForge.Video;

namespace MJPEG_Streamer_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MJPEGStream VideoStream;

        public MainWindow()
        {
            InitializeComponent();

            VideoStream = new MJPEGStream();
            setupVideoStream();
        }

        private void setupVideoStream()
        {
            VideoStream.Source = "http://starbucksucks.pwnage/thing.mjpeg";
            VideoStream.NewFrame += new EventHandler(VideoStream_NewFrame);
            VideoStream.Start();
        }

        private void VideoStream_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {

        }

        private void StreamWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            VideoStream.Stop();
        }
    }
}
