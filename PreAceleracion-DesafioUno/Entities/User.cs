using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace PreAceleracion_DesafioUno.Entities
{
    public class User
    {
        //propiedades escalares
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }

        //propiedades de navegacion
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
