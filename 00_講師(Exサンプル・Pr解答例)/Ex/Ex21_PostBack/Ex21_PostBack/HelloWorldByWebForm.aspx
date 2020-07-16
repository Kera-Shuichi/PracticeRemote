<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorldByWebForm.aspx.cs" Inherits="Ex21_PostBack.HelloWorldByWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="名前："></asp:Label>
            <asp:TextBox ID="txtYourName" runat="server"></asp:TextBox>
            <asp:Button ID="btnHello" runat="server" Text="Hello" OnClick="btnHello_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text="" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
