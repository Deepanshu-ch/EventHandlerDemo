using System;

namespace EventHandlerDemo
{
    static class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Thor" };
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService();  // Subscriber
            var smsService = new SmsService();    // Another Subscriber

            // Here we are not calling it as a method so we don't have bracets here like OnVideoEncode()
            // One way to understand is this VideoEncoded which is our event contains a list of references which we add with += sign

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; 

            // before calling this method subscription must be performed else VideoEncode will return null
            videoEncoder.Encode(video);

            // Now lets remove mail service and add SMS service here
            Console.WriteLine("Removing Mail Service and Adding SMS Service");

            videoEncoder.VideoEncoded -= mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
