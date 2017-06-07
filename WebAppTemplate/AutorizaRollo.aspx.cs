using Rollos.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTemplate
{
    public partial class AutorizaRollo : System.Web.UI.Page
    {
        //static string CadenaConecta = @"Data Source=192.168.18.96;Initial Catalog=skytex;User ID=soludin_develop;Password=dinamico20";
        static string CadenaConecta = @"Data Source=SQL;Initial Catalog=skytex;User ID=soludin_develop;Password=dinamico20";
        string ele_cve, ef_cve, art_tip;
        int? si, no, opc, afectados, pedido, dispo;
        protected void Page_Load(object sender, EventArgs e)
        {
            ele_cve = Request["ele_cve"].ToString().TrimEnd(' ');
            si = Int32.Parse(Request["si"].ToString().TrimEnd(' '));
            no = Int32.Parse(Request["no"].ToString().TrimEnd(' '));
            opc = Int32.Parse(Request["opc"].ToString().TrimEnd(' '));
            pedido = Int32.Parse(Request["pedido"].ToString().TrimEnd(' '));
            dispo = Int32.Parse(Request["dispo"].ToString().TrimEnd(' '));
            art_tip = Request["art_tip"].ToString().TrimEnd(' ');
            ef_cve = "001";
            //Response.Write(ele_cve + "-" + si + "-" + no + "-" + opc + "-" + pedido + "-" + dispo + "-" + art_tip + "-" + ef_cve);
            lblEle_cve.Text = ele_cve;
            if (opc == 0)
            {
                btnNoAutoriza.Visible = false;
                btnAutoriza.Visible = true;
            }
            else if (opc == 1)
            {
                btnNoAutoriza.Visible = true;
                btnAutoriza.Visible = false;
            }
        }

        protected void btnAutoriza_Click(object sender, EventArgs e)
        {
            string articulo, calidad, uni_uso, cliente, mensaje, sku_cve, obs;
            decimal ele_exis_um;
            int? batch, opc, si, no;
            articulo = variables.Articulo;
            calidad = "";
            ele_exis_um = 0;
            uni_uso = "";
            batch = 0;
            cliente = variables.Cliente;
            obs = tbxObservacion.Text;
            si = 1;
            no = 0;
            
            sku_cve = obtieneSku_cve(ele_cve);

            opc = 1;
            try
            {

                SqlConnection _conn = new SqlConnection(CadenaConecta);
                SqlCommand _cmd1 = new SqlCommand();
                _cmd1.Connection = _conn;
                _cmd1.CommandType = CommandType.Text;
                _cmd1.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9},{10},{11},'{12}','{13}','{14}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip, obs);
                SqlDataAdapter _da1 = new SqlDataAdapter(_cmd1);
                _conn.Open();
                afectados = _cmd1.ExecuteNonQuery();
                _conn.Close();
                /*if (afectados >= 1)
                {*/
                Response.Write("<script type=\"text/javascript\">alert('Se autorizo el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                /*}
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                }*/
            }
            catch (Exception ex)
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
            }
        }        
        protected void btnNoAutoriza_Click(object sender, EventArgs e)
        {
            string articulo, calidad, uni_uso, cliente, mensaje, sku_cve, obs;
            decimal ele_exis_um;
            int? batch, opc, si, no;
            articulo = variables.Articulo;
            calidad = "";
            ele_exis_um = 0;
            uni_uso = "";
            batch = 0;
            cliente = variables.Cliente;
            obs = tbxObservacion.Text;
            si = 0;
            no = 1;

            sku_cve = obtieneSku_cve(ele_cve);

            opc = 1;
            try
            {
                SqlConnection _conn = new SqlConnection(CadenaConecta);
                SqlCommand _cmd1 = new SqlCommand();
                _cmd1.Connection = _conn;
                _cmd1.CommandType = CommandType.Text;
                _cmd1.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9},{10},{11},'{12}','{13}','{14}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip, obs);
                SqlDataAdapter _da1 = new SqlDataAdapter(_cmd1);
                _conn.Open();
                afectados = _cmd1.ExecuteNonQuery();
                _conn.Close();
                /*if (afectados >= 1)
                {*/
                Response.Write("<script type=\"text/javascript\">alert('No se autoriza el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                /*}
                else
                {
                    Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                }*/
            }
            catch (Exception ex)
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
        public string obtieneSku_cve(string ele_cve)
        {
            string sku_cve = "";
            SqlConnection _con = new SqlConnection(CadenaConecta);
            SqlCommand _cmd = new SqlCommand();
            _cmd.Connection = _con;
            _cmd.CommandType = CommandType.Text;
            _cmd.CommandText = String.Format("select sku_cve from icatarima  where ele_cve = '{0}' ", ele_cve);
            SqlDataAdapter _da = new SqlDataAdapter(_cmd);
            _con.Open();
            sku_cve = Convert.ToString(_cmd.ExecuteScalar());
            _con.Close();
            return sku_cve;
        }
    }
}