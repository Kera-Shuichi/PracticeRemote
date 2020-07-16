
--DISTINCT
--◆すべての店の名前を重複せずに取得
SELECT DISTINCT 
	StoreName 
FROM 
	StoreSales


--◆WHERE
--◆売上が1,000以上のデータの店名を取得
SELECT 
	StoreName 
FROM 
	StoreSales 
WHERE 
	Sales >= 1000


--◆OR,AND
--◆売上が1,000以上、または売上が500から275の間にある店名を取得
SELECT 
	　StoreName 
FROM 
	　StoreSales 
WHERE 
	　Sales >= 1000 
OR (Sales >=275 AND Sales <= 500)
--OR (Sales BETWEEN 275 AND 500)


--◆IN
--◆店名がLos AngelesまたはSan Diegoのデータを全項目取得
SELECT 
	* 
FROM 
	StoreSales 
WHERE 
	StoreName IN ('Los Angeles','San Diego')


--◆BETWEEN
--◆売上日付が1999/1/6から1999/1/10の間にあるデータを全項目取得
SELECT 
	* 
FROM 
	StoreSales 
WHERE 
	SalesDate BETWEEN '1999/1/6' AND '1999/1/10'


--◆LIKE
--◆店名に「AN」を含むデータを全項目取得
SELECT 
	* 
FROM 
	StoreSales 
WHERE 
	StoreName LIKE '%AN%'


--◆ORDER BY
--◆売上の降順でテーブルを並べ替え、データを全項目取得
SELECT 
	* 
FROM 
	StoreSales 
ORDER BY 
	Sales DESC


--◆SUM
--◆売上の合計値を取得（列名は「合計」で出力）
SELECT 
	SUM(Sales) AS 合計 
FROM 
	StoreSales


--◆AVG
--◆売上の平均値を取得（列名は「平均」で出力）
SELECT 
	AVG(Sales) AS 平均 
FROM 
	StoreSales


--◆MAX
--◆売上の最大値を取得（列名は「最大値」で出力）
SELECT 
	MAX(Sales) AS 最大値 
FROM 
	StoreSales


--◆MIN
--（◆売上の最小値を取得（列名は「最小値」で出力））
SELECT 
	MIN(Sales) AS 最小値 
FROM 
	StoreSales


--◆COUNT
--◆売上が500より大きいデータの個数を取得（列名は「行数」）
SELECT 
	COUNT(Sales) AS 行数 
FROM 
	StoreSales 
WHERE 
	Sales > 500


--◆GROUP BY
--◆店名と店ごとの売上の合計値を取得（合計値の列名は「合計」）
SELECT 
	 StoreName
　 ,SUM(Sales) AS 合計 
FROM 
	 StoreSales 
GROUP BY 
	 StoreName


--◆HAVING
--◆売上の合計値が1500以上の店の名前と、売上の合計値を取得（合計値の列名は「合計」）
SELECT 
	StoreName
   ,SUM(Sales) AS 合計 
FROM 
	StoreSales 
GROUP BY 
	StoreName 
HAVING 
	SUM(Sales) >= 1500


--◆別名
--◆Fromでテーブル名をAと別名定義し、店の名前と、店ごとの売上の合計値を取得（合計値の列名は「合計」）
SELECT 
	A.StoreName
   ,SUM(A.Sales) AS 合計 
FROM 
	StoreSales AS A 
GROUP BY 
	A.StoreName


--◆INNER JOIN
--◆地域名と、地域ごとの売上を取得
SELECT 
	A1.RegionName AS 地域
   ,SUM(A2.Sales) AS 合計
FROM 
	GeoGraphy AS A1 
		INNER JOIN StoreSales AS A2 
			ON A1.StoreName = A2.StoreName
GROUP BY 
	A1.RegionName


--◆LEFT JOIN
--◆地域名テーブルの店の名前をすべてと、店ごとの売上を取得
SELECT 
	A1.StoreName
   ,SUM(A2.Sales) 
FROM 
	GeoGraphy AS A1 
		LEFT OUTER JOIN StoreSales AS A2 
			ON A1.StoreName = A2.StoreName
GROUP BY 
	A1.StoreName


--◆サブクエリ（副問合せ）
--◆西（WEST）にある店の売上の合計値を取得
SELECT 
	SUM(Sales) AS 西の売上合計 
FROM 
	StoreSales 
WHERE 
	StoreName IN 
		(SELECT StoreName 
		 FROM GeoGraphy 
		 WHERE RegionName = 'West')

--◎副問い合わせとの比較演算子に「=」を使用する場合、副問い合わせが1行を戻す必要がある
--　GeoGraphyテーブルには「West」のレコードが2行あるため、エラーとなる
--↓エラーになるクエリ
--SELECT SUM(Sales) AS 西の売上合計 FROM StoreSales 
--WHERE StoreName = (SELECT StoreName FROM GeoGraphy WHERE RegionName = 'West');


--◆UNION
--◆Internet_Salesの売上日付と、StoreSalesの売上日付を1列で取得。（重複するものは1件だけ表示）
SELECT 
	SalesDate 
FROM 
	InternetSales 
UNION 
SELECT 
	SalesDate 
FROM 
	StoreSales


--◆UNION ALL
--◆Internet_Salesの売上日付と、StoreSalesの売上日付を1列で取得（重複するものもすべて表示）
SELECT 
	SalesDate 
FROM 
	StoreSales 
UNION ALL 
SELECT 
	SalesDate 
FROM 
	InternetSales


--◆INTERSECT
--◆Internet_Salesの売上日付と、StoreSalesの売上日付のうち、どちらのテーブルにも存在するものを取得
SELECT 
	SalesDate 
FROM 
	StoreSales 
INTERSECT 
SELECT 
	SalesDate 
FROM 
	InternetSales 


--◆SUBSTRING	    
--◆すべての店の名前を先頭から3文字だけ取得
SELECT 
	SUBSTRING(StoreName,1,3) 
FROM 
	StoreSales


