using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rollos.LogicaNegocio
{
    public class variables
    {
        static string pedido;
        public static string Pedido
        {
            get { return variables.pedido; }
            set { variables.pedido = value; }
        }
        static string dispo;
        public static string Dispos
        {
            get { return variables.dispo; }
            set { variables.dispo = value; }
        }
        static string cliente;
        public static string Cliente
        {
            get { return variables.cliente; }
            set { variables.cliente = value; }
        }
        static string articulo;
        public static string Articulo
        {
            get { return variables.articulo; }
            set { variables.articulo = value; }
        }
    }
}
