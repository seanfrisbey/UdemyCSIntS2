using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cont = true;

            Console.Write("Enter a name for your post: ");
            var title = Console.ReadLine();

            Console.Write("Enter a description for your post: ");
            var description = Console.ReadLine();

            var post = new Post();

            post.Title = string.IsNullOrEmpty(title) ? post.Title : title;
            post.Description = string.IsNullOrEmpty(description) ? post.Description : description;

            while (cont)
            {
                Console.Write("Type \"up\" or \"down\" to upvote or downvote, " +
                                  "or type \"end\" to exit: ");
                var inputOption = Console.ReadLine();

                switch (inputOption)
                {
                    case "up":
                        post.Upvote();
                        break;
                    case "down":
                        post.Downvote();
                        break;
                    default:
                        cont = false;
                        break;
                }

            }

            Console.WriteLine("TITLE: {0}\n" +
                              "DESCRIPTION: {1}\n" +
                              "DATE CREATED: {2}\n" +
                              "VOTE COUNT: {3}",
                              post.Title, post.Description, post.DateTimeCreated, post.GetVoteScore().ToString());
        }
    }
}
