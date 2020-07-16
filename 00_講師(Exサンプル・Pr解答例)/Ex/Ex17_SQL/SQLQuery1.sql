
--すべて列を表示する
--SELECT *
--FROM Member

--特定の列を表示する
--SELECT No, Name
--FROM Member

--抽出条件を指定する
--SELECT *
--FROM Member
--WHERE Height > 180

--特定の文字を含む行を抽出する
--SELECT *
--FROM Member
--WHERE Name LIKE N'%木%'

--複合条件で行を抽出する
--SELECT *
--FROM Member
--WHERE Height > 180
--  AND Weight > 100

--数値の範囲を指定して抽出する
--SELECT *
--FROM [Member]
--WHERE Height BETWEEN 175 AND 185

--ソート
--SELECT *
--FROM Member
--ORDER BY Height

--重複した行をまとめる
--SELECT DISTINCT Height
--FROM Member

--テーブルの結合
--SELECT Member.Name, Result.Hit
--FROM Member, Result
--WHERE Member.No = Result.No

--計算式を記述する
--SELECT No, Hit * 5
--FROM Result

--テーブルの結合と抽出条件の指定
--SELECT Member.Name, Result.Hit
--FROM Member, Result
--WHERE Member.No = Result.No
--  AND Result.Hit > 40

--グループ化を行う
--SELECT Member.Position, SUM(Result.Hit)
--FROM Member, Result
--WHERE Member.No = Result.No
--GROUP BY Member.Position

--グループ化されたデータの検索条件指定
--SELECT Member.Position, SUM(Result.Hit)
--FROM Member, Result
--WHERE Member.No = Result.No
--GROUP BY Member.Position
--HAVING SUM(Result.Hit) > 80

--列に別の名前を付ける
--SELECT
--  No
-- ,Name AS '選手名'
-- ,Position AS 'ポジション'
--FROM Member

--テーブルに別の名前を付ける
--SELECT A.Name, B.Hit
--FROM Member AS A, Result AS B
--WHERE A.No = B.No

--抽出結果をもとにさらに抽出を行う
--SELECT No, Name
--FROM Member
--WHERE No IN (
--	SELECT No
--	FROM Result
--	WHERE Hit > 40)

--EXISTS述語を使った相関副問い合わせ
--SELECT No, Name
--FROM Member
--WHERE EXISTS (
--	SELECT No
--	FROM Result
--	WHERE Member.No = Result.No)

--INNER JOINを使って表を結合する
--SELECT Member.No, Member.Name, Result.Hit
--FROM Member INNER JOIN Result
--	ON Member.No = Result.No

--LEFT JOINを使って表を結合する
--SELECT Member.No, Member.Name, Result.Hit
--FROM Member LEFT OUTER JOIN Result
--	ON Member.No = Result.No