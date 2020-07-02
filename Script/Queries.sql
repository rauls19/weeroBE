--Discos offset
SELECT *
FROM discos
limit 5 offset 0;

--Users with genre
select *
from users u 
where u.genre = 'F' and u.interested = 0;

--Women interested in men
select * 
from users u
where  u.genre = 'M' and u.interested = 1 and u.disco = 1;
--limit 20 offset 5;

--Men interested in women
select * 
from users u 
where u.genre = 'F' and u.interested = 0 and u.disco = 1;

--Men interested in men
select * 
from users u 
where u.genre = 'M' and u.interested = 0 and u.disco = 1;

--Woman interested in woman
select * 
from users u 
where u.genre = 'F' and u.interested = 1 and u.disco = 1;

--Men interested in both
select * 
from users u 
where u.genre = 'M' and u.interested = 0 and u.disco = 1
union 
select *
from users u2 
where u2.genre = 'F' and u2.interested = 0 and u2.disco = 1
union
select *
from users u3
where u3.interested = 2 and u3.disco = 1;

--Woman interested in both
select * 
from users u 
where u.genre = 'M' and u.interested = 1 and u.disco = 1
union 
select *
from users u2 
where u2.genre = 'F' and u2.interested = 1 and u2.disco = 1
union
select *
from users u3
where u3.interested = 2 and u3.disco = 1;

select u.id , u."name" , u.surname
from users u left join likes l on u.id = l.userLike 
where l.userLike is null and u.id != 2 and 
		u.genre = 'M' and u.interested = 1;

select u.id , u."name" , u.surname
from users u 
where u.id != 2 and u.genre = 'M' and u.interested = 1;

select *
from likes l;

select *
from users u 
where u.genre ='F' and u.interested =0;

select l.userLike
from likes l 
where l.userOrigin = 2;

--Query to get the list of possible matches
select * 
from users u 
where u.id != 2 and u.genre = 'M' and u.interested = 1 and u.disco = 1
		and u.id not in (
			select l.userLike
			from likes l 
			where l.userOrigin = 2
			union 
			select m.userlike 
			from matches m
			where m.userorigin =2
		)
limit 10 offset 0;