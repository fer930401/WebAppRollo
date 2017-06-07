using Rollos.Entidades;
using Rollos.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTemplate
{
    public partial class DefectosRollo : System.Web.UI.Page
    {
        string art_tip = "";
        string elemento = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                art_tip = Request["art_tip"].ToString().TrimEnd(' ');
                elemento = Request["elemento"].ToString().TrimEnd(' ');
                gvDefectos.DataSource = llenaTablaDefectos(art_tip, elemento);
                gvDefectos.DataBind();
            }
        }
        public static DataTable llenaTablaDefectos(string art_tip, string elemento)
        {
            LogicaNegocioCls logicaNegocio = new LogicaNegocioCls();
            List<sp_WebAppRollos_Result> consDefectos = logicaNegocio.autorizarRollos(art_tip, elemento, "", 0, "", 0, "", 0, 0, 0);
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("dft_cve", typeof(string));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("tot_dft", typeof(string));

            DataRow dr;
            if (consDefectos != null)
            {
                int i = 0;
                foreach (var defecto in consDefectos)
                {
                    dr = dt.NewRow();
                    dr["dft_cve"] = defecto.dft_cve.TrimEnd(' ');
                    dr["nombre"] = defecto.nombre.TrimEnd(' ');
                    dr["tot_dft"] = defecto.tot_dft;
                    dt.Rows.Add(dr);
                    i++;
                }
            }
            return dt;
        }
    }
}