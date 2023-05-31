Create database FoodieApp

select * from AddressTable

Use FoodieApp

-- create UserTable
CREATE TABLE UserTable (
    UserId int PRIMARY KEY IDENTITY(1,1),
    FirstName varchar(255) NOT NULL,
    Lastname varchar(255) NOT NULL,
    Emailid varchar(255) NOT NULL,
    password varchar(255) NOT NULL,
    MobileNo bigint NOT NULL
);

select * from UserTable

select * from Cuisine
select * from RestaurantTable
select * from CategoryTable
select * from Resataurantcity
select * from FoodType

alter table RestaurantTable  add Image varchar(550) not null
-- create AddressTable,
CREATE TABLE AddressTable (
    AddressId int PRIMARY KEY IDENTITY(1,1),
    Fullname varchar(255) NOT NULL,
    MobileNo bigint NOT NULL,
    pinCode int NOT NULL,
    Address varchar(550) NOT NULL,
    City varchar(255) NOT NULL,
    State varchar(255) NOT NULL,
    UserId int NOT NULL,
    FOREIGN KEY (UserId) REFERENCES UserTable(UserId) ON UPDATE CASCADE
);

-- create CategoryTable
CREATE TABLE CategoryTable (
    CategoryId int PRIMARY KEY IDENTITY(1,1),
    CategoryName varchar(255) NOT NULL,
    Categoryimage varchar(550) NOT NULL,
    CategoryDescription varchar(550) NOT NULL
);

-- create Rcity
CREATE TABLE Resataurantcity (
    cityId int PRIMARY KEY identity(1,1),
    City varchar(255) NOT NULL,
    State varchar(255) NOT NULL
);
Drop table Resataurantcity
-- create RestaurantTable
CREATE TABLE RestaurantTable (
    Id int PRIMARY KEY IDENTITY(1,1),
    Name varchar(355) NOT NULL,	
    CityId int NOT NULL,
    CuisineId int NOT NULL,
    Rating decimal(2,2) NOT NULL,
    TypeId int NOT NULL,
	CategoryId int NOT NULL,
    FOREIGN KEY (CityId) REFERENCES Resataurantcity(cityId),
    FOREIGN KEY (CuisineId) REFERENCES Cuisine(Id),
    FOREIGN KEY (TypeId) REFERENCES FoodType(Id) ,
    FOREIGN KEY (CategoryId) REFERENCES CategoryTable( CategoryId)
);

insert into RestaurantTable (Name,CityId,CuisineId,Rating,TypeId,CategoryId,Menutype,CostPerPerson,Image) 
VALUES ('Veg Junction',1,1,4.2,1,3,'North indian & south indian',200,'https://i.ibb.co/FYhw48T/food1.jpg '),('Veg Junction',1,2,4.2,1,5,'North indian & south indian',200,'https://i.ibb.co/FYhw48T/food1.jpg ')
,('Cheese Cafe',1,4,3.9,1,4,'cheese sandwhich,pizza,maggi.',150,'https://i.ibb.co/9tPHLKt/food2.jpg'),('Cheese Cafe',1,5,3.9,1,7,'cheese sandwhich,pizza,maggi.',150,'https://i.ibb.co/9tPHLKt/food2.jpg')
,('Delicious',1,1,3.6,3,3,'chicken ,Fry fish, Briyani',200,'https://i.ibb.co/Tr2vBm8/food3.jpg'),('Delicious',1,4,3.6,3,5,'chicken ,Fry fish, Briyani',200,'https://i.ibb.co/Tr2vBm8/food3.jpg'),
('Pizza Hub',1,4,4.5,2,4,'Pizza , Burger, MilkShake',150,'https://i.ibb.co/Ht6nHjH/food9.jpg'),('Pizza Hub',1,5,4.5,2,6,'Pizza , Burger, MilkShake',150,'https://i.ibb.co/Ht6nHjH/food9.jpg'),
('Chinese Hub',1,4,4.1,2,4,'Noodles, Machurian, pasta',100,'https://i.ibb.co/DG0sCNs/food5.jpg'),('Chinese Hub',1,5,4.1,2,7,'Noodles, Machurian, pasta',100,'https://i.ibb.co/DG0sCNs/food5.jpg'),
('Punjabi Dhaba',1,1,4.6,1,5,'punjabi Thali ,North indian,Drinks',250,'https://i.ibb.co/0c6GGgz/food6.jpg'),('Punjabi Dhaba',1,1,4.6,1,7,'punjabi Thali ,North indian,Drinks',250,'https://i.ibb.co/0c6GGgz/food6.jpg')




