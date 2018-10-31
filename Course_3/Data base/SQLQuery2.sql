SELECT CompanyName + ' : ' +  ISNULL(Fax,'не имеет факс') FROM [dbo].[Customers]

SELECT Fax FROM [dbo].[Customers] WHERE City='London' and Fax IS NOT NULL ORDER BY ContactName ASC
-- Если написать DESC, то обратная сортировка
-- ASC по возрастанию

