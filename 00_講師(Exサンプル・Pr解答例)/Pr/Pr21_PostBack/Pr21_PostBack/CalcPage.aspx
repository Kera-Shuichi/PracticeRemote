<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcPage.aspx.cs" Inherits="Pr22_PostBack.CalcPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CalcPage</title>
 
</head>
<body>
    <form id="form1" runat="server">
    <div id="inputArea">
        <asp:Label ID="FormulaTitleLabel" runat="server" Text="数式"></asp:Label>
        <br />
        <asp:TextBox ID="LeftValueInput" runat="server"></asp:TextBox>
        　<asp:DropDownList ID="OperatorList" runat="server" Height="19px" Width="58px">
            <asp:ListItem>＋</asp:ListItem>
            <asp:ListItem>－</asp:ListItem>
            <asp:ListItem>÷</asp:ListItem>
            <asp:ListItem>×</asp:ListItem>
          </asp:DropDownList>
        <asp:TextBox ID="RightValueInput" runat="server"></asp:TextBox>
        <asp:Button ID="ExecButton" runat="server" Text="計算" OnClick="ExecButton_Click"/>
        <br />
    </div>

    <div id="outputArea">
        <asp:Label ID="AnswerTitleLabel" runat="server" Text="答え ： "></asp:Label>
        <asp:Label ID="AnswerLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
