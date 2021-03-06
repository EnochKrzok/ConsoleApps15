using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    /// Enoch Jozue Krzok 1.0
    ///</author> 
    public class NewsFeed
    {
        public List<Post> Posts { get; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();

            MessagePost post = new MessagePost( "BobIsCooking" , "Im good cook");
            AddPost(post);

            PhotoPost photopost = new PhotoPost("GregOnFire", "Photo.png", "Dont let this guy cook!!");
            AddPost(photopost);
        }


        ///<summary>
        /// Add a post to the news feed.
        /// 
        /// @param post  The post to be added.
        ///</summary>
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all posts
            foreach (Post post in Posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }
}