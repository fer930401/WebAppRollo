using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rollos.AccesoDatos;

namespace Rollos.LogicaNegocio
{
    public class LogicaNegocioCls
    {
        AccesoDatos.AccesoDatosCls datos;
        public LogicaNegocioCls()
        {
            datos = new AccesoDatosCls();
        }
        public List<Entidades.sp_qrollosxaut_Result> consRollos(string ef_cve, string tipdoc_cve, short? sw)
        {
            return datos.consRollos(ef_cve, tipdoc_cve, sw);
        }
        public List<Entidades.sp_WebAppRollos_Result> autorizarRollos(string articulo, string ele_cve, string calidad, decimal ele_exis_um, string uni_uso, int? batch, string cliente, int? si, int? no, int? opc)
        {
            return datos.autorizarRollos(articulo, ele_cve, calidad, ele_exis_um, uni_uso, batch, cliente, si, no, opc);
        }
    }
}
