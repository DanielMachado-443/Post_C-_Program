using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Sessao9_Exercicio2.Entities
{
    class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> PostComment = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime date, string title, string content, int likes)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comment comment)
        {
            PostComment.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            PostComment.Remove(comment);
        }

        public int AddLikes(int likes)
        {
            return Likes += likes;
        }

        public int RemoveLikes(int likes)
        {
            return Likes -= likes;
        }

        public override string ToString()
        {
            return "   Title: "
                + Title
                + "\n   Likes: "
                + Likes
                + " - "
                + "Post Date: "
                + Date
                + "\n   Content: "
                + Content
                + "\n   Comments: ";
        }
    }
}
