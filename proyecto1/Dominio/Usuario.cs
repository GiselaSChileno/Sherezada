using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Correo { get; set; }  
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public int Tipo { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaNormal { get;set; }
        public int Interacciones { get; set; }  

    }

}
