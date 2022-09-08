create table Medikamente
(
  id int primary key not null identity(1,1),
  name varchar(250) not null,
  preis float not null,
  Menge int not null,
  bild image not null



)

select * from Medikamente