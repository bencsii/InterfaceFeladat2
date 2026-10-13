using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFeladat
{
    internal class StreamingPlatform
    {
        private List<IContent> contents;

        public StreamingPlatform()
        {
            contents = new List<IContent>();
        }

        
        public void AddContent(IContent content)
        {
            if (content != null)
            {
                contents.Add(content);
            }
        }

        
        public IContent GetLongestContent()
        {
            if (contents == null || contents.Count == 0)
                return null;

            IContent longest = contents[0];
            int maxLength = longest.GetLenght();

            foreach (var c in contents)
            {
                if (c.GetLenght() > maxLength)
                {
                    longest = c;
                    maxLength = c.GetLenght();
                }
            }

            return longest;
        }
    }
}
