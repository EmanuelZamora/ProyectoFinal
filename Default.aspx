<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProyectoFinal.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        <br />
        Blockbuster</p>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Persona.aspx">Ingresar datos de persona</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Autor.aspx">Ingresar datos de autor</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Artista.aspx">Ingresar datos de artista</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de banda</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de miembros</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de instrumentalista</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de instrumentos</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de interpretes</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/Disco.aspx">Ingresar datos de disco</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de formato</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de cancionespiezamusical</asp:HyperLink>
            <br />
            <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/Agregar.aspx">Ingresar datos de genero</asp:HyperLink>
        </div>
    </form>
</body>
</html>
