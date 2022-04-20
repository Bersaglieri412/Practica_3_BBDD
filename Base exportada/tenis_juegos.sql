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
-- Table structure for table `juegos`
--

DROP TABLE IF EXISTS `juegos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `juegos` (
  `Jugadora` int NOT NULL,
  `Partido` int NOT NULL,
  `Set1` int NOT NULL,
  `Set2` int NOT NULL,
  `Set3` int DEFAULT NULL,
  PRIMARY KEY (`Jugadora`,`Partido`),
  KEY `FK_Pla_Mat_idx` (`Partido`),
  CONSTRAINT `FK_Pla_Mat` FOREIGN KEY (`Partido`) REFERENCES `partidos` (`idPartido`),
  CONSTRAINT `FK_Pla_Pla` FOREIGN KEY (`Jugadora`) REFERENCES `jugadoras` (`idJugadora`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `juegos`
--

LOCK TABLES `juegos` WRITE;
/*!40000 ALTER TABLE `juegos` DISABLE KEYS */;
INSERT INTO `juegos` VALUES (2,512,6,6,-1),(2,516,1,3,-1),(2,540,3,6,6),(2,544,3,6,6),(2,545,2,6,3),(2,548,1,3,-1),(2,570,6,6,-1),(2,571,6,1,6),(2,573,1,6,6),(2,598,6,2,6),(2,599,6,1,6),(2,601,2,2,-1),(2,605,0,6,1),(2,618,0,3,-1),(2,626,3,6,6),(2,627,6,6,-1),(2,629,6,1,6),(2,635,6,2,6),(2,636,2,3,-1),(2,646,2,6,0),(3,520,6,6,-1),(3,523,6,2,6),(3,524,6,6,-1),(3,526,6,2,2),(3,533,6,6,-1),(3,537,6,2,6),(3,538,6,6,-1),(3,546,6,2,3),(3,553,3,0,-1),(3,561,6,6,-1),(3,565,2,2,-1),(3,575,6,3,6),(3,579,6,6,-1),(3,580,0,2,-1),(3,581,6,6,-1),(3,585,0,6,3),(3,589,6,1,6),(3,593,2,0,-1),(3,595,6,6,-1),(3,599,0,6,1),(3,633,6,6,-1),(3,637,6,1,1),(3,640,2,1,-1),(3,653,3,2,-1),(4,527,0,2,-1),(4,567,1,0,-1),(4,574,6,6,-1),(4,578,3,6,1),(4,602,0,2,-1),(4,616,6,1,6),(4,620,6,0,0),(4,632,6,1,6),(4,636,6,6,-1),(4,638,2,6,2),(4,639,6,1,0),(4,648,6,1,3),(16,511,6,6,-1),(16,515,6,6,-1),(16,517,1,1,-1),(16,519,6,0,6),(16,523,3,6,0),(16,534,2,6,0),(16,541,6,2,6),(16,544,6,1,1),(16,588,3,6,1),(16,630,6,6,-1),(16,633,3,3,-1),(16,653,6,6,-1),(16,657,6,3,6),(16,659,6,1,6),(17,518,2,6,3),(17,549,3,0,-1),(17,554,1,6,6),(17,558,1,1,-1),(17,563,6,3,0),(17,584,0,6,6),(17,585,6,3,6),(17,587,6,6,-1),(17,616,1,6,2),(17,625,0,6,6),(17,628,0,6,6),(17,629,3,6,2),(17,649,6,6,-1),(17,650,2,3,-1),(21,514,6,0,6),(21,515,0,1,-1),(21,532,0,6,6),(21,536,3,6,0),(21,542,6,0,3),(21,547,6,6,-1),(21,551,1,6,6),(21,552,6,6,-1),(21,555,0,6,6),(21,558,6,6,-1),(21,559,3,6,3),(21,562,6,6,-1),(21,565,6,6,-1),(21,566,0,2,-1),(21,568,6,1,3),(21,577,6,0,6),(21,578,6,2,6),(21,580,6,6,-1),(21,596,1,2,-1),(21,603,3,6,6),(21,607,6,6,-1),(21,608,6,6,-1),(21,630,1,2,-1),(21,632,3,6,1),(21,639,3,6,6),(21,643,6,6,-1),(21,645,1,6,6),(24,519,1,6,1),(24,548,6,6,-1),(24,551,6,3,1),(24,561,1,2,-1),(24,577,0,6,2),(24,617,6,3,3),(24,623,6,6,-1),(24,627,2,1,-1),(24,642,6,6,-1),(24,643,0,3,-1),(24,656,6,0,6),(24,657,3,6,0),(25,521,1,3,-1),(25,534,6,2,6),(25,537,2,6,3),(25,562,3,3,-1),(25,570,2,1,-1),(25,603,6,2,1),(25,609,6,2,6),(25,613,6,6,-1),(25,615,6,6,-1),(25,619,6,2,0),(25,634,6,6,-1),(25,637,3,6,6),(25,638,6,2,6),(25,648,0,6,6),(25,651,3,6,2),(25,655,6,6,-1),(25,658,2,6,3),(26,525,3,6,2),(26,535,0,0,-1),(26,542,1,6,6),(26,543,1,6,3),(26,556,3,6,6),(26,557,6,2,1),(26,584,6,1,2),(26,597,2,6,3),(26,605,6,1,6),(26,606,3,6,2),(26,611,3,6,6),(26,614,3,6,6),(26,615,2,1,-1),(26,624,3,1,-1),(26,640,6,6,-1),(26,644,6,3,2),(26,649,3,0,-1),(26,654,6,6,-1),(26,658,6,2,6),(26,659,1,6,3),(27,526,2,6,6),(27,530,1,6,0),(27,533,3,0,-1),(27,546,0,6,6),(27,550,6,1,2),(27,563,1,6,6),(27,564,6,6,-1),(27,566,6,6,-1),(27,590,0,3,-1),(27,612,6,2,1),(27,617,2,6,6),(27,621,6,6,-1),(27,622,6,6,-1),(27,635,2,6,0),(27,647,6,1,1),(28,513,6,0,0),(28,528,6,1,6),(28,529,2,6,6),(28,531,3,3,-1),(28,541,3,6,2),(28,568,3,6,6),(28,572,2,2,-1),(28,583,2,0,-1),(28,590,6,6,-1),(28,593,6,6,-1),(28,594,0,2,-1),(28,595,2,2,-1),(28,610,6,6,-1),(28,614,6,0,1),(28,647,2,6,6),(28,651,6,1,6),(28,652,3,1,-1),(29,511,2,2,-1),(29,520,0,2,-1),(29,553,6,6,-1),(29,557,2,6,6),(29,559,6,0,6),(29,569,2,6,0),(29,583,6,6,-1),(29,586,2,3,-1),(29,612,2,6,6),(29,613,2,1,-1),(29,619,2,6,6),(29,620,2,6,6),(29,622,2,1,-1),(29,626,6,3,1),(29,641,6,6,-1),(29,644,2,6,6),(29,645,6,1,1),(29,655,2,3,-1),(30,513,2,6,6),(30,516,6,6,-1),(30,517,6,6,-1),(30,518,6,0,6),(30,522,3,6,6),(30,524,2,0,-1),(30,525,6,2,6),(30,529,6,0,3),(30,532,6,2,3),(30,539,6,6,-1),(30,543,6,3,6),(30,545,6,3,6),(30,560,2,0,-1),(30,567,6,6,-1),(30,571,0,6,1),(30,574,1,1,-1),(30,582,3,6,3),(30,588,6,1,6),(30,592,0,0,-1),(30,610,2,0,-1),(30,623,0,2,-1),(30,634,0,0,-1),(30,641,0,2,-1),(30,654,3,0,-1),(31,512,3,1,-1),(31,527,6,6,-1),(31,530,6,2,6),(31,531,6,6,-1),(31,540,6,2,0),(31,554,6,1,3),(31,576,6,6,-1),(31,579,2,3,-1),(31,591,2,0,-1),(31,598,2,6,2),(31,604,2,6,1),(31,611,6,2,0),(31,624,6,6,-1),(31,628,6,2,3),(31,642,1,3,-1),(31,656,0,6,1),(32,514,1,6,2),(32,521,6,6,-1),(32,522,6,1,0),(32,528,3,6,1),(32,535,6,6,-1),(32,536,6,0,6),(32,538,0,2,-1),(32,549,6,6,-1),(32,550,1,6,6),(32,552,0,1,-1),(32,556,6,3,1),(32,560,6,6,-1),(32,564,0,1,-1),(32,576,2,1,-1),(32,582,6,2,6),(32,586,6,6,-1),(32,587,0,3,-1),(32,591,6,6,-1),(32,592,6,6,-1),(32,594,6,6,-1),(32,597,6,3,6),(32,600,6,3,6),(32,601,6,6,-1),(32,602,6,6,-1),(32,606,6,1,6),(32,608,1,2,-1),(32,609,1,6,2),(33,539,0,2,-1),(33,547,0,2,-1),(33,555,6,0,1),(33,569,6,0,6),(33,572,6,6,-1),(33,573,6,1,3),(33,575,0,6,2),(33,581,1,3,-1),(33,589,1,6,2),(33,596,6,6,-1),(33,600,3,6,1),(33,604,6,2,6),(33,607,3,1,-1),(33,618,6,6,-1),(33,621,0,3,-1),(33,625,6,3,0),(34,646,6,2,6),(34,650,6,6,-1),(34,652,6,6,-1);
/*!40000 ALTER TABLE `juegos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-20 23:52:01
