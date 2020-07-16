<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountPage.aspx.cs" Inherits="Pr23_State_Transfer.CountPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    
        <asp:Button ID="btnPush" runat="server" OnClick="btnPush_Click" Text="Push!" Height="38px" Width="110px" />
        <asp:Label ID="lblCount" runat="server" Text="0"></asp:Label>
    
        <br />
    
        <br />
        <asp:Label ID="lblTime" runat="server"></asp:Label>
    
        <asp:HiddenField ID="hdnStartTime" runat="server" />
    
    </div>
    </form>
</body>
</html>
