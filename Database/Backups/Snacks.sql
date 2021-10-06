CREATE DATABASE Snacks
GO

USE Snacks
GO

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo

CREATE TABLE TableFood
(
	id	INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	status NVARCHAR(100) NOT NULL  DEFAULT N'Trống'
)
GO 

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName	NVARCHAR(100)NOT NULL DEFAULT N'Staff',
	Password NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --1:admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id	INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id	INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE NULL,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0--1: đã thanh toán && 0:chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

INSERT INTO dbo.Account (UserName, DisplayName, Password, Type)
VALUES (N'KD',N'Kai',N'1',1)

INSERT INTO dbo.Account (UserName, DisplayName, Password, Type)
VALUES (N'Staff',N'Staff',N'1',0)

GO

CREATE PROC GetAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE UserName = @username
END 
GO

CREATE PROC Snack_Login
@userName nvarchar(100),
@passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM  dbo.Account WHERE UserName = @userName AND Password = @passWord
END
GO

--thêm bàn
DECLARE @i INT = 0
WHILE @i <= 10 
BEGIN 
	INSERT dbo.TableFood (name) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END

GO 

CREATE PROC GetTableList
AS SELECT * FROM dbo.TableFood
GO

--thêm catagory
INSERT dbo.FoodCategory (name)
VALUES (N'Chiên')
INSERT dbo.FoodCategory (name)
VALUES (N'Xào')
INSERT dbo.FoodCategory (name)
VALUES (N'Nước')

--thêm món ăn
INSERT dbo.Food (name, idCategory, price)
VALUES (N'Cá viên chiên',1,12000)
INSERT dbo.Food (name, idCategory, price)
VALUES (N'Bò viên chiên',1,12000)

INSERT dbo.Food (name, idCategory, price)
VALUES (N'Mì xào',2,15000)
INSERT dbo.Food (name, idCategory, price)
VALUES (N'Nui xào',2,15000)

INSERT dbo.Food (name, idCategory, price)
VALUES (N'7 Up',3,15000)
INSERT dbo.Food (name, idCategory, price)
VALUES (N'Trà sữa',3,20000)

--thêm bill
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status)
VALUES (GETDATE(), NULL, 1, 0)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status)
VALUES (GETDATE(), NULL, 2, 0)
INSERT dbo.Bill(DateCheckIn, DateCheckOut, idTable, status)
VALUES (GETDATE(), GETDATE(), 2, 1)

--thêm bill infor
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(4,1,2)
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(4,2,2)
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(5,3,2)
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(5,1,2)
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(3,4,2)
INSERT dbo.BillInfo(idBill, idFood, count)
VALUES(3,2,2)

SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo

GO
SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f
WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = 2

select * from Food
select * from FoodCategory

GO
CREATE PROC InsertBill
@idTable INT
AS
BEGIN
 INSERT dbo.Bill (DateCheckIn, DateCheckOut, idTable, status, discount)
 VALUES (GETDATE(), NULL, @idTable, 0, 0)
END
GO

CREATE PROC InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExistsBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @isExistsBillInfo = id, @foodCount = bi.count 
		FROM dbo.BillInfo as bi
		WHERE idBill= @idBill AND idFood = @idFood
	IF (@isExistsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount >0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE	
		BEGIN 
			INSERT dbo.BillInfo (idBill, idFood, count)
			VALUES (@idBill, @idFood, @count)
		END	
END
GO

SELECT MAX(id) FROM dbo.Bill
UPDATE dbo.Bill SET status = 1 WHERE id = 1
GO

CREATE TRIGGER UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idTable INT 
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	DECLARE @count INT 
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill
	IF (@count >0)
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id= @idTable
	ELSE
		 UPDATE dbo.TableFood SET status = N'Trống' WHERE id= @idTable
END
GO



CREATE TRIGGER UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT 
	SELECT @idBill = id FROM Inserted 
	DECLARE @idTable INT
	SELECT @idTable = idTable  FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

ALTER TABLE dbo.Bill
Add discount INT 
UPDATE dbo.Bill SET discount = 0 
GO

CREATE PROC SwitchTable 
@idTable1 int, @idTable2 int
AS BEGIN
	DECLARE @idFirstBill INT
	DECLARE @idSecondBill INT
	DECLARE @isFirstTableEmpty INT = 1
	DECLARE @isSecondTableEmpty INT = 1
	
	SELECT @idSecondBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	IF (@idFirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill (DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable1, 0)
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	END
	SELECT @isFirstTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idFirstBill
	IF (@idSecondBill IS NULL)
	BEGIN
		INSERT dbo.Bill (DateCheckIn, DateCheckOut, idTable, status)
		VALUES (GETDATE(), NULL, @idTable2, 0)
		SELECT @idSecondBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	END
	SELECT @isSecondTableEmpty = COUNT(*) FROM BillInfo WHERE idBill = @idSecondBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSecondBill
	UPDATE dbo.BillInfo SET idBill = @idSecondBill WHERE idBill = @idFirstBill
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	DROP TABLE IDBillInfoTable
	IF(@isFirstTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
	IF(@isSecondTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1

END
GO
ALTER TABLE Bill ADD totalPrice FLOAT
GO

CREATE PROC GetListBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
END
GO

CREATE PROC UpdateAccount 
@userName NVARCHAR(100), @didplayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE UserName = @userName AND Password = @password
	IF(@isRightPass = 1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @didplayName WHERE UserName = @userName
		END
		ELSE
			UPDATE Account SET DisplayName = @didplayName, Password = @newPassword WHERE UserName = @userName
		END
END	 
GO

CREATE TRIGGER DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id , @idBill = Deleted.idBill FROM Deleted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id= @idTable
END
GO

CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END   
    RETURN @strInput
END
GO 

CREATE PROC GetListBillByDateAndPage
@checkIn date, @checkOut date, @page INT
AS
BEGIN
	DECLARE @pageRows INT = 10
	DECLARE @selectRows INT = @pageRows 
	DECLARE @exceptRows INT = (@page - 1) * @pageRows
	;WITH BillShow AS ( SELECT b.id ,t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount [Giảm giá]
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable )

	SELECT TOP (@selectRows) * FROM BillShow WHERE id NOT IN (SELECT TOP(@exceptRows) id FROM BillShow)
END
GO

CREATE PROC GetNumBillByDate
@checkIn date, @checkOut date
AS
BEGIN

	SELECT COUNT(*)
	FROM Bill AS b, TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
END
GO 


