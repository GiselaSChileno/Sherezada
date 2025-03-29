using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comentarios
    {
        public int IdCom {  get; set; }
        public int IdUs { get; set; }
        public int IdCap { get; set; }  
        public string UsNombre { get; set; }
        public string Comentario { get; set; }
        public int Likes { get; set; }
    }
}
