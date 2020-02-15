using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hopper.Models
{
    public class Comment
    {
        // Bug comments allow users to communicate with each other over the status and progress of a bug.
        // Each comment contains a message that can be updated. Message edits are saved and include time stamps.

        public string User { get; set; } // TODO: update to a user object when it's ready.
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<Message> Messages { get; set; }

        public Comment(string message)
        {
            Created = DateTime.Now;
            Messages = new List<Message>();
            Message firstMessage = new Message(message);
            Messages.Add(firstMessage);
        }

        public void Update(string message)
        {
            Message newMessage = new Message(message);
            Messages.Add(newMessage);
        }
    }
}