-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.16 - MySQL Community Server (GPL)
-- Server OS:                    Win32
-- HeidiSQL Version:             9.5.0.5196
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for member
CREATE DATABASE IF NOT EXISTS `member` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `member`;

-- Dumping structure for table member.user
CREATE TABLE IF NOT EXISTS `user` (
  `Member_id` varchar(20) NOT NULL,
  `Nama_lengkap` varchar(50) DEFAULT NULL,
  `Jenis_kelamin` enum('Pria','Wanita') DEFAULT NULL,
  `Tanggal_lahir` date DEFAULT NULL,
  `Telepon` varchar(15) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  `Alamat` varchar(50) DEFAULT NULL,
  `Kota` varchar(50) DEFAULT NULL,
  `Kode_pos` char(10) DEFAULT NULL,
  `Catatan` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Member_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table member.user: ~0 rows (approximately)
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
/*!40000 ALTER TABLE `user` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
