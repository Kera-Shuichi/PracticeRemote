<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="01_ajax.aspx.cs" Inherits="Ex27_JavaScript_ajax._01_ajax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title></title>
  <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <h3 id="view-datetime">ここに時間を表示します</h3>
    </div>
    <div>
      <input id="run-ajax" type="button" value="時間を表示" />
    </div>
    <div>
      <script type="text/javascript">
        $('#run-ajax').on('click', function () {
          $.ajax({
            // GET or POST データ通信の方法
            type: 'GET',
            // URL
            url: '01_ajax_server.aspx',
            cache: false,
            // データ通信に成功した際に行う処理
            success: function (response) {
              $('#view-datetime').text(response);
            }
          })
        })
      </script>
    </div>
  </form>
</body>
</html>
