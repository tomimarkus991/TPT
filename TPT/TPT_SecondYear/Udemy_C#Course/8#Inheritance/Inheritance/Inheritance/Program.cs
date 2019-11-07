using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Pildike", true, "Tomi");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Nii lahe", "Tomi", "www.eki.ee", true);
            Console.WriteLine(imagePost1.ToString());

            VideoPost videoPost1 = new VideoPost("R6 Gameplay", 4, "www.youtube.com/r6_Gameplay", true, "Galaxy991");
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            videoPost1.Stop();

            Console.ReadLine();
        }
    }
}
