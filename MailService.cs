using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerDemo
{
    // This is subscriber
    public class MailService  // Subscriber Class
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)  // This is our Event Handler
        {
            Console.WriteLine("Sending an Email...." + e.Video.Title);
        }
    }
}
