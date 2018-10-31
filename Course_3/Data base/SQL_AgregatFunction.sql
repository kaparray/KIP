------------------------
-- Агрегатные функции --
------------------------

-- Sum Сумирует все значения в столбце игнорируя NULL значения
SELECT Sum(amt) FROM Orders

-- AVG  Вычисляет среднее значение игнорируя NULL значения
SELECT AVG(amt) FROM Orders

-- MAX/MIN максимум или минимум значение стролбца игнорируя NULL значения
SELECT MAX(amt) FROM Orders

-- COUNT считает кол-во строк. если со звёздочкой, то не игнорирует NULL
SELECT COUNT(amt) FROM Customers

SELECT COUNT(*) FROM Customers -- все строки в таблице

-----------------------
-- Операция GROUP BY --
-----------------------

SELECT * FROM [dbo].[Products]

SELECT CategoryID, Count(*) AS "Value"
FROM Products
GROUP BY CategoryID


-- Позволяет перейти от списка одних объектов к списку других объектов

