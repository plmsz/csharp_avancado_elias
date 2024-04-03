using _04_3_Eventos.Lib;
using _04_3_Eventos.Lib.Mensageiro;
using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace _04_3_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVideo.Click += EventoDeClick;
        }

        public void EventoDeClick(object sender, EventArgs e)
        {
            Video video = new Video() { Nome = "video.mp4" };

            var videoEncoder = new VideoEnconder(); //publisher
            var mailService = new Email(); //subscriber
            var smsService = new SMS(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

            videoEncoder.Encode(video);



        }
    }
}
