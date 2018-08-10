<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notasMB.aspx.cs" Inherits="notasMB.notasMB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro de Notas</h1>
            <asp:Label ID="descrição" runat="server" Text="Sistema de cadastro de notas."></asp:Label>
            <br />
            <br />
            <asp:Label ID="id" runat="server" Text="ID da nota: "></asp:Label><asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="data" runat="server" Text="Data de emissão da nota: "></asp:Label><asp:TextBox ID="txtdata" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="valor" runat="server" Text="Valor da nota: "></asp:Label><asp:TextBox ID="txtvalor" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="desc" runat="server" Text="Descrição do serviço prestado: "></asp:Label><asp:TextBox ID="txtdesc" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnIncluir" runat="server" Text="Incluir" OnClick="btnIncluir_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnExcluir" runat="server" Text="Exluir" style="width: 49px" />
        </div>
    </form>
</body>
</html>
