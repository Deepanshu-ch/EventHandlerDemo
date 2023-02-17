using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerDemo
{

    /* Lets make custom class to send custom arguments in our events */
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder  // Publisher Class
    {
       // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // first step define a delegate

       // public event VideoEncodedEventHandler? VideoEncoded; // second step create an event

        // We can also use built in c# EventHandler so that we won't be needing a delegate so comment out first two steps

        public event EventHandler<VideoEventArgs>? VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // third step raising the event and as per naming convention it should start with on and followed by name of event it also should be protected and virtual void
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) // here we are checking if there is a subscriber or not
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
            // VideoEncoded?.Invoke(this, EventArgs.Empty); // One other way to check if it is null or not by doing so it will run but won't throw exception
        }
    }
}
