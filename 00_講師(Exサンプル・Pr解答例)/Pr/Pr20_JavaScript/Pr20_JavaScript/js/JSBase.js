// ページロード関数
$(function () {
  // jQuery。ID「rdo1_0」に対して「checked」属性に「true」を設定
  // 初期表示用
  $('#rdo1_0').prop('checked', true);

  // 「setItem」関数呼び出し
  setItem();

  // 各イベント追加：下記の方法はjQueryを使用したもの。(研修ではやっていない)
  // $('セレクタ').on('イベント名', イベントが発生したときに実行したい処理・関数);
  // ラジオボタンにイベントハンドラを付与

  // セレクタの意味：「input」タグの中で「name」属性に「rdo=1」が設定されているコントロール全て
  $('input[name="rdo1"]').on('change', setItem);

  // 送信ボタンにイベントハンドラを付与
  // セレクタの意味：IDに「btn1」が設定されているコントロール
  $('#btn1').on('click', checkInput);
})

// 初期化処理
function clear() {
  // セレクタの意味：タグ内のクラスに「errPerson」もしくは「errCompany」が設定されているタグに関して
  // .css：cssを設定する
  $('.errPerson, .errCompany').css('backgroundColor', 'white');

  // セレクタの意味：特定のIDの場合
  // .val：コントロールによって挙動が変わる。テキストボックスの場合はテキストボックスに入力されたデータ。
  //       val('')⇒テキストボックスに空文字を設定。C#の「テキストボックス.Text = "";」と同じ意味
  //       複数のテキストボックスに対して空文字の代入を行っている
  //      補足：var inputData = $('セレクタ').val(); とするとテキストボックスに入力されたデータを取得可能。
  $('#txt1, #txt2, #txt3').val('');
  $('#lblErr').text('');
}

// ラジオボタンの値によって表示をセット
function setItem() {
  // セレクタの意味：「input」タグの中で「name」属性に「rdo1」が設定され、チェックが付いているコントロール
  // .val()：ラジオボタンの場合は「value」属性に設定された値の取得及び代入が可能。
  //　　　　　value属性：チェックの有無で0と1が切り替わる
  let selectedVal = $('input[name="rdo1"]:checked').val();

  // 表示非表示の切り替え
  if (selectedVal == 0) {
    $('.person').css('display', 'inline-block');
    $('.company').css('display', 'none');
  } else if (selectedVal == 1) {
    $('.person').css('display', 'none');
    $('.company').css('display', 'inline-block');
  }

  // クリア関数呼び出し
  clear();
}

// 入力チェック
function checkInput() {
  let selectedVal = $('input[name="rdo1"]:checked').val();
  let name;
  let address;
  let errItem;

  if (selectedVal == 0) {
    name = $('#txt1').val();
    if (name == '') {
      $('#txt1').css('backgroundColor', 'pink');
    } else {
      $('#txt1').css('backgroundColor', 'white');
    }
  } else if (selectedVal == 1) {
    name = $('#txt2').val();
    if (name == '') {
      $('#txt2').css('backgroundColor', 'pink');
    } else {
      $('#txt2').css('backgroundColor', 'white');
    }
  }

  address = $('#txt3').val();
  if (address == '') {
    $('#txt3').css('backgroundColor', 'pink');
  } else {
    $('#txt3').css('backgroundColor', 'white');
  }

  if (name == '' || address == '') {
    // エラー
    $('#lblErr').text('項目を入力してください。');
    return false;
  } else {
    // 確認ダイアログでも可
    // OK
    alert('登録しますか？');
    return true;
  }
}