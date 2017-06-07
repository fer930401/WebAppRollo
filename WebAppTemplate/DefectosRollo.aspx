<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DefectosRollo.aspx.cs" Inherits="WebAppTemplate.DefectosRollo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1" />
    <!-- Referencia a estilos en la carpeta Content -->
    <link type="text/css" rel="stylesheet" href="<%=ResolveUrl("~/Content/bootstrap.css")%>" />

    <!-- Referencia de archivos JavaScript en la carpeta Scripts -->
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/jquery-1.10.2.js") %>"></script>
    <script type="text/javascript" src="<%= ResolveClientUrl("~/Scripts/bootstrap.js") %>"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <asp:GridView 
                        ID="gvDefectos" runat="server" HeaderStyle-BackColor="#042644" 
                        HeaderStyle-ForeColor="White" EmptyDataText="No hay defectos para mostrar" 
                        CssClass="table" AutoGenerateColumns="false">
                        <HeaderStyle Font-Bold="True" />
                        <Columns>
                            <asp:BoundField DataField="dft_cve" HeaderText="Defecto:" SortExpression="dft_cve" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre:" SortExpression="nombre" />
                            <asp:BoundField DataField="tot_dft" HeaderText="Puntos:" SortExpression="tot_dft" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
