<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringMain.aspx.cs" Inherits="Pr22_Screen_Transfer.QueryStringMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Product:"></asp:Label>
            <asp:DropDownList ID="ProductList" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Maker:"></asp:Label>
            <asp:DropDownList ID="MakerList" runat="server"></asp:DropDownList>
            <br /><br />
            <asp:Button ID="CheckButton" runat="server" Text="確認" OnClick="CheckButton_Click" />
        </div>
    </form>
</body>
</html>
