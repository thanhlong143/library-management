Use [master]
go

drop database [library]
go

create database [library]
go

use [library]
go

create table Floors
(
	FloorID int primary key
)

INSERT INTO [dbo].[Floors] ([FloorID]) VALUES (1)
GO
INSERT INTO [dbo].[Floors] ([FloorID]) VALUES (2)
GO
INSERT INTO [dbo].[Floors] ([FloorID]) VALUES (3)
GO

Create table Shelves
(
	ShelfID int primary key
)
go

INSERT INTO [dbo].[Shelves] ([ShelfID]) VALUES (1)
GO
INSERT INTO [dbo].[Shelves] ([ShelfID]) VALUES (2)
GO
INSERT INTO [dbo].[Shelves] ([ShelfID]) VALUES (3)
GO
INSERT INTO [dbo].[Shelves] ([ShelfID]) VALUES (4)
GO

--USERS
create table Users (UserID int identity(1,1) primary key, UserName nvarchar(50), Address nvarchar(100), 
					PhoneNumber varchar(15) unique, Orderdetails nvarchar(200), Password varchar(100), type int not null default 0)
go
INSERT INTO Users (Username, Address, PhoneNumber, Orderdetails, Password) VALUES
  (N'Nguyễn Văn A', N'123 Đường ABC, Quận 1, TP.HCM', '0123456789', N'Chi tiết đơn hàng 1', 'password1'),
  (N'Trần Thị B', N'456 Đường XYZ, Quận 2, TP.HCM', '0987654321', N'Chi tiết đơn hàng 2', 'password2'),
  (N'Lê Văn C', N'789 Đường DEF, Quận 3, TP.HCM', '0345678901', N'Chi tiết đơn hàng 3', 'password3'),
  (N'Hồ Thị D', N'101 Đường HIJ, Quận 4, TP.HCM', '0765432190', N'Chi tiết đơn hàng 4', 'password4'),
  (N'Phạm Văn E', N'202 Đường LMN, Quận 5, TP.HCM', '0567890123', N'Chi tiết đơn hàng 5', 'password5'),
  (N'Đặng Thị F', N'303 Đường OPQ, Quận 6, TP.HCM', '0234567891', N'Chi tiết đơn hàng 6', 'password6'),
  (N'Bùi Văn G', N'404 Đường RST, Quận 7, TP.HCM', '0456789012', N'Chi tiết đơn hàng 7', 'password7'),
  ( N'Mai Thị H', N'505 Đường UVW, Quận 8, TP.HCM', '0890123456', N'Chi tiết đơn hàng 8', 'password8'),
  (N'Hoàng Văn I', N'606 Đường XYZ, Quận 9, TP.HCM', '0678901234', N'Chi tiết đơn hàng 9', 'password9'),
  (N'Vũ Thị K', N'707 Đường ABC, Quận 10, TP.HCM', '0456789123', N'Chi tiết đơn hàng 10', 'password10');
GO
INSERT INTO Users (Username, Address, PhoneNumber, Password, type) VALUES
  (N'Admin', N'123 Đường ABC, Quận 1, TP.HCM', '0868133811', 'adminpass', 1)
go

--AUTHORS
create table Authors (AuthorID int identity(1,1), AuthorName nvarchar(100) primary key)
go
INSERT INTO Authors VALUES
  (N'J K Rowling'),
  (N'Nam Cao'),
  (N'Thạch Lam'),
  (N'Paulo Coelho'),
  (N'Viện Kinh tế Việt Nam'),
  (N'Gosho Aoyama')
Go

--CATEGORIES
create table Categories (CategoryID int identity(1,1), CategoryName nvarchar(50) primary key)
go

INSERT INTO Categories VALUES
  (N'Khoa học'),
  (N'Thơ'),
  (N'Trinh thám'),
  (N'Lịch sử'),
  (N'Tiểu thuyết'),
  (N'Tâm lý học');
GO

--BOOKS
create table Books (BookID int identity(1,1) primary key,
					BookName nvarchar(100),
					ShelfID int foreign key references Shelves(ShelfID),
					FloorID int foreign key references Floors(FloorID),
					AuthorName nvarchar(100) foreign key references Authors(AuthorName),
					CategoryName nvarchar(50) foreign key references Categories(CategoryName),
					Date_publication date,
					Descriptions nvarchar(1000),
					Quantity int, 
					image varchar(500) default 'book1.jpg')
go


