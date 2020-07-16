<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="Ex23_StateTransition.HiddenField" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnTest" runat="server" Text="Button" OnClick="btnTest_Click" />
            <asp:Label ID="lblTest" runat="server" Text="Label"></asp:Label>
            <asp:HiddenField ID="hdnTest" runat="server" />
        </div>
    </form>
</body>
</html>
