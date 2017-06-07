using Rollos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rollos.AccesoDatos
{
    public class AccesoDatosCls
    {
        RollosEntities contexto;
        public AccesoDatosCls()
        {
            //inicializacion de la variable contexto
            contexto = new RollosEntities();
        }
        public List<sp_qrollosxaut_Result> consRollos(string ef_cve, string tipdoc_cve, short? sw)
        {
            List<Entidades.sp_qrollosxaut_Result> consRollos = contexto.sp_qrollosxaut(ef_cve,tipdoc_cve,sw).ToList();
            SqlConnection.ClearAllPools();
            return consRollos;
        }
        public List<sp_WebAppRollos_Result> autorizarRollos(string articulo, string ele_cve, string calidad, decimal ele_exis_um, string uni_uso, int? batch, string cliente, int? si, int? no, int? opc)
        {
            List<Entidades.sp_WebAppRollos_Result> autorizaRollos = contexto.sp_WebAppRollos(articulo, ele_cve, calidad, ele_exis_um, uni_uso, batch, cliente,si, no, opc).ToList();
            SqlConnection.ClearAllPools();
            return autorizaRollos;
        }
    }
}
