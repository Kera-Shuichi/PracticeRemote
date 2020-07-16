// ページロード関数
$(function () {
  $('#btnCalc').on('click', calcScoreClick);
  $('#btnClear').on('click', clearScore);
})

// 計算ボタン押下時処理
function calcScoreClick() {
  $('#lblError').text('');

  // 合計点の計算
  calcScore();

  //// 得意教科・苦手教科を算出
  //calcGoodNotSubject();

  return false;
}

// 合計点を計算
function calcScore() {
  const strPoint = '点';

  for (var i = 1; i < 6; i++) {
    var scoreSum = 0;
    for (var j = 1; j < 4; j++) {
      let scoreElem = $('#txtScore' + i + '_' + j);
      scoreSum = scoreSum + getNum(scoreElem);
    }

    $('#lblSum' + i).text(scoreSum + strPoint);
  }
}

// クリアボタン押下時処理
function clearScore() {
  // テキストボックスの初期化(空白を設定する)
  $('input[type="text"]').val('');

  // テキストボックスの背景白設定
  $('input[type="text"]').css('backgroundColor', 'white');

  // 合計点の空白設定
  $('#lblSum1').text('');
  $('#lblSum2').text('');
  $('#lblSum3').text('');
  $('#lblSum4').text('');
  $('#lblSum5').text('');

  // エラーメッセージ初期化
  $('#lblError').text('');

  return false;
}

// 数値型に変換して返す
function getNum(elem) {
  var val = elem.val();

  if (val == null) {
    return 0;
  } else if (!$.isNumeric(val)) {
    $('#lblError').text('100以下の数字を入力してください。');
    elem.css('backgroundColor', 'pink');
    return 0;
  }

  var val = parseInt(val);
  if (val < 0 || val > 100) {
    $('#lblError').text('100以下の数字を入力してください。');
    elem.css('backgroundColor', 'pink');
    return 0;
  }

  elem.css('backgroundColor', 'white');
  return val;
}


//// 得意教科、苦手教科を割り出す
//function calcGoodNotSubject() {

//    for (let i = 1; i < 6; i++) {
//        let maxScore = 0;   // 最高得点
//        let minScore = 0;   // 最低得点
//        let maxSubject;     // 最高得点教科
//        let minSubject;     // 最低得点教科

//        for (let j = 1; j < 4; j++) {
//            const score = getNum($('#txtScore' + i + '_' + j));

//            if (score >= maxScore) {
//                maxScore = score;
//                maxSubject = $('#lblTitleSubject' + j).text();
//            }
//            if (score <= minScore) {
//                minScore = score;
//                minSubject = $('#lblTitleSubject' + j).text();
//            }
//        }

//        // 得意教科、苦手教科をラベルにセット
//        if (maxScore > 0) {
//            $('#lblGood' + i).text(maxSubject);
//        }
//        if (minScore < 100) {
//            $('#lblNotGood' + i).text(minSubject);
//        }
//    }
//}