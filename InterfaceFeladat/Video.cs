using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFeladat
{
    internal class Video
    {
        string title;
        int length;

        public Video(string title, int length)
        {
            this.title = title;
            this.length = length;
        }

        public string Title { get => title; set => title = value; }
        public int Length { get => length; set => length = value; }
    }
}
