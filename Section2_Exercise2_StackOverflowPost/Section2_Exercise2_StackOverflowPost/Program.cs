using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2_Exercise2_StackOverflowPost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I need help with my app! This is my problem...");
            Post.UpVote();
            //upvote
            //upvote
            //upvote
            //downvote
        }
    }

    public class Post
    {
        int counter = 0;

        public void UpVote()
        {
            counter++;
        }

        public static void DownVote()
        {
            counter--;
        }
    }
}
