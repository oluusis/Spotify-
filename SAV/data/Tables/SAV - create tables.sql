use master
go

if exists(select * from sys.databases where name = 'db_SAV')
drop database db_SAV
go

create database db_SAV
go
use db_SAV
go

create table tb_Artists
(
	ID				int				identity(1,1)	not null	PRIMARY KEY,
	Name			varchar(100)					not null,
	Description		varchar(1000)						null,
	CountryCode		varchar(2)						not null,
	ActiveFrom		datetime						not null,
	ActiveTo		datetime							null,
	ImageFile		varchar(200)					not null,
	
);

create table tb_Albums
(
	ID				int				identity(1,1)	not null	PRIMARY KEY, 
	Title			varchar(100)					not null,
	Year			int								not null,
	Description		varchar(1000)						null,
	ImageFile		varchar(200)					not null,
	Artist_ID		int 							not null,

	CONSTRAINT FK_Album_Artist
		FOREIGN KEY (Artist_ID)
		REFERENCES tb_Artists
);

create table tb_Songs
(
	ID				int				identity(1,1)	not null	PRIMARY KEY,
	Name			varchar(100)					not null,
	SongFile		varchar(200)					not null,
	DiscNo			int								not null,
	TrackNo			int								not null,
	Duration		float							not null,
	Album_ID		int								not null,

	CONSTRAINT FK_Song_Album	
		FOREIGN KEY (Album_ID)
		REFERENCES tb_Albums
);


create table tb_User
(
	ID 				int				identity(1,1)	not null 	PRIMARY KEY,
	Username		varchar(50)						not null,
	Password 		varchar(300)					not null,
	FirstName		varchar(50)						not null,
	LastName 		varchar(50)						not null,
	Email			varchar(100)					null,
	IsActive 		bit								not null
)

create table tb_Role
(
	ID				int 			identity(1,1) 	not null 		PRIMARY KEY,
	Code 			varchar(10)						not null,
	Name 			varchar(50)						not null,
	Description		varchar(500)					null

)

create table tb_UserRole
(
	ID				int 			identity(1,1) 	not null 		PRIMARY KEY,
	User_ID			int								not null,
	Role_ID			int 							not null,

	CONSTRAINT FK_UserRole_User
		FOREIGN KEY (User_ID)
		REFERENCES tb_User,
	
	CONSTRAINT FK_UserRole_Role
		FOREIGN KEY (Role_ID)
		REFERENCES tb_Role

)


