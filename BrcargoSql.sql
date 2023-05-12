
create table Statuses
(
	StatusId int identity(1,1) primary key,
	StatusName nvarchar(30)
)
create table Users
(
	UserId int identity(1,1) primary key,
	UserStatusId int references Statuses(StatusId),
	UserFirstName nvarchar(50),
	UserLastName nvarchar(50),
	UserEmail nvarchar(50),
	UserPassword nvarchar(50),
	UserPhone int,
	UserBirthDay nvarchar(50),
	UserAddress nvarchar(100),
	UserFin int
)
create table Shops
(
	ShopId int identity(1,1) primary key,
	ShopName nvarchar(50),
	ShopLogo nvarchar(50),
	ShopUrl nvarchar(255)
)
create table Branchs
(
	BranchId int identity(1,1) primary key,
	BranchName nvarchar(50),
	BranchAddress nvarchar(100),
	BranchPhone int
)
create table Levels
(
	LevelId int identity(1,1) primary key,
	LevelName nvarchar(100)
)
create table Orders
(
	OrderId int identity(1,1) primary key,
	OrderClientId int references Users(UserId),
	OrderDate datetime not null default getdate(),
	OrderLevelId int references Levels(LevelId),
	OrderBranchId int references Branchs(BranchId),
)
create table Products
(
	ProductId int identity(1,1) primary key,
	ProductName nvarchar(50),
	ProductUrl nvarchar(100),
	ProductPrice int,
	ProductCargoAmount int,
	ProductCount int,
	ProductShopId int references Shops(ShopId)
)
create table Notifications
(
	NotificationId int identity(1,1) primary key,
	NotificationOrderId int references Orders(OrderId),
	NotificationClientId int references Users(UserId),
	NotificationTitle nvarchar(100),
	NotificationDescription nvarchar(250),
	NotificationDate datetime not null default getdate(),
	NotificationIsRead  bit not null default 0
)