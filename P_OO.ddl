-- *********************************************
-- * SQL MySQL generation                      
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.2              
-- * Generator date: Sep 14 2021              
-- * Generation date: Mon Jan 24 10:52:28 2022 
-- * LUN file: F:\01-Projets\P_OO Smart Thesaurus\MCD-MLD\MCD-MLD-Database.lun 
-- * Schema: MLD db file/1 
-- ********************************************* 


-- Tables Section
-- _____________ 

create table t_file (
     idFile char(1) not null,
     filName varchar(255) not null,
     filType varchar(5) not null,
     filPath char(260) not null,
     idIndex char(1),
     constraint ID_t_file_ID primary key (idFile));

create table t_index (
     idIndex char(1) not null,
     indDateIndexation varchar(10) not null,
     indNumberIndex int not null,
     constraint ID_t_index_ID primary key (idIndex));


-- Constraints Section
-- ___________________ 

alter table t_file add constraint FKR_FK
     foreign key (idIndex)
     references t_index (idIndex);

-- Not implemented
-- alter table t_index add constraint ID_t_index_CHK
--     check(exists(select * from t_file
--                  where t_file.idIndex = idIndex)); 


-- Index Section
-- _____________ 

create unique index ID_t_file_IND
     on t_file (idFile);

create index FKR_IND
     on t_file (idIndex);

create unique index ID_t_index_IND
     on t_index (idIndex);

