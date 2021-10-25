using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAceleracion_DesafioUno.Entities
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public User IdUsuario { get; set; }
    }
}
