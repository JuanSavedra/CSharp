using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations.Entities {
    class Post {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes) {
            Moment = moment;
            Title = title;  
            Content = content;  
            Likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() { 
            StringBuilder sb =  new StringBuilder(); //Responsável por fazer a montagem da string de forma eficiente
            sb.AppendLine(Title); //Adiciona um texto ao fim
            sb.AppendLine($"{Likes} Likes - {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments) {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
