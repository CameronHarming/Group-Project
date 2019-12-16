-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: users
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `userstable`
--

DROP TABLE IF EXISTS `userstable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userstable` (
  `username` varchar(50) CHARACTER SET latin2 DEFAULT NULL,
  `password` varchar(255) CHARACTER SET latin2 NOT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `first_name` varchar(45) CHARACTER SET latin2 NOT NULL,
  `last_name` varchar(45) CHARACTER SET latin2 NOT NULL,
  `email` varchar(45) CHARACTER SET latin2 NOT NULL,
  `First_time_Login` tinyint(4) DEFAULT NULL,
  `user_id` int(11) NOT NULL,
  `title` varchar(45) NOT NULL,
  PRIMARY KEY (`email`),
  UNIQUE KEY `email_UNIQUE` (`email`) /*!80000 INVISIBLE */,
  UNIQUE KEY `user_id_UNIQUE` (`user_id`) /*!80000 INVISIBLE */,
  UNIQUE KEY `username` (`username`),
  KEY `user_id` (`user_id`) /*!80000 INVISIBLE */
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userstable`
--

LOCK TABLES `userstable` WRITE;
/*!40000 ALTER TABLE `userstable` DISABLE KEYS */;
INSERT INTO `userstable` VALUES ('','','2019-12-14 23:20:34','','','',NULL,2362,''),('Charming','Password1!','2019-12-14 20:02:49','Cameron','Harming','Cameronharming@gmail.com',NULL,1,'Rap'),('MusicBlaster','Password1!','2019-12-15 01:00:34','Cameron','Harming','Cameronharming@hotmail.com',NULL,4213,'Techno Beats'),('Username','Password','2019-12-14 19:58:56','First Name','Last Name','Email',NULL,0,'Pop'),('BasicUser','Password','2019-12-15 13:18:00','Basic','User','email@email.com',NULL,3221,'Country Hits'),('JD','Donthackplz','2019-12-14 23:22:35','John','Doe','JohnDoe@hotmail.com',NULL,5389,'EDM');
/*!40000 ALTER TABLE `userstable` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-15 22:53:31
