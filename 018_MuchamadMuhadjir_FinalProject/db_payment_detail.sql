/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 10.4.18-MariaDB : Database - db_payment_detail
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_payment_detail` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_payment_detail`;

/*Table structure for table `__efmigrationshistory` */

DROP TABLE IF EXISTS `__efmigrationshistory`;

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `__efmigrationshistory` */

insert  into `__efmigrationshistory`(`MigrationId`,`ProductVersion`) values 
('20211022004446_Inital Add','5.0.11');

/*Table structure for table `tb_payment_detail` */

DROP TABLE IF EXISTS `tb_payment_detail`;

CREATE TABLE `tb_payment_detail` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `cardOwnerName` longtext DEFAULT NULL,
  `cardNumber` longtext DEFAULT NULL,
  `expirationDate` datetime(6) NOT NULL,
  `securityCode` longtext DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

/*Data for the table `tb_payment_detail` */

insert  into `tb_payment_detail`(`Id`,`cardOwnerName`,`cardNumber`,`expirationDate`,`securityCode`) values 
(1,'Muchamad Muhadjir','3456 8721 0987 6732','2022-12-22 00:00:00.000000','jhs12jhds7g2jbhgvj21vjvapo9'),
(2,'Firdaus Alam Hudi','1367 7621 4579 8931','2021-08-30 00:00:00.000000','io9dsjhg23rnxhgyd2vd7b8gf28g'),
(4,'Widad Muhammad','1248 9817 1295 1246','2023-10-12 00:00:00.000000','2u1ue827hjhasnasdo2382rmfjf'),
(5,'Irfan Agus','1309 0138 9827 8592','2025-06-28 00:00:00.000000','opdsajio23opsamsbahgv2324kb'),
(6,'Arma Ardhan','9284 3561 6587 6734','2025-10-28 10:10:12.000000','kju12jfas7g2jbhgvj21i87apo9');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
