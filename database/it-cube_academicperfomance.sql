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
-- Table structure for table `academicperfomance`
--

DROP TABLE IF EXISTS `academicperfomance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `academicperfomance` (
  `idacademicperfomance` char(36) NOT NULL,
  `Idstudent` char(36) NOT NULL,
  `attendance` varchar(2) DEFAULT NULL,
  `lessontopic` varchar(100) DEFAULT NULL,
  `date` char(20) NOT NULL,
  `idproject` char(36) NOT NULL,
  PRIMARY KEY (`idacademicperfomance`),
  UNIQUE KEY `idacademicperfomance_UNIQUE` (`idacademicperfomance`),
  KEY `idstudents_idx` (`Idstudent`),
  KEY `Idproject_idx` (`idproject`),
  CONSTRAINT `Idproject` FOREIGN KEY (`idproject`) REFERENCES `projects` (`idproject`),
  CONSTRAINT `Idstudents` FOREIGN KEY (`Idstudent`) REFERENCES `students` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `academicperfomance`
--

LOCK TABLES `academicperfomance` WRITE;
/*!40000 ALTER TABLE `academicperfomance` DISABLE KEYS */;
INSERT INTO `academicperfomance` VALUES ('0d475efd-256f-4561-a74d-752fd6951c52','750599b3-9121-433c-810e-914fc5042a27','+',NULL,'01-09-2021','68cab61b-1a1e-4d6c-8f93-fdc80298ef12'),('13314444-4907-4f3d-a0f6-781ccedc9e92','750599b3-9121-433c-810e-914fc5042a27','+',NULL,'03-09-2021','68cab61b-1a1e-4d6c-8f93-fdc80298ef12'),('4e73cb2f-459f-44f3-900c-04676e2d61b3','750599b3-9121-433c-810e-914fc5042a27','+',NULL,'04-09-2021','68cab61b-1a1e-4d6c-8f93-fdc80298ef12'),('63387fc1-f433-4053-a6eb-066a525cc9bb','750599b3-9121-433c-810e-914fc5042a29','н',NULL,'04-09-2021','d5d46fbf-b676-472d-af60-d49ab643a1d6'),('66cd0cfc-9da0-4ee8-9258-b204a0c6cf21','750599b3-9121-433c-810e-914fc5042a29','+',NULL,'02-09-2021','d5d46fbf-b676-472d-af60-d49ab643a1d6'),('7602030a-1e32-47da-baa2-b7f60ea209d8','750599b3-9121-433c-810e-914fc5042a29','+',NULL,'01-09-2021','d5d46fbf-b676-472d-af60-d49ab643a1d6'),('7de1e272-73ed-49cb-9f71-515f576f17c9','750599b3-9121-433c-810e-914fc5042a27','+',NULL,'02-09-2021','68cab61b-1a1e-4d6c-8f93-fdc80298ef12'),('f4030177-4e7b-4897-a287-e0a596c17304','750599b3-9121-433c-810e-914fc5042a31','н',NULL,'02-09-2021','4d87a111-0bf4-4478-8160-fdf226713cfa'),('fbe70c47-41c5-4f34-bb62-03ed04efebb8','750599b3-9121-433c-810e-914fc5042a31','+',NULL,'04-09-2021','4d87a111-0bf4-4478-8160-fdf226713cfa');
/*!40000 ALTER TABLE `academicperfomance` ENABLE KEYS */;
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