alter table RestaurantTable alter column Rating decimal(10,2) not null
truncate table RestaurantTable
-- create MenuTable
CREATE TABLE MenuTable (
    MenuId int PRIMARY KEY IDENTITY(1,1),
    RestaurantId int NOT NULL,
    MenuName varchar(255) NOT NULL,
    Price varchar(255) NOT NULL,
    Image varchar(550) NOT NULL,
    Rating float NOT NULL,
    CusineId int NOT NULL,
    FOREIGN KEY (RestaurantId) REFERENCES RestaurantTable(Id),
    FOREIGN KEY (CusineId) REFERENCES Cuisine(Id)
);
drop table MenuTable

Insert into MenuTable (RestaurantId,MenuName,Price,Image,Rating,CusineId) values(1,'Paneer Tadka',220,'https://i.ibb.co/FYhw48T/food1.jpg',4.2,1),
(1,'Palak Paneer',240,'https://i.ibb.co/QYNnY5Z/palak-paneer-recipe.jpg',4.4,1),(1,'Dal Tadka',190,'https://i.ibb.co/gg0xgVj/Dal-Tadka-2.jpg',4.5,1),
(2,'Masala Dosa',150,'https://i.ibb.co/93w6jSw/thumb-700-0-0-0-auto.jpg',3.9,2),(2,'Idli',145,'https://i.ibb.co/N2Ws4dk/idli12.jpg',3.8,2),
(2,'Sambhar Vada',160,'https://i.ibb.co/HKppnvs/Medu-vada-recipe-in-Robocook-fryo-1200x900.jpg',4,2)

CREATE or ALTER PROCEDURE sp_GetAllMenu
@restaurant varchar(255)
AS
BEGIN
    SELECT * FROM MenuTable where RestaurantId in ( select Id from RestaurantTable where Name=@restaurant);
END

    SELECT * FROM MenuTable where RestaurantId in ( select Id from RestaurantTable where Name='Veg Junction');



-- create CartTable
CREATE TABLE CartTable (
    CartId int PRIMARY KEY IDENTITY(1,1),
    UserId int NOT NULL,
    MenuId int NOT NULL,
    Quantity int NOT NULL,
    FOREIGN KEY (UserId) REFERENCES UserTable(UserId) ON UPDATE CASCADE,
    FOREIGN KEY (MenuId) REFERENCES MenuTable(MenuId) ON UPDATE CASCADE
);

-- create PayementTable
CREATE TABLE PayementTable (
    PaymentId int PRIMARY KEY IDENTITY(1,1),
    UserId int NOT NULL,
    PaymentMode varchar(255) NOT NULL,
    FOREIGN KEY (UserId) REFERENCES UserTable(UserId) ON UPDATE CASCADE
);

-- create OrderTable
CREATE TABLE OrderTable (
    orderId int PRIMARY KEY IDENTITY(1,1),
    UserId int NOT NULL,
    MenuId int NOT NULL,
    Quantity int NOT NULL,
    TotalPrice int NOT NULL,
    PaymentId int NOT NULL,
    FOREIGN KEY (UserId) REFERENCES UserTable(UserId) ,
    FOREIGN KEY (MenuId) REFERENCES MenuTable(MenuId) ,
    FOREIGN KEY (PaymentId) REFERENCES PayementTable(PaymentId) 
);

-- create Cuisine
CREATE TABLE Cuisine (
    Id int PRIMARY KEY IDENTITY(1,1),
    CuisineName varchar(255) NOT NULL
);

CREATE TABLE FoodType (
	Id INT PRIMARY KEY IDENTITY(1,1),
	TypeTitle VARCHAR(255) NOT NULL
)


CREATE PROCEDURE [dbo].[sp_CreateUser]
    @FirstName varchar(255),
    @LastName varchar(255),
    @EmailId varchar(255),
    @Password varchar(255),
    @MobileNo bigint
AS
BEGIN

    BEGIN TRY
        BEGIN TRANSACTION;

        INSERT INTO UserTable (FirstName, LastName, EmailId, Password, MobileNo)
        VALUES (@FirstName, @LastName, @EmailId, @Password, @MobileNo);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END


CREATE PROCEDURE [dbo].[sp_GetAllUsers]
AS
BEGIN
    
    BEGIN TRY
        BEGIN TRANSACTION;

        SELECT *
        FROM UserTable;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT  ERROR_MESSAGE()
    END CATCH
END

