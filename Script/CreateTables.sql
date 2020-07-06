
--Discos (I will save the Logo's path instead of bytea, not yet)
--Dummy
--INSERT INTO public.discos
--("name", "location", logo)
--VALUES('Pacha', '41.385933, 2.197039', null);
--I am using db identifiers, I should use hasid as an identifier

drop table discos;
drop table matches;
drop table users;
drop table likes;
drop table pictures;
drop table dislikes;
 
CREATE TABLE Discos (
    Id bigserial,
    Name varchar(255),
    Location varchar(255),
    Street varchar(255),
    City varchar(255),
    Logo bytea
);
CREATE TABLE Matches (
    id      	bigserial,
    userOrigin	bigint,
    userLike	bigint
);
-- Define all properties
CREATE TABLE users (
    id          bigserial,
    hashid      varchar(300),
    name        varchar(50),
    surname     varchar(150),
    birthday    date,
	email       varchar(50),
    password    varchar(255),
	Age         integer,
	Interested  int,
	Location    varchar(255),
	Description varchar(255),
	Mobilephone int unique,
	disco 		bigint,
	genre		varchar(1)
);
CREATE TABLE likes (
    id      	bigserial,
    userOrigin	bigint,
    userLike	bigint
);
CREATE TABLE pictures (
    id          bigserial,
    hashid      varchar(300),
    orderpic     int
);
CREATE TABLE dislikes (
    id          bigserial,
    userOrigin  bigint,
    userLike    bigint
);