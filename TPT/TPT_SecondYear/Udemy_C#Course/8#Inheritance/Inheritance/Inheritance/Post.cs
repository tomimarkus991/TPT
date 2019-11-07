using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Post
    {
        private static int currentPostId;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }
        public Post()
        {
            IsPublic = true;
            ID = 551341;
            Title = "Picture DOGGO";
            SendByUsername = "Glaaxy991";            
        }
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.IsPublic = isPublic;
            this.Title = title;
            this.SendByUsername = sendByUsername;
        }
        protected int GetNextID()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
