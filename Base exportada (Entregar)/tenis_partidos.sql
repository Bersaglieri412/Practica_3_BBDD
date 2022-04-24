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
-- Table structure for table `partidos`
--

DROP TABLE IF EXISTS `partidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partidos` (
  `idPartido` int NOT NULL AUTO_INCREMENT,
  `Anualidad` int NOT NULL,
  `Torneo` int NOT NULL,
  `Ganadora` int NOT NULL,
  `Ronda` char(1) NOT NULL,
  PRIMARY KEY (`idPartido`),
  KEY `FK_Mat_Edi_idx` (`Anualidad`,`Torneo`),
  KEY `FK_Mat_Play_idx` (`Ganadora`),
  CONSTRAINT `FK_Mat_Edi` FOREIGN KEY (`Anualidad`, `Torneo`) REFERENCES `ediciones` (`Anualidad`, `Torneo`),
  CONSTRAINT `FK_Mat_Play` FOREIGN KEY (`Ganadora`) REFERENCES `jugadoras` (`idJugadora`)
) ENGINE=InnoDB AUTO_INCREMENT=1262 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partidos`
--

LOCK TABLES `partidos` WRITE;
/*!40000 ALTER TABLE `partidos` DISABLE KEYS */;
INSERT INTO `partidos` VALUES (1052,2015,9,33,'c'),(1053,2015,9,2,'c'),(1054,2015,9,30,'c'),(1055,2015,9,4,'c'),(1056,2015,9,33,'s'),(1057,2015,9,30,'s'),(1058,2015,9,30,'f'),(1059,2016,9,30,'c'),(1060,2016,9,4,'c'),(1061,2016,9,38,'c'),(1062,2016,9,25,'c'),(1063,2016,9,30,'s'),(1064,2016,9,4,'s'),(1065,2016,9,4,'f'),(1066,2016,10,16,'c'),(1067,2016,10,33,'c'),(1068,2016,10,2,'c'),(1069,2016,10,29,'c'),(1070,2016,10,29,'s'),(1071,2016,10,33,'s'),(1072,2016,10,33,'f'),(1073,2017,10,31,'c'),(1074,2017,10,17,'c'),(1075,2017,10,35,'c'),(1076,2017,10,38,'c'),(1077,2017,10,31,'s'),(1078,2017,10,35,'s'),(1079,2017,10,31,'f'),(1080,2017,11,26,'c'),(1081,2017,11,31,'c'),(1082,2017,11,2,'c'),(1083,2017,11,16,'c'),(1084,2017,11,26,'s'),(1085,2017,11,2,'s'),(1086,2017,11,26,'f'),(1087,2018,11,4,'c'),(1088,2018,11,31,'c'),(1089,2018,11,16,'c'),(1090,2018,11,35,'c'),(1091,2018,11,35,'s'),(1092,2018,11,16,'s'),(1093,2018,11,35,'f'),(1094,2018,15,31,'c'),(1095,2018,15,26,'c'),(1096,2018,15,25,'c'),(1097,2018,15,38,'c'),(1098,2018,15,38,'s'),(1099,2018,15,25,'s'),(1100,2018,15,25,'f'),(1101,2019,15,35,'c'),(1102,2019,15,33,'c'),(1103,2019,15,16,'c'),(1104,2019,15,29,'c'),(1105,2019,15,29,'s'),(1106,2019,15,16,'s'),(1107,2019,15,16,'f'),(1108,2019,16,33,'c'),(1109,2019,16,3,'c'),(1110,2019,16,25,'c'),(1111,2019,16,2,'c'),(1112,2019,16,33,'s'),(1113,2019,16,25,'s'),(1114,2019,16,33,'f'),(1115,2021,16,32,'c'),(1116,2021,16,35,'c'),(1117,2021,16,38,'c'),(1118,2021,16,26,'c'),(1119,2021,16,26,'s'),(1120,2021,16,38,'s'),(1121,2021,16,26,'f'),(1122,2021,17,26,'c'),(1123,2021,17,27,'c'),(1124,2021,17,32,'c'),(1125,2021,17,29,'c'),(1126,2021,17,29,'s'),(1127,2021,17,32,'s'),(1128,2021,17,32,'f'),(1129,2022,17,24,'c'),(1130,2022,17,28,'c'),(1131,2022,17,17,'c'),(1132,2022,17,21,'c'),(1133,2022,17,21,'s'),(1134,2022,17,17,'s'),(1135,2022,17,17,'f'),(1136,2022,18,33,'c'),(1137,2022,18,35,'c'),(1138,2022,18,16,'c'),(1139,2022,18,4,'c'),(1140,2022,18,4,'s'),(1141,2022,18,16,'s'),(1142,2022,18,4,'f'),(1143,2021,18,40,'c'),(1144,2021,18,30,'c'),(1145,2021,18,38,'c'),(1146,2021,18,32,'c'),(1147,2021,18,32,'s'),(1148,2021,18,30,'s'),(1149,2021,18,32,'f'),(1150,2021,19,35,'c'),(1151,2021,19,32,'c'),(1152,2021,19,29,'c'),(1153,2021,19,31,'c'),(1154,2021,19,31,'s'),(1155,2021,19,32,'s'),(1156,2021,19,32,'f'),(1157,2019,19,32,'c'),(1158,2019,19,33,'c'),(1159,2019,19,3,'c'),(1160,2019,19,38,'c'),(1161,2019,19,32,'s'),(1162,2019,19,33,'s'),(1163,2019,19,32,'f'),(1164,2019,20,33,'c'),(1165,2019,20,4,'c'),(1166,2019,20,21,'c'),(1167,2019,20,17,'c'),(1168,2019,20,33,'s'),(1169,2019,20,4,'s'),(1170,2019,20,4,'f'),(1171,2018,20,32,'c'),(1172,2018,20,4,'c'),(1173,2018,20,26,'c'),(1174,2018,20,30,'c'),(1175,2018,20,32,'s'),(1176,2018,20,26,'s'),(1177,2018,20,26,'f'),(1178,2018,21,32,'c'),(1179,2018,21,27,'c'),(1180,2018,21,26,'c'),(1181,2018,21,31,'c'),(1182,2018,21,31,'s'),(1183,2018,21,27,'s'),(1184,2018,21,27,'f'),(1185,2017,21,26,'c'),(1186,2017,21,35,'c'),(1187,2017,21,30,'c'),(1188,2017,21,16,'c'),(1189,2017,21,16,'s'),(1190,2017,21,30,'s'),(1191,2017,21,30,'f'),(1192,2017,22,33,'c'),(1193,2017,22,30,'c'),(1194,2017,22,17,'c'),(1195,2017,22,41,'c'),(1196,2017,22,33,'s'),(1197,2017,22,30,'s'),(1198,2017,22,30,'f'),(1199,2016,22,28,'c'),(1200,2016,22,30,'c'),(1201,2016,22,41,'c'),(1202,2016,22,27,'c'),(1203,2016,22,28,'s'),(1204,2016,22,41,'s'),(1205,2016,22,41,'f'),(1206,2016,23,39,'c'),(1207,2016,23,4,'c'),(1208,2016,23,21,'c'),(1209,2016,23,25,'c'),(1210,2016,23,39,'s'),(1211,2016,23,4,'s'),(1212,2016,23,39,'f'),(1213,2015,23,21,'c'),(1214,2015,23,30,'c'),(1215,2015,23,4,'c'),(1216,2015,23,26,'c'),(1217,2015,23,26,'s'),(1218,2015,23,4,'s'),(1219,2015,23,26,'f'),(1220,2015,24,40,'c'),(1221,2015,24,24,'c'),(1222,2015,24,28,'c'),(1223,2015,24,39,'c'),(1224,2015,24,39,'s'),(1225,2015,24,24,'s'),(1226,2015,24,39,'f'),(1227,2014,24,32,'c'),(1228,2014,24,33,'c'),(1229,2014,24,25,'c'),(1230,2014,24,17,'c'),(1231,2014,24,17,'s'),(1232,2014,24,25,'s'),(1233,2014,24,17,'f'),(1234,2014,25,32,'c'),(1235,2014,25,4,'c'),(1236,2014,25,27,'c'),(1237,2014,25,25,'c'),(1238,2014,25,25,'s'),(1239,2014,25,27,'s'),(1240,2014,25,27,'f'),(1241,2015,25,30,'c'),(1242,2015,25,24,'c'),(1243,2015,25,2,'c'),(1244,2015,25,25,'c'),(1245,2015,25,25,'s'),(1246,2015,25,2,'s'),(1247,2015,25,2,'f'),(1248,2015,26,28,'c'),(1249,2015,26,24,'c'),(1250,2015,26,26,'c'),(1251,2015,26,31,'c'),(1252,2015,26,31,'s'),(1253,2015,26,26,'s'),(1254,2015,26,31,'f'),(1255,2016,26,32,'c'),(1256,2016,26,30,'c'),(1257,2016,26,4,'c'),(1258,2016,26,27,'c'),(1259,2016,26,32,'s'),(1260,2016,26,30,'s'),(1261,2016,26,32,'f');
/*!40000 ALTER TABLE `partidos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-24 21:21:33
