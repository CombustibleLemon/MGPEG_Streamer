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
using MjpegProcessor;

namespace MJPEG_Streamer_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The URL for the MJPEG stream
        /// </summary>
        private const string _mjpeg_url = "http://216.8.159.21/mjpg/video.mjpg";
        readonly MjpegDecoder _mjpeg;

        /// <summary>
        /// The constructor for MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _mjpeg = new MjpegDecoder();
            _mjpeg.FrameReady += mjpeg_FrameReady;
            _mjpeg.Error += _mjpeg_Error;
            _mjpeg.ParseStream(new Uri(_mjpeg_url));
        }

        /// <summary>
        /// Event for the MJPEG Decoder that occurs when a new frame is ready for display
        /// </summary>
        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Event for the MJPEG Decoder that occurs when there is an error
        /// </summary>
        private void _mjpeg_Error(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Event for the window that occurs when the window closes
        /// </summary>
        private void StreamWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
