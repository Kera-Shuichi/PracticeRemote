<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SamplePage2.aspx.cs" Inherits="Pr22_Screen_Transfer.SamplePage2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="border: medium dashed #27b964; background-color:white; width:350px; padding:30px; margin:auto; text-align:left">
        <table><tr><td><img src ="icon.jpg" /></td><td style="padding-left:30px;"><asp:Label ID="lblName" runat="server" Text="Label" Font-Size="Large" Font-Bold="True"></asp:Label></td></tr></table>
        
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server" Text="Label" Width="100%" Font-Size="Medium"></asp:Label>

        <br />
        <br />
        <div style="text-align: right; border-top:#27b964 dashed 1px; padding-top:5px;">
        <asp:Label ID="lblDate" runat="server" Text="Label" Width="100%" Font-Size="Small"></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>
