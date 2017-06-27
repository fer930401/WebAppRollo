using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Rollos.LogicaNegocio;
using System.Data;
using Rollos.Entidades;
using System.Data.SqlClient;

namespace WebAppTemplate
{
    public partial class Inicio : System.Web.UI.Page
    {
        //static string CadenaConecta = @"Data Source=192.168.18.96;Initial Catalog=skytex;User ID=soludin_develop;Password=dinamico20";
        static string CadenaConecta = @"Data Source=SQL;Initial Catalog=skytex;User ID=soludin_develop;Password=dinamico20";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(variables.Pedido) == false)
                {
                    tbxFolPed.Text = variables.Pedido;
                    gv21.DataSource = llenaBloque21Filtro(Int32.Parse(variables.Pedido), 0, 0, 1);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(Int32.Parse(variables.Pedido), 0, 0, 1);
                    gv22.DataBind();
                    gvPC.DataSource = llenaBloquePCFiltro(Int32.Parse(variables.Pedido), 0, 0, 1);
                    gvPC.DataBind();
                }
                else if (string.IsNullOrEmpty(variables.Dispos) == false)
                {
                    tbxFolDispo.Text = variables.Dispos;
                    gv21.DataSource = llenaBloque21Filtro(0, Int32.Parse(variables.Dispos), 0, 2);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(0, Int32.Parse(variables.Dispos), 0, 2);
                    gv22.DataBind();
                    gvPC.DataSource = llenaBloquePCFiltro(0, Int32.Parse(variables.Dispos), 0, 2);
                    gvPC.DataBind();
                }
                else if (string.IsNullOrEmpty(variables.Dispos) == false && string.IsNullOrEmpty(variables.Pedido) == false)
                {
                    tbxFolPed.Text = variables.Pedido;
                    tbxFolDispo.Text = variables.Dispos;
                    gv21.DataSource = llenaBloque21Filtro(Int32.Parse(variables.Pedido), Int32.Parse(variables.Dispos), 0, 3);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(Int32.Parse(variables.Pedido), Int32.Parse(variables.Dispos), 0, 3);
                    gv22.DataBind();
                    gvPC.DataSource = llenaBloquePCFiltro(Int32.Parse(variables.Pedido), Int32.Parse(variables.Dispos), 0, 3);
                    gvPC.DataBind();
                }
                if (string.IsNullOrEmpty(variables.Cliente) == false)
                {
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
            }
        }

        protected void tbxFolPed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxFolPed.Text) == false && string.IsNullOrEmpty(tbxFolDispo.Text) == true)
                {
                    int pedido = Int32.Parse(tbxFolPed.Text);
                    int dispo = 0;
                    int status = 0;
                    int opc = 1;
                    variables.Pedido = tbxFolPed.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolPed.Text) == false && string.IsNullOrEmpty(tbxFolDispo.Text) == false)
                {
                    int pedido = Int32.Parse(tbxFolPed.Text);
                    int dispo = Int32.Parse(tbxFolDispo.Text);
                    int status = 0;
                    int opc = 3;
                    variables.Pedido = tbxFolPed.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolPed.Text) == true && string.IsNullOrEmpty(tbxFolDispo.Text) == false)
                {
                    int pedido = 0;
                    int dispo = Int32.Parse(tbxFolDispo.Text);
                    int status = 0;
                    int opc = 2;
                    variables.Pedido = tbxFolPed.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolPed.Text) == true && string.IsNullOrEmpty(tbxFolDispo.Text) == true)
                {
                    gv21.DataSource = null;
                    gv21.DataBind();
                    gv22.DataSource = null;
                    gv22.DataBind();
                    variables.Cliente = null;
                    variables.Pedido = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type=\"text/javascript\">alert('No se inserto un numero en la busqueda, intente de nuevo'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        protected void tbxFolDispo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbxFolDispo.Text) == false && string.IsNullOrEmpty(tbxFolPed.Text) == true)
                {
                    int pedido = 0;
                    int dispo = Int32.Parse(tbxFolDispo.Text);
                    int status = 0;
                    int opc = 2;
                    variables.Dispos = tbxFolDispo.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolDispo.Text) == false && string.IsNullOrEmpty(tbxFolPed.Text) == false)
                {
                    int pedido = Int32.Parse(tbxFolPed.Text);
                    int dispo = Int32.Parse(tbxFolDispo.Text);
                    int status = 0;
                    int opc = 3;
                    variables.Dispos = tbxFolDispo.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolDispo.Text) == true && string.IsNullOrEmpty(tbxFolPed.Text) == false)
                {
                    int pedido = Int32.Parse(tbxFolPed.Text);
                    int dispo = 0;
                    int status = 0;
                    int opc = 1;
                    variables.Dispos = tbxFolDispo.Text;
                    gv21.DataSource = llenaBloque21Filtro(pedido, dispo, status, opc);
                    gv21.DataBind();
                    gv22.DataSource = llenaBloque22Filtro(pedido, dispo, status, opc);
                    gv22.DataBind();
                    lblCliente.Text = "Cliente: <strong>" + variables.Cliente + "</strong>";
                }
                else if (string.IsNullOrEmpty(tbxFolDispo.Text) == true && string.IsNullOrEmpty(tbxFolPed.Text) == true)
                {
                    gv21.DataSource = null;
                    gv21.DataBind();
                    gv22.DataSource = null;
                    gv22.DataBind();
                    variables.Dispos = null;
                    variables.Cliente = null;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script type=\"text/javascript\">alert('No se inserto un numero en la busqueda, intente de nuevo'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        public static DataTable llenaBloque21Filtro(int FolPed, int FolDispo, int status, int opc)
        {
            LogicaNegocioCls logicaNegocio = new LogicaNegocioCls();
            List<sp_qrollosxaut_Result> conRollos21 = logicaNegocio.consRollos("001", "icautr", 0);
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("articulo", typeof(string));
            dt.Columns.Add("ele_cve", typeof(string));
            dt.Columns.Add("calidad", typeof(string));
            dt.Columns.Add("ele_exis_um", typeof(decimal));
            dt.Columns.Add("uni_uso", typeof(string));
            dt.Columns.Add("batch", typeof(string));
            dt.Columns.Add("cliente", typeof(string));
            dt.Columns.Add("SI", typeof(string));
            dt.Columns.Add("NO", typeof(string));
            dt.Columns.Add("dispo", typeof(string));
            dt.Columns.Add("fol_ped", typeof(string));

            DataRow dr;
            if (conRollos21 != null)
            {
                int i = 0;
                foreach (var elemento in conRollos21)
                {
                    dr = dt.NewRow();
                    dr["articulo"] = elemento.articulo;
                    dr["ele_cve"] = elemento.ele_cve;
                    dr["calidad"] = elemento.calidad;
                    dr["ele_exis_um"] = elemento.ele_exis_um;
                    dr["uni_uso"] = elemento.uni_uso;
                    dr["batch"] = elemento.batch;
                    dr["SI"] = elemento.SI;
                    dr["NO"] = elemento.NO;
                    dr["dispo"] = elemento.dispo;
                    dr["fol_ped"] = elemento.fol_ped;
                    if (opc == 1)
                    {
                        if (elemento.calidad.Equals("21") == true && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 2)
                    {
                        if (elemento.calidad.Equals("21") == true && elemento.dispo == FolDispo)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 3)
                    {
                        if (elemento.calidad.Equals("21") == true && elemento.dispo == FolDispo && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    i++;
                }
            }
            //return dt;
            dt.DefaultView.Sort = "dispo, batch, ele_cve asc";
            return dt.DefaultView.ToTable();
        }

        public static DataTable llenaBloque22Filtro(int FolPed, int FolDispo, int status, int opc)
        {
            LogicaNegocioCls logicaNegocio = new LogicaNegocioCls();
            List<sp_qrollosxaut_Result> conRollos22 = logicaNegocio.consRollos("001", "icautr", 0);
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("articulo", typeof(string));
            dt.Columns.Add("ele_cve", typeof(string));
            dt.Columns.Add("calidad", typeof(string));
            dt.Columns.Add("ele_exis_um", typeof(decimal));
            dt.Columns.Add("uni_uso", typeof(string));
            dt.Columns.Add("batch", typeof(string));
            dt.Columns.Add("cliente", typeof(string));
            dt.Columns.Add("SI", typeof(string));
            dt.Columns.Add("NO", typeof(string));
            dt.Columns.Add("dispo", typeof(string));
            dt.Columns.Add("fol_ped", typeof(string));

            DataRow dr;
            if (conRollos22 != null)
            {
                int i = 0;
                foreach (var elemento in conRollos22)
                {
                    dr = dt.NewRow();
                    dr["articulo"] = elemento.articulo;
                    dr["ele_cve"] = elemento.ele_cve;
                    dr["calidad"] = elemento.calidad;
                    dr["ele_exis_um"] = elemento.ele_exis_um;
                    dr["uni_uso"] = elemento.uni_uso;
                    dr["batch"] = elemento.batch;
                    dr["SI"] = elemento.SI;
                    dr["NO"] = elemento.NO;
                    dr["dispo"] = elemento.dispo;
                    dr["fol_ped"] = elemento.fol_ped;
                    if (opc == 1)
                    {
                        if (elemento.calidad.Equals("22") == true && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 2)
                    {
                        if (elemento.calidad.Equals("22") == true && elemento.dispo == FolDispo)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 3)
                    {
                        if (elemento.calidad.Equals("22") == true && elemento.dispo == FolDispo && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    i++;
                }
            }
            dt.DefaultView.Sort = "dispo, batch, ele_cve asc";
            return dt.DefaultView.ToTable();
        }

        public static DataTable llenaBloquePCFiltro(int FolPed, int FolDispo, int status, int opc)
        {
            LogicaNegocioCls logicaNegocio = new LogicaNegocioCls();
            List<sp_qrollosxaut_Result> conRollosPC = logicaNegocio.consRollos("001", "icautr", 0);
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("articulo", typeof(string));
            dt.Columns.Add("ele_cve", typeof(string));
            dt.Columns.Add("calidad", typeof(string));
            dt.Columns.Add("ele_exis_um", typeof(decimal));
            dt.Columns.Add("uni_uso", typeof(string));
            dt.Columns.Add("batch", typeof(string));
            dt.Columns.Add("cliente", typeof(string));
            dt.Columns.Add("SI", typeof(string));
            dt.Columns.Add("NO", typeof(string));
            dt.Columns.Add("dispo", typeof(string));
            dt.Columns.Add("fol_ped", typeof(string));

            DataRow dr;
            if (conRollosPC != null)
            {
                int i = 0;
                foreach (var elemento in conRollosPC)
                {
                    dr = dt.NewRow();
                    dr["articulo"] = elemento.articulo;
                    dr["ele_cve"] = elemento.ele_cve;
                    dr["calidad"] = elemento.calidad;
                    dr["ele_exis_um"] = elemento.ele_exis_um;
                    dr["uni_uso"] = elemento.uni_uso;
                    dr["batch"] = elemento.batch;
                    dr["SI"] = elemento.SI;
                    dr["NO"] = elemento.NO;
                    dr["dispo"] = elemento.dispo;
                    dr["fol_ped"] = elemento.fol_ped;
                    if (opc == 1)
                    {
                        if (elemento.calidad.Equals("11") == true || elemento.calidad.Equals("12") == true || elemento.calidad.Equals("13") == true && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 2)
                    {
                        if (elemento.calidad.Equals("11") == true || elemento.calidad.Equals("12") == true || elemento.calidad.Equals("13") == true && elemento.dispo == FolDispo)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    else if (opc == 3)
                    {
                        if (elemento.calidad.Equals("11") == true || elemento.calidad.Equals("12") == true || elemento.calidad.Equals("13") == true && elemento.dispo == FolDispo && elemento.fol_ped == FolPed)
                        {
                            variables.Cliente = elemento.cliente;
                            variables.Articulo = elemento.articulo;
                            dt.Rows.Add(dr);
                        }
                    }
                    i++;
                }
            }
            dt.DefaultView.Sort = "dispo, batch, ele_cve asc";
            return dt.DefaultView.ToTable();
        }

        protected void cbx21_CheckedChanged(object sender, EventArgs e)
        {
            string elementos21 = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gv21.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve,sku_cve,art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 1;
                    no = 0;
                    pedido = Int32.Parse(row.Cells[8].Text);
                    
                    sku_cve = obtieneSku_cve(ele_cve);

                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));

                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque 21'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementos21 = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque 21'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el bloque 21'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        protected void cbx22_CheckedChanged(object sender, EventArgs e)
        {
            string elementos22 = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gv22.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve,sku_cve, art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 1;
                    no = 0;
                    pedido = Int32.Parse(row.Cells[8].Text);

                    sku_cve = obtieneSku_cve(ele_cve);

                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));

                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementos22 = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                    //Response.Write("<script type=\"text/javascript\">alert('Se autorizo el rollo: " + articulo + " - " + ele_cve + "');</script>");
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        protected void cbxPCSI_CheckedChanged(object sender, EventArgs e)
        {
            string elementosPC = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gvPC.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve, sku_cve, art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 1;
                    no = 0;
                    pedido = Int32.Parse(row.Cells[8].Text);

                    sku_cve = obtieneSku_cve(ele_cve);

                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));

                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementosPC = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('Se autorizo todo el bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al autorizar el bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        protected void cbx21No_CheckedChanged(object sender, EventArgs e)
        {
            string elementos21 = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gv21.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve, sku_cve, art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 0;
                    no = 1;
                    pedido = Int32.Parse(row.Cells[8].Text);

                    sku_cve = obtieneSku_cve(ele_cve);
                    
                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));

                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque 21'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementos21 = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el bloque: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque 21'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar bloque 21'); window.location.href = 'Inicio.aspx';</script>");
            }
        }

        protected void cbx22No_CheckedChanged(object sender, EventArgs e)
        {
            string elementos22 = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gv22.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve, sku_cve, art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 0;
                    no = 1;
                    pedido = Int32.Parse(row.Cells[8].Text);

                    sku_cve = obtieneSku_cve(ele_cve);
                    
                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));
                    
                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementos22 = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el bloque: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                    //Response.Write("<script type=\"text/javascript\">alert('Se autorizo el rollo: " + articulo + " - " + ele_cve + "');</script>");
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el bloque 22'); window.location.href = 'Inicio.aspx';</script>");
            }
        }
       
        protected void cbxPCNO_CheckedChanged(object sender, EventArgs e)
        {
            string elementos21 = "";
            int errorAutorizacion = 0;
            foreach (GridViewRow row in gvPC.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    string articulo, ele_cve, calidad, uni_uso, cliente, mensaje, ef_cve, sku_cve, art_tip;
                    decimal ele_exis_um;
                    int? batch, opc, si, no, error, afectados, dispo, pedido;
                    ef_cve = "001";
                    articulo = Server.HtmlDecode(row.Cells[1].Text);
                    ele_cve = row.Cells[2].Text;
                    calidad = row.Cells[3].Text;
                    ele_exis_um = decimal.Parse(row.Cells[4].Text);
                    uni_uso = row.Cells[5].Text;
                    dispo = Int32.Parse(row.Cells[6].Text);
                    batch = Int32.Parse(row.Cells[7].Text);
                    cliente = variables.Cliente;
                    si = 0;
                    no = 1;
                    pedido = Int32.Parse(row.Cells[8].Text);

                    sku_cve = obtieneSku_cve(ele_cve);

                    art_tip = articulo;
                    art_tip = art_tip.Substring(art_tip.IndexOf('(') + 1);
                    art_tip = art_tip.Substring(0, art_tip.IndexOf(')'));

                    opc = 2;
                    try
                    {
                        SqlConnection _conn = new SqlConnection(CadenaConecta);
                        SqlCommand _cmd = new SqlCommand();
                        _cmd.Connection = _conn;
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = String.Format("exec sp_gautele '{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}',{8},{9}, {10}, {11},'{12}','{13}'", ef_cve, sku_cve.TrimEnd(' '), ele_cve.TrimEnd(' '), calidad.TrimEnd(' '), ele_exis_um, uni_uso.TrimEnd(' '), batch, cliente.TrimEnd(' '), si, no, dispo, pedido, sku_cve, art_tip);
                        SqlDataAdapter _da = new SqlDataAdapter(_cmd);
                        _conn.Open();
                        afectados = _cmd.ExecuteNonQuery();
                        _conn.Close();
                        /*if (afectados >= 1)
                        {*/
                        Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
                        /*}
                        else
                        {
                            errorAutorizacion = 1;
                            Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el rollo: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                        }*/
                    }
                    catch (Exception ex)
                    {
                        errorAutorizacion = 1;
                        elementos21 = ex.Message;
                        Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar el bloque: " + ele_cve + "'); window.location.href = 'Inicio.aspx';</script>");
                    }
                }
            }
            if (errorAutorizacion == 0)
            {
                Response.Write("<script type=\"text/javascript\">alert('No se autorizo todo el bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Ocurrio un error al no autorizar bloque de Piezas Cortas'); window.location.href = 'Inicio.aspx';</script>");
            }
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