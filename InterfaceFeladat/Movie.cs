using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFeladat
{
    internal class Movie : IContent
    {
        private Video video;

        public Movie(Video video)
        {
            this.video = video ?? throw new ArgumentNullException(nameof(video));
        }

        public string GetTitle()
        {
            return video != null ? video.Title : string.Empty;
        }

        public int GetLenght()
        {
            return video != null ? video.Length : 0;
        }
    }
}
