------------------------
-- ���������� ������� --
------------------------

-- Sum �������� ��� �������� � ������� ��������� NULL ��������
SELECT Sum(amt) FROM Orders

-- AVG  ��������� ������� �������� ��������� NULL ��������
SELECT AVG(amt) FROM Orders

-- MAX/MIN �������� ��� ������� �������� �������� ��������� NULL ��������
SELECT MAX(amt) FROM Orders

-- COUNT ������� ���-�� �����. ���� �� ���������, �� �� ���������� NULL
SELECT COUNT(amt) FROM Customers

SELECT COUNT(*) FROM Customers -- ��� ������ � �������

-----------------------
-- �������� GROUP BY --
-----------------------

SELECT * FROM [dbo].[Products]

SELECT CategoryID, Count(*) AS "Value"
FROM Products
GROUP BY CategoryID


-- ��������� ������� �� ������ ����� �������� � ������ ������ ��������

