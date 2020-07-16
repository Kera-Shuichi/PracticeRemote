<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect1.aspx.cs" Inherits="Ex22_ScreenTransition.Redirect1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="リダイレクト1" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="リダイレクト2" OnClick="Button2_Click" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="リダイレクト3" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
