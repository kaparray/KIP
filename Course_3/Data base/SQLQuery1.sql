SELECT * FROM [dbo].[titles] WHERE Price < 20
SELECT * FROM [dbo].[titles] WHERE Price > 20
SELECT * FROM [dbo].[titles] WHERE Price = 20
SELECT * FROM [dbo].[titles] WHERE Price  IS NULL

SELECT * FROM [dbo].[titles]

SELECT * FROM [dbo].[titles] WHERE Price  IS NULL
SELECT * FROM [dbo].[titles] WHERE Price  IS NOT NULL


SELECT Title + '(' + CAST(Price AS varchar) + ')' FROM titles

SELECT 1 + 1
SELECT 1 + '1'
SELECT '1' + '1'

SELECT ISNULL(CAST(Price AS varchar),'Lol') FROM titles


-- Операции приведения типов CAST + CONVERT
SELECT CAST('1' AS INT) + 1

SELECT Convert(varchar, 1) + '1'


SELECT Convert(varchar, GETDATE(), 103)




SELECT * FROM [dbo].[titles] WHERE price IS NULL OR price = 0 