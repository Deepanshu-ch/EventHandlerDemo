using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerDemo
{
    // Now lets make one more subscriber and send a SMS this time
    public class SmsService  // Subscriber Class
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending an SMS....." + e.Video.Title);
        }
    }
}
