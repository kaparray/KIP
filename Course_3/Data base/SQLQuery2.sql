SELECT CompanyName + ' : ' +  ISNULL(Fax,'�� ����� ����') FROM [dbo].[Customers]

SELECT Fax FROM [dbo].[Customers] WHERE City='London' and Fax IS NOT NULL ORDER BY ContactName ASC
-- ���� �������� DESC, �� �������� ����������
-- ASC �� �����������

