<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MealsNotes.aspx.cs" Inherits="Pr27_JavaScript_ajax.MealsNotes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>食事登録画面</title>
  <script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:Label ID="lblDate" runat="server" Text="Label">日付：</asp:Label>
      <asp:TextBox ID="Date" runat="server"></asp:TextBox>

      <br />
      <br />

      <asp:RadioButtonList ID="EatStatus" runat="server" RepeatColumns="3">
        <asp:ListItem Value="1">朝食</asp:ListItem>
        <asp:ListItem Value="2">昼食</asp:ListItem>
        <asp:ListItem Value="3">夕食</asp:ListItem>
      </asp:RadioButtonList>
      <asp:Label ID="lblGenre" runat="server" Text="Label">ジャンル：</asp:Label>
      <asp:DropDownList ID="Genre" runat="server"></asp:DropDownList>

      <br />
      <br />

      <asp:Label ID="lblMenu" runat="server" Text="Label">メニュー：</asp:Label>
      <asp:DropDownList ID="Menu" runat="server"></asp:DropDownList>

      <br />
      <br />

      <input type="button" id="Resister" value="登録チェック" />

    </div>
  </form>

  <script type="text/javascript">
    // ジャンル設定
    function setGenre() {
      // ajax使用
      $.ajax({
        type: 'GET',
        url: 'GenreItems.aspx',
        cache: false,
        success: function (response) {
          // データ通信が成功した場合

          // カンマ区切りの文字列を配列化
          let itemList = response.split(',');

          // ドロップダウンリスト(select)項目(option)設定
          // 配列の要素分だけループ
          let count = 0;
          while (count < itemList.length) {
            //// ベタ書きしたタグを追加する場合
            //$('#Genre').append('<option value="' + count + '">' + itemList[count] + '</option>');

            // value値、テキストを指定して生成
            $('#Genre').append($('<option>').val(count).text(itemList[count]));
            count++;
          }
        }
      });
    }

    // メニュー設定
    function setMenu() {
      // 項目を設定する前にもともと入っている項目を削除する
      // jquery ID:#Menuのoptionタグ　を削除(.remove())
      $('#Menu option').remove();

      // ジャンルのValue値を取得
      let genre = $('#Genre').val();

      // ジャンルが0⇒空白を選択したと判断して処理を中断する
      if (genre === '0') {
        return;
      }

      // ajax使用
      // url：genreで何を選択されているかを確認するため、URLクエリパラメータでデータを渡す
      $.ajax({
        type: 'GET',
        url: 'MenuItems.aspx?genre=' + genre,
        cache: false,
        success: function (response) {
          // データ通信が成功した場合

          // カンマ区切りの文字列を配列化
          let itemList = response.split(',');

          // ドロップダウンリスト(select)項目(option)設定
          // 配列の要素分だけループ
          let count = 0;
          while (count < itemList.length) {
            // value値、テキストを指定して生成
            $('#Menu').append($('<option>').val(count).text(itemList[count]));
            count++;
          }
        }
      });
    }

    // 入力チェック関数(ajax)
    function checkInput() {
      // サーバに送るデータ取得
      let date = $('#Date').val();
      let status = $('#EatStatus input:checked').val();
      let genre = $('#Genre').val();
      let menu = $('#Menu').val();

      // ajaxで使用するurl作成
      ////// 文字列結合
      ////let url = 'checkInput.aspx?' + 'date=' + date + '&status=' + status + '&genre=' + genre + '&menu' + menu;

      // 埋め込み文字列
      // バッククォート(`)を使用すると埋め込み文字列可能
      let url = `CheckInput.aspx?date=${date}&status=${status}&genre=${genre}&menu=${menu}`;
      

      // ajax
      $.ajax({
        type: 'GET',
        url: url,
        cache: false,
        success: function (response) {
          // データ通信が成功した場合

          // response：エラーメッセージが格納されているので、エラーになったか確認
          if (response !== '') {
            // エラーメッセージ表示
            alert(response);
          }
          else {
            alert('入力内容に問題ありません');
          }
        }
      });
    }

    // ジャンル設定
    setGenre();

    // ジャンルのイベントハンドラ設定
    $('#Genre').on('change', function () {
      // メニュー設定
      setMenu();
    });

    // ボタン押下時のイベントハンドラ設定
    $('#Resister').on('click', function () {
      // 入力チェック
      checkInput();
    });
  </script>
</body>
</html>
