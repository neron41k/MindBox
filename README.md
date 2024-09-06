### Решение С#
[Класс](https://github.com/neron41k/MindBox/blob/master/MindBox/Figure.cs)
[Тесты](https://github.com/neron41k/MindBox/blob/master/MindBox.Tests/MindBoxTest.cs)

###  Создание БД и таблиц
    CREATE DATABASE MindBoxDB
    USE MindBoxDB

    CREATE TABLE Products(
    ID INT PRIMARY KEY IDENTITY, 
    ProductName NVARCHAR(MAX) NOT NULL);

    CREATE TABLE Category(
    ID INT PRIMARY KEY IDENTITY,
    CategoryName NVARCHAR(MAX) NOT NULL);

    CREATE TABLE ProductsCategorys(
    IDProduct INT NOT NULL,
    IDCategory INT NOT NULL,
    FOREIGN KEY(IDProduct) REFERENCES Products(ID),
    FOREIGN KEY(IDCategory) REFERENCES Category(ID));

    CREATE UNIQUE INDEX ProductsCategorys ON ProductsCategorys(IDProduct, IDCategory);

###  Заполнение БД
    INSERT INTO Products VALUES('Колонка'), ('Светильник'), ('Нож');
    INSERT INTO Category VALUES('Техника'), ('Компьютерная периферия'), ('Освещение');
    INSERT INTO ProductsCategorys VALUES (1, 2), (2, 1), (2, 3);

###  Решение
    SELECT p.ProductName AS "Продукт", c.CategoryName AS "Категория" FROM Products AS p
    LEFT JOIN ProductsCategorys AS pc ON p.ID = pc.IDProduct
    LEFT JOIN Category AS c ON c.id = pc.IDCategory
