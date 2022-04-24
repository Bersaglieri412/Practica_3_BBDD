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
-- Table structure for table `jugadoras`
--

DROP TABLE IF EXISTS `jugadoras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugadoras` (
  `idJugadora` int NOT NULL AUTO_INCREMENT,
  `NombreJugadora` varchar(45) NOT NULL,
  `FechaNacimientoJugadora` date NOT NULL,
  `PuntosJugadora` int NOT NULL DEFAULT '0',
  `PaisJugadora` char(3) NOT NULL,
  PRIMARY KEY (`idJugadora`),
  UNIQUE KEY `PlayerName_UNIQUE` (`NombreJugadora`),
  KEY `FK_Pla_Cou_idx` (`PaisJugadora`),
  CONSTRAINT `FK_Pla_Cou` FOREIGN KEY (`PaisJugadora`) REFERENCES `paises` (`idPais`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=41 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugadoras`
--

LOCK TABLES `jugadoras` WRITE;
/*!40000 ALTER TABLE `jugadoras` DISABLE KEYS */;
INSERT INTO `jugadoras` VALUES (2,'Lucía López','2004-01-22',535,'ESP'),(3,'Andrea García','2004-01-22',1215,'ESP'),(4,'Every Fernández','2022-04-12',920,'ING'),(16,'Audrey Lemon','2003-06-15',610,'AUS'),(17,'Alebarda Moiccina','1995-01-18',1120,'ITA'),(21,'Selena Guillerma','2000-06-22',1150,'ESP'),(24,'Margaret Tatcher','1925-10-13',675,'ING'),(25,'Pamela Voskova','1997-09-18',550,'RUS'),(26,'Pamela andersen','2003-06-11',430,'ALE'),(27,'Lima wallace','1989-10-25',605,'MEX'),(28,'Octaviana Valiniskova','2022-04-18',535,'RUM'),(29,'Oriola Anderson','2022-04-18',660,'CAN'),(30,'Jesusa Manuel','2022-04-18',665,'MEX'),(31,'Medina Ubombo','2022-04-20',735,'EMI'),(32,'Francisca Melnibumba','2022-04-20',1085,'UGA'),(33,'Pedra Bascugnet','2022-04-20',780,'FRA'),(34,'Vladyana Savalenka','2022-04-20',620,'RUS'),(35,'Sofia Yockovick','2022-04-22',165,'SER'),(38,'Miguela Ramos','1983-10-14',145,'GUA'),(39,'Shakayawea','2022-04-23',0,'EST'),(40,'Paula Badosa Gilbert','2022-04-23',100,'ESP');
/*!40000 ALTER TABLE `jugadoras` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-24 14:07:08
