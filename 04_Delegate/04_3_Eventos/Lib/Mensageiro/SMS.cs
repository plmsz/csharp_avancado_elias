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
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("SMS enviado ");
        }
    }
}
