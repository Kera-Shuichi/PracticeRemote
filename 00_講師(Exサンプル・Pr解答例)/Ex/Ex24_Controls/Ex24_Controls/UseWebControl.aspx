﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseWebControl.aspx.cs" Inherits="Ex24_Controls.UseWebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="クリック" OnClick="Button1_Click" />
        </asp:Panel>
    </form>
</body>
</html>