INSERT INTO Books VALUES
  ( N'Harry Potter and the philosopher s Stone', 1, 1, N'J K Rowling', N'Tiểu thuyết', '2001-11-16', N'Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.', 10, 'harrypotter1.jpg'),
  ( N'Cách Mạng Ruộng Đất Ở Việt Nam', 1, 1, N'Viện Kinh tế Việt Nam', N'Khoa học', '2021-11-20', N'Đến hết thế kỷ XX, có thể nói, xã hội Việt Nam vẫn là một xã hội chịu sự chi phối của ba yếu tố nông thôn – nông nghiệp – nông dân. Chế độ ruộng đất là một vấn đề “hằng xuyên” trong lịch sử Việt Nam. Mọi biến động về chế độ ruộng đất đều ảnh hưởng lớn đến cấu trúc và sự phát triển của xã hội. Vì vậy, đây là mảng đề tài luôn được các nhà Sử học, Kinh tế học Việt Nam quan tâm nghiên cứu.', 10, 'cmruongdatvn.jpg'),
  ( N'Tuyển Tập Nam Cao (2023)', 2, 1, N'Nam Cao', N'Tiểu thuyết', '2023-01-01', N'Tuyển tập Nam Cao” xin giới thiệu tới quý độc giả những sáng tác tiêu biểu nhất của nhà văn Nam Cao: Chí Phèo; Đời thừa; Sống mòn; Tư cách mõ; Quên điều độ; Lang rận; Nhìn người ta sung sướng; Lão Hạc… và nhiều truyện ngắn khác.', 10, 'namcao.jpg'),
  ( N'Nhà giả kim', 3, 1, N'Paulo Coelho', N'Tiểu thuyết', '1988-02-05', N'Nhà giả kim (tựa gốc tiếng Bồ Đào Nha: O Alquimista) là tiểu thuyết được xuất bản lần đầu ở Brasil năm 1988, và là cuốn sách nổi tiếng nhất của nhà văn Paulo Coelho. Tác phẩm đã được dịch ra 67 ngôn ngữ và bán ra tới 95 triệu bản (theo thống kê ngày 19 tháng 5 năm 2008), trở thành một trong những cuốn sách bán chạy nhất mọi thời đại.', 10, 'nhagiakim.jpg'),
  ( N'Thám Tử Lừng Danh Conan - Tập 1', 4, 1, N'Gosho Aoyama', N'Trinh thám', '2017-12-30', N'Nhân vật chính của truyện là một thám tử học sinh trung học có tên là Kudo Shinichi - thám tử học đường xuất sắc - một lần bị bọn tội phạm ép uống thuốc độc và bị teo nhỏ thành học sinh tiểu học lấy tên là Conan Edogawa và luôn cố gắng truy tìm tung tích tổ chức Áo Đen nhằm lấy lại hình dáng cũ.', 10, 'conan.jpg')
go


create table Borrow(BorrowID int identity(1,1) primary key, 
					BookID int foreign key references Books(BookID),
					UserID int foreign key references Users(UserID),
					BorrowedDate date not null,
					Amount int check(Amount>=0), 
					status nvarchar(15) not null default N'Chờ Mượn')
GO

INSERT INTO [dbo].[Borrow]
           ([BookID]
           ,[UserID]
           ,[BorrowedDate]
           ,[Amount]
           ,[status])
     VALUES
           (1
           ,1
           ,GETDATE() - 30
           ,2
           ,default)
GO

Create proc AddBorrow  (@BookID INT, @UserID INT, @Amount int, @BorrowID int out)
AS
BEGIN
	IF (Select Books.Quantity From Books Where BookID = @BookID) > 0
	BEGIN
		If @Amount <= (Select Books.Quantity From Books Where BookID = @BookID)
		BEGIN
			INSERT INTO Borrow(BookID, UserID, BorrowedDate, Amount, status)
			Values (@BookID, @UserID, GETDATE(), @Amount, default)
			Select  @BorrowID = @@IDENTITY
		END
		ELSE PRINT (N'Không Đủ sách')
	END
	ELSE Print(N'Không Đủ sách')
END
GO

CREATE PROC DeleteBorrow (@BorrowID int)
As
	delete from Borrow where BorrowID=@BorrowID
go


--LOAN
create table Loan (LoanID int identity(1,1) primary key, BorrowID int foreign key references Borrow(BorrowID),
					ConfirmDate date not null, Overdue date not null, ReturnDate date default '9998-12-31', 
					AmountOfFine int check(AmountOfFine>=0), status nvarchar(15) not null default N'Chưa Trả')
