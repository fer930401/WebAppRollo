<%@ Page Language="C#" MasterPageFile="~/Rollos.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="WebAppTemplate.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Fixed navbar -->
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#<%=gv21.ClientID%> [id='btnDefectos']").on("click", function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert(elemento);
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('DefectosRollo.aspx?art_tip='+art_tip+'&elemento='+elemento);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "Defectos",
                    close: function(e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
        });
        $(function () {
            $("#<%=gv22.ClientID%> [id='btnDefectos']").on("click", function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert(elemento);
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('DefectosRollo.aspx?art_tip=' + art_tip + '&elemento=' + elemento);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "Defectos",
                    close: function (e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
        });
        $(function () {
            $("#<%=gv21.ClientID%> input[name*='chkStatus21']").on("click", function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dispo = $("td:eq(6)", tr).html();
                var pedido = $("td:eq(8)", tr).html();
                var si = 1;
                var no = 0;
                var opc = 0;
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert("1 si");
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('AutorizaRollo.aspx?ele_cve=' + elemento + '&si=' + si + '&no=' + no + '&opc=' + opc + '&dispo=' + dispo + '&pedido=' + pedido + '&art_tip=' + art_tip);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "Autorizar",
                    close: function (e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
            $("#<%=gv21.ClientID%> input[name*='chkStatus21No']").change(function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dispo = $("td:eq(6)", tr).html();
                var pedido = $("td:eq(8)", tr).html();
                var si = 0;
                var no = 1;
                var opc = 1;
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert("1 no");
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('AutorizaRollo.aspx?ele_cve=' + elemento + '&si=' + si + '&no=' + no + '&opc=' + opc + '&dispo=' + dispo + '&pedido=' + pedido + '&art_tip=' + art_tip);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "No autorizar",
                    close: function (e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
            $("#<%=gv22.ClientID%> input[name*='chkStatus22']").on("click", function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dispo = $("td:eq(6)", tr).html();
                var pedido = $("td:eq(8)", tr).html();
                var si = 1;
                var no = 0;
                var opc = 0;
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert("1 si");
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('AutorizaRollo.aspx?ele_cve=' + elemento + '&si=' + si + '&no=' + no + '&opc=' + opc + '&dispo=' + dispo + '&pedido=' + pedido + '&art_tip=' + art_tip);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "Autorizar",
                    close: function (e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
            $("#<%=gv22.ClientID%> input[name*='chkStatus22No']").change(function () {
                var tr = $(this).parent().parent();
                var art_tip = $("td:eq(1)", tr).html();
                art_tip = art_tip.substring(art_tip.indexOf('(') + 1);
                art_tip = art_tip.substring(0, art_tip.indexOf(')'));
                var elemento = $("td:eq(2)", tr).html();
                var dispo = $("td:eq(6)", tr).html();
                var pedido = $("td:eq(8)", tr).html();
                var si = 0;
                var no = 1;
                var opc = 1;
                var dWidth = $(window).width() * 0.4;
                var dHeight = $(window).height() * 0.4;
                //alert(pedido);
                $('<div>').dialog({
                    modal: true,
                    open: function () {
                        $(this).load('AutorizaRollo.aspx?ele_cve=' + elemento + '&si=' + si + '&no=' + no + '&opc=' + opc + '&dispo=' + dispo + '&pedido=' + pedido + '&art_tip=' + art_tip);
                    },
                    width: dWidth,
                    height: dHeight,
                    draggable: false,
                    responsive: true,
                    title: "No autorizar",
                    close: function (e, ui) {
                        window.location.href = 'Inicio.aspx';
                    }
                });
            });
        });
    </script>
    <style>
        .ui-dialog {
            z-index:1000000000;
            top: 0; left: 0;
            margin: auto;
            position: fixed;
            max-width: 100%;
            max-height: 100%;
            display: flex;
            flex-direction: column;
            align-items: stretch;
            background-color:white;
        }
        .ui-dialog .ui-dialog-content {
            flex: 1;
        }
        .ui-dialog .ui-dialog-buttonpane {
            background:white;
        }
    </style>

    <div style="padding-left:25px; padding-right:25px;">
        <div class="well">
            <div class="form-inline">
                <div class="form-group">
                    <img src="Media/Imagenes/logo_skytex.png" width="50" height="50" />
                </div>
                <div class="form-group">
                    <h2>Autorización rollos en tarima</h2>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <h5>De los listados mostrados acontinuacion selecciona la opcion del renglon</h5>
                <div class="row">
                    <div class="col-md-12">
                        <strong><asp:Label ID="lbl1" runat="server" Text="Buscar el folio del pedido:"></asp:Label></strong>
                        <asp:TextBox ID="tbxFolPed" runat="server" AutoPostBack="true" OnTextChanged="tbxFolPed_TextChanged" ValidationGroup="validaPedido" onkeypress="return event.keyCode != 13;"></asp:TextBox> 
                        <asp:RegularExpressionValidator ID="validaPedidos" runat="server" ErrorMessage=" *Solo numeros " ControlToValidate="tbxFolPed" ValidationGroup="validaPedido" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    
                        <strong><asp:Label ID="lbl2" runat="server" Text="Busca el folio de Dispo:"></asp:Label></strong>
                        <asp:TextBox ID="tbxFolDispo" runat="server" AutoPostBack="true" OnTextChanged="tbxFolDispo_TextChanged" ValidationGroup="validaDispo" onkeypress="return event.keyCode != 13;" ></asp:TextBox> 
                        <asp:RegularExpressionValidator ID="validaDispos" runat="server" ErrorMessage=" *Solo numeros " ControlToValidate="tbxFolDispo" ValidationGroup="validaDispo" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                    
                        <asp:Label ID="lblCliente" runat="server" Text=""></asp:Label>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbx21" runat="server" Text="Autorizar todo el bloque 21" Checked="false" OnCheckedChanged="cbx21_CheckedChanged" AutoPostBack="true" />
                </label>
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbx21No" runat="server" Text="No autorizar todo el bloque 21" Checked="false" OnCheckedChanged="cbx21No_CheckedChanged" AutoPostBack="true" />
                </label>
                <asp:GridView ID="gv21" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#042644" HeaderStyle-ForeColor="White"
                    EmptyDataText="No hay rollos del bloque 21 para autorizar" Font-Size="X-Small">
                    <HeaderStyle Font-Bold="True" />
                    <Columns>
                        <%--<asp:TemplateField HeaderText="Autorizar:">
                            <ItemTemplate>
                                <asp:RadioButton ID="rbtSi" runat="server" Text="Si" GroupName="validaRollo" />
                                <asp:RadioButton ID="rbtNo" runat="server" Text="No" GroupName="validaRollo" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:TemplateField HeaderText="Autorizar:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkStatus21" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("SI").ToString())) %>'
                                    Text="Si"/>
                                <br />
                                <asp:CheckBox ID="chkStatus21No" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("NO").ToString())) %>'
                                    Text="No"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="articulo" HeaderText="Articulo:" SortExpression="articulo" />
                        <asp:BoundField DataField="ele_cve" HeaderText="Elemento:" SortExpression="ele_cve"  />
                        <asp:BoundField DataField="calidad" HeaderText="Calidad:" SortExpression="calidad"  />
                        <asp:BoundField DataField="ele_exis_um" HeaderText="Exist.:" SortExpression="ele_exis_um" HtmlEncode="false" DataFormatString="{0:F1}" />
                        <asp:BoundField DataField="uni_uso" HeaderText="Unidad uso:" SortExpression="uni_uso"  />
                        <asp:BoundField DataField="dispo" HeaderText="Dispo:" SortExpression="dispo" />
                        <asp:BoundField DataField="batch" HeaderText="Batch:" SortExpression="batch"  />
                        <asp:BoundField DataField="fol_ped" HeaderText="Pedido:" SortExpression="fol_ped"  />
                        <asp:TemplateField HeaderText="Defectos:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%--<asp:Button ID="btnDefectos" runat="server" CssClass="btn btn-success" Text="Defectos"/>--%>
                                <a id="btnDefectos" class="btn btn-success btn-xs">Defectos</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%-- <asp:BoundField DataField="cliente" HeaderText="Cliente:" SortExpression="cliente"  />
                        <asp:BoundField DataField="SI" HeaderText="Opcion:" SortExpression="SI"  />
                        <asp:BoundField DataField="NO" HeaderText="Opcion:" SortExpression="NO" />--%>
                    </Columns>
                </asp:GridView>
            </div>

            <div class="col-md-4">
                <%--<strong><asp:Label ID="lbl2" runat="server" Text=""></asp:Label></strong>
                <asp:TextBox ID="tbxBatch22" runat="server" AutoPostBack="true" OnTextChanged="tbxBatch22_TextChanged" Enabled="false" Visible="false"></asp:TextBox>
                <br />
                <br />--%>
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbx22" runat="server" Text="Autorizar todo el bloque 22" Checked="false" OnCheckedChanged="cbx22_CheckedChanged" AutoPostBack="true"/>
                </label>
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbx22No" runat="server" Text="No autorizar todo el bloque 22" Checked="false" OnCheckedChanged="cbx22No_CheckedChanged" AutoPostBack="true"/>
                </label>
                <asp:GridView
                    ID="gv22" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#042644" HeaderStyle-ForeColor="White"
                    EmptyDataText="No hay rollos del bloque 22 para autorizar" Font-Size="X-Small">
                    <Columns>
                        <asp:TemplateField HeaderText="Autorizar:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkStatus22" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("SI").ToString())) %>'
                                    Text="Si"/>
                                <br />
                                <asp:CheckBox ID="chkStatus22No" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("NO").ToString())) %>'
                                    Text="No"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="articulo" HeaderText="Articulo:" SortExpression="articulo" />
                        <asp:BoundField DataField="ele_cve" HeaderText="Elemento:" SortExpression="ele_cve" />
                        <asp:BoundField DataField="calidad" HeaderText="Calidad:" SortExpression="calidad" />
                        <asp:BoundField DataField="ele_exis_um" HeaderText="Exist.:" SortExpression="ele_exis_um" HtmlEncode="false" DataFormatString="{0:F1}"/>
                        <asp:BoundField DataField="uni_uso" HeaderText="Unidad uso:" SortExpression="uni_uso" />
                        <asp:BoundField DataField="dispo" HeaderText="Dispo:" SortExpression="dispo" />
                        <asp:BoundField DataField="batch" HeaderText="Batch:" SortExpression="batch" />
                        <asp:BoundField DataField="fol_ped" HeaderText="Pedido:" SortExpression="fol_ped"  />
                        <asp:TemplateField HeaderText="Defectos:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <%--<asp:Button ID="btnDefectos" runat="server" CssClass="btn btn-success" Text="Defectos"/>--%>
                                <a id="btnDefectos" class="btn btn-success btn-xs">Defectos</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <%-- <asp:BoundField DataField="cliente" HeaderText="Cliente:" SortExpression="cliente" />
                        <asp:BoundField DataField="SI" HeaderText="SI:" SortExpression="SI"  />
                        <asp:BoundField DataField="NO" HeaderText="NO:" SortExpression="NO" />--%>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-md-4">
                
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbxPCSI" runat="server" Text="Autorizar todo el bloque Piezas Cortas" Checked="false" OnCheckedChanged="cbxPCSI_CheckedChanged" AutoPostBack="true" />
                </label>
                <label class="checkbox-inline">
                    <asp:CheckBox ID="cbxPCNO" runat="server" Text="No autorizar todo el bloque Piezas Cortas" Checked="false" OnCheckedChanged="cbxPCNO_CheckedChanged" AutoPostBack="true" />
                </label>
                <asp:GridView ID="gvPC" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#042644" HeaderStyle-ForeColor="White"
                    EmptyDataText="No hay rollos del bloque de Piezas Cortas para autorizar" Font-Size="X-Small">
                    <HeaderStyle Font-Bold="True" />
                    <Columns>
                        <asp:TemplateField HeaderText="Autorizar:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="chkStatusPC" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("SI").ToString())) %>'
                                    Text="Si"/>
                                <br />
                                <asp:CheckBox ID="chkStatusPCNo" runat="server" 
                                    Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("NO").ToString())) %>'
                                    Text="No"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="articulo" HeaderText="Articulo:" SortExpression="articulo" />
                        <asp:BoundField DataField="ele_cve" HeaderText="Elemento:" SortExpression="ele_cve" />
                        <asp:BoundField DataField="calidad" HeaderText="Calidad:" SortExpression="calidad" />
                        <asp:BoundField DataField="ele_exis_um" HeaderText="Exist.:" SortExpression="ele_exis_um" HtmlEncode="false" DataFormatString="{0:F1}"/>
                        <asp:BoundField DataField="uni_uso" HeaderText="Unidad uso:" SortExpression="uni_uso" />
                        <asp:BoundField DataField="dispo" HeaderText="Dispo:" SortExpression="dispo" />
                        <asp:BoundField DataField="batch" HeaderText="Batch:" SortExpression="batch" />
                        <asp:BoundField DataField="fol_ped" HeaderText="Pedido:" SortExpression="fol_ped"  />
                        <asp:TemplateField HeaderText="Defectos:" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <a id="btnDefectos" class="btn btn-success btn-xs">Defectos</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" /> 
    
</asp:Content>
