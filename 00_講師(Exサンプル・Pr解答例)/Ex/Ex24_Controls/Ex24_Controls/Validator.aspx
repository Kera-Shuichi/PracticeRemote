<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Ex24_Controls.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- RequiredFieldValidator --%>
            <asp:Label ID="Label1" runat="server" Text="RequiredField:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="テキストを入力してください" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <%-- ComareValidator --%>
            <asp:Label ID="Label2" runat="server" Text="生年"></asp:Label>
            <asp:TextBox ID="Birth" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="小学校入学年"></asp:Label>
            <asp:TextBox ID="Enroll" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="CompareValidator1: "></asp:Label>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="生年は入学年よりも前で" ControlToCompare="Enroll" ControlToValidate="Birth" Operator="LessThan" Type="Integer"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label5" runat="server" Text="CompareValidator2: "></asp:Label>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="生年は1850年よりも後で" ControlToValidate="Birth" Operator="GreaterThan" Type="Integer" ValueToCompare="1850"></asp:CompareValidator>
            <br />
            <br />
            <%-- RangeValidator --%>
            <asp:Label ID="Label6" runat="server" Text="年齢"></asp:Label>
            <asp:TextBox ID="Age" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="生年月日"></asp:Label>
            <asp:TextBox ID="Birthday" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="RangeValidator1: "></asp:Label>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="年齢は0-150才の範囲で" ControlToValidate="Age" MaximumValue="150" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            <asp:Label ID="Label9" runat="server" Text="RangeValidator2: "></asp:Label>
            <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="誕生日は1850年以降で" ControlToValidate="Birthday" MaximumValue="9999/12/31" MinimumValue="1850/1/1" Type="Date" ></asp:RangeValidator>
            <br />
            <br />
            <%-- RegularExpressionValidator --%>
            <asp:Label ID="Label10" runat="server" Text="郵便番号"></asp:Label>
            <asp:TextBox ID="PostalCode" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label11" runat="server" Text="RegularExpressionValidator: "></asp:Label>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="郵便番号を正しく入力してください" ControlToValidate="PostalCode" ValidationExpression="\d{3}(-(\d{4}|\d{2}))?"></asp:RegularExpressionValidator>

            <br />
            <asp:Button ID="Button1" runat="server" Text="登録" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
