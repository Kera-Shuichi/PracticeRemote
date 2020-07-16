<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Pr23_State_Transfer.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #areaToDo {
            height: 130px;
            width: 325px;
        }
        .item{
            background-color:lightblue;
            padding-left:10px;
            padding-right:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="margin:10px;">
    <div>    
        <table border="0">
            <tr>
                <td rowspan ="3">
                    <asp:Calendar ID="Calendar1" runat="server" Height="16px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                </td>
                <td class="item">日付</td>
                <td><asp:TextBox ID="tbxDate" runat="server"></asp:TextBox>
                </td>
                </tr>             
                <tr><td class="item">重要度</td>                   
                    <td>
                    <asp:DropDownList ID="listImportance" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr><td class="item">やること</td>
                    <td>&nbsp;<asp:TextBox ID="tbxToDo" runat="server" Height="124px" TextMode="MultiLine" Width="270px"></asp:TextBox>
                    </td>
                </tr>           
        </table> 
    </div>
        <asp:Button ID="btnExec" runat="server" Text="登録" Width="85px" OnClick="btnExec_Click" />
        &emsp;&emsp;&emsp;&emsp;

        <asp:Label ID="lblErr" runat="server" ForeColor="Red"></asp:Label>

    </form>
</body>
</html>
