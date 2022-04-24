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
-- Table structure for table `torneos`
--

DROP TABLE IF EXISTS `torneos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `torneos` (
  `idTorneo` int NOT NULL AUTO_INCREMENT,
  `NombreTorneo` varchar(45) NOT NULL,
  `CiudadTorneo` varchar(45) NOT NULL,
  `PaisTorneo` char(3) DEFAULT NULL,
  PRIMARY KEY (`idTorneo`),
  UNIQUE KEY `TournamentName_UNIQUE` (`NombreTorneo`),
  KEY `PaisTorneo_idx` (`PaisTorneo`),
  CONSTRAINT `PaisTorneo` FOREIGN KEY (`PaisTorneo`) REFERENCES `paises` (`idPais`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `torneos`
--

LOCK TABLES `torneos` WRITE;
/*!40000 ALTER TABLE `torneos` DISABLE KEYS */;
INSERT INTO `torneos` VALUES (9,'Wimblendon','Londres','ING'),(10,'Open Australia','Sydney','AUS'),(11,'Conde de Godó','Madrid','ESP'),(15,'Roland Garros','Paris','FRA'),(16,'Andalucía Open','Marbella','ESP'),(17,'Melbourne summer set','Melbourne','AUS'),(18,'Shenzen Open','Shenzen','CHI'),(19,'St Petersburg Ladies Trophy','San Petersburgo','RUS'),(20,'Toyota Thailand Open','Hua Hin','TAI'),(21,'Abierto Mexicano Telcel','Acapulco','MEX'),(22,'Hungarian Ladies Open','Budapest','HUN'),(23,'Qatar Total Open','Doha','QAT'),(24,'BNP Paribas Open','Indian Wells','EST'),(25,'J&T Banka Prague Open','Praga','REP'),(26,'Mutua Madrid Open','Madrid','ESP');
/*!40000 ALTER TABLE `torneos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-24 21:21:32
