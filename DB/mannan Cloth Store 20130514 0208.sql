-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.27


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema shop
--

CREATE DATABASE IF NOT EXISTS shop;
USE shop;

--
-- Definition of table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
CREATE TABLE `accounts` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `bankname` varchar(45) NOT NULL,
  `accountnum` varchar(45) NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `accounts`
--

/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;


--
-- Definition of table `banking`
--

DROP TABLE IF EXISTS `banking`;
CREATE TABLE `banking` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `bankname` varchar(25) NOT NULL,
  `acnum` varchar(25) NOT NULL,
  `catagory` varchar(15) NOT NULL,
  `type` varchar(15) NOT NULL,
  `amount` double NOT NULL,
  `subject` varchar(45) NOT NULL,
  `issuedby` varchar(25) NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `banking`
--

/*!40000 ALTER TABLE `banking` DISABLE KEYS */;
/*!40000 ALTER TABLE `banking` ENABLE KEYS */;


--
-- Definition of table `challan`
--

DROP TABLE IF EXISTS `challan`;
CREATE TABLE `challan` (
  `serial` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `party` varchar(15) NOT NULL,
  `tno` varchar(10) DEFAULT NULL,
  `weight` varchar(10) DEFAULT NULL,
  `amount` double NOT NULL DEFAULT '0',
  `carriage` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `challan`
--

/*!40000 ALTER TABLE `challan` DISABLE KEYS */;
/*!40000 ALTER TABLE `challan` ENABLE KEYS */;


--
-- Definition of table `expenses`
--

DROP TABLE IF EXISTS `expenses`;
CREATE TABLE `expenses` (
  `serial` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `expensetype` varchar(25) NOT NULL,
  `amount` double NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `expenses`
--

/*!40000 ALTER TABLE `expenses` DISABLE KEYS */;
/*!40000 ALTER TABLE `expenses` ENABLE KEYS */;


--
-- Definition of table `gatepass`
--

DROP TABLE IF EXISTS `gatepass`;
CREATE TABLE `gatepass` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `subject` varchar(45) NOT NULL,
  `amount` double NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gatepass`
--

/*!40000 ALTER TABLE `gatepass` DISABLE KEYS */;
/*!40000 ALTER TABLE `gatepass` ENABLE KEYS */;


--
-- Definition of table `ledger`
--

DROP TABLE IF EXISTS `ledger`;
CREATE TABLE `ledger` (
  `accountname` varchar(20) NOT NULL,
  `amount` double NOT NULL,
  `date` date NOT NULL,
  `Serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Serial`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ledger`
--

/*!40000 ALTER TABLE `ledger` DISABLE KEYS */;
/*!40000 ALTER TABLE `ledger` ENABLE KEYS */;


--
-- Definition of table `loan`
--

DROP TABLE IF EXISTS `loan`;
CREATE TABLE `loan` (
  `emname` varchar(25) NOT NULL,
  `contact` double NOT NULL,
  `lstpaid` double NOT NULL,
  `due` double NOT NULL,
  `lstpaydate` date DEFAULT NULL,
  `idnum` int(10) unsigned NOT NULL,
  `perday` double NOT NULL,
  `attendance` int(2) unsigned zerofill NOT NULL DEFAULT '00',
  `lastattend` date DEFAULT NULL,
  `tillnow` double unsigned zerofill DEFAULT NULL,
  PRIMARY KEY (`idnum`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `loan`
--

/*!40000 ALTER TABLE `loan` DISABLE KEYS */;
/*!40000 ALTER TABLE `loan` ENABLE KEYS */;


--
-- Definition of table `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE `log` (
  `userid` varchar(25) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `password` varchar(25) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `usrtype` varchar(10) NOT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `log`
--

/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` (`userid`,`password`,`usrtype`) VALUES 
 (0x41446D6173756D,0x6D6373654144,'admin'),
 (0x6E72,0x323232,'admin'),
 (0x75736572,0x3132333435,'normal');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;


--
-- Definition of table `nameofbanks`
--

DROP TABLE IF EXISTS `nameofbanks`;
CREATE TABLE `nameofbanks` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `bankname` varchar(45) NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `nameofbanks`
--

/*!40000 ALTER TABLE `nameofbanks` DISABLE KEYS */;
/*!40000 ALTER TABLE `nameofbanks` ENABLE KEYS */;


--
-- Definition of table `parties`
--

DROP TABLE IF EXISTS `parties`;
CREATE TABLE `parties` (
  `name` varchar(25) CHARACTER SET utf8 COLLATE utf8_bin NOT NULL,
  `address` varchar(45) NOT NULL,
  `mobile` varchar(16) NOT NULL,
  `tel` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `parties`
--

/*!40000 ALTER TABLE `parties` DISABLE KEYS */;
/*!40000 ALTER TABLE `parties` ENABLE KEYS */;


--
-- Definition of table `partyledger`
--

DROP TABLE IF EXISTS `partyledger`;
CREATE TABLE `partyledger` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `partyname` varchar(25) NOT NULL,
  `address` varchar(45) NOT NULL,
  `date` date NOT NULL,
  `paytype` varchar(15) NOT NULL,
  `amount` double NOT NULL,
  `issuedby` varchar(25) NOT NULL,
  `mobile` varchar(15) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `partyledger`
--

/*!40000 ALTER TABLE `partyledger` DISABLE KEYS */;
/*!40000 ALTER TABLE `partyledger` ENABLE KEYS */;


--
-- Definition of table `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE `products` (
  `Model` varchar(20) NOT NULL,
  `Generic` varchar(20) NOT NULL,
  `Type` varchar(20) NOT NULL,
  `Details` varchar(100) DEFAULT 'No Information Available',
  `PurchasePrice` double NOT NULL,
  `Available` double NOT NULL,
  `SellingPrice` double NOT NULL,
  `purpcode` varchar(10) NOT NULL,
  PRIMARY KEY (`Model`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

/*!40000 ALTER TABLE `products` DISABLE KEYS */;
/*!40000 ALTER TABLE `products` ENABLE KEYS */;


--
-- Definition of table `profit`
--

DROP TABLE IF EXISTS `profit`;
CREATE TABLE `profit` (
  `Model` varchar(10) NOT NULL,
  `QSold` int(11) NOT NULL,
  `Date` date NOT NULL,
  `profit` double NOT NULL,
  `Serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Less` double NOT NULL DEFAULT '0',
  PRIMARY KEY (`Serial`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `profit`
--

/*!40000 ALTER TABLE `profit` DISABLE KEYS */;
/*!40000 ALTER TABLE `profit` ENABLE KEYS */;


--
-- Definition of table `purchased`
--

DROP TABLE IF EXISTS `purchased`;
CREATE TABLE `purchased` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `pid` varchar(15) NOT NULL,
  `gen` varchar(15) NOT NULL,
  `tp` varchar(15) NOT NULL,
  `quantity` int(10) unsigned NOT NULL,
  `unitprice` double NOT NULL,
  `amount` double NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `purchased`
--

/*!40000 ALTER TABLE `purchased` DISABLE KEYS */;
/*!40000 ALTER TABLE `purchased` ENABLE KEYS */;


--
-- Definition of table `salaryhistory`
--

DROP TABLE IF EXISTS `salaryhistory`;
CREATE TABLE `salaryhistory` (
  `idnum` int(10) unsigned NOT NULL,
  `amount` double NOT NULL,
  `date` date NOT NULL,
  `emname` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `salaryhistory`
--

/*!40000 ALTER TABLE `salaryhistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `salaryhistory` ENABLE KEYS */;


--
-- Definition of table `sold`
--

DROP TABLE IF EXISTS `sold`;
CREATE TABLE `sold` (
  `serial` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `quantity` int(10) unsigned NOT NULL,
  `amount` double NOT NULL,
  `pid` varchar(15) NOT NULL,
  `unitprice` double NOT NULL,
  `gen` varchar(15) NOT NULL,
  `tp` varchar(15) NOT NULL,
  PRIMARY KEY (`serial`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `sold`
--

/*!40000 ALTER TABLE `sold` DISABLE KEYS */;
/*!40000 ALTER TABLE `sold` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
