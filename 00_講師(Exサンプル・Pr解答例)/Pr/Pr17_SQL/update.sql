--◆1行挿入
--対象テーブル：GeoGraphy
--追加データ：Id = 5,　RegionName = South,　StoreName = Florida
INSERT 
INTO GeoGraphy 
VALUES(5,'South',null)


--◆列を指定して追加する
--対象テーブル：StoreSales
--追加データ：Id = 5,　StoreName = Boston
INSERT 
INTO StoreSales(Id,StoreName) 
VALUES(5,'Boston')


--◆1回のINSERT文で2行挿入する
INSERT 
INTO InternetSales 
VALUES(5,'1999/01/12',820),(6,'1999/01/13',1200)


--◆SELECTで得た結果をINSERTする
INSERT 
	INTO StoreSales(Id,Sales,SalesDate) 
		SELECT 
			Id,Sales,SalesDate 
		FROM 
			InternetSales 
		WHERE 
		　Id=6


--◆行を指定して更新する
UPDATE 
	StoreSales 
SET 
	StoreName = 'Florida' 
WHERE 
	Id = 6


--◆複数列を指定して更新する
UPDATE 
	StoreSales 
SET 
	Sales = 180
   ,SalesDate = '1999/01/08' 
WHERE 
	Id = 5


--◆サブクエリを使って更新する
--更新内容：Id = 6のデータの Sales に、InternetSalesテーブルの 
--              Salesの合計値を設定する
UPDATE 
	StoreSales 
SET 
	Sales = (SELECT 
				　SUM(Sales) 
			 　FROM 
				　InternetSales) 
WHERE 
	Id = 6


--◆指定行のみを削除する
DELETE 
FROM 
	GeoGraphy 
WHERE 
	Id = 5


--◆サブクエリを使って削除する
--対象データ：西(West）にある店のデータ
DELETE 
FROM 
	StoreSales 
WHERE StoreName IN (SELECT StoreName 
					FROM GeoGraphy 
					WHERE RegionName = 'West')
