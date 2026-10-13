using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Video v1 = new Video("Inception", 150);
            Video v2 = new Video("Episode 1", 45);
            Video v3 = new Video("Episode 2", 50);

            
            Movie movie = new Movie(v1);
            Console.WriteLine("Movie Title: " + movie.GetTitle());
            Console.WriteLine("Movie lenght: " + movie.GetLenght());
            Series series1 = new Series("Sor1", v2);
            
            Series series2 = new Series("Sor2", new List<Video> { v2, v3 });

            Console.WriteLine("Series1 Title: " + series1.GetTitle());
            Console.WriteLine("Series1 lenght: " + series1.GetLenght());

            Console.WriteLine("Series2 Title: " + series2.GetTitle());
            Console.WriteLine("Series2 lenght: " + series2.GetLenght());

            
            StreamingPlatform platform = new StreamingPlatform();
            platform.AddContent(movie);
            platform.AddContent(series1);
            platform.AddContent(series2);

            var longest = platform.GetLongestContent();
            if (longest != null)
            {
                Console.WriteLine("Longest content: " + longest.GetTitle() + " (" + longest.GetLenght() + " minutes)");
            }
            else
            {
                Console.WriteLine("No content on the platform.");
            }
        }
    }
}
