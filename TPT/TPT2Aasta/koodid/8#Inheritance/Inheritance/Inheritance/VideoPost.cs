using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Inheritance
{
    class VideoPost:Post
    {
        // Member fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected double Length { get; set; }
        public VideoPost() { }
        public VideoPost(string title, double length, string videoURL, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();

            this.Title = title;
            this.Length = length;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }                     
        }
        private void TimerCallback(Object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine("Video at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }               
        }
        public void Start()
        {

        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.Length, this.VideoURL, this.SendByUsername);
        }
    }
}
