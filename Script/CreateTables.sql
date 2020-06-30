
--Discos (I will save the Logo's path instead of bytea, not yet)
--Dummy
--INSERT INTO public.discos
--("name", "location", logo)
--VALUES('Pacha', '41.385933, 2.197039', null);

drop table discos;

CREATE TABLE Discos (
    Id bigserial,
    Name varchar(255),
    Location varchar(255),
    Street varchar(255),
    City varchar(255),
    Logo bytea
);

INSERT INTO public.discos ("name", "location", Street, City) VALUES('Sala Apolo','41.37438 2.169588','Nou de la Rambla, 11 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Astoria','41.39394 2.153234','de París, 19 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Atik Electronik','41.37552 2.148344','Plaza de España,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Bachata','41.39211 2.150098','de Casanova, 17 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Barroko''s','41.39597 2.149840','d''Aribau, 24 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Bestial Beach Club','41.38518 2.196851','de Ramon Trias Fargas, 2- Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Bikini','41.39014 2.136766','L''Illa, Avinguda Diagonal, 54 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Bling Bling','41.39572 2.152674','de Tuset,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Boulevard','41.39244 2.163861','Passeig de Gràcia, 5 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Canela','41.40953, 2.160881','de Ca l''Alegre de Dalt, 5 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Carpe Diem','41.38518 2.196263','Passeig Marítim de la Barceloneta, 3 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Catwalk','41.38587 2.196813','de Ramon Trias Fargas, 2-- Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('City Hall','41.38771 2.168288','Rambla de Catalunya, 2- Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Clubhaus','41.38444 2.184594','del Marqués de l''Argentera, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Costa Breve','41.39546 2.150343','d''Aribau, 23 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Drome','41.39558 2.150018','de Moià,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Eclipse Hotel W','41.36863 2.190016','Plaça Rosa Del Vents  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('El Cinco Club','41.39259 2.141173','Plaça de Joan Llongueras,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('El Patrón','41.39543 2.148785','Travessera de Gr…cia, 4 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Ethniko','41.37538 2.188626','Passeig de Joan de Borb¢, 7 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Funky Buddha','41.37495 2.182006','Moll d''Espanya  Planta  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Gatsby','41.39613 2.151358','de Tuset, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Go Beatch','41.41360 2.229493','Port Esportiu, 14P (Port Forum), Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Golden Rose','41.37917 2.175878','dels Escudellers,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Grupo Arena','41.38850 2.163850','Balmes, 34 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Hotel Arts','41.38703 2.196511','Marina, 19-21 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Hotel Melia','41.40625 2.200997','Pere IV, 27 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Hyde Club','41.39262 2.162524','Passatge de Domingo,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Imperator','41.39717 2.160046','Còrsega, 327 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Input','41.36888 2.147747','Avinguda Francesc Ferrer i Guàrdia, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Jamboree','41.37972 2.175264','Pla‡a Reial, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('La Fira Provença','41.39048 2.155626','Provença, 17 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('La Fira Villarroel','41.39219 2.147825','Villarroel, 21 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('La Terrazza','41.36949 2.148059','Avenida Francesc Ferrer i Guàrdia, Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Luz De Gas','41.39464 2.149189','Muntaner, 24 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Medusa & Morena','41.38652 2.164947','Gran Via de les Corts Catalanes, 59 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Merlin','41.40061 2.190822','·vila, 14 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Mix Club','41.38645 2.182492','Comerç, 2 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Mojito','41.39312 2.156847','Rossell¢, 21 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Moog','41.37799 2.175068','Arc del Teatre, 3 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Nuba','41.39384 2.136000','del Dr. Fleming, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Opium','41.38558 2.196792','Passeig Marítim de la Barceloneta, 3 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Otto Zutz','41.40062 2.150009','de Lincoln, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Otto Zutz Los Altos','41.40062 2.150009','de Lincoln, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Pacha','41.38598 2.196996','Passeig Marítim de la Barceloneta, 3 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Purobeach Club','41.40882 2.217637','Passeig del Taulat, 262-26 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Razzmatazz','41.39794 2.191127','dels Almogàvers, 12 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Ikibana','41.39292 2.135200','del Dr. Fleming, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Sala B','41.39485 2.149035','de Muntaner, 24 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Sala Plataforma','41.37318 2.168040','La Rambla, 14 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Shöko','41.38573 2.197033','Passeig Marítim de la Barceloneta, 3 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Sidecar','41.38077 2.175252','Pla‡a Reial,  Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Sutton','41.39612 2.151517','de Tuset, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Tarantos','41.37990 2.175275','Pla‡a Reial, 1 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Twenties','41.39374 2.158079','del Rosselló, 20 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Velissima','41.36736 2.189014','Passeig de Joan de Borbó, 10 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Wolf','41.39587 2.188531','dels Almogàvers, 8 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Soho','41.39537 2.149882','Aribau, 19 Barcelona', 'Barcelona');
INSERT INTO public.discos ("name", "location", Street, City) VALUES('Up&Down','41.38131 2.114330','Avenida Dr. Marañón, 1 Barcelona', 'Barcelona');


SELECT *
FROM discos
limit 5 offset 0;


drop table matches;

CREATE TABLE Matches (
    id      	bigserial,
    userOrigin	bigint,
    userLike	bigint
);

drop table users;
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

INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Carlos','S nchez','20/10/1992','carlossanchez@gmail.com','carlossanchez',2,'41.413052, 2.182326','Estudiante UPF Para vivir m s tiempo tenemos que envejecer.','639253745','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Laura ','Sans','15/05/1995','laurasans@gmail.com','laurasans',0,'41.398002, 2.150066','Busco un chico atento, no ido m s...Hay que mirar m s all  de lo que ves.','694837283','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Patri','Bonhome','02/03/1999','patribonhome@gmail.com','patribonhome',1,'41.398002, 2.150066','Me gusta el techno. Tu cuerpo escucha todo lo que dice tu mente. S‚ positiva.','629102968','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Roger','Figaflores','12/12/2001','rogerfigaflores@gmail.com','rogerfigaflores',1,'41.390768, 2.153787','No esperes verme en Bling Bling. Una mentalidad positiva te ayuda a triunfar, piensa bien para vivir mejor.','669483627','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Aitor','Casta¤o','14/01/2000','aitorcasta¤o@gmail.com','aitrocasta¤o',1,'41.392152, 2.148229','S‚ sincero con el mundo (y contigo mismo), entrega tu coraz¢n a quien sepa apreciarlo y vive cada d¡a como si fuese el £ltimo.','617286612','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Bruno','Bermudez','30/03/2000','brunobermudez@gmail.com','brunobermudez',0,'41.395927, 2.142006','No le llames sue¤o, ll malo plan','693385744','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Daniel','Guit‚rrez','04/05/2000','danielgutierrez@gmail.com','danielguiterrez',1,'41.400128, 2.157831','Juzgar una persona no define quien es ella. Define quien eres t£.','683302937','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Frank','S„ngel','19/04/2000','franksangel@gmail.com','franksangel',1,'41.400128, 2.157831','La felicidad es como la coronavirus: un estado que se transmite, se contagia y se propaga.','633829466','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Laura ','Sed¢','15/07/2000','laurasedo@gmail.com','laurasedo',2,'41.386783, 2.170255','Estudiante UPF. La melancol¡a es la felicidad de estar triste.','647388277','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Martina','Castella','30/08/2001','martinacastella@gmail.com','martinacastella',1,'41.381510, 2.165266','Esc pate de lo ordinario.','644839445','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Oriol','Poligru','12/10/2001','oriolpoligru@gmail.com','oriolpoligru',1,'41.381204, 2.173677','Demuestra que puedes hacer mejor selfies que yo.','632836640','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Samantha','Calvo','07/07/2001','samanthacalvo@gmail.com','samanthacalvo',0,'41.382210, 2.179589','Vive, lucha, sue¤a, viaja. Repite.','633920199','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Ra£l','Lovezno','09/12/2001','raullovezno@gmail.com','raullovezno',1,'41.383369, 2.181756','Estudiante UB. Drama es despertarse un domingo a las 5:30 de la ma¤ana en lugar de acostarse','638294462','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Naiara','G¢mez','26/06/2001','naiaragomez@gmail.com','naiaragomez',1,'41.384359, 2.182807','onre¡r y no darse mala vida por nadie, esa es la actitud.','677483910','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Sheila','Bru','30/09/1999','sheilabru@gmail.com','sheilabru',0,'41.384359, 2.182807','La felicidad es una direcci¢n, no un lugar.','644839204','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Pol','Panoso','23/03/1999','polpanoso@gmail.com','polpanoso',1,'41.385519, 2.197013','Si no viene, usa el plan VE.','648592746','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Mario','Estaci¢n','05/12/1999','marioestacion@gmail.com','marioestacion',1,'41.385599, 2.197410','La vida no es un problema a resolver sino una realidad experimentar.','633772288','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Josh','Angustia','24/03/1999','joshangustia@gmail.com','joshangustia',0,'41.385752, 2.196595','No te estoy diciendo que ser  f cil, te estoy diciendo que valdr  la pena.','647009812','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Rafel','Leopoldo','02/06/1999','rafelleopoldo@gmail.com','rafelangustia',2,'41.386629, 2.197260','Sea donde sea, como sea, pero juntos.','657738294','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Camila','Camar‚s','14/07/1998','camilacamares@gmail.com','camilacamares',0,'41.387112, 2.196724','Estudiante Biolog¡a UB. Algunos de tus silencios rompen la barrera del sonido.','657384928','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Rodrigo','Fuentes','15/11/1998','rodrigofuentes@gmail.com','rodrigofuentes',0,'41.388609, 2.199857','Si lo puedes explicar, no es amor.','638492059','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Laia','Sancho','09/04/1998','laiasancho@gmail.com','laiasancho',0,'41.389213, 2.196595','Ve con quien te haga sentir viva.','637488293','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Ismael','Mimbre','28/04/1998','ismaelmimbre@gmail.com','ismaelmimbre',1,'41.368500, 2.189951','No soy lo que escribo, soy lo que sientes al leerme.','647294886','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Aitor','Barro','01/10/1998','aitorbarro@gmail.com','aitorbarro',1,'41.368862, 2.190198','Me gustas por dentro y por fuera fiera.','639203956','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Pere','Febrer','06/01/1997','perefebrer@gmail.com','perefebrer',2,'41.368886, 2.189887','¨Puedes darme un beso? Prometo devolv‚rtelo.','637482293','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Sergey','Ilianov','17/01/1997','sergeyilianov@gmail.com','sergeyilianov',1,'41.368789, 2.189962','Quiero verte y mis ganas lo saben.','664763829','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Laura ','Astuto','08/02/1997','lauraastuto@gmail.com','lauraastuto',0,'41.368765, 2.190177','Nuestros cuerpos riman.','610998545','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Armando','Bronza','15/03/1997','armandobronza@gmail.com','armandobronza',1,'41.379757, 2.175262','Viajar a Marte o a la pr¢xima esquina. Pero contigo.','637482938','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Pau','Pamies','14/12/1997','paupamies@gmail.com','paupamies',0,'41.379757, 2.175262','Me empez¢ a dar ordenes. A m¡, que soy de inercias.','663366738','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Mireia','Voltav n','01/10/1996','mireiavoltavan@gmail.com','mireiavoltavan',0,'41.379757, 2.175262','Normas de la casa: enfadarse muy poco, saber perdonar, gritar solo de alegria, besarse mil veces al d¡a, re¡r a carcajada limpia.','663315308','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Joan','Torn‚','31/10/1996','joantorne@gmail.com','joantorne',1,'41.379898, 2.175593','Si el amor aprieta, no es tu talla.','638493029','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Juan','Carrascosa','08/11/1996','juancarrascosa@gmail.com','juancarrascosa',1,'41.379826, 2.175475','No puedes comenzar el siguiente cap¡tulo si sigues leyendo el anterior.','648392049','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Alba','L¢pez','04/12/1996','albalopez@gmail.com','albalopez',1,'41.379826, 2.175475','No te lo creas tanto. El 99% de tu belleza procede de mi manera de mirarte.','685940321','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Jon','Vallhonrat','14/06/1995','jonvallhonrat@gmail.com','jonvallhonrat',1,'41.375461, 2.188566','El coraz¢n deber¡a tener las opciones: Eliminar contacto, borrar historial y solucionar problema.','685748394','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Denis','Ca¤o','22/03/1995','deniscano@gmail.com','deniscano',1,'41.375461, 2.188566','Nada ni nadie te hace sentir como tu no te sientes.','638294856','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Alfredo','Redondo','30/03/1995','alfredoredondo@gmail.com','alfredoredondo',1,'41.375461, 2.188566','Aquello en lo que te enfocas acaba siendo parte en tu vida.','658204958','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Ferran','Ma¤o','05/12/1995','ferranmano@gmail.com','ferranmano',0,'41.375461, 2.188566','Comparte la m£sica que suena dentro de ti.','624938423','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Andrea','Flores','27/03/1995','andreaflores@gmail.com','andreaflores',2,'41.375461, 2.188566','Aquello en lo que te enfocas acaba siendo parte en tu vida','649302945','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Daniel','Arrastia','01/03/1994','danielarrastia@gmail.com','danielarrastia',1,'41.395630, 2.152736','Frecuentemente el peso que necesitas perder no esta en tu cuerpo.','649392930','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Paula','Artig¢s','13/03/1994','paulaartigos@gmail.com','paulaartigos',1,'41.395630, 2.152736','Nac¡ para aprender y saberlo me mantiene humildemente feliz y eternamente asombrada.','648578392','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Andrea','Arrabel','16/11/1994','andreaarrabel@gmail.com','andreaarrabel',2,'41.395630, 2.152736',' Live for today, plan for tomorrow, party tonight (Drake).','619385768','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Sara','Aznar','22/09/1994','saraaznar@gmail.com','saraaznar',0,'41.395630, 2.152736','El tiempo es largo, pero la vida es corta (Steve Wonder).','639284857','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Caterina','Ballv‚','25/07/1993','caterinaballve@gmail.com','cterinaballve',0,'41.395630, 2.152736','My excuse is that I?m young (DJ Khaled).','647173087','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Nerina','Carneros','14/02/1992','nerinacarneros@gmail.com','nerinacarneros',1,'41.395974, 2.151622','¨A qui‚n le importa lo que yo haga? ¨A qui‚n le importa lo que yo diga?','693029586','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Olga','Navarro','16/06/1992','olganavarro@gmail.com','olganavarro',2,'41.395974, 2.151622','Y aunque suene cursi, nunca dejes que digan que no eres hermoso','849302956','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Patricia','Serra','28/10/1992','patriciaserra@gmail.com','patriciaserra',0,'41.395974, 2.151622','No me des los buenos d¡as, ¨ok? dame tus mejores noches. ','640293927','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Carlota','Casellas','18/12/1991','carlotacasellas@gmail.com','carlotacasellas',0,'41.395974, 2.151622','El pasado puede doler, pero, tal como yo lo veo, puedes o huir de ‚l o aprender?','664938266','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Izhar','Menda','19/11/1991','izharmenda@gmail.com','izharmenda',0,'41.395974, 2.151622','Si quieres un amigo, c¢mprate un perro','639402966','M');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Mireia','Escobar','16/06/1990','mireiaescobar@gmail.com','mireiaescobar',1,'41.395974, 2.151622','Yo no soy mala, es que me han dibujado as¡','648392039','F');
INSERT INTO public.users ("name", surname, birthday, email, "password", interested, "location", description, mobilephone, genre) VALUES('Marc','Esquirolazo','19/09/1990','marcesquirolazo@gmail.com','marcesquirolazo',0,'41.395974, 2.151622','Hoy es el primer d¡a del resto de mi vida. Odio tinder.','639485069','M');

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

drop table likes

CREATE TABLE likes (
    id      	bigserial,
    userOrigin	bigint,
    userLike	bigint
);
insert into likes (userOrigin, userLike) values (2, 5);
insert into likes (userOrigin, userLike) values (2, 7);
insert into likes (userOrigin, userLike) values (2, 8);
insert into likes (userOrigin, userLike) values (2, 11);
insert into likes (userOrigin, userLike) values (2, 13);
insert into likes (userOrigin, userLike) values (2, 35);
insert into likes (userOrigin, userLike) values (12, 36);

select u.id , u."name" , u.surname
from users u left join likes l on u.id = l.userLike 
where l.userLike is null and u.id != 2 and 
		u.genre = 'M' and u.interested = 1;

select u.id , u."name" , u.surname
from users u 
where u.id != 2 and u.genre = 'M' and u.interested = 1

select *
from likes l 

select *
from users u 
where u.genre ='F' and u.interested =0

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
		);