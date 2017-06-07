<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AutorizaRollo.aspx.cs" Inherits="WebAppTemplate.AutorizaRollo" %>

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
                        <div class="row">
                            <h5>Inserta alguna observacion para el elemento:<strong> <asp:Label ID="lblEle_cve" runat="server" Text=""></asp:Label></strong></h5>
                            <asp:TextBox ID="tbxObservacion" runat="server" Rows="4" Columns="50" TextMode="MultiLine"></asp:TextBox>
                            <br />
                            <br />
                        </div>
                        <div class="row">
                            <asp:Button ID="btnAutoriza" runat="server" Text="Autorizar" CssClass="btn btn-success" OnClick="btnAutoriza_Click"/>
                            <asp:Button ID="btnNoAutoriza" runat="server" Text="No autorizar" CssClass="btn btn-success" OnClick="btnNoAutoriza_Click"/>
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-danger" OnClick="btnCancelar_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
