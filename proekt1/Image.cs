using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace proekt1
{
    class ImagePicture
    {
        public int Id { get; private set; }
        public Image image { get; private set; }
        public int rating;
        

        public ImagePicture(Image image, int i)
        {
            this.image = image;
            this.Id = i;
        }
    }
}
