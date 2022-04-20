-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: tenis
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `ediciones`
--

DROP TABLE IF EXISTS `ediciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ediciones` (
  `Anualidad` int NOT NULL,
  `Torneo` int NOT NULL,
  `Ganadora` int NOT NULL,
  PRIMARY KEY (`Anualidad`,`Torneo`),
  KEY `FK_Edi_Tou_idx` (`Torneo`),
  KEY `FK_Edi_Pla_idx` (`Ganadora`),
  CONSTRAINT `FK_Edi_Pla` FOREIGN KEY (`Ganadora`) REFERENCES `jugadoras` (`idJugadora`),
  CONSTRAINT `FK_Edi_Tou` FOREIGN KEY (`Torneo`) REFERENCES `torneos` (`idTorneo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ediciones`
--

LOCK TABLES `ediciones` WRITE;
/*!40000 ALTER TABLE `ediciones` DISABLE KEYS */;
INSERT INTO `ediciones` VALUES (2015,11,2),(2022,15,2),(2017,9,3),(2021,9,3),(2021,11,16),(2017,11,17),(2016,11,21),(2019,15,21),(2020,10,21),(2020,11,21),(2018,10,24),(2017,10,25),(2020,15,25),(2021,15,27),(2022,10,27),(2021,10,29),(2015,9,30),(2019,10,30),(2019,9,31),(2018,11,32),(2019,11,32),(2016,10,34);
/*!40000 ALTER TABLE `ediciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-20 23:52:02