GO

/*
drop table Loan
go
*/

/*
INSERT INTO [dbo].[Loan]
           ([BorrowID]
		   ,[ConfirmDate]
           ,[Overdue]
           ,[ReturnDate]
           ,[AmountOfFine]
           ,[status])
     VALUES
           (1
           ,GETDATE() - 29
           ,GETDATE() - 14
		   ,default
           ,0
           ,default)
GO
*/

CREATE PROCEDURE LoanAdd 
(
	@BorrowID INT,
	@LoanID int OUTPUT
)
AS 
BEGIN
	if exists(Select Loan.BorrowID from Loan where Loan.BorrowID=@BorrowID)
	begin
		Print(N'Mã Mượn Này đã được mượn')
	end
	else 
	begin
		INSERT INTO [dbo].[Loan] ([BorrowID], [ConfirmDate], [Overdue], [ReturnDate], [AmountOfFine], [status])
		VALUES (@BorrowID ,Getdate(), getdate()+15 ,Default ,0 ,default)
		Select  @LoanID = @@IDENTITY
		Update Books Set Books.Quantity = Books.Quantity - (Select Borrow.Amount from Borrow where BorrowID=@BorrowID)
		Where Books.BookID = (Select Borrow.BookID from Borrow where Borrow.BorrowID=@BorrowID)
		if (Select Books.Quantity from Books where Books.BookID = (Select Borrow.BookID from Borrow where Borrow.BorrowID=@BorrowID)) < 0
		begin
			Update Books Set Books.Quantity = 0 where Books.BookID = (Select Borrow.BookID from Borrow where Borrow.BorrowID=@BorrowID)
		end
		Update Borrow set status=N'Đã Mượn' where BorrowID=@BorrowID
	end
END
GO


CREATE Proc UpdateLoan (@LoanID int, @AmountOfFine int)
as
begin
	Update Books Set Books.Quantity = Books.Quantity + (Select Borrow.Amount from Borrow where BorrowID=(Select Loan.BorrowID from Loan where LoanID=@LoanID))
	Where Books.BookID = (Select Borrow.BookID from Borrow where Borrow.BorrowID=(Select Loan.BorrowID from Loan where LoanID=@LoanID))
	
	update Loan set ReturnDate=GETDATE(), AmountOfFine=@AmountOfFine, status=N'Đã Trả' where LoanID = @LoanID
end
go

/*
create proc LoanDelete @LoanID int 
AS
BEGIN
	update Books set Books.Quantity = .Books.Quantity + Loan.Amount From Books Join Loan On Books.BookID = Loan.BookID Where Loan.LoanID = @LoanID
	DElete from Loan where LoanID = @LoanID
END
GO
*/


--REPORTING
create table Reporting (ReportID int identity(1,1) primary key, UserID int foreign key references Users(UserID),
						BookID int foreign key references Books(BookID), IssueDecriptions nvarchar(1000), status nvarchar(10) default N'Chưa Sửa')
go


