<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transfer1.aspx.cs" Inherits="Ex22_ScreenTransition.Transfer1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="yourNameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="myCheckBox" runat="server" Text="Check" />
            <br />
            <asp:Button ID="trasferButton" runat="server" Text="遷移" OnClick="trasferButton_Click" />
        </div>
    </form>
</body>
</html>
