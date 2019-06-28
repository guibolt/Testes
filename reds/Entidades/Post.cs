﻿using System;
using System.Collections.Generic;
using System.Text;

namespace reds.Entidades
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string  Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {

        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        
        public void AddComent(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComent( Comment comment)
        {
            Comments.Add(comment);
        }

    }

}
