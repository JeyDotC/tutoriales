<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MVP.aspx.cs" Inherits="Capacitacion.MVP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .alineado-derecha {
            text-align: right;
        }
        #content {
            width: 80%;
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="content">
            <div>
                <asp:Label AssociatedControlID="Nombre" runat="server">Nombre: </asp:Label>
                <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label AssociatedControlID="Tratamiento" runat="server">Tratamiento: </asp:Label>
                <asp:TextBox ID="Tratamiento" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label AssociatedControlID="Edad" runat="server">Edad: </asp:Label>
                <asp:TextBox ID="Edad" runat="server"></asp:TextBox>
            </div>
            <asp:Button ID="Guardar" runat="server" Text="Guardar" OnClick="Guardar_Click" />
            <div>
                <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="false"
                    Width="100%">
                    <Columns>
                        <asp:BoundField DataField="Tratamiento" HeaderText="Tratamiento" ItemStyle-Width="10%" ItemStyle-CssClass="alineado-derecha" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:BoundField DataField="Edad" HeaderText="Edad" ItemStyle-CssClass="alineado-derecha" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
