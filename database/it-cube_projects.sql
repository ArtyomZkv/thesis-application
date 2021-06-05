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
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `projects` (
  `idproject` char(36) NOT NULL,
  `projectname` varchar(100) NOT NULL,
  `idstudent` char(36) NOT NULL,
  PRIMARY KEY (`idproject`),
  UNIQUE KEY `idproject_UNIQUE` (`idproject`),
  KEY `idstudent` (`idstudent`),
  CONSTRAINT `idstudent` FOREIGN KEY (`idstudent`) REFERENCES `students` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects`
--

LOCK TABLES `projects` WRITE;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
INSERT INTO `projects` VALUES ('0c4ce7cd-08dc-4d31-abff-8764a0ea63ea','Разработка компьютреной игры','750599b3-9121-433c-810e-914fc5042a21'),('2d9e9957-24b9-4f42-b007-149391df0c6e','Разработка чепухи','750599b3-9121-433c-810e-914fc5042a20'),('4d87a111-0bf4-4478-8160-fdf226713cfa','Разработка iPhone','750599b3-9121-433c-810e-914fc5042a31'),('5c9c7c2c-3707-45ba-b3f2-310f1246f07b','Белеберда','750599b3-9121-433c-810e-914fc5042a20'),('6650c0b2-03c4-4cbc-a766-bf177fbb4dc0','Разработка чего-нибудь','750599b3-9121-433c-810e-914fc5042a21'),('68cab61b-1a1e-4d6c-8f93-fdc80298ef12','Проект','750599b3-9121-433c-810e-914fc5042a27'),('9819b241-76cf-4f39-9355-96fd743ed4b4','Разработка дрона на Android','750599b3-9121-433c-810e-914fc5042a22'),('be73858e-dcfc-4686-9278-65d1e3290a8m','Разработка браузера','750599b3-9121-433c-810e-914fc5042a20'),('be73858e-dcfc-4686-9278-65d1e3290a8q','Разработка браузера','750599b3-9121-433c-810e-914fc5042a20'),('d53302e5-da44-42bd-bf4d-959a9c8849e4','Разработка модели мобильного телефона','750599b3-9121-433c-810e-914fc5042a23'),('d5d46fbf-b676-472d-af60-d49ab643a1d6','Разработка браузера для Android','750599b3-9121-433c-810e-914fc5042a29'),('e5e25f83-7d78-40c4-88c1-8780481eafd1','Разработка мобильного приложения','750599b3-9121-433c-810e-914fc5042a25');
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;
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
