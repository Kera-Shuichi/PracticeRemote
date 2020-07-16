<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryStringSub.aspx.cs" Inherits="Pr22_Screen_Transfer.QueryStringSub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ProductTitleLabel" runat="server" Text="Product:"></asp:Label>
            <asp:Label ID="ProductTextLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="MakerTitleLabel" runat="server" Text="Maker:"></asp:Label>
            <asp:Label ID="MakerTextLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
