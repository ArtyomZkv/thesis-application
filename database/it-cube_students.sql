-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: it-cube
-- ------------------------------------------------------
-- Server version	8.0.23

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `ID` char(36) NOT NULL,
  `name` varchar(100) NOT NULL,
  `dateofbirth` date NOT NULL,
  `parentsname` varchar(100) DEFAULT NULL,
  `district` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `study` varchar(100) DEFAULT NULL,
  `phone` varchar(45) NOT NULL,
  `email` varchar(100) NOT NULL,
  `date` date NOT NULL,
  `groupid` char(36) NOT NULL,
  `directionid` char(36) NOT NULL,
  `parentsphone` char(12) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `id_UNIQUE` (`ID`),
  KEY `directionid_idx` (`directionid`),
  KEY `globalgrpID_idx` (`groupid`),
  CONSTRAINT `directionid` FOREIGN KEY (`directionid`) REFERENCES `directions` (`iddirection`),
  CONSTRAINT `globalgrpID` FOREIGN KEY (`groupid`) REFERENCES `globalgroup` (`globalgrpID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('750599b3-9121-433c-810e-914fc5042a15','Крайнов Виктор Олегович','2002-11-19','Крайнова Ольга Викторовна','Перевозкй район','Перевоз',NULL,'89874325234','fospho@mail.ru','2017-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be9','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89033123124'),('750599b3-9121-433c-810e-914fc5042a20','Зуйков Артём Андреевич','2001-05-14','Зуйкова Ольга Александровна','Кстовский район','Кстово',NULL,'89200600504','why@gmail.com','2018-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be9','0139be9e-f32a-473b-b940-5513af09a706','89200600503'),('750599b3-9121-433c-810e-914fc5042a21','Шаляхин Никита Алексеевич','2001-04-19','Шаляхина Анна Владимировна','Княгиниский район','Княгинино',NULL,'89202575703','snake@mail.ru','2017-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be9','0139be9e-f32a-473b-b940-5513af09a707','89200134123'),('750599b3-9121-433c-810e-914fc5042a22','Никифоров Сергей Петрович','2001-09-18','Никифорова Анна Алексеевна','Нижегородский район','Нижний Новгород',NULL,'89033124453','still@mail.ru','2018-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89033157593'),('750599b3-9121-433c-810e-914fc5042a23','Засухин Кирилл Григорьевич','2002-11-19','Засухина Елена Анатольевна','Перевозский район','Перевоз',NULL,'89200653154','here@gmail.com','2019-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89123123714'),('750599b3-9121-433c-810e-914fc5042a24','Кириешкин Чипсик Сухарькович','2001-09-09','Кириешкина Нина Петрвона','Перевозский район','Дубское',NULL,'89874323513','just@mail.ru','2019-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89200123513'),('750599b3-9121-433c-810e-914fc5042a25','Волков Сергей Михайлович','2001-03-11','Волкова Анна Петровна','Кстовский район','Кстово',NULL,'89200123152','to@mal.ru','2020-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89035324742'),('750599b3-9121-433c-810e-914fc5042a26','Никитин Михаил Викторович','2000-01-18','Никитина Ирина Викторовна','Княгининский район','Княгинино',NULL,'89042347763','suffer@mail.ru','2020-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89035324713'),('750599b3-9121-433c-810e-914fc5042a27','Кузьмин Ворон Андреевич','2001-09-22','Кузьмина Синица Алексеевна','Кстовский район','Кстово',NULL,'89123124155','kuzya@gmail.com','2019-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89033157234'),('750599b3-9121-433c-810e-914fc5042a28','Пупочкин Вова Петрович','1999-04-15','Пупокина Ольга Анатольевна','Нижегородский район','Нижинй Новгород',NULL,'89123514123','pupa@mail.ru','2017-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be9','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89033157112'),('750599b3-9121-433c-810e-914fc5042a29','Ноутбук Асер Эльдорадович','2001-11-11','Коврикова Олеся Ивановна','Кстовский район','Кстово',NULL,'89200023432','acer@mail.ru','2019-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89123126457'),('750599b3-9121-433c-810e-914fc5042a31','Паленов Дмитрий Валентинович','2002-03-28','Паленова Ольга Владимировна','Кстовский район','Кстово',NULL,'89123151343','fedora@mail.ru','2019-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be8','7aa8b03c-28bc-49b8-b36a-99180cb7cca8','89123121245'),('750599b3-9121-433c-810e-914fc5042a32','Семёнов Виктор Петрович','2001-04-19','Семёнова Виктория Петровная','Княгининский район','Княгинино',NULL,'89200234723','Semenoff_13@mail.ru','2020-09-01','1c4a4e22-77a4-47bc-9f91-25777bf08be9','0139be9e-f32a-473b-b940-5513af09a707','89212736414'),('750599b3-9121-433c-810e-914fc5042a33','Дедсеков Никита Андреевич','2002-08-29','Дедсекова Ольга Викторовна','Нижегородский район','Нижний Новгород',NULL,'89123761243','Nikitosick125@gmail.com','2021-01-14','1c4a4e22-77a4-47bc-9f91-25777bf08be9','0139be9e-f32a-473b-b940-5513af09a707','89123126413');
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-05 21:33:56
