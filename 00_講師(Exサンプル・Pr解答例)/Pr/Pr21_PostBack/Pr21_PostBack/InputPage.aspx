<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InputPage.aspx.cs" Inherits="Pr22_PostBack.InputPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="InputPanel" runat="server" Height="119px" Width="323px">
            <asp:Label ID="InputLabel" runat="server" Text="文字を入力して下さい"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="ValueInput" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="InputOKButton" runat="server" Text="OK" OnClick="btnInputOK_Click" />
        </asp:Panel>
        <asp:Panel ID="ConfirmPanel" runat="server" Height="119px" Width="323px">
            <asp:Label ID="ConfirmLabel" runat="server" Text="下記の文字が入力されました"></asp:Label>
            <br />
            <br />
            <asp:Label ID="InputValueLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ConfirmOKButton" runat="server" OnClick="btnConfirmOK_Click" Text="OK" />
            <asp:Button ID="CancelButton" runat="server" OnClick="btnCancel_Click" Text="CANCEL" />
        </asp:Panel>
        <asp:Panel ID="CompletePanel" runat="server" Height="119px" Width="323px">
            <asp:Label ID="CompleteLabel" runat="server" Text="入力が完了しました"></asp:Label>
            <br />
            <br />
            <br />
            <br />
        </asp:Panel>
    </form>
</body>
</html>