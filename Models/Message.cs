using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Message
    {
        // A Message is the main body of a bug comment.
        // A time stamp is saved when a message is created, allowing for a history of message edits in the comment.

        public string Text { get; set; }
        public DateTime Created { get; set; }

        public Message(string message)
        {
            Text = message;
            Created = DateTime.Now;
        }
    }
}