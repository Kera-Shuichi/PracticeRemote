<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Pr23_State_Transfer.Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .item{
            background-color:lightblue;
        }
        .auto-style1 {
            background-color: lightblue;
            width: 56px;
        }
        .auto-style2 {
            background-color: lightblue;
            width: 89px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table>
            <tr>
                <td class="auto-style2">日付</td>
                <td>
                    <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="item">重要度</td>
                <td>
            <asp:Label ID="lblImportance" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="item">やること</td>
                <td>
                <asp:Label ID="lblToDo" runat="server" Text="Label" Width="350px"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>