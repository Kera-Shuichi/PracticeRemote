<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anchor1.aspx.cs" Inherits="Ex22_ScreenTransition.Anchor1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Anchor2.aspx">アンカータグによる遷移</a>
            <br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="Anchor2.aspx"
                runat="server">Webコントロールによる遷移</asp:HyperLink>
        </div>
    </form>
</body>
</html>
