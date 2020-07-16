<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack.aspx.cs" Inherits="Ex21_PostBack.PostBack" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="dateTimeLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="postBackLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="sendButton" runat="server" Text="送信" OnClick="sendButton_Click" />
            <asp:CheckBox ID="sendCheck" runat="server" Text="送信済" />
        </div>
    </form>
</body>
</html>
