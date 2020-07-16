<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice1.aspx.cs" Inherits="Pr24_Web_Controls.Practice1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label5" runat="server" Text="名前を入力してください。（必須）"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="txtName"
                ErrorMessage="名前が入力されていません。">
            </asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="年齢を入力してください。（0 ～ 100）"></asp:Label>
            <br />
            <asp:TextBox ID="txtOld" runat="server"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server"
                ControlToValidate="txtOld"
                ErrorMessage="年齢は０から１００までの値で入力してください。"
                MaximumValue="100"
                MinimumValue="0"
                Type="Integer">
            </asp:RangeValidator>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="e-mailアドレスを入力してください。"></asp:Label>
            <br />
            <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ControlToValidate="txtMail"
                ErrorMessage="正しいメールアドレスが入力されていません。"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="e-mailアドレスを入力してください。（確認用）"></asp:Label>
            <br />
            <asp:TextBox ID="txtMailCheck" runat="server"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToCompare="txtMailCheck"
                ControlToValidate="txtMail"
                ErrorMessage="e-mailアドレスが異なります。">
            </asp:CompareValidator>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="性別を選択して下さい。"></asp:Label><br />
            <asp:RadioButtonList ID="rblSei" runat="server" RepeatColumns="2">
                <asp:ListItem Selected="True">男性</asp:ListItem>
                <asp:ListItem>女性</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="出身地方を選択して下さい。"></asp:Label><br />
            <asp:DropDownList ID="ddlFrom" runat="server">
                <asp:ListItem>北海道</asp:ListItem>
                <asp:ListItem>本州</asp:ListItem>
                <asp:ListItem>四国</asp:ListItem>
                <asp:ListItem>九州</asp:ListItem>
            </asp:DropDownList><br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="好物を選択して下さい。（未選択可能）"></asp:Label><br />
            <asp:CheckBoxList ID="cblLike" runat="server" RepeatColumns="3">
                <asp:ListItem>肉</asp:ListItem>
                <asp:ListItem>魚</asp:ListItem>
                <asp:ListItem>野菜</asp:ListItem>
            </asp:CheckBoxList><br />
            <asp:Button ID="btnSend" runat="server" Text="送信" OnClick="btnSend_Click" Style="height: 21px" UseSubmitBehavior="False" />
        </div>
    </form>
</body>
</html>
