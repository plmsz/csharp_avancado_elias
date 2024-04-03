using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _04_3_Eventos.Lib.VideoEnconder;

namespace _04_3_Eventos.Lib.Mensageiro
{
    public class SMS
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("SMS enviado para " + e.Video.Nome);
        }
    }
}
