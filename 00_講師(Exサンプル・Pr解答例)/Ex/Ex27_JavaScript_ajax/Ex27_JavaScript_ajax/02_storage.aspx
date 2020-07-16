<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="02_storage.aspx.cs" Inherits="Ex27_JavaScript_ajax._02_storage" %>

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
      <h1>
        セッションストレージ：<span id="session-value"></span>
      </h1>
    </div>
    <div>
      <h1>
        ローカルストレージ：<span id="local-value"></span>
      </h1>
    </div>
    <div>
      <input id="btn-clear" type="button" value="クリア" />
    </div>
    <div>
      <script type="text/javascript">
        $('#btn-clear').on('click', function () {
          // 削除関数(キーを指定して削除)
          sessionStorage.removeItem('session-value');
          localStorage.removeItem('local-value');

          // クリア関数(全て削除)
          sessionStorage.clear();
          localStorage.clear();
        });


        // 現在日付を取得(ブラウザ側)
        var today = new Date();

        // セッションストレージに「session-value」なければ登録
        if (sessionStorage['session-value'] == null) {
          sessionStorage.setItem('session-value', today);
        }

        // セッションストレージからデータを取得
        var session_value = sessionStorage.getItem('session-value');
        // 画面に表示
        $('#session-value').text(session_value);


        // ローカルストレージ
        if (localStorage['local-value'] == null) {
          localStorage.setItem('local-value', today);
        }

        var local_value = localStorage.getItem('local-value');
        $('#local-value').text(local_value);

      </script>
    </div>
  </form>
</body>
</html>