CREATE PROCEDURE BookAdd
(@BookName NVARCHAR(100), @ShelfID int, @FloorID int, @AuthorName NVARCHAR(100), @CategoryName NVARCHAR(50), @Date_publication DATE, @Descriptions NVARCHAR(1000), @Quantity INT, @image varchar(100), @BookID int OUTPUT, @AuthorID int OUTPUT, @CategoryID int OUTPUT )
AS
BEGIN
	IF EXISTS(SELECT BookName FROM Books WHERE BookName = @BookName)
	BEGIN
		UPDATE Books SET Quantity = Quantity + @Quantity
		WHERE Books.BookName = @BookName
	END
	ELSE
	BEGIN
		IF EXISTS(SELECT AuthorName FROM Authors Where AuthorName = @AuthorName)
		BEGIN
			IF EXISTS(SELECT CategoryName FROM Categories Where CategoryName = @CategoryName)
			BEGIN
				INSERT INTO Books (BookName, ShelfID, FloorID, AuthorName, CategoryName, Date_publication, Descriptions, Quantity, image)
				Values ( @BookName, @ShelfID, @FloorID, @AuthorName, @CategoryName, @Date_publication, @Descriptions, @Quantity, @image)
				Select 
					@BookID = @@IDENTITY
			END
			ELSE
			BEGIN
				INSERT INTO Categories (CategoryName) VALUES (@CategoryName)
				SELECT @CategoryID = @@IDENTITY

				INSERT INTO Books (BookName, ShelfID, FloorID, AuthorName, CategoryName, Date_publication, Descriptions, Quantity, image)
				Values ( @BookName, @ShelfID, @FloorID, @AuthorName, @CategoryName, @Date_publication, @Descriptions, @Quantity, @image)
				Select 
					@BookID = @@IDENTITY
			END
		END
		ELSE 
		BEGIN
			INSERT INTO Authors (AuthorName) VALUES (@AuthorName)
			SELECT @AuthorID = @@IDENTITY
			IF EXISTS(SELECT CategoryName FROM Categories WHERE CategoryName = @CategoryName)
			BEGIN
				INSERT INTO Books (BookName, ShelfID, FloorID, AuthorName, CategoryName, Date_publication, Descriptions, Quantity, image)
				Values ( @BookName, @ShelfID, @FloorID, @AuthorName, @CategoryName, @Date_publication, @Descriptions, @Quantity, @image)
				Select 
					@BookID = @@IDENTITY
			END
			ELSE
			BEGIN
				INSERT INTO Categories (CategoryName) VALUES (@CategoryName)
				SELECT @CategoryID = @@IDENTITY

				INSERT INTO Books (BookName, ShelfID, FloorID, AuthorName, CategoryName, Date_publication, Descriptions, Quantity, image)
				Values ( @BookName, @ShelfID, @FloorID, @AuthorName, @CategoryName, @Date_publication, @Descriptions, @Quantity, @image)
				Select 
					@BookID = @@IDENTITY
			END
		END
	END
END
GO

CREATE PROC UpdateBook
(@BookID int, @BookName NVARCHAR(100), @ShelfID int, @FloorID int, @AuthorName NVARCHAR(100), @CategoryName NVARCHAR(50), @Date_publication DATE, @Descriptions NVARCHAR(1000), @Quantity INT, @image varchar(500))
AS
BEGIN
	Update Books SET BookName=@BookName, ShelfID=@ShelfID, FloorID=@FloorID, AuthorName=@AuthorName, CategoryName=@CategoryName, Date_publication=@Date_publication, Descriptions=@Descriptions, Quantity=Quantity+@Quantity, image=@image
	Where BookID = @BookID
END
GO


CREATE proc DeleteBook
( @BookID int )
AS
	if exists (Select BookID from Borrow where BookID = @BookID)
	BEGIN
		If exists (Select BorrowID from Loan where BorrowID = (Select BorrowID from Borrow where BookID = @BookID))
		Begin
			delete from Loan where BorrowID = (Select BorrowID from Borrow where BookID = @BookID)
		End
		Delete Borrow where BookID = @BookID
	END
	if exists (Select * from Reporting where BookID = @BookID)
	BEGIN
		Delete Reporting where BookID = @BookID
	END
	DElete from Books where BookID = @BookID
GO

create proc SendReport
@UserID int, @BookID int, @IssueDecriptions nvarchar(1000), @ReportID int out
as
begin
INSERT INTO [dbo].[Reporting]
           ([UserID]
           ,[BookID]
           ,[IssueDecriptions]
		   ,[status])
     VALUES
           (@UserID
           ,@BookID
           ,@IssueDecriptions
		   ,default)
	Select @ReportID = @@IDENTITY
end
go

create proc UpdateReport @ReportID int
as
	update Reporting set status=N'Đã Sửa' where ReportID=@ReportID
go

Create View V_Report
AS
	SELECT Reporting.ReportID as N'Mã Báo Cáo', Reporting.UserID as N'Mã Sinh Viên', Reporting.BookID as N'Mã Sách', Books.BookName as N'Tên Sách',
		   Reporting.IssueDecriptions as N'Mô Tả Lỗi', Reporting.status as N'Trạng Thái'
	FROM Reporting INNER JOIN
    Books ON Reporting.BookID = Books.BookID INNER JOIN
    Users ON Reporting.UserID = Users.UserID
GO

/*
drop table Reporting 
drop table Loan
drop table Books
drop table Authors
drop table Categories
drop table Users
drop table Loan
*/
	

--User
	-- Add user
Create proc USP_Login
@PhoneNumber nvarchar(15), @Password varchar(100)
as
begin
	select * from dbo.Users where PhoneNumber = @PhoneNumber and Password = @Password
end
go

create proc USP_Register
@UserName nvarchar(100), @Address nvarchar(100), @PhoneNumber varchar(15), @Password varchar(100), @UserID int out
as
begin
	Insert into Users (UserName, Address, PhoneNumber, Password, type) Values (@UserName, @Address, @PhoneNumber, @Password, 0)
	select @UserID = @@IDENTITY
