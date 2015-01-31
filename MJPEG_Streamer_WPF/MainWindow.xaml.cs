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
        readonly MjpegDecoder _mjpeg;

        public MainWindow()
        {
            InitializeComponent();
            _mjpeg = new MjpegDecoder();
            _mjpeg.FrameReady += mjpeg_FrameReady;
            _mjpeg.Error += _mjpeg_Error;
            _mjpeg.ParseStream(new Uri(""));
        }

        private void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _mjpeg_Error(object sender, ErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void StreamWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
