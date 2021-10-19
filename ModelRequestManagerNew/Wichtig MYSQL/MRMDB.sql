create database MRMDB;
use MRMDB;
create table Users
(
UserID int not null primary key auto_increment,
UserGuidID varchar(50) not null,
UserName varchar(128) not null unique,
UserPassword varchar(128),
UserFirstName varchar(128),
UserLastName varchar(128),
UserBirthDate varchar(20),
UserRegisterDate varchar(20),
UserEmail varchar(128),
UserTelefon varchar(128),
UserAdmin bool,
UserAvailable bool
);





create table Requests
(
ReqID int not null,
ReqUserID int not null,
ReqNote varchar(128) not null,
ReqText Text not null,
ReqCategory int,
ReqFile varchar(128),
ReqWhiteBox bool,
ReqLow bool,
ReqHigh bool,
ReqTexture bool,
ReqDateTime varchar(20),
available bool,
index requestid (reqid),
Foreign key (ReqUserID) references Users(UserID)
);

create table SaveRequests
(
SaveUserId int not null,
SRUserID int not null,
SRReqID int not null,
foreign key (sruserid) references users(userid),

foreign key (SRReqID) references requests(ReqID)
);
create table UpDownload
(
UploadID int not null primary key auto_increment,
UDReqID int not null,
UDReqUserID int not null,
UDUserID int not null,
Filename varchar(128) not null,
FileText text not null,
FilePath varchar(256) not null,
PicturePath varchar (256),
UploadDate datetime,
FileWhiteBox bool,
FileLow bool,
FileHigh bool,
FileTexture bool

);

create table test
(
test varchar(128)
);
