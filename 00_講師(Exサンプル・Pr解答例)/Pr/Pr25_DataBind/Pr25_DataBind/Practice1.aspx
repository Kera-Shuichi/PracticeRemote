<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice1.aspx.cs" Inherits="Pr25_DataBind.Practice1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
    .auto-style1 {
      width: 227px;
    }

    .auto-style2 {
      width: 159px;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <table>
        <tr>
          <td class="auto-style1">メーカー
          </td>
          <td class="auto-style2">カテゴリー
          </td>
        </tr>
        <tr>
          <td class="auto-style1">
            <asp:ListBox ID="ListBox1" runat="server" Width="198px" AutoPostBack="True" OnSelectedIndexChanged="SelectedIndexChanged"></asp:ListBox>
          </td>
          <td class="auto-style2">
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="133px" AutoPostBack="True" OnSelectedIndexChanged="SelectedIndexChanged">
            </asp:DropDownList>
          </td>
        </tr>
      </table>

      <br />
      <br />

    </div>
    商品一覧
        <asp:GridView ID="GridView1" runat="server" Height="16px" Width="895px" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowCommand="GridView1_RowCommand" ShowHeaderWhenEmpty="True">
          <AlternatingRowStyle BackColor="White" />
          <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID">
              <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="品名" />
            <asp:BoundField DataField="MakerName" HeaderText="メーカー" />
            <asp:BoundField DataField="CategoryName" HeaderText="区分">
              <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Cost" HeaderText="原価" DataFormatString="{0:C}">
              <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="ListPrice" HeaderText="定価" DataFormatString="{0:C}">
              <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="SellPrice" HeaderText="売価" DataFormatString="{0:C}">
              <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:ButtonField ButtonType="Button" CommandName="Bold" Text="Bold">
              <ItemStyle HorizontalAlign="Center" />
            </asp:ButtonField>
            <asp:CommandField ShowSelectButton="True" />
          </Columns>
          <FooterStyle BackColor="#CCCC99" />
          <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" Height="20px" />
          <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
          <RowStyle BackColor="#F7F7DE" />
          <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
          <SortedAscendingCellStyle BackColor="#FBFBF2" />
          <SortedAscendingHeaderStyle BackColor="#848384" />
          <SortedDescendingCellStyle BackColor="#EAEAD3" />
          <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
  </form>
</body>
</html>