CREATE PROCEDURE [dbo].[sp_UpdateUser]
    @UserId int,
    @FirstName varchar(255),
    @LastName varchar(255),
    @EmailId varchar(255),
    @Password varchar(255),
    @MobileNo bigint
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE UserTable
        SET FirstName = @FirstName,
            LastName = @LastName,
            EmailId = @EmailId,
            Password = @Password,
            MobileNo = @MobileNo
        WHERE UserId = @UserId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END


CREATE PROCEDURE [dbo].[sp_DeleteUser]
    @UserId int
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM UserTable WHERE UserId = @UserId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END

--Address StoreProcedure

CREATE PROCEDURE sp_InsertAddress
(
    @Fullname varchar(255),
    @MobileNo bigint,
    @pinCode int,
    @Address varchar(550),
    @City varchar(255),
    @State varchar(255),
    @UserId int
)
AS
BEGIN

    BEGIN TRANSACTION;

    BEGIN TRY
        INSERT INTO AddressTable (Fullname, MobileNo, pinCode, Address, City, State, UserId)
        VALUES (@Fullname, @MobileNo, @pinCode, @Address, @City, @State, @UserId);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
         DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END

--update_sp

CREATE PROCEDURE UpdateAddress_sp
(
    @AddressId int,
    @Fullname varchar(255),
    @MobileNo bigint,
    @pinCode int,
    @Address varchar(550),
    @City varchar(255),
    @State varchar(255)
)
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE AddressTable SET
            Fullname = @Fullname,
            MobileNo = @MobileNo,
            pinCode = @pinCode,
            Address = @Address,
            City = @City,
            State = @State
        WHERE AddressId = @AddressId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
     throw;
    END CATCH;
END

--get sp

CREATE PROCEDURE sp_GetAllAddresses
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM AddressTable;
END


--delete sp


CREATE PROCEDURE sp_DeleteAddress
(
    @AddressId int
)
AS
BEGIN
    DELETE FROM AddressTable WHERE AddressId = @AddressId;
END

--category sp

CREATE PROCEDURE [dbo].[sp_CreateCategory]
    @CategoryName varchar(255),
    @CategoryImage varchar(550),
    @CategoryDescription varchar(550)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION

        INSERT INTO CategoryTable (CategoryName, CategoryImage, CategoryDescription) VALUES (@CategoryName, @CategoryImage, @CategoryDescription)

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        THROW;
    END CATCH
END


CREATE PROCEDURE [dbo].[sp_ReadAllCategory]
  
AS
BEGIN
    SET NOCOUNT ON;

    SELECT * FROM CategoryTable 
END

CREATE PROCEDURE [dbo].[sp_UpdateCategory]
    @CategoryId int,
    @CategoryName varchar(255),
    @CategoryImage varchar(550),
    @CategoryDescription varchar(550)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION

        UPDATE CategoryTable SET CategoryName = @CategoryName, CategoryImage = @CategoryImage, CategoryDescription = @CategoryDescription WHERE CategoryId = @CategoryId

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        THROW;
    END CATCH
END

CREATE PROCEDURE [dbo].[sp_DeleteCategory]
    @CategoryId int
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION

        DELETE FROM CategoryTable WHERE CategoryId = @CategoryId

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        THROW;
    END CATCH
END

CREATE PROCEDURE Sp_Getallrestaurants
@categoryid int,
@cityname varchar(255)
as
if(@categoryid=0)
	begin
			select Name,Menutype,CostPerPerson,Image from RestaurantTable where CityId in(select cityId from Resataurantcity where City=@cityname) group by Name,Menutype,CostPerPerson,Image

	end
else
	begin
			select Name,Menutype,CostPerPerson,Image from RestaurantTable where CategoryId=@Categoryid and CityId in(select cityId from Resataurantcity where City=@cityname) group by Name,Menutype,CostPerPerson,Image

	end 

drop procedure Sp_Getallrestaurants
exec Sp_Getallrestaurants 5


alter procedure Getcity
as
begin 
	begin try
		begin tran
			select * from Resataurantcity 
		commit tran
	end try
	begin catch
		rollback tran
		throw;
	end catch
end

exec Getcity

create or alter procedure GetRestbyname
@name varchar(255),
@city varchar(255)
as
begin 
	begin try
		begin tran
			select Name,Menutype,CostPerPerson,Image from RestaurantTable where Name like '%'+@name+'%' and CityId in(select cityId from Resataurantcity where City=@city) group by Name,Menutype,CostPerPerson,Image
		commit tran
	end try
	begin catch
		rollback tran
		throw;
	end catch
end


						select Name,Menutype,CostPerPerson,Image from RestaurantTable where Name like 'Veg Junction' and CityId in(select cityId from Resataurantcity where City='Nagpur') group by Name,Menutype,CostPerPerson,Image


