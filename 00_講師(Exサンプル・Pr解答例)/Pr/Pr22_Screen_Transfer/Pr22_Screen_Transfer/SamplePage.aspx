<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SamplePage.aspx.cs" Inherits="Pr22_Screen_Transfer.SamplePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 150px;
            width: 460px;
        }
        #msgArea {
            height: 90px;
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="名前"></asp:Label>
            <br />
            <asp:TextBox ID="tbxName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="つぶやき"></asp:Label>
            <br />
            <asp:TextBox ID="txtTweet" runat="server" TextMode="MultiLine" Height="85px" Width="350px"></asp:TextBox><br />
            <br />
            <%--<asp:Button ID="btnSend" runat="server" Text="送信" PostBackUrl="SamplePage2.aspx" />--%>
            <asp:Button ID="btnSend" runat="server" Text="送信" OnClick="btnSend_Click" />
            <br />
        </div>
    </form>
</body>
</html>
