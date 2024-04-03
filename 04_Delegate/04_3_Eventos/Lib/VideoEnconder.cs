using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_3_Eventos.Lib
{
    public class VideoEnconder
    {
        //Define a delegate
        //define an evente based on that delegate
        // raise the event

        //public event EventHandler<VideoEventArgs> Encoded;
        public delegate void VideoEncodedEventHandler (object source, EventArgs args);
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Convertendo video...");
            Thread.Sleep(2000);
            Console.WriteLine("Video convertido");

            OnVideoEncoded();
        }

        public virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null) VideoEncoded(this, EventArgs.Empty);
        }

    }
}