end
go

create proc USP_UpdateUser
@UserID int, @UserName nvarchar(100), @Address nvarchar(100), @PhoneNumber varchar(15), @Orderdetails nvarchar(200), @Password varchar(100)
as
begin
	Update Users SET UserName=@UserName, Address=@Address, PhoneNumber=@PhoneNumber, Orderdetails=@Orderdetails, Password=@Password
	WHere UserID = @UserID
end
go


create proc DeleteUser ( @UserID int )
AS
	
	if exists (Select UserID from Borrow where UserID = @UserID)
	BEGIN
		If exists (Select BorrowID from Loan where BorrowID = (Select BorrowID from Borrow where UserID = @UserID))
		Begin
			delete from Loan where BorrowID = (Select BorrowID from Borrow where UserID = @UserID)
		End
		Delete Borrow where UserID = @UserID
	END
	if exists (Select * from Reporting where UserID = @UserID)
	BEGIN
		Delete Reporting where UserID = @UserID
	END
	DElete from Users where UserID = @UserID
GO


/*
	CREATE PROCEDURE AuthorAdd 
	(
	
		@FullName NVARCHAR(100),
		@AuthorID int OUTPUT
	)
	AS INSERT INTO Authors (FullName)
	Values (@FullName)
	Select 
		@AuthorID = @@IDENTITY

	-- Edit Author
	CREATE PROCEDURE AuthorEdit
		@AuthorID INT,
		@Fullname NVARCHAR(100)
	AS
	BEGIN

		UPDATE Authors
		SET
			Fullname = @Fullname
		WHERE
			AuthorID = @AuthorID;

	END;

	-- Delete Author
	create proc AuthorDelete
	(
	@AuthorID int
	)
	AS
	if exists (Select * from Books where AuthorID = @AuthorID)
	BEGIN
		Delete Books where AuthorID = @AuthorID
	END

	DElete from Authors where AuthorID = @AuthorID

	CREATE PROCEDURE CategoryAdd 
	(
	
		@CategoryName NVARCHAR(100),
		@CategoryID int OUTPUT
	)
	AS INSERT INTO Categories (CategoryName)
	Values (@CategoryName)
	Select 
		@CategoryID = @@IDENTITY

	-- Edit Author
	CREATE PROCEDURE CategoryEdit
		@CategoryID INT,
		@CategoryName NVARCHAR(30)
	AS
	BEGIN

		UPDATE Categories
		SET
			CategoryName = @CategoryName
		WHERE
			CategoryID = @CategoryID;

	END;

	-- Delete Author
	create proc CategoryDelete
	(
	@CategoryID int
	)
	AS
	if exists (Select * from Books where CategoryID = @CategoryID)
	BEGIN
		Delete Books where CategoryID = @CategoryID
	END

	DElete from Categories where CategoryID = @CategoryID
*/

--Loan
	-- Add new book



	--Delete Loan




-- View book
/*
Create view v_book
as
(
SELECT Books.BookID, Books.BookName, Categories.CategoryName, Authors.FullName
FROM     Authors INNER JOIN
                  Books ON Authors.AuthorID = Books.AuthorID INNER JOIN
                  Categories ON Books.CategoryID = Categories.CategoryID
)
go

CREATE proc SearchBook
@SearchQuery nvarchar(100)
as
	SELECT BookID as N'Mã Sách', BookName as N'Tên Sách', AuthorName as N'Tác Giả', CategoryName as N'Danh Mục', Date_publication as N'Ngày Xuất Bản', Descriptions as N'Mô Tả', Quantity as N'Số Lượng' FROM Books
	Where BookName like '%'+@SearchQuery+'%' OR Descriptions like '%'+@SearchQuery+'%'
Go
*/


