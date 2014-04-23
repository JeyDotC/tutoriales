<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delegados.aspx.cs" Inherits="Capacitacion.Delegados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="FooButton" runat="server" Text="Foo Button" OnClick="FooButton_Click" />
        <asp:Button ID="BarButton" runat="server" Text="Bar Button" OnClick="BarButton_Click" />
        <asp:Button ID="BazButton" runat="server" Text="Baz Button" OnClick="BazButton_Click" />
        <asp:Button ID="GoFoo" runat="server" Text="Gofoo Button" OnClick="GoFoo_Click" />
    </div>
        <div>
            <asp:Literal ID="Mensaje" runat="server"></asp:Literal>
        </div>
        <div>
            <asp:BulletedList ID="Lista" runat="server"></asp:BulletedList>
        </div>
    </form>
</body>
</html>
