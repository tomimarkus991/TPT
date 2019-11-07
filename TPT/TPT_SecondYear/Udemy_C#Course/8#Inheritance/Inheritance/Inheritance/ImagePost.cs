using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ImagePost : Post
    {
        protected string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.IsPublic = isPublic;
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL ,this.SendByUsername);
        }
    }
}
