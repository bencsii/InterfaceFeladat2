using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFeladat
{
    internal class Series : IContent
    {
        private string title;
        private List<Video> videos;

       
        public Series(string title, Video firstVideo)
        {
            this.title = title;
            this.videos = new List<Video>();
            if (firstVideo != null)
            {
                this.videos.Add(firstVideo);
            }
        }

        
        public Series(string title, List<Video> videos)
        {
            this.title = title;
            this.videos = videos != null ? new List<Video>(videos) : new List<Video>();
        }

        public string GetTitle()
        {
            return title;
        }

        public int GetLenght()
        {
            int total = 0;
            foreach (var v in videos)
            {
                if (v != null)
                {
                    total += v.Length;
                }
            }
            return total;
        }
    }
}
