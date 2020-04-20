
--Discos (I will save the Logo's path instead of bytea, not yet)
CREATE TABLE Discos (
    Id bigserial,
    Name varchar(255),
    Location varchar(255),
    Logo bytea
);
--Dummy
--INSERT INTO public.discos
--("name", "location", logo)
--VALUES('Pacha', '41.385933, 2.197039', null);