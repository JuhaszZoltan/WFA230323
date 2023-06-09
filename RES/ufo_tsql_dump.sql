-- CREATE DATABASE hasznaltufo;
-- USE hasznaltufo;

CREATE TABLE tipus(
    tipusid INT PRIMARY KEY IDENTITY,
    nev VARCHAR(45),
    alapar INT);

CREATE TABLE vevo(
    vevoid INT PRIMARY KEY IDENTITY,
    nev VARCHAR(45),
    cim VARCHAR(45),
    megbizhato BIT);

CREATE TABLE ufo(
    ufoid INT PRIMARY KEY IDENTITY,
    tipus INT FOREIGN KEY REFERENCES tipus(tipusid),
    lopott BIT,
    serules INT,
    foglalo INT NULL FOREIGN KEY REFERENCES vevo(vevoid));

INSERT INTO tipus VALUES
('Nautiloid', 1300),
('Pleiadian', 900),
('Roswell', 420),
('Merlin', 1100),
('TIE fighter', 2400),
('Death Star', 100000),
('YT-1300F', 5040),
('Enterprise', 6600),
('Archer', 4000),
('Discovery', 3900);

INSERT INTO vevo VALUES
('Arryne Marte','Crystalline Sea',0),
('Paulie Tiner','Axuz Military Base',0),
('Jamy Carte','Floating City',1),
('Henry Barner','Radioactive City',1),
('Chomy Sonez','Crystalline Sea',0),
('Lary Grobins','Frozen Moon',0),
('Johny Wardez','Luminous City',1),
('Braldy Simmurph','Cale Crystal Mines',0),
('Roge Warte','Frozen Moon',0),
('Stery Murphy','Floating City',0);

INSERT INTO ufo VALUES
(1, 0, 33, 3),
(1, 1, 14, null),
(10, 1, 42, null),
(8, 0, 67, null),
(9, 0, 97, 1),
(7, 0, 10, null),
(5, 0, 11, 5),
(6, 0, 7, null),
(4, 1, 33, null),
(4, 0, 31, null),
(4, 0, 44, 7),
(7, 0, 50, 10),
(7, 1, 9, null),
(1, 0, 25, 3),
(6, 1, 25, 4),
(3, 0, 73, null),
(1, 1, 61, null),
(2, 0, 11, null),
(10, 1, 20, null),
(3, 1, 27, 2),
(10, 1, 29, null),
(8, 0, 90, null),
(9, 0, 81, null),
(10, 0, 51, 6),
(3, 1, 54, 8),
(5, 0, 25, null),
(5, 0, 10, 8),
(6, 1, 21, 4),
(8, 1, 30, 3);