-- Delete issue
/*
create proc DeleteIssue
( @ReportID int )
AS
	DElete from Reporting where ReportID = @ReportID
go
*/
-- View Muon sach
/*
CREATE view v_Loan
as
	SELECT Loan.LoanID as N'Mã Hóa Đơn', Borrow.UserID as N'Mã Người Mượn', Users.UserName as N'Tên Người Mượn', Users.Address as N'Địa Chỉ', Users.PhoneNumber as N'Số Điện Thoại',
		   Books.BookName as N'Tên Sách', Books.ShelfID as N'Kệ Số', Books.FloorID as N'Tầng', Borrow.BorrowedDate as N'Ngày Mượn', Borrow.Amount as N'Số Lượng Mượn',
		   Loan.ConfirmDate as N'Ngày Được Mượn', Loan.Overdue as N'Hạn Trả', Loan.ReturnDate as N'Ngày Trả', Loan.AmountOfFine as N'Phạt', Loan.status as N'Trạng Thái'
	FROM Books INNER JOIN
                  Borrow ON Books.BookID = Borrow.BookID INNER JOIN
                  Loan ON Borrow.BorrowID = Loan.BorrowID INNER JOIN
                  Users ON Borrow.UserID = Users.UserID
go
*/

create proc USP_v_Loan  (@UserID int)
as
	SELECT Loan.LoanID as N'Mã Hóa Đơn', Books.BookName as N'Tên Sách', Books.ShelfID as N'Kệ Số', Books.FloorID as N'Tầng', Borrow.BorrowedDate as N'Ngày Mượn', Borrow.Amount as N'Số Lượng Mượn',
	   Loan.ConfirmDate as N'Ngày Được Mượn', Loan.Overdue as N'Hạn Trả', Loan.ReturnDate as N'Ngày Trả', Loan.AmountOfFine as N'Phạt', Loan.status as N'Trạng Thái'
	FROM Books INNER JOIN
         Borrow ON Books.BookID = Borrow.BookID INNER JOIN
         Loan ON Borrow.BorrowID = Loan.BorrowID INNER JOIN
         Users ON Borrow.UserID = Users.UserID
	where Borrow.UserID = @UserID
go


CREATE view v_Borrow
as
	SELECT Borrow.BorrowID as N'Mã Mượn', Borrow.UserID as N'Mã Người Mượn', Users.UserName as N'Tên Người Mượn', Users.Address as N'Địa Chỉ', Users.PhoneNumber as N'Số Điện Thoại',
		   Borrow.BookID as N'Mã Sách', Books.BookName as N'Tên Sách', Books.ShelfID as N'Kệ Số', Books.FloorID as N'Tầng', Borrow.BorrowedDate as N'Ngày Mượn',
		   Borrow.Amount as N'Số Lượng Mượn', Books.Quantity as N'Số Lượng Sách Còn', Borrow.status as N'Trạng Thái'
	FROM Books INNER JOIN
         Borrow ON Books.BookID = Borrow.BookID INNER JOIN
         Users ON Borrow.UserID = Users.UserID
	Where Borrow.status=N'Chờ Mượn'
go

CREATE proc USP_v_Borrow  (@UserID int)
as
	SELECT Borrow.BorrowID as N'Mã Mượn', Borrow.BookID as N'Mã Sách', Books.BookName as N'Tên Sách', Books.ShelfID as N'Kệ Số', Books.FloorID as N'Tầng', Borrow.BorrowedDate as N'Ngày Mượn',
		   Borrow.Amount as N'Số Lượng Mượn', Books.Quantity as N'Số Lượng Sách Còn', Borrow.status as N'Trạng Thái'
	FROM Books INNER JOIN
         Borrow ON Books.BookID = Borrow.BookID INNER JOIN
         Users ON Borrow.UserID = Users.UserID
	Where Borrow.status=N'Chờ Mượn' AND Borrow.UserID = @UserID
go




-- Qua han
/*
Create proc QuaHan
as
(
	SELECT * FROM v_Loan
	WHERE DATEDIFF(DAY, BorrowedDate, GETDATE()) > 0
)
*/

-- Tạo trigger trước khi insert vào bảng Loan
/*
CREATE TRIGGER trg_PreventDuplicateBookLoans
ON Loan
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT l.BookID
        FROM Loan l
        INNER JOIN inserted i ON l.BookID = i.BookID
    )
    BEGIN
        RAISERROR ('Cuốn sách đã được mượn.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        INSERT INTO Loan (LoanID, BookID, UserID, BorrowedDate, ReturnDate, AmountOfFine)
        SELECT LoanID, BookID, UserID, BorrowedDate, ReturnDate, AmountOfFine
        FROM inserted;
    END
END;
INSERT INTO Loan 
VALUES (1, 1, 1, '2023-11-01', '2023-12-01', 0),
       (2, 1, 2, '2023-11-01', '2023-12-01', 0);
INSERT INTO Loan VALUES (3, 1, 3, '2023-11-05', '2023-11-25', 0);
select * from Loan
DELETE FROM Loan;
*/



