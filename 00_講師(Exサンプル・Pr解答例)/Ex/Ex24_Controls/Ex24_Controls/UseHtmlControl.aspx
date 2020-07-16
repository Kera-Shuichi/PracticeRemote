<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseHtmlControl.aspx.cs" Inherits="Ex24_Controls.UseHtmlCotrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div runat="server" id="div1">
            <input runat="server" type="text" id="text1" />
            <br />
            <span runat="server" id="span1"></span>
            <br />
            <input runat="server" type="button" id="btn1" value="クリック" onserverclick="btn1_ServerClick" />
        </div>
    </form>
</body>
</html>
