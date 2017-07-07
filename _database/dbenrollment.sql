-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 09, 2014 at 05:37 AM
-- Server version: 5.6.12-log
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbenrollment`
--
CREATE DATABASE IF NOT EXISTS `dbenrollment` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `dbenrollment`;

-- --------------------------------------------------------

--
-- Table structure for table `aboutus`
--

CREATE TABLE IF NOT EXISTS `aboutus` (
  `AboutusID` int(11) NOT NULL AUTO_INCREMENT,
  `History` varchar(500) NOT NULL,
  `Historypic` varchar(100) NOT NULL,
  `Vision` varchar(500) NOT NULL,
  `Mission` varchar(500) NOT NULL,
  `OrganizationPic` varchar(100) NOT NULL,
  PRIMARY KEY (`AboutusID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `alumni`
--

CREATE TABLE IF NOT EXISTS `alumni` (
  `alumni_id` int(11) NOT NULL AUTO_INCREMENT,
  `alumni_category` varchar(20) NOT NULL,
  `alumni_name` varchar(30) NOT NULL,
  `alumni_position` varchar(15) NOT NULL,
  `alumni_description` varchar(250) NOT NULL,
  `alumni_image` mediumblob NOT NULL,
  `alumni_activity` varchar(250) NOT NULL,
  `alumni_content` varchar(2500) NOT NULL,
  `alumni_speech` varchar(2500) NOT NULL,
  PRIMARY KEY (`alumni_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `alumni`
--

-- --------------------------------------------------------

--
-- Table structure for table `faculties`
--

CREATE TABLE IF NOT EXISTS `faculties` (
  `FacultyId` int(5) NOT NULL,
  `FacultyName` varchar(30) NOT NULL,
  `FacultyPosition` varchar(30) NOT NULL,
  `FacultyImage` mediumblob NOT NULL,
  `FacultyCategory` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faculties`
--

-- --------------------------------------------------------

--
-- Table structure for table `faq`
--

CREATE TABLE IF NOT EXISTS `faq` (
  `faqid` varchar(11) NOT NULL,
  `faqquestion` varchar(80) NOT NULL,
  `faqanswer` varchar(80) NOT NULL,
  PRIMARY KEY (`faqid`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faq`
--

INSERT INTO `faq` (`faqid`, `faqquestion`, `faqanswer`) VALUES
('faq1', 'Do you allow reservation?', 'Yes.'),
('faq2', 'When is your enrollment period?', 'It usually starts at last week of March and end at last week of June.'),
('faq3', 'Do you accept Roman Catholic?', 'Yes.'),
('faq4', 'Do you allow refund if the student is already enrolled?', 'Yes but only before classes start.'),
('faq5', 'Is it possible for an instructor to drop a student from a class?', 'Yes, possible.'),
('faq6', 'How much is the entrance exam? And when it is conducted?', 'P150 pesos. It could be on the spot or scheduled '),
('faq7', 'Can I view my account online? ', 'Yes just go to Myportal and login.');

-- --------------------------------------------------------

--
-- Table structure for table `newsevents`
--

CREATE TABLE IF NOT EXISTS `newsevents` (
  `newsid` int(11) NOT NULL AUTO_INCREMENT,
  `newstitle` varchar(100) NOT NULL,
  `newscategory` varchar(10) NOT NULL,
  `newscontent` varchar(2500) NOT NULL,
  `newsimage` mediumblob NOT NULL,
  `newsdate` datetime NOT NULL,
  PRIMARY KEY (`newsid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `newsevents`
--
-- --------------------------------------------------------

--
-- Table structure for table `others`
--

CREATE TABLE IF NOT EXISTS `others` (
  `backsubjectlimit` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `others`
--

INSERT INTO `others` (`backsubjectlimit`) VALUES
(3);

-- --------------------------------------------------------

--
-- Table structure for table `schoolinfo`
--

CREATE TABLE IF NOT EXISTS `schoolinfo` (
  `contactno` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `schoolinfo`
--

INSERT INTO `schoolinfo` (`contactno`) VALUES
('(043)757-0163');

-- --------------------------------------------------------

--
-- Table structure for table `tblaccounts`
--

CREATE TABLE IF NOT EXISTS `tblaccounts` (
  `username` varchar(30) NOT NULL,
  `userpass` varchar(30) NOT NULL,
  `usertype` varchar(25) NOT NULL,
  `name` varchar(20) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblaccounts`
--

INSERT INTO `tblaccounts` (`username`, `userpass`, `usertype`, `name`) VALUES
('MGanoria', 'MAdvent', 'Admin', 'Marvin Ganoria');

-- --------------------------------------------------------

--
-- Table structure for table `tblcontacts`
--

CREATE TABLE IF NOT EXISTS `tblcontacts` (
  `Name` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `vMessages` varchar(250) NOT NULL,
  `isread` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcontacts`
--

INSERT INTO `tblcontacts` (`Name`, `Email`, `vMessages`, `isread`) VALUES
('', 'tq_daryl@yahoo.com', 'bbbbb', 'Read');

-- --------------------------------------------------------

--
-- Table structure for table `tbldiscounts`
--

CREATE TABLE IF NOT EXISTS `tbldiscounts` (
  `discountid` varchar(30) NOT NULL,
  `dis_name` varchar(20) NOT NULL,
  `dis_rate` float NOT NULL,
  `yeargrade` varchar(30) NOT NULL,
  `DiscountType` varchar(30) NOT NULL,
  `DiscountBy` varchar(30) NOT NULL,
  PRIMARY KEY (`discountid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbldiscounts`
--

INSERT INTO `tbldiscounts` (`discountid`, `dis_name`, `dis_rate`, `yeargrade`, `DiscountType`, `DiscountBy`) VALUES
('Grade School Child Discount', 'Child Discount', 5, 'Grade School ', 'Default Discount', 'Percent'),
('High SchoolAdventist', 'Adventist', 25, 'High School', 'Default Discount', 'Percent'),
('Grade School Adventist', 'Adventist', 25, 'Grade School ', 'Default Discount', 'Percent'),
('High SchoolChild Discount', 'Child Discount', 5, 'High School', 'Default Discount', 'Percent'),
('High SchoolValedictorian', 'Valedictorian', 100, 'High School', 'Default Discount', 'Percent'),
('High SchoolSalutatorian', 'Salutatorian', 50, 'High School', 'Default Discount', 'Percent'),
('Grade School Cash', 'Cash', 5, 'Grade School ', 'Default Discount', 'Percent'),
('High SchoolCash', 'Cash', 5, 'High School', 'Default Discount', 'Percent');

-- --------------------------------------------------------

--
-- Table structure for table `tblenrollmentperiod`
--

CREATE TABLE IF NOT EXISTS `tblenrollmentperiod` (
  `enrollmentperiodid` varchar(20) NOT NULL,
  `enrollmentstart` date DEFAULT NULL,
  `enrollmentend` date DEFAULT NULL,
  `schoolyearid` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`enrollmentperiodid`),
  KEY `schoolyearid` (`schoolyearid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblenrollmentperiod`
--

INSERT INTO `tblenrollmentperiod` (`enrollmentperiodid`, `enrollmentstart`, `enrollmentend`, `schoolyearid`) VALUES
('2014', '2014-03-03', '2014-06-02', '2014'),
('2015', '2015-03-03', '2015-06-02', '2015');

-- --------------------------------------------------------

--
-- Table structure for table `tblgradings`
--

CREATE TABLE IF NOT EXISTS `tblgradings` (
  `gradingperiodid` varchar(6) NOT NULL,
  `gradingperiod` date DEFAULT NULL,
  `schoolyearid` varchar(5) DEFAULT NULL,
  `gradingname` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`gradingperiodid`),
  KEY `schoolyearid` (`schoolyearid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblgradings`
--

INSERT INTO `tblgradings` (`gradingperiodid`, `gradingperiod`, `schoolyearid`, `gradingname`) VALUES
('02014', '2014-08-02', '2014', '1st Grading'),
('12014', '2014-10-02', '2014', '2nd Grading'),
('22014', '2014-12-02', '2014', '3rd Grading'),
('32014', '2015-02-02', '2014', '4th Grading'),
('42014', '2015-03-02', '2014', '5th Grading'),
('02015', '2015-08-02', '2015', '1st Grading'),
('12015', '2015-10-02', '2015', '2nd Grading'),
('22015', '2015-12-02', '2015', '3rd Grading'),
('32015', '2016-02-02', '2015', '4th Grading'),
('42015', '2016-03-02', '2015', '5th Grading');

-- --------------------------------------------------------

--
-- Table structure for table `tblrefunds`
--

CREATE TABLE IF NOT EXISTS `tblrefunds` (
  `refundid` varchar(10) DEFAULT NULL,
  `refunddays` int(11) NOT NULL,
  `refund` float NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblrefunds`
--

INSERT INTO `tblrefunds` (`refundid`, `refunddays`, `refund`) VALUES
('Day7', 7, 10);

-- --------------------------------------------------------

--
-- Table structure for table `tblrequirements`
--

CREATE TABLE IF NOT EXISTS `tblrequirements` (
  `requirementkey` varchar(20) NOT NULL,
  `student_type` varchar(20) NOT NULL,
  `req_name` varchar(30) NOT NULL,
  `req_desc` varchar(50) DEFAULT NULL,
  `yeargrade` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`requirementkey`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblrequirements`
--

INSERT INTO `tblrequirements` (`requirementkey`, `student_type`, `req_name`, `req_desc`, `yeargrade`) VALUES
('NewNSO ', 'New', 'NSO ', 'Birth Certificate', 'Grade School '),
('OldNSO ', 'Old', 'NSO ', 'Birth Certificate', 'Grade School '),
('ForeignNSO ', 'Foreign', 'NSO ', 'Birth Certificate', 'Grade School '),
('New2x2 Picture ', 'New', '2x2 Picture', '', 'High School'),
('Transferee2x2 Pictur', 'Transferee', '2x2 Picture', '', 'High School'),
('Foreign2x2 Picture ', 'Foreign', '2x2 Picture', '', 'High School');

-- --------------------------------------------------------

--
-- Table structure for table `tblrooms`
--

CREATE TABLE IF NOT EXISTS `tblrooms` (
  `roomno` varchar(15) NOT NULL,
  `room_name` varchar(20) DEFAULT NULL,
  `room_type` varchar(15) DEFAULT NULL,
  `room_building` varchar(20) DEFAULT NULL,
  `room_floor` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`roomno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblrooms`
--

INSERT INTO `tblrooms` (`roomno`, `room_name`, `room_type`, `room_building`, `room_floor`) VALUES
('1', 'RM1', '1', 'Lecture', '1'),
('2', 'RM2', '1', 'Lecture', '1'),
('3', 'RM3', '1', 'Lecture', '1'),
('4', 'RM4', '1', 'Lecture', '1'),
('TLE', 'RMTLE', '1', 'Laboratory', '1');

-- --------------------------------------------------------

--
-- Table structure for table `tblschoolyear`
--

CREATE TABLE IF NOT EXISTS `tblschoolyear` (
  `schoolyearid` varchar(5) NOT NULL,
  `schoolyearstart` date DEFAULT NULL,
  `schoolyearend` date DEFAULT NULL,
  `schoolyeartype` varchar(7) DEFAULT NULL,
  PRIMARY KEY (`schoolyearid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblschoolyear`
--

INSERT INTO `tblschoolyear` (`schoolyearid`, `schoolyearstart`, `schoolyearend`, `schoolyeartype`) VALUES
('2014', '2014-06-02', '2015-03-02', 'Regular'),
('2015', '2015-06-02', '2016-03-02', 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `tblspecializations`
--

CREATE TABLE IF NOT EXISTS `tblspecializations` (
  `specialization_id` varchar(40) NOT NULL,
  `tea_specialization` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`specialization_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentaccounts`
--

CREATE TABLE IF NOT EXISTS `tblstudentaccounts` (
  `username` varchar(30) NOT NULL DEFAULT '',
  `studentid` varchar(30) DEFAULT NULL,
  `userpass` varchar(30) NOT NULL,
  PRIMARY KEY (`username`),
  KEY `studentid` (`studentid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentaccounts`
--

INSERT INTO `tblstudentaccounts` (`username`, `studentid`, `userpass`) VALUES
('DimayugaAnne', '2014-002', '12345678'),
('VillafuerteCherrie', '2015-0013', 'qwertyuiop'),
('2015-0016', '2015-0016', 'TiquioWilfredo'),
('2015-0017', '2015-0017', 'MagpantayZaldy'),
('2015-0018', '2015-0018', 'SalvadorAquino');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentdiscounts`
--

CREATE TABLE IF NOT EXISTS `tblstudentdiscounts` (
  `studentdiscount` varchar(15) DEFAULT NULL,
  `studentdiscountrate` float DEFAULT NULL,
  `studentid` varchar(30) DEFAULT NULL,
  KEY `studentid` (`studentid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentdiscounts`
--

INSERT INTO `tblstudentdiscounts` (`studentdiscount`, `studentdiscountrate`, `studentid`) VALUES
('Adventist', 50, '2014-001'),
('Adventist', 50, '2014-002'),
('Adventist', 50, '2014-003'),
('Adventist', 50, '2015-0002'),
('Adventist', 25, '2015-0003'),
('Cash', 5, '2015-0004'),
('Valedictorian', 100, '2015-0004'),
('Adventist', 25, '2015-0009'),
('Adventist', 25, '2015-0010'),
('Adventist', 25, '2015-0011'),
('Salutatorian', 50, '2015-0012'),
('Salutatorian', 50, '2015-0013'),
('Adventist', 25, '2015-0016');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentrequirements`
--

CREATE TABLE IF NOT EXISTS `tblstudentrequirements` (
  `studentschoolyear` varchar(30) DEFAULT NULL,
  `studentrequirements` varchar(20) DEFAULT NULL,
  `studentid` varchar(30) DEFAULT NULL,
  `requirementcleared` varchar(10) DEFAULT NULL,
  KEY `studentid` (`studentid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentrequirements`
--

INSERT INTO `tblstudentrequirements` (`studentschoolyear`, `studentrequirements`, `studentid`, `requirementcleared`) VALUES
('20142014-003', 'NSO ', '2014-003', 'To Follow'),
('20152015-0001', 'NSO ', '2015-0001', 'To Follow'),
('20152015-0002', 'NSO ', '2015-0002', 'To Follow'),
('20152015-0003', 'NSO ', '2015-0003', 'To Follow'),
('20152015-0017', '2x2 Picture', '2015-0017', 'Cleared'),
('20152015-0018', '2x2 Picture', '2015-0018', 'Cleared');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE IF NOT EXISTS `tblstudents` (
  `studentid` varchar(30) NOT NULL,
  `st_lname` varchar(20) NOT NULL,
  `st_fname` varchar(20) NOT NULL,
  `st_mname` varchar(20) NOT NULL,
  `st_type` varchar(20) NOT NULL,
  `st_bdate` date NOT NULL,
  `st_gender` varchar(15) NOT NULL,
  `st_religion` varchar(30) NOT NULL,
  `st_address` varchar(50) NOT NULL,
  `st_contactno` bigint(11) NOT NULL,
  `fa_name` varchar(20) NOT NULL,
  `fa_contactno` bigint(11) DEFAULT NULL,
  `fa_occupation` varchar(30) DEFAULT NULL,
  `mo_name` varchar(20) NOT NULL,
  `mo_contactno` bigint(11) DEFAULT NULL,
  `mo_occupation` varchar(30) DEFAULT NULL,
  `st_registration` date DEFAULT NULL,
  `gua_name` varchar(30) NOT NULL,
  `gua_relationship` varchar(30) NOT NULL,
  `gua_contactno` bigint(11) NOT NULL,
  PRIMARY KEY (`studentid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`studentid`, `st_lname`, `st_fname`, `st_mname`, `st_type`, `st_bdate`, `st_gender`, `st_religion`, `st_address`, `st_contactno`, `fa_name`, `fa_contactno`, `fa_occupation`, `mo_name`, `mo_contactno`, `mo_occupation`, `st_registration`, `gua_name`, `gua_relationship`, `gua_contactno`) VALUES
('2014-001', 'Tiquio', 'Daryl', 'Magpantay', 'New', '1994-09-17', 'Male', 'Adventist', 'Tambo', 9101010011, 'Willy', 9191919199, 'Driver', 'Baby', 9191919919, 'HouseWife', '2014-09-17', '', '', 0),
('2014-002', 'Dimayuga', 'Anne Lorraine', 'Guillarte', 'New', '1994-10-11', 'Female', 'Adventist', 'Bagoong Pook, Lipa City', 9191191911, 'Arnel', 1919191999, 'Businessman', 'Lalaine', 1191919191, 'aaaa', '2014-09-17', '', '', 0),
('2014-003', 'Gerriel', 'Silva', 'sds', 'New', '1994-09-21', 'Male', 'Adventist', 'asasasasas', 9129212121, 'sasa', 12121212121, 'asas', 'sasa', 21212121212, 'asasas', '2014-09-21', '', '', 0),
('2015-0001', 'Ferrancullo', 'Ricardo', 'Dela Cruz', 'New', '1992-09-24', 'Male', 'Other: Specify', 'Sabang, Lipa City', 9094484225, 'Ricardo', 9094484224, 'Piggery Manager', 'Felma', 9094484225, 'Housewife', '2014-09-24', '', 'Parents', 0),
('2015-0002', 'Fernando', 'John Kevin', 'Suarez', 'New', '1993-07-27', 'Male', 'Adventist', 'Bagongpook, Lipa City', 9212417253, 'Francisco', 2133712391, 'Famer', 'Erminda', 1273129, 'Housewife', '2014-09-30', '', '', 0),
('2015-0003', 'Bigol', 'Ian', 'John', 'New', '1994-09-30', 'Male', 'Adventist', 'Bagong Pook', 9111111111, 'Bigol', 9111111111, 'driver', 'Bigol', 9111111111, 'housewife', '2014-09-30', 'Ina', 'Yaya', 9111111111),
('2015-0004', 'Ilustre', 'Aldrich', 'P', 'Transferee', '1994-10-01', 'Male', 'Adventist', 'asas', 9999, 'asas', 99999, 'sasas', 'asas', 9999999, 'asas', '2014-10-01', '', '', 0),
('2015-0005', 'Oracion', 'Daisy', 'M', 'New', '1994-10-01', 'Female', 'Adventist', 'asas', 999, 'asas', 999999, 'asas', 'asas', 99999, 'asas', '2014-10-01', '', '', 0),
('2015-0006', 'Pangan', 'Jhonard', 'as', 'New', '1994-10-03', 'Male', 'Adventist', 'as', 999, 'sdsd', 9999999999, 'ds', 'sds', 999, 'sds', '2014-10-03', '', '', 0),
('2015-0007', 'Oracion', 'Reidon', 'M', 'New', '1997-10-03', 'Male', 'Adventist', 'assa', 9, 'asa', 999, 'as', 'as', 999, 'asa', '2014-10-03', '', '', 0),
('2015-0008', 'Calingasan', 'Rona', 'M', 'New', '1995-10-03', 'Female', 'Adventist', 'sass', 99, 'asa', 999, 'asas', 'asa', 999, 'asas', '2014-10-03', '', '', 0),
('2015-0009', 'qwerty', 'asas', 'asa', 'Transferee', '1994-10-07', 'Male', 'Adventist', 'asas', 99, 'asa', 99, 'asa', 'asas', 99, 'sas', '2014-10-07', '', '', 0),
('2015-0010', 'Toto', 'asa', 'sas', 'Transferee', '1994-10-07', 'Male', 'Adventist', 'asasa', 9999999999, 'sasas', 9999999999, 'sas', 'asas', 9999999999, 'asas', '2014-10-07', '', '', 0),
('2015-0011', 'Dimayuga', 'Ellaine', 'Guillarte', 'Transferee', '1992-10-07', 'Female', 'Adventist', 'wasdasdasd', 9999999999, 'fsasdasd', 9999999999, 'sdasd', 'sdasdas', 9999999999, 'sadasd', '2014-10-07', '', '', 0),
('2015-0012', 'Flores', 'Ramon', 'P', 'New', '1979-10-08', 'Male', 'Romantic Catholic', 'Taysan', 9999999999, 'Flores', 9999999999, 'Instructor', 'Flores', 9999999999, 'Instructor', '2014-10-08', '', '', 0),
('2015-0013', 'Villafuerte', 'Cherrie', 'F', 'New', '1990-10-08', 'Female', 'Roman Catholic', 'Lipa', 9999999999, 'Cherrie', 9999999999, 'Instructor', 'Cherrie', 9999999999, 'Instructor', '2014-10-08', '', '', 0),
('2015-0014', 'Beleno', 'Mariel', 'A', 'Transferee', '1995-10-08', 'Female', 'Romantic Catholic', 'Lipa', 9999999999, 'Mariel', 9999999999, 'Student', 'Mariel', 9999999999, 'Student', '2014-10-08', '', '', 0),
('2015-0015', 'Magpantay', 'Dominga', 'a', 'New', '1987-10-08', 'Female', 'Roman Catholic', 'Lipa', 0, 'Dominga', 9999999999, 'Housewife', 'Dominga', 9999999999, 'Housewife', '2014-10-08', '', '', 0),
('2015-0016', 'Tiquio', 'Wilfredo', 'M', 'New', '1990-10-08', 'Male', 'Roman Catholic', 'Lipa', 0, 'asa', 9999999999, 'asa', 'dsd', 9999999999, 'sdsd', '2014-10-08', '', '', 0),
('2015-0017', 'Magpantay', 'Zaldy', 'M', 'Transferee', '1991-10-08', 'Male', 'Roman Catholic', 'Lipa', 0, 'Zaldy', 909, 'as', 'sds', 909, 'dsds', '2014-10-08', '', '', 0),
('2015-0018', 'Salvador', 'Aquino', 'A', 'New', '1994-10-08', 'Male', 'Roman Catholic', 'Lipa', 0, 'Salvador', 9999999999, 'Driver', 'Salvador', 9999999999, 'Driver', '2014-10-08', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentsections`
--

CREATE TABLE IF NOT EXISTS `tblstudentsections` (
  `studentsection` varchar(30) NOT NULL,
  `studentschoolyear` varchar(30) DEFAULT NULL,
  `yearlevelsectioncode` varchar(40) NOT NULL,
  PRIMARY KEY (`studentsection`),
  KEY `studentschoolyear` (`studentschoolyear`),
  KEY `yearlevelsectioncode` (`yearlevelsectioncode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentsections`
--

INSERT INTO `tblstudentsections` (`studentsection`, `studentschoolyear`, `yearlevelsectioncode`) VALUES
('2014-0022014Grade IA', '20142014-002', 'Grade IA'),
('2014-0032014Grade IA', '20142014-003', 'Grade IA'),
('2015-00012015Grade IA', '20152015-0001', 'Grade IA'),
('2015-00032015Grade IA', '20152015-0003', 'Grade IA'),
('2015-00032015', '20152015-0003', ''),
('2015-00042015Year IIA', '20152015-0004', 'Year IIA'),
('2015-00052015Year IA', '20152015-0005', 'Year IA'),
('2015-00052015', '20152015-0005', ''),
('2015-00062015Year IA', '20152015-0006', 'Year IA'),
('2015-00072015Year IA', '20152015-0007', 'Year IA'),
('2015-00082015', '20152015-0008', ''),
('2015-00092015Year IIA', '20152015-0009', 'Year IIA'),
('2015-00102015Year IIA', '20152015-0010', 'Year IA'),
('2015-00112015Year IIA', '20152015-0011', ''),
('2015-00112015', '20152015-0011', ''),
('2015-00122015Year IA', '20152015-0012', 'Year IA'),
('2015-00132015Year IA', '20152015-0013', 'Year IIA'),
('2015-00142015Year IIA', '20152015-0014', 'Year IIA'),
('2015-00142015', '20152015-0014', 'Year IIA'),
('2015-00152015Year IA', '20152015-0015', 'Year IA'),
('2015-00152015', '20152015-0015', ''),
('2015-00172015Year IIA', '20152015-0017', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentsubjects`
--

CREATE TABLE IF NOT EXISTS `tblstudentsubjects` (
  `studentsubject` varchar(30) NOT NULL,
  `studentschoolyear` varchar(30) DEFAULT NULL,
  `yearlevelsectioncode` varchar(40) DEFAULT NULL,
  `subjectcode` varchar(30) DEFAULT NULL,
  `subjectstatus` varchar(20) NOT NULL,
  `gradingperiodid` varchar(6) NOT NULL,
  `grade` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`studentsubject`),
  KEY `yearlevelsectioncode` (`yearlevelsectioncode`),
  KEY `gradingperiodid` (`gradingperiodid`),
  KEY `studentschoolyear` (`studentschoolyear`),
  KEY `subjectcode` (`subjectcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentsubjects`
--

INSERT INTO `tblstudentsubjects` (`studentsubject`, `studentschoolyear`, `yearlevelsectioncode`, `subjectcode`, `subjectstatus`, `gradingperiodid`, `grade`) VALUES
('20142014-002EnglishGrade I0201', '20142014-002', '', 'EnglishGrade I', 'Taking', '02014', '75.00'),
('20142014-002FilipinoGrade I020', '20142014-002', '', 'FilipinoGrade I', 'Taking', '02014', '0.00'),
('20142014-002MathGrade I02014', '20142014-002', '', 'MathGrade I', 'Taking', '02014', '0.00'),
('20142014-002EnglishGrade I1201', '20142014-002', '', 'EnglishGrade I', 'Taking', '12014', '0.00'),
('20142014-002FilipinoGrade I120', '20142014-002', '', 'FilipinoGrade I', 'Taking', '12014', '0.00'),
('20142014-002MathGrade I12014', '20142014-002', '', 'MathGrade I', 'Taking', '12014', '0.00'),
('20142014-002EnglishGrade I2201', '20142014-002', '', 'EnglishGrade I', 'Taking', '22014', '0.00'),
('20142014-002FilipinoGrade I220', '20142014-002', '', 'FilipinoGrade I', 'Taking', '22014', '0.00'),
('20142014-002MathGrade I22014', '20142014-002', '', 'MathGrade I', 'Taking', '22014', '0.00'),
('20142014-002EnglishGrade I3201', '20142014-002', '', 'EnglishGrade I', 'Taking', '32014', '0.00'),
('20142014-002FilipinoGrade I320', '20142014-002', '', 'FilipinoGrade I', 'Taking', '32014', '0.00'),
('20142014-002MathGrade I32014', '20142014-002', '', 'MathGrade I', 'Taking', '32014', '0.00'),
('20142014-002EnglishGrade I4201', '20142014-002', '', 'EnglishGrade I', 'Taking', '42014', '0.00'),
('20142014-002FilipinoGrade I420', '20142014-002', '', 'FilipinoGrade I', 'Taking', '42014', '0.00'),
('20142014-002MathGrade I42014', '20142014-002', '', 'MathGrade I', 'Taking', '42014', '0.00'),
('20142014-003EnglishGrade I0201', '20142014-003', 'Grade IA', 'EnglishGrade I', 'Taking', '02014', '75.00'),
('20142014-003FilipinoGrade I020', '20142014-003', 'Grade IA', 'FilipinoGrade I', 'Taking', '02014', '0.00'),
('20142014-003MathGrade I02014', '20142014-003', 'Grade IA', 'MathGrade I', 'Taking', '02014', '0.00'),
('20142014-003EnglishGrade I1201', '20142014-003', 'Grade IA', 'EnglishGrade I', 'Taking', '12014', '0.00'),
('20142014-003FilipinoGrade I120', '20142014-003', 'Grade IA', 'FilipinoGrade I', 'Taking', '12014', '0.00'),
('20142014-003MathGrade I12014', '20142014-003', 'Grade IA', 'MathGrade I', 'Taking', '12014', '0.00'),
('20142014-003EnglishGrade I2201', '20142014-003', 'Grade IA', 'EnglishGrade I', 'Taking', '22014', '0.00'),
('20142014-003FilipinoGrade I220', '20142014-003', 'Grade IA', 'FilipinoGrade I', 'Taking', '22014', '0.00'),
('20142014-003MathGrade I22014', '20142014-003', 'Grade IA', 'MathGrade I', 'Taking', '22014', '0.00'),
('20142014-003EnglishGrade I3201', '20142014-003', 'Grade IA', 'EnglishGrade I', 'Taking', '32014', '0.00'),
('20142014-003FilipinoGrade I320', '20142014-003', 'Grade IA', 'FilipinoGrade I', 'Taking', '32014', '0.00'),
('20142014-003MathGrade I32014', '20142014-003', 'Grade IA', 'MathGrade I', 'Taking', '32014', '0.00'),
('20142014-003EnglishGrade I4201', '20142014-003', 'Grade IA', 'EnglishGrade I', 'Taking', '42014', '0.00'),
('20142014-003FilipinoGrade I420', '20142014-003', 'Grade IA', 'FilipinoGrade I', 'Taking', '42014', '0.00'),
('20142014-003MathGrade I42014', '20142014-003', 'Grade IA', 'MathGrade I', 'Taking', '42014', '0.00'),
('20152015-0001EnglishGrade I020', '20152015-0001', 'Grade IA', 'EnglishGrade I', 'Taking', '02015', '95.00'),
('20152015-0001FilipinoGrade I02', '20152015-0001', 'Grade IA', 'FilipinoGrade I', 'Taking', '02015', '90.00'),
('20152015-0001MathGrade I02015', '20152015-0001', 'Grade IA', 'MathGrade I', 'Taking', '02015', '85.00'),
('20152015-0001EnglishGrade I120', '20152015-0001', 'Grade IA', 'EnglishGrade I', 'Taking', '12015', '0.00'),
('20152015-0001FilipinoGrade I12', '20152015-0001', 'Grade IA', 'FilipinoGrade I', 'Taking', '12015', '0.00'),
('20152015-0001MathGrade I12015', '20152015-0001', 'Grade IA', 'MathGrade I', 'Taking', '12015', '0.00'),
('20152015-0001EnglishGrade I220', '20152015-0001', 'Grade IA', 'EnglishGrade I', 'Taking', '22015', '0.00'),
('20152015-0001FilipinoGrade I22', '20152015-0001', 'Grade IA', 'FilipinoGrade I', 'Taking', '22015', '0.00'),
('20152015-0001MathGrade I22015', '20152015-0001', 'Grade IA', 'MathGrade I', 'Taking', '22015', '0.00'),
('20152015-0001EnglishGrade I320', '20152015-0001', 'Grade IA', 'EnglishGrade I', 'Taking', '32015', '0.00'),
('20152015-0001FilipinoGrade I32', '20152015-0001', 'Grade IA', 'FilipinoGrade I', 'Taking', '32015', '0.00'),
('20152015-0001MathGrade I32015', '20152015-0001', 'Grade IA', 'MathGrade I', 'Taking', '32015', '0.00'),
('20152015-0001EnglishGrade I420', '20152015-0001', 'Grade IA', 'EnglishGrade I', 'Taking', '42015', '0.00'),
('20152015-0001FilipinoGrade I42', '20152015-0001', 'Grade IA', 'FilipinoGrade I', 'Taking', '42015', '0.00'),
('20152015-0001MathGrade I42015', '20152015-0001', 'Grade IA', 'MathGrade I', 'Taking', '42015', '0.00'),
('20152015-0003EnglishGrade I020', '20152015-0003', 'Grade IA', 'EnglishGrade I', 'Taking', '02015', '0.00'),
('20152015-0003FilipinoGrade I02', '20152015-0003', 'Grade IA', 'FilipinoGrade I', 'Taking', '02015', '0.00'),
('20152015-0003MathGrade I02015', '20152015-0003', 'Grade IA', 'MathGrade I', 'Taking', '02015', '0.00'),
('20152015-0003EnglishGrade I120', '20152015-0003', 'Grade IA', 'EnglishGrade I', 'Taking', '12015', '0.00'),
('20152015-0003FilipinoGrade I12', '20152015-0003', 'Grade IA', 'FilipinoGrade I', 'Taking', '12015', '0.00'),
('20152015-0003MathGrade I12015', '20152015-0003', 'Grade IA', 'MathGrade I', 'Taking', '12015', '0.00'),
('20152015-0003EnglishGrade I220', '20152015-0003', 'Grade IA', 'EnglishGrade I', 'Taking', '22015', '0.00'),
('20152015-0003FilipinoGrade I22', '20152015-0003', 'Grade IA', 'FilipinoGrade I', 'Taking', '22015', '0.00'),
('20152015-0003MathGrade I22015', '20152015-0003', 'Grade IA', 'MathGrade I', 'Taking', '22015', '0.00'),
('20152015-0003EnglishGrade I320', '20152015-0003', 'Grade IA', 'EnglishGrade I', 'Taking', '32015', '0.00'),
('20152015-0003FilipinoGrade I32', '20152015-0003', 'Grade IA', 'FilipinoGrade I', 'Taking', '32015', '0.00'),
('20152015-0003MathGrade I32015', '20152015-0003', 'Grade IA', 'MathGrade I', 'Taking', '32015', '0.00'),
('20152015-0003EnglishGrade I420', '20152015-0003', 'Grade IA', 'EnglishGrade I', 'Taking', '42015', '0.00'),
('20152015-0003FilipinoGrade I42', '20152015-0003', 'Grade IA', 'FilipinoGrade I', 'Taking', '42015', '0.00'),
('20152015-0003MathGrade I42015', '20152015-0003', 'Grade IA', 'MathGrade I', 'Taking', '42015', '0.00'),
('20152015-0004EnglishYear II020', '20152015-0004', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '90.00'),
('20152015-0004MathYear II02015', '20152015-0004', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0004EnglishYear II120', '20152015-0004', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '87.00'),
('20152015-0004MathYear II12015', '20152015-0004', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0004EnglishYear II220', '20152015-0004', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0004MathYear II22015', '20152015-0004', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0004EnglishYear II320', '20152015-0004', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0004MathYear II32015', '20152015-0004', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0004EnglishYear II420', '20152015-0004', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0004MathYear II42015', '20152015-0004', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0005EnglishYear I0201', '20152015-0005', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0005MathYear I02015', '20152015-0005', 'Year IA', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0005EnglishYear I1201', '20152015-0005', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0005MathYear I12015', '20152015-0005', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0005EnglishYear I2201', '20152015-0005', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0005MathYear I22015', '20152015-0005', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0005EnglishYear I3201', '20152015-0005', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0005MathYear I32015', '20152015-0005', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0005EnglishYear I4201', '20152015-0005', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0005MathYear I42015', '20152015-0005', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0006EnglishYear I0201', '20152015-0006', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0006MathYear I02015', '20152015-0006', 'Year IA', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0006EnglishYear I1201', '20152015-0006', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0006MathYear I12015', '20152015-0006', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0006EnglishYear I2201', '20152015-0006', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0006MathYear I22015', '20152015-0006', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0006EnglishYear I3201', '20152015-0006', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0006MathYear I32015', '20152015-0006', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0006EnglishYear I4201', '20152015-0006', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0006MathYear I42015', '20152015-0006', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0007EnglishYear I0201', '20152015-0007', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0007MathYear I02015', '20152015-0007', 'Year IA', 'MathYear I', 'Taking', '02015', '87.00'),
('20152015-0007EnglishYear I1201', '20152015-0007', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0007MathYear I12015', '20152015-0007', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0007EnglishYear I2201', '20152015-0007', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0007MathYear I22015', '20152015-0007', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0007EnglishYear I3201', '20152015-0007', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0007MathYear I32015', '20152015-0007', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0007EnglishYear I4201', '20152015-0007', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0007MathYear I42015', '20152015-0007', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0008EnglishYear I0201', '20152015-0008', 'Year I', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0008MathYear I02015', '20152015-0008', 'Year I', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0008EnglishYear I1201', '20152015-0008', 'Year I', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0008MathYear I12015', '20152015-0008', 'Year I', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0008EnglishYear I2201', '20152015-0008', 'Year I', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0008MathYear I22015', '20152015-0008', 'Year I', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0008EnglishYear I3201', '20152015-0008', 'Year I', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0008MathYear I32015', '20152015-0008', 'Year I', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0008EnglishYear I4201', '20152015-0008', 'Year I', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0008MathYear I42015', '20152015-0008', 'Year I', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0009ScienceYear I0201', '20152015-0009', 'NULL', 'ScienceYear I', 'Failed', '02015', '0.00'),
('20152015-0009ScienceYear I1201', '20152015-0009', 'NULL', 'ScienceYear I', 'Failed', '12015', '0.00'),
('20152015-0009ScienceYear I2201', '20152015-0009', 'NULL', 'ScienceYear I', 'Failed', '22015', '0.00'),
('20152015-0009ScienceYear I3201', '20152015-0009', 'NULL', 'ScienceYear I', 'Failed', '32015', '0.00'),
('20152015-0009ScienceYear I4201', '20152015-0009', 'NULL', 'ScienceYear I', 'Failed', '42015', '0.00'),
('20152015-0009English02015', '20152015-0009', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0009English12015', '20152015-0009', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0009English22015', '20152015-0009', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0009English32015', '20152015-0009', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0009English42015', '20152015-0009', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0009EnglishYear II020', '20152015-0009', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '0.00'),
('20152015-0009MathYear II02015', '20152015-0009', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0009EnglishYear II120', '20152015-0009', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '0.00'),
('20152015-0009MathYear II12015', '20152015-0009', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0009EnglishYear II220', '20152015-0009', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0009MathYear II22015', '20152015-0009', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0009EnglishYear II320', '20152015-0009', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0009MathYear II32015', '20152015-0009', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0009EnglishYear II420', '20152015-0009', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0009MathYear II42015', '20152015-0009', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0010MathYear I02015', '20152015-0010', 'Year IA', 'MathYear I', 'Failed', '02015', '80.00'),
('20152015-0010MathYear I12015', '20152015-0010', 'Year IA', 'MathYear I', 'Failed', '12015', '87.00'),
('20152015-0010MathYear I22015', '20152015-0010', 'Year IA', 'MathYear I', 'Failed', '22015', '0.00'),
('20152015-0010MathYear I32015', '20152015-0010', 'Year IA', 'MathYear I', 'Failed', '32015', '0.00'),
('20152015-0010MathYear I42015', '20152015-0010', 'Year IA', 'MathYear I', 'Failed', '42015', '0.00'),
('20152015-0010EnglishI02015', '20152015-0010', 'Year IA', 'MathYear I', 'Taking', '02015', '80.00'),
('20152015-0010EnglishII02015', '20152015-0010', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0010EnglishI12015', '20152015-0010', 'Year IA', 'MathYear I', 'Taking', '12015', '87.00'),
('20152015-0010EnglishII12015', '20152015-0010', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0010EnglishI22015', '20152015-0010', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0010EnglishII22015', '20152015-0010', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0010EnglishI32015', '20152015-0010', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0010EnglishII32015', '20152015-0010', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0010EnglishI42015', '20152015-0010', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0010EnglishII42015', '20152015-0010', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0010EnglishYear II020', '20152015-0010', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '0.00'),
('20152015-0010MathYear II02015', '20152015-0010', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0010EnglishYear II120', '20152015-0010', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '0.00'),
('20152015-0010MathYear II12015', '20152015-0010', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0010EnglishYear II220', '20152015-0010', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0010MathYear II22015', '20152015-0010', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0010EnglishYear II320', '20152015-0010', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0010MathYear II32015', '20152015-0010', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0010EnglishYear II420', '20152015-0010', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0010MathYear II42015', '20152015-0010', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0011EnglishYear I0201', '20152015-0011', 'NULL', 'EnglishYear I', 'Failed', '02015', '85.00'),
('20152015-0011EnglishYear I1201', '20152015-0011', 'NULL', 'EnglishYear I', 'Failed', '12015', '0.00'),
('20152015-0011EnglishYear I2201', '20152015-0011', 'NULL', 'EnglishYear I', 'Failed', '22015', '0.00'),
('20152015-0011EnglishYear I3201', '20152015-0011', 'NULL', 'EnglishYear I', 'Failed', '32015', '0.00'),
('20152015-0011EnglishYear I4201', '20152015-0011', 'NULL', 'EnglishYear I', 'Failed', '42015', '0.00'),
('20152015-0011EnglishI02015', '20152015-0011', 'Year IA', 'EnglishYear I', 'Taking', '02015', '85.00'),
('20152015-0011EnglishI12015', '20152015-0011', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0011EnglishI22015', '20152015-0011', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0011EnglishI32015', '20152015-0011', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0011EnglishI42015', '20152015-0011', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0011EnglishYear II020', '20152015-0011', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '0.00'),
('20152015-0011MathYear II02015', '20152015-0011', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0011EnglishYear II120', '20152015-0011', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '0.00'),
('20152015-0011MathYear II12015', '20152015-0011', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0011EnglishYear II220', '20152015-0011', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0011MathYear II22015', '20152015-0011', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0011EnglishYear II320', '20152015-0011', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0011MathYear II32015', '20152015-0011', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0011EnglishYear II420', '20152015-0011', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0011MathYear II42015', '20152015-0011', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0012EnglishYear I0201', '20152015-0012', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0012MathYear I02015', '20152015-0012', 'Year IA', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0012ScienceYear I0201', '20152015-0012', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0012EnglishYear I1201', '20152015-0012', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0012MathYear I12015', '20152015-0012', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0012ScienceYear I1201', '20152015-0012', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0012EnglishYear I2201', '20152015-0012', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0012MathYear I22015', '20152015-0012', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0012ScienceYear I2201', '20152015-0012', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0012EnglishYear I3201', '20152015-0012', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0012MathYear I32015', '20152015-0012', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0012ScienceYear I3201', '20152015-0012', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0012EnglishYear I4201', '20152015-0012', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0012MathYear I42015', '20152015-0012', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0012ScienceYear I4201', '20152015-0012', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0013EnglishYear I0201', '20152015-0013', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0013MathYear I02015', '20152015-0013', 'Year IA', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0013ScienceYear I0201', '20152015-0013', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0013EnglishYear I1201', '20152015-0013', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0013MathYear I12015', '20152015-0013', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0013ScienceYear I1201', '20152015-0013', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0013EnglishYear I2201', '20152015-0013', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0013MathYear I22015', '20152015-0013', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0013ScienceYear I2201', '20152015-0013', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0013EnglishYear I3201', '20152015-0013', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0013MathYear I32015', '20152015-0013', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0013ScienceYear I3201', '20152015-0013', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0013EnglishYear I4201', '20152015-0013', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0013MathYear I42015', '20152015-0013', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0013ScienceYear I4201', '20152015-0013', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0014ScienceYear I0201', '20152015-0014', 'NULL', 'ScienceYear I', 'Failed', '02015', '0.00'),
('20152015-0014ScienceYear I1201', '20152015-0014', 'NULL', 'ScienceYear I', 'Failed', '12015', '0.00'),
('20152015-0014ScienceYear I2201', '20152015-0014', 'NULL', 'ScienceYear I', 'Failed', '22015', '0.00'),
('20152015-0014ScienceYear I3201', '20152015-0014', 'NULL', 'ScienceYear I', 'Failed', '32015', '0.00'),
('20152015-0014ScienceYear I4201', '20152015-0014', 'NULL', 'ScienceYear I', 'Failed', '42015', '0.00'),
('20152015-0014EnglishI02015', '20152015-0014', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0014EnglishI12015', '20152015-0014', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0014EnglishI22015', '20152015-0014', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0014EnglishI32015', '20152015-0014', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0014EnglishI42015', '20152015-0014', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0014EnglishYear II020', '20152015-0014', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '0.00'),
('20152015-0014MathYear II02015', '20152015-0014', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0014EnglishYear II120', '20152015-0014', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '0.00'),
('20152015-0014MathYear II12015', '20152015-0014', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0014EnglishYear II220', '20152015-0014', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0014MathYear II22015', '20152015-0014', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0014EnglishYear II320', '20152015-0014', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0014MathYear II32015', '20152015-0014', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0014EnglishYear II420', '20152015-0014', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0014MathYear II42015', '20152015-0014', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0015EnglishYear I0201', '20152015-0015', 'Year IA', 'EnglishYear I', 'Taking', '02015', '0.00'),
('20152015-0015MathYear I02015', '20152015-0015', 'Year IA', 'MathYear I', 'Taking', '02015', '0.00'),
('20152015-0015ScienceYear I0201', '20152015-0015', 'Year IA', 'ScienceYear I', 'Taking', '02015', '0.00'),
('20152015-0015EnglishYear I1201', '20152015-0015', 'Year IA', 'EnglishYear I', 'Taking', '12015', '0.00'),
('20152015-0015MathYear I12015', '20152015-0015', 'Year IA', 'MathYear I', 'Taking', '12015', '0.00'),
('20152015-0015ScienceYear I1201', '20152015-0015', 'Year IA', 'ScienceYear I', 'Taking', '12015', '0.00'),
('20152015-0015EnglishYear I2201', '20152015-0015', 'Year IA', 'EnglishYear I', 'Taking', '22015', '0.00'),
('20152015-0015MathYear I22015', '20152015-0015', 'Year IA', 'MathYear I', 'Taking', '22015', '0.00'),
('20152015-0015ScienceYear I2201', '20152015-0015', 'Year IA', 'ScienceYear I', 'Taking', '22015', '0.00'),
('20152015-0015EnglishYear I3201', '20152015-0015', 'Year IA', 'EnglishYear I', 'Taking', '32015', '0.00'),
('20152015-0015MathYear I32015', '20152015-0015', 'Year IA', 'MathYear I', 'Taking', '32015', '0.00'),
('20152015-0015ScienceYear I3201', '20152015-0015', 'Year IA', 'ScienceYear I', 'Taking', '32015', '0.00'),
('20152015-0015EnglishYear I4201', '20152015-0015', 'Year IA', 'EnglishYear I', 'Taking', '42015', '0.00'),
('20152015-0015MathYear I42015', '20152015-0015', 'Year IA', 'MathYear I', 'Taking', '42015', '0.00'),
('20152015-0015ScienceYear I4201', '20152015-0015', 'Year IA', 'ScienceYear I', 'Taking', '42015', '0.00'),
('20152015-0017EnglishYear II020', '20152015-0017', 'Year IIA', 'EnglishYear II', 'Taking', '02015', '0.00'),
('20152015-0017MathYear II02015', '20152015-0017', 'Year IIA', 'MathYear II', 'Taking', '02015', '0.00'),
('20152015-0017Araling Panlipuna', '20152015-0017', 'Year IIA', 'Araling PanlipunanYear II', 'Taking', '02015', '0.00'),
('20152015-0017ScienceYear II020', '20152015-0017', 'Year IIA', 'ScienceYear II', 'Taking', '02015', '0.00'),
('20152015-0017FilipinoYear II02', '20152015-0017', 'Year IIA', 'FilipinoYear II', 'Taking', '02015', '0.00'),
('20152015-0017TLEYear II02015', '20152015-0017', 'Year IIA', 'TLEYear II', 'Taking', '02015', '0.00'),
('20152015-0017MapehYear II02015', '20152015-0017', 'Year IIA', 'MapehYear II', 'Taking', '02015', '0.00'),
('20152015-0017BibleYear II02015', '20152015-0017', 'Year IIA', 'BibleYear II', 'Taking', '02015', '0.00'),
('20152015-0017PEYear II02015', '20152015-0017', 'Year IIA', 'PEYear II', 'Taking', '02015', '0.00'),
('20152015-0017EnglishYear II120', '20152015-0017', 'Year IIA', 'EnglishYear II', 'Taking', '12015', '0.00'),
('20152015-0017MathYear II12015', '20152015-0017', 'Year IIA', 'MathYear II', 'Taking', '12015', '0.00'),
('20152015-0017ScienceYear II120', '20152015-0017', 'Year IIA', 'ScienceYear II', 'Taking', '12015', '0.00'),
('20152015-0017FilipinoYear II12', '20152015-0017', 'Year IIA', 'FilipinoYear II', 'Taking', '12015', '0.00'),
('20152015-0017TLEYear II12015', '20152015-0017', 'Year IIA', 'TLEYear II', 'Taking', '12015', '0.00'),
('20152015-0017MapehYear II12015', '20152015-0017', 'Year IIA', 'MapehYear II', 'Taking', '12015', '0.00'),
('20152015-0017BibleYear II12015', '20152015-0017', 'Year IIA', 'BibleYear II', 'Taking', '12015', '0.00'),
('20152015-0017PEYear II12015', '20152015-0017', 'Year IIA', 'PEYear II', 'Taking', '12015', '0.00'),
('20152015-0017EnglishYear II220', '20152015-0017', 'Year IIA', 'EnglishYear II', 'Taking', '22015', '0.00'),
('20152015-0017MathYear II22015', '20152015-0017', 'Year IIA', 'MathYear II', 'Taking', '22015', '0.00'),
('20152015-0017ScienceYear II220', '20152015-0017', 'Year IIA', 'ScienceYear II', 'Taking', '22015', '0.00'),
('20152015-0017FilipinoYear II22', '20152015-0017', 'Year IIA', 'FilipinoYear II', 'Taking', '22015', '0.00'),
('20152015-0017TLEYear II22015', '20152015-0017', 'Year IIA', 'TLEYear II', 'Taking', '22015', '0.00'),
('20152015-0017MapehYear II22015', '20152015-0017', 'Year IIA', 'MapehYear II', 'Taking', '22015', '0.00'),
('20152015-0017BibleYear II22015', '20152015-0017', 'Year IIA', 'BibleYear II', 'Taking', '22015', '0.00'),
('20152015-0017PEYear II22015', '20152015-0017', 'Year IIA', 'PEYear II', 'Taking', '22015', '0.00'),
('20152015-0017EnglishYear II320', '20152015-0017', 'Year IIA', 'EnglishYear II', 'Taking', '32015', '0.00'),
('20152015-0017MathYear II32015', '20152015-0017', 'Year IIA', 'MathYear II', 'Taking', '32015', '0.00'),
('20152015-0017ScienceYear II320', '20152015-0017', 'Year IIA', 'ScienceYear II', 'Taking', '32015', '0.00'),
('20152015-0017FilipinoYear II32', '20152015-0017', 'Year IIA', 'FilipinoYear II', 'Taking', '32015', '0.00'),
('20152015-0017TLEYear II32015', '20152015-0017', 'Year IIA', 'TLEYear II', 'Taking', '32015', '0.00'),
('20152015-0017MapehYear II32015', '20152015-0017', 'Year IIA', 'MapehYear II', 'Taking', '32015', '0.00'),
('20152015-0017BibleYear II32015', '20152015-0017', 'Year IIA', 'BibleYear II', 'Taking', '32015', '0.00'),
('20152015-0017PEYear II32015', '20152015-0017', 'Year IIA', 'PEYear II', 'Taking', '32015', '0.00'),
('20152015-0017EnglishYear II420', '20152015-0017', 'Year IIA', 'EnglishYear II', 'Taking', '42015', '0.00'),
('20152015-0017MathYear II42015', '20152015-0017', 'Year IIA', 'MathYear II', 'Taking', '42015', '0.00'),
('20152015-0017ScienceYear II420', '20152015-0017', 'Year IIA', 'ScienceYear II', 'Taking', '42015', '0.00'),
('20152015-0017FilipinoYear II42', '20152015-0017', 'Year IIA', 'FilipinoYear II', 'Taking', '42015', '0.00'),
('20152015-0017TLEYear II42015', '20152015-0017', 'Year IIA', 'TLEYear II', 'Taking', '42015', '0.00'),
('20152015-0017MapehYear II42015', '20152015-0017', 'Year IIA', 'MapehYear II', 'Taking', '42015', '0.00'),
('20152015-0017BibleYear II42015', '20152015-0017', 'Year IIA', 'BibleYear II', 'Taking', '42015', '0.00'),
('20152015-0017PEYear II42015', '20152015-0017', 'Year IIA', 'PEYear II', 'Taking', '42015', '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudenttransactions`
--

CREATE TABLE IF NOT EXISTS `tblstudenttransactions` (
  `studentfee` varchar(50) NOT NULL,
  `studentschoolyear` varchar(30) DEFAULT NULL,
  `balancename` varchar(30) DEFAULT NULL,
  `balancecategory` varchar(30) DEFAULT NULL,
  `paymentmode` varchar(20) DEFAULT NULL,
  `balance` decimal(10,2) DEFAULT NULL,
  `balancedate` date DEFAULT NULL,
  PRIMARY KEY (`studentfee`),
  KEY `studentschoolyear` (`studentschoolyear`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudenttransactions`
--

INSERT INTO `tblstudenttransactions` (`studentfee`, `studentschoolyear`, `balancename`, `balancecategory`, `paymentmode`, `balance`, `balancedate`) VALUES
('2014-001GradeIGeneral FeeRegular2014', '20142014-001', 'General Fee', 'Miscellaneous', NULL, '2000.00', '0001-01-01'),
('2014-001GradeIRegistration FeeRegular2014', '20142014-001', 'Registration Fee', 'Miscellaneous', NULL, '200.00', '0001-01-01'),
('2014-001GradeIBook FeeRegular2014', '20142014-001', 'Book Fee', 'Other Fees', NULL, '2000.00', '0001-01-01'),
('2014-001TFGradeI1st PaymentRegular2014', '20142014-001', '1st Payment', 'Tuition', NULL, '2000.00', '2014-06-02'),
('2014-001TFGradeI2nd PaymentRegular2014', '20142014-001', '2nd Payment', 'Tuition', NULL, '2000.00', '2014-08-02'),
('2014-001TFGradeI3rd PaymentRegular2014', '20142014-001', '3rd Payment', 'Tuition', NULL, '2000.00', '2014-10-02'),
('2014-001TFGradeI4th PaymentRegular2014', '20142014-001', '4th Payment', 'Tuition', NULL, '2000.00', '2014-12-02'),
('2014-001TFGradeI5th PaymentRegular2014', '20142014-001', '5th Payment', 'Tuition', NULL, '2000.00', '2015-02-02'),
('2014-002GradeIGeneral FeeRegular2014', '20142014-002', 'General Fee', 'Miscellaneous', NULL, '801.00', '0001-01-01'),
('2014-002GradeIRegistration FeeRegular2014', '20142014-002', 'Registration Fee', 'Miscellaneous', NULL, '200.00', '0001-01-01'),
('2014-002Other12014', '20142014-002', 'Book Fee', 'Other Fees', NULL, '2000.00', NULL),
('2014-002TF92014', '20142014-002', '5th Payment', 'Tuition', 'Partial Payment', '2000.00', '2015-02-02'),
('2014-002TF82014', '20142014-002', '4th Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-12-02'),
('2014-002TF72014', '20142014-002', '3rd Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-10-02'),
('2014-002TF62014', '20142014-002', '2nd Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-08-02'),
('2014-002TF52014', '20142014-002', '1st Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-06-02'),
('2014-003GradeIGeneral FeeRegular2014', '20142014-003', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2014-003GradeIRegistration FeeRegular2014', '20142014-003', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0014YearIIGeneral FeeRegular2015', '20152015-0014', 'General Fee', 'Miscellaneous', NULL, '1091.50', '0001-01-01'),
('2014-003TF92014', '20142014-003', '5th Payment', 'Tuition', 'Partial Payment', '2000.00', '2015-02-02'),
('2015-0002TFGradeI2nd PaymentRegular2015', '20152015-0002', '2nd Payment', 'Tuition', NULL, '2000.00', '2014-08-02'),
('2014-003TF82014', '20142014-003', '4th Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-12-02'),
('2014-003TF72014', '20142014-003', '3rd Payment', 'Tuition', 'Partial Payment', '2000.00', '2014-10-02'),
('2014-003TF62014', '20142014-003', '2nd Payment', 'Tuition', 'Partial Payment', '200.00', '2014-08-02'),
('2015-0002TFGradeI1st PaymentRegular2015', '20152015-0002', '1st Payment', 'Tuition', NULL, '2000.00', '2014-06-02'),
('2014-003TF52014', '20142014-003', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2014-06-02'),
('2015-0001GradeIGeneral FeeRegular2015', '20152015-0001', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0001GradeIRegistration FeeRegular2015', '20152015-0001', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0001GradeIBook FeeRegular2015', '20152015-0001', 'Book Fee', 'Other Fees', NULL, '2000.00', '0001-01-01'),
('2015-0012Other12015', '20152015-0012', 'Books', 'Other Fees', NULL, '200.00', '2014-10-08'),
('2015-0002GradeIBook FeeRegular2015', '20152015-0002', 'Book Fee', 'Other Fees', NULL, '2000.00', '0001-01-01'),
('2015-0002GradeIRegistration FeeRegular2015', '20152015-0002', 'Registration Fee', 'Miscellaneous', NULL, '200.00', '0001-01-01'),
('2015-0002GradeIGeneral FeeRegular2015', '20152015-0002', 'General Fee', 'Miscellaneous', NULL, '2000.00', '0001-01-01'),
('2015-0001TF92015', '20152015-0001', '5th Payment', 'Tuition', 'Partial Payment', '4200.00', '2015-02-02'),
('2015-0001TF82015', '20152015-0001', '4th Payment', 'Tuition', 'Partial Payment', '4200.00', '2014-12-02'),
('2015-0001TF72015', '20152015-0001', '3rd Payment', 'Tuition', 'Partial Payment', '0.00', '2014-10-02'),
('2015-0001TF62015', '20152015-0001', '2nd Payment', 'Tuition', 'Partial Payment', '0.00', '2014-08-02'),
('2015-0001TF52015', '20152015-0001', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2014-06-02'),
('2015-0002TFGradeI3rd PaymentRegular2015', '20152015-0002', '3rd Payment', 'Tuition', NULL, '2000.00', '2014-10-02'),
('2015-0006YearIGeneral FeeRegular2015', '20152015-0006', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0002TFGradeI4th PaymentRegular2015', '20152015-0002', '4th Payment', 'Tuition', NULL, '2000.00', '2014-12-02'),
('2015-0002TFGradeI5th PaymentRegular2015', '20152015-0002', '5th Payment', 'Tuition', NULL, '2000.00', '2015-02-02'),
('2015-0003GradeIGeneral FeeRegular2015', '20152015-0003', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0003GradeIRegistration FeeRegular2015', '20152015-0003', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0003GradeIBook FeeRegular2015', '20152015-0003', 'Book Fee', 'Other Fees', NULL, '2000.00', '0001-01-01'),
('2015-0005TF92015', '20152015-0005', '5th Payment', 'Tuition', 'Partial Payment', '2224.00', '2016-02-02'),
('2015-0005Other12015', '20152015-0005', 'Books', 'Other Fees', NULL, '0.00', '2014-10-01'),
('2015-0006YearIRegistration FeeRegular2015', '20152015-0006', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0004YearIIRegistration FeeRegular2015', '20152015-0004', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0004YearIIGeneral FeeRegular2015', '20152015-0004', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0003TF92015', '20152015-0003', '5th Payment', 'Tuition', 'Partial Payment', '1457.00', '2016-02-02'),
('2015-0003TF82015', '20152015-0003', '4th Payment', 'Tuition', 'Partial Payment', '1457.00', '2015-12-02'),
('2015-0003TF72015', '20152015-0003', '3rd Payment', 'Tuition', 'Partial Payment', '1457.00', '2015-10-02'),
('2015-0003TF62015', '20152015-0003', '2nd Payment', 'Tuition', 'Partial Payment', '0.00', '2015-08-02'),
('2015-0003TF52015', '20152015-0003', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2015-06-02'),
('2015-0003Other12015', '20152015-0003', 'Books', 'Other Fees', NULL, '4350.00', '2014-09-30'),
('2015-0005YearIGeneral FeeRegular2015', '20152015-0005', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0004FullTuitionFee2015', '20152015-0004', 'Full Payment', 'Tuition', 'Full Payment', '0.00', '2014-10-01'),
('2015-0005YearIRegistration FeeRegular2015', '20152015-0005', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0005TF82015', '20152015-0005', '4th Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-12-02'),
('2015-0005TF72015', '20152015-0005', '3rd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-10-02'),
('2015-0005TF62015', '20152015-0005', '2nd Payment', 'Tuition', 'Partial Payment', '1448.00', '2015-08-02'),
('2015-0005TF52015', '20152015-0005', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2015-06-02'),
('2015-0007YearIGeneral FeeRegular2015', '20152015-0007', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0007YearIRegistration FeeRegular2015', '20152015-0007', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0006TF92015', '20152015-0006', '5th Payment', 'Tuition', 'Partial Payment', '2224.00', '2016-02-02'),
('2015-0006TF82015', '20152015-0006', '4th Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-12-02'),
('2015-0006TF72015', '20152015-0006', '3rd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-10-02'),
('2015-0006TF62015', '20152015-0006', '2nd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-08-02'),
('2015-0006TF52015', '20152015-0006', '1st Payment', 'Tuition', 'Partial Payment', '1987.00', '2015-06-02'),
('2015-0008YearIGeneral FeeRegular2015', '20152015-0008', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0008YearIRegistration FeeRegular2015', '20152015-0008', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0007TF92015', '20152015-0007', '5th Payment', 'Tuition', 'Partial Payment', '2224.00', '2016-02-02'),
('2015-0007TF82015', '20152015-0007', '4th Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-12-02'),
('2015-0007TF72015', '20152015-0007', '3rd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-10-02'),
('2015-0007TF62015', '20152015-0007', '2nd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-08-02'),
('2015-0007TF52015', '20152015-0007', '1st Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-06-02'),
('2015-0009YearIIRegistration FeeRegular2015', '20152015-0009', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0009YearIIGeneral FeeRegular2015', '20152015-0009', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0008TF92015', '20152015-0008', '5th Payment', 'Tuition', 'Partial Payment', '2224.00', '2016-02-02'),
('2015-0008TF82015', '20152015-0008', '4th Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-12-02'),
('2015-0008TF72015', '20152015-0008', '3rd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-10-02'),
('2015-0008TF62015', '20152015-0008', '2nd Payment', 'Tuition', 'Partial Payment', '2224.00', '2015-08-02'),
('2015-0008TF52015', '20152015-0008', '1st Payment', 'Tuition', 'Partial Payment', '1987.00', '2015-06-02'),
('2015-0010YearIIRegistration FeeRegular2015', '20152015-0010', 'Registration Fee', 'Miscellaneous', NULL, '763.00', '0001-01-01'),
('2015-0010YearIIGeneral FeeRegular2015', '20152015-0010', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0009TF92015', '20152015-0009', '5th Payment', 'Tuition', 'Partial Payment', '1754.00', '2015-02-02'),
('2015-0009TF82015', '20152015-0009', '4th Payment', 'Tuition', 'Partial Payment', '1754.00', '2014-12-02'),
('2015-0009TF72015', '20152015-0009', '3rd Payment', 'Tuition', 'Partial Payment', '645.00', '2014-10-02'),
('2015-0009TF62015', '20152015-0009', '2nd Payment', 'Tuition', 'Partial Payment', '0.00', '2014-08-02'),
('2015-0009TF52015', '20152015-0009', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2014-06-02'),
('2015-0009Other22015', '20152015-0009', 'Science', 'Other Fees', NULL, '100.00', '2014-10-07'),
('2015-0011YearIIRegistration FeeRegular2015', '20152015-0011', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0011YearIIGeneral FeeRegular2015', '20152015-0011', 'General Fee', 'Miscellaneous', NULL, '3823.00', '0001-01-01'),
('2015-0010TF92015', '20152015-0010', '5th Payment', 'Tuition', 'Partial Payment', '1754.00', '2015-02-02'),
('2015-0010TF82015', '20152015-0010', '4th Payment', 'Tuition', 'Partial Payment', '1754.00', '2014-12-02'),
('2015-0010TF72015', '20152015-0010', '3rd Payment', 'Tuition', 'Partial Payment', '1754.00', '2014-10-02'),
('2015-0010TF62015', '20152015-0010', '2nd Payment', 'Tuition', 'Partial Payment', '1754.00', '2014-08-02'),
('2015-0010TF52015', '20152015-0010', '1st Payment', 'Tuition', 'Partial Payment', '1754.00', '2014-06-02'),
('2015-0010Other12015', '20152015-0010', 'Books', 'Other Fees', NULL, '4500.00', '2014-10-07'),
('2015-0010Other22015', '20152015-0010', 'MathI', 'Other Fees', NULL, '100.00', '2014-10-07'),
('2015-0010Other32015', '20152015-0010', 'ScienceI', 'Other Fees', NULL, '100.00', '2014-10-07'),
('2015-0012YearIGeneral FeeRegular2015', '20152015-0012', 'General Fee', 'Miscellaneous', NULL, '200.00', '0001-01-01'),
('2015-0012YearIRegistration FeeRegular2015', '20152015-0012', 'Registration Fee', 'Miscellaneous', NULL, '200.00', '0001-01-01'),
('2015-0011TF92015', '20152015-0011', '5th Payment', 'Tuition', 'Partial Payment', '1774.00', '2015-02-02'),
('2015-0011TF72015', '20152015-0011', '3rd Payment', 'Tuition', 'Partial Payment', '1774.00', '2014-10-02'),
('2015-0011TF82015', '20152015-0011', '4th Payment', 'Tuition', 'Partial Payment', '1774.00', '2014-12-02'),
('2015-0011TF52015', '20152015-0011', '1st Payment', 'Tuition', 'Partial Payment', '1774.00', '2014-06-02'),
('2015-0011TF62015', '20152015-0011', '2nd Payment', 'Tuition', 'Partial Payment', '1774.00', '2014-08-02'),
('2015-0013YearIRegistration FeeRegular2015', '20152015-0013', 'Registration Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0013YearIGeneral FeeRegular2015', '20152015-0013', 'General Fee', 'Miscellaneous', NULL, '0.00', '0001-01-01'),
('2015-0012TF92015', '20152015-0012', '5th Payment', 'Tuition', 'Partial Payment', '300.00', '2016-02-02'),
('2015-0012TF82015', '20152015-0012', '4th Payment', 'Tuition', 'Partial Payment', '300.00', '2015-12-02'),
('2015-0012TF72015', '20152015-0012', '3rd Payment', 'Tuition', 'Partial Payment', '300.00', '2015-10-02'),
('2015-0012TF62015', '20152015-0012', '2nd Payment', 'Tuition', 'Partial Payment', '300.00', '2015-08-02'),
('2015-0012TF52015', '20152015-0012', '1st Payment', 'Tuition', 'Partial Payment', '300.00', '2015-06-02'),
('2015-0013TF92015', '20152015-0013', '5th Payment', 'Tuition', 'Partial Payment', '1285.00', '2015-02-02'),
('2015-0013TF82015', '20152015-0013', '4th Payment', 'Tuition', 'Partial Payment', '1285.00', '2014-12-02'),
('2015-0013TF72015', '20152015-0013', '3rd Payment', 'Tuition', 'Partial Payment', '1285.00', '2014-10-02'),
('2015-0013Other12015', '20152015-0013', 'Books', 'Other Fees', NULL, '0.00', '2014-10-08'),
('2015-0013TF62015', '20152015-0013', '2nd Payment', 'Tuition', 'Partial Payment', '1283.50', '2014-08-02'),
('2015-0013TF52015', '20152015-0013', '1st Payment', 'Tuition', 'Partial Payment', '0.00', '2014-06-02'),
('2015-0014TF92015', '20152015-0014', '5th Payment', 'Tuition', 'Partial Payment', '2244.00', '2015-02-02'),
('2015-0014TF82015', '20152015-0014', '4th Payment', 'Tuition', 'Partial Payment', '2244.00', '2014-12-02'),
('2015-0014TF72015', '20152015-0014', '3rd Payment', 'Tuition', 'Partial Payment', '2244.00', '2014-10-02'),
('2015-0014TF62015', '20152015-0014', '2nd Payment', 'Tuition', 'Partial Payment', '2244.00', '2014-08-02'),
('2015-0014TF52015', '20152015-0014', '1st Payment', 'Tuition', 'Partial Payment', '2244.00', '2014-06-02'),
('2015-0014YearIIRegistration FeeRegular2015', '20152015-0014', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0015YearIGeneral FeeRegular2015', '20152015-0015', 'General Fee', 'Miscellaneous', NULL, '3823.00', '0001-01-01'),
('2015-0015YearIRegistration FeeRegular2015', '20152015-0015', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0016TFYearI4th PaymentRegular2015', '20152015-0016', '4th Payment', 'Tuition', NULL, '1409.85', '2014-12-02'),
('2015-0018CFYearI3rd PaymentRegular2015', '20152015-0018', '3rd Payment', 'Computer Fee', NULL, '344.60', '2014-10-02'),
('2015-0018TFYearI3rd PaymentRegular2015', '20152015-0018', '3rd Payment', 'Tuition', NULL, '1879.80', '2014-10-02'),
('2015-0016YearIRegistration FeeRegular2015', '20152015-0016', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0016YearIGeneral FeeRegular2015', '20152015-0016', 'General Fee', 'Miscellaneous', NULL, '3823.00', '0001-01-01'),
('2015-0018YearIRegistration FeeRegular2015', '20152015-0018', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0017YearIIGeneral FeeRegular2015', '20152015-0017', 'General Fee', 'Miscellaneous', NULL, '3823.00', '0001-01-01'),
('2015-0018TFYearI2nd PaymentRegular2015', '20152015-0018', '2nd Payment', 'Tuition', NULL, '1879.80', '2014-08-02'),
('2015-0015TF92015', '20152015-0015', '5th Payment', 'Tuition', 'Partial Payment', '2224.40', '2015-02-02'),
('2015-0016TFYearI3rd PaymentRegular2015', '20152015-0016', '3rd Payment', 'Tuition', NULL, '1409.85', '2014-10-02'),
('2015-0016TFYearI2nd PaymentRegular2015', '20152015-0016', '2nd Payment', 'Tuition', NULL, '1409.85', '2014-08-02'),
('2015-0015TF82015', '20152015-0015', '4th Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-12-02'),
('2015-0015TF72015', '20152015-0015', '3rd Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-10-02'),
('2015-0015TF62015', '20152015-0015', '2nd Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-08-02'),
('2015-0016TFYearI1st PaymentRegular2015', '20152015-0016', '1st Payment', 'Tuition', NULL, '1409.85', '2014-06-02'),
('2015-0016YearIBooksRegular2015', '20152015-0016', 'Books', 'Other Fees', NULL, '4500.00', '0001-01-01'),
('2015-0015TF52015', '20152015-0015', '1st Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-06-02'),
('2015-0016TFYearI5th PaymentRegular2015', '20152015-0016', '5th Payment', 'Tuition', NULL, '1409.85', '2015-02-02'),
('2015-0015Other12015', '20152015-0015', 'Math Book', 'Other Fees', NULL, '700.00', '2014-10-08'),
('2015-0015Other22015', '20152015-0015', 'Home WorkEd Book', 'Other Fees', NULL, '500.00', '2014-10-08'),
('2015-0015Other32015', '20152015-0015', 'English Book', 'Other Fees', NULL, '660.00', '2014-10-08'),
('2015-0015Other42015', '20152015-0015', 'Science Book', 'Other Fees', NULL, '757.00', '2014-10-08'),
('2015-0018YearIGeneral FeeRegular2015', '20152015-0018', 'General Fee', 'Miscellaneous', NULL, '3823.00', '0001-01-01'),
('2015-0017TF92015', '20152015-0017', '5th Payment', 'Tuition', 'Partial Payment', '2224.40', '2015-02-02'),
('2015-0017TF82015', '20152015-0017', '4th Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-12-02'),
('2015-0017TF72015', '20152015-0017', '3rd Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-10-02'),
('2015-0017TF62015', '20152015-0017', '2nd Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-08-02'),
('2015-0017TF52015', '20152015-0017', '1st Payment', 'Tuition', 'Partial Payment', '2224.40', '2014-06-02'),
('2015-0017YearIIRegistration FeeRegular2015', '20152015-0017', 'Registration Fee', 'Miscellaneous', NULL, '940.00', '0001-01-01'),
('2015-0017Other82015', '20152015-0017', 'Computer Book', 'Other Fees', NULL, '280.00', '2014-10-08'),
('2015-0017Other72015', '20152015-0017', 'PE Book', 'Other Fees', NULL, '446.00', '2014-10-08'),
('2015-0017Other62015', '20152015-0017', 'Filipino Book', 'Other Fees', NULL, '540.00', '2014-10-08'),
('2015-0017Other52015', '20152015-0017', 'Science Book', 'Other Fees', NULL, '757.00', '2014-10-08'),
('2015-0017Other42015', '20152015-0017', 'English Book', 'Other Fees', NULL, '660.00', '2014-10-08'),
('2015-0017Other32015', '20152015-0017', 'Home WorkEd Book', 'Other Fees', NULL, '500.00', '2014-10-08'),
('2015-0017Other22015', '20152015-0017', 'Math Book', 'Other Fees', NULL, '700.00', '2014-10-08'),
('2015-0017Other12015', '20152015-0017', 'AP Book', 'Other Fees', NULL, '617.00', '2014-10-08'),
('2015-0018CFYearI4th PaymentRegular2015', '20152015-0018', '4th Payment', 'Computer Fee', NULL, '344.60', '2014-12-02'),
('2015-0018TFYearI4th PaymentRegular2015', '20152015-0018', '4th Payment', 'Tuition', NULL, '1879.80', '2014-12-02'),
('2015-0018CFYearI5th PaymentRegular2015', '20152015-0018', '5th Payment', 'Computer Fee', NULL, '344.60', '2015-02-02'),
('2015-0018TFYearI5th PaymentRegular2015', '20152015-0018', '5th Payment', 'Tuition', NULL, '1879.80', '2015-02-02'),
('2015-0018CFYearI2nd PaymentRegular2015', '20152015-0018', '2nd Payment', 'Computer Fee', NULL, '344.60', '2014-08-02'),
('2015-0018YearIMath BookRegular2015', '20152015-0018', 'Math Book', 'Other Fees', NULL, '700.00', '0001-01-01'),
('2015-0018CFYearI1st PaymentRegular2015', '20152015-0018', '1st Payment', 'Computer Fee', NULL, '344.60', '2014-06-02'),
('2015-0018TFYearI1st PaymentRegular2015', '20152015-0018', '1st Payment', 'Tuition', NULL, '1879.80', '2014-06-02'),
('2015-0018YearIHome WorkEd BookRegular2015', '20152015-0018', 'Home WorkEd Book', 'Other Fees', NULL, '500.00', '0001-01-01'),
('2015-0018YearIEnglish BookRegular2015', '20152015-0018', 'English Book', 'Other Fees', NULL, '660.00', '0001-01-01'),
('2015-0018YearIScience BookRegular2015', '20152015-0018', 'Science Book', 'Other Fees', NULL, '757.00', '0001-01-01'),
('2015-0018YearIFilipino BookRegular2015', '20152015-0018', 'Filipino Book', 'Other Fees', NULL, '540.00', '0001-01-01'),
('2015-0018YearIAP BookRegular2015', '20152015-0018', 'AP Book', 'Other Fees', NULL, '617.00', '0001-01-01'),
('2015-0018YearIPE BookRegular2015', '20152015-0018', 'PE Book', 'Other Fees', NULL, '446.00', '0001-01-01'),
('2015-0018YearIComputer BookRegular2015', '20152015-0018', 'Computer Book', 'Other Fees', NULL, '280.00', '0001-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentyear`
--

CREATE TABLE IF NOT EXISTS `tblstudentyear` (
  `studentschoolyear` varchar(30) NOT NULL,
  `studentid` varchar(30) DEFAULT NULL,
  `studentstatus` varchar(20) DEFAULT NULL,
  `schoolyearid` varchar(5) DEFAULT NULL,
  `assessedid` int(11) DEFAULT NULL,
  PRIMARY KEY (`studentschoolyear`),
  KEY `studentid` (`studentid`),
  KEY `schoolyearid` (`schoolyearid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentyear`
--

INSERT INTO `tblstudentyear` (`studentschoolyear`, `studentid`, `studentstatus`, `schoolyearid`, `assessedid`) VALUES
('20142014-001', '2014-001', 'Registered', '2014', NULL),
('20142014-002', '2014-002', 'Enrolled', '2014', NULL),
('20142014-003', '2014-003', 'Enrolled', '2014', NULL),
('20152015-0001', '2015-0001', 'Enrolled', '2015', NULL),
('20152015-0002', '2015-0002', 'Registered', '2015', NULL),
('20152015-0003', '2015-0003', 'Enrolled', '2015', 0),
('20152015-0004', '2015-0004', 'Enrolled', '2015', 0),
('20152015-0005', '2015-0005', 'Enrolled', '2015', 0),
('20152015-0006', '2015-0006', 'Enrolled', '2015', 0),
('20152015-0007', '2015-0007', 'Enrolled', '2015', 0),
('20152015-0008', '2015-0008', 'Enrolled', '2015', 0),
('20152015-0009', '2015-0009', 'Enrolled', '2015', 0),
('20152015-0010', '2015-0010', 'Assessed', '2015', 4),
('20152015-0011', '2015-0011', 'Assessed', '2015', 5),
('20152015-0012', '2015-0012', 'Assessed', '2015', 3),
('20152015-0013', '2015-0013', 'Enrolled', '2015', 0),
('20152015-0014', '2015-0014', 'Enrolled', '2015', 0),
('20152015-0015', '2015-0015', 'Assessed', '2015', 6),
('20152015-0016', '2015-0016', 'Registered', '2015', NULL),
('20152015-0017', '2015-0017', 'Assessed', '2015', 0),
('20152015-0018', '2015-0018', 'Registered', '2015', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblstudentyearlevel`
--

CREATE TABLE IF NOT EXISTS `tblstudentyearlevel` (
  `studentschoolyear` varchar(30) DEFAULT NULL,
  `yearlevelcode` varchar(30) DEFAULT NULL,
  KEY `studentschoolyear` (`studentschoolyear`),
  KEY `yearlevelcode` (`yearlevelcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblstudentyearlevel`
--

INSERT INTO `tblstudentyearlevel` (`studentschoolyear`, `yearlevelcode`) VALUES
('20142014-001', 'GradeI'),
('20142014-002', 'GradeI'),
('20142014-003', 'GradeI'),
('20152015-0001', 'GradeI'),
('20152015-0002', 'GradeI'),
('20152015-0003', 'GradeI'),
('20152015-0004', 'YearII'),
('20152015-0005', 'YearI'),
('20152015-0006', 'YearI'),
('20152015-0007', 'YearI'),
('20152015-0008', 'YearI'),
('20152015-0009', 'YearII'),
('20152015-0010', 'YearII'),
('20152015-0011', 'YearII'),
('20152015-0012', 'YearI'),
('20152015-0013', 'YearI'),
('20152015-0014', 'YearII'),
('20152015-0015', 'YearI'),
('20152015-0016', 'YearI'),
('20152015-0017', 'YearII'),
('20152015-0018', 'YearI');

-- --------------------------------------------------------

--
-- Table structure for table `tblsubjects`
--

CREATE TABLE IF NOT EXISTS `tblsubjects` (
  `subjectcode` varchar(30) NOT NULL,
  `sub_code` varchar(20) NOT NULL,
  `sub_name` varchar(20) NOT NULL,
  `unit` decimal(10,1) NOT NULL,
  PRIMARY KEY (`subjectcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsubjects`
--

INSERT INTO `tblsubjects` (`subjectcode`, `sub_code`, `sub_name`, `unit`) VALUES
('MathGrade I', 'MathI', 'Math', '1.5'),
('EnglishGrade I', 'EnglishI', 'English', '1.5'),
('FilipinoGrade I', 'FilipinoI', 'Filipino', '1.2'),
('MathYear II', 'MathII', 'Math', '1.5'),
('EnglishYear II', 'EnglishII', 'English', '1.5'),
('MathYear I', 'MathI', 'Math', '1.5'),
('EnglishYear I', 'EnglishI', 'English', '1.5'),
('ScienceYear I', 'ScienceI', 'Science', '2.0'),
('FilipinoYear I', 'FilipinoI', 'Filipino', '1.2'),
('Araling PanlipunanYear I', 'Araling PanlipunanI', 'Araling Panlipunan', '1.0'),
('BibleYear I', 'BibleI', 'Bible', '0.3'),
('PEYear I', 'PEI', 'PE', '1.0'),
('PEYear II', 'PEII', 'PE', '1.0'),
('TLEYear I', 'TLEI', 'TLE', '1.2'),
('MapehYear I', 'MapehI', 'Mapeh', '1.2'),
('FilipinoYear II', 'FilipinoII', 'Filipino', '1.2'),
('ScienceYear II', 'ScienceII', 'Science', '2.0'),
('Araling PanlipunanYear II', 'Araling PanlipunanII', 'Araling Panlipunan', '1.0'),
('BibleYear II', 'BibleII', 'Bible', '0.3'),
('TLEYear II', 'TLEII', 'TLE', '1.2'),
('MapehYear II', 'MapehII', 'Mapeh', '1.2'),
('FilipinoYear III', 'FilipinoIII', 'Filipino', '1.2'),
('EnglishYear III', 'EnglishIII', 'English', '1.5'),
('MathYear III', 'MathIII', 'Math', '1.5'),
('ScienceYear III', 'ScienceIII', 'Science', '2.0'),
('Araling PanlipunanYear III', 'Araling PanlipunanII', 'Araling Panlipunan', '1.0'),
('TLEYear III', 'TLEIII', 'TLE', '1.2'),
('MapehYear III', 'MapehIII', 'Mapeh', '1.2'),
('BibleYear III', 'BibleIII', 'Bible', '0.3');

-- --------------------------------------------------------

--
-- Table structure for table `tblteacheraccounts`
--

CREATE TABLE IF NOT EXISTS `tblteacheraccounts` (
  `username` varchar(30) NOT NULL DEFAULT '',
  `userpass` varchar(30) NOT NULL,
  `teacherid` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`username`),
  KEY `teacherid` (`teacherid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblteachers`
--

CREATE TABLE IF NOT EXISTS `tblteachers` (
  `teacherid` varchar(25) NOT NULL,
  `tea_lname` varchar(20) NOT NULL,
  `tea_fname` varchar(20) NOT NULL,
  `tea_mname` varchar(20) DEFAULT NULL,
  `tea_address` varchar(50) DEFAULT NULL,
  `tea_contactno` int(11) NOT NULL,
  `tea_email` varchar(30) NOT NULL,
  `teacherstatus` varchar(20) NOT NULL,
  PRIMARY KEY (`teacherid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblteachers`
--

INSERT INTO `tblteachers` (`teacherid`, `tea_lname`, `tea_fname`, `tea_mname`, `tea_address`, `tea_contactno`, `tea_email`, `teacherstatus`) VALUES
('2014-T001', 'Oracion', 'Daisy', 'M', 'Cuenca', 910101010, 'daisy_oracion@gmail.com', 'OK'),
('2015-T002', 'Olarte', 'Moises', 'I', 'Rosario', 2147483647, '', 'OK'),
('2015-T003', 'Villarante', 'Jeffrel', 'P', 'Rosario', 99999999, '', 'OK');

-- --------------------------------------------------------

--
-- Table structure for table `tblteachersubjects`
--

CREATE TABLE IF NOT EXISTS `tblteachersubjects` (
  `subjectcode` varchar(30) NOT NULL,
  `teacherid` varchar(25) NOT NULL,
  KEY `subjectcode` (`subjectcode`),
  KEY `teacherid` (`teacherid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbltransactions`
--

CREATE TABLE IF NOT EXISTS `tbltransactions` (
  `studentfee` varchar(50) DEFAULT NULL,
  `transacno` varchar(20) DEFAULT NULL,
  `paymenttype` varchar(20) DEFAULT NULL,
  `dateofpayment` datetime DEFAULT NULL,
  `amountpaid` decimal(10,2) DEFAULT NULL,
  KEY `studentfee` (`studentfee`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbltransactions`
--

INSERT INTO `tbltransactions` (`studentfee`, `transacno`, `paymenttype`, `dateofpayment`, `amountpaid`) VALUES
('2014-001GradeIGeneral FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001GradeIRegistration FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001GradeIBook FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001CFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001TFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001CFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001TFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001CFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001TFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001CFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001TFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001CFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-001TFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002GradeIGeneral FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002GradeIRegistration FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002GradeIBook FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002CFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002TFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002CFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002TFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002CFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002TFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002CFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002TFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002CFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002TFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-002GradeIGeneral FeeRegular2014', '000000000001', 'Cash', '2014-09-18 12:01:00', '1199.00'),
('2014-002GradeIRegistration FeeRegular2014', '000000000001', 'Cash', '2014-09-18 12:01:00', '0.00'),
('2014-002TF52014', '000000000001', 'Cash', '2014-09-18 12:01:00', '0.00'),
('2014-002TF62014', '000000000001', 'Cash', '2014-09-18 12:01:00', '0.00'),
('2014-002CF52014', '000000000001', 'Cash', '2014-09-18 12:01:00', '0.00'),
('2014-002CF62014', '000000000001', 'Cash', '2014-09-18 12:01:00', '0.00'),
('2014-003GradeIGeneral FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003GradeIRegistration FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003GradeIBook FeeRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003CFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003TFGradeI1st PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003CFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003TFGradeI2nd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003CFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003TFGradeI3rd PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003CFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003TFGradeI4th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003CFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003TFGradeI5th PaymentRegular2014', NULL, NULL, NULL, '0.00'),
('2014-003GradeIGeneral FeeRegular2014', '000000000002', 'Cash', '2014-09-21 06:01:00', '2000.00'),
('2014-003GradeIRegistration FeeRegular2014', '000000000002', 'Cash', '2014-09-21 06:01:00', '200.00'),
('2014-003TF52014', '000000000002', 'Cash', '2014-09-21 06:01:00', '2000.00'),
('2014-003TF62014', '000000000002', 'Cash', '2014-09-21 06:01:00', '1800.00'),
('2014-003CF52014', '000000000002', 'Cash', '2014-09-21 06:01:00', '0.00'),
('2014-003CF62014', '000000000002', 'Cash', '2014-09-21 06:01:00', '0.00'),
('2015-0001GradeIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001GradeIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001GradeIBook FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001CFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001TFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001CFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001TFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001CFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001TFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001CFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001TFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001CFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001TFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0001GradeIGeneral FeeRegular2015', '000000000003', 'Cash', '2014-09-24 08:01:00', '2000.00'),
('2015-0001GradeIRegistration FeeRegular2015', '000000000003', 'Cash', '2014-09-24 08:01:00', '200.00'),
('2015-0001TF52015', '000000000003', 'Cash', '2014-09-24 08:01:00', '2800.00'),
('2015-0001TF62015', '000000000003', 'Cash', '2014-09-24 08:01:00', '0.00'),
('2015-0001TF72015', '000000000003', 'Cash', '2014-09-24 08:01:00', '0.00'),
('2015-0001TF52015', '000000000004', 'Cash', '2014-09-24 08:01:00', '1400.00'),
('2015-0001TF62015', '000000000004', 'Cash', '2014-09-24 08:01:00', '4200.00'),
('2015-0001TF72015', '000000000005', 'Cash', '2014-09-24 08:01:00', '4200.00'),
('2015-0002GradeIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002GradeIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002GradeIBook FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002CFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002TFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002CFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002TFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002CFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002TFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002CFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002TFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002CFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0002TFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003GradeIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003GradeIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003GradeIBook FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003CFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003TFGradeI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003CFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003TFGradeI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003CFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003TFGradeI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003CFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003TFGradeI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003CFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003TFGradeI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0003GradeIGeneral FeeRegular2015', '000000000006', 'Cash', '2014-09-30 10:01:00', '2665.00'),
('2015-0003GradeIRegistration FeeRegular2015', '000000000006', 'Cash', '2014-09-30 10:01:00', '313.00'),
('2015-0003TF52015', '000000000006', 'Cash', '2014-09-30 10:01:00', '1457.00'),
('2015-0003TF62015', '000000000006', 'Cash', '2014-09-30 10:01:00', '565.00'),
('2015-0003TF62015', '000000000007', 'Cash', '2014-09-30 10:01:00', '892.00'),
('2015-0004YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004YearIIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0004YearIIGeneral FeeRegular2015', '000000000008', 'Cash', '2014-10-01 04:01:00', '3823.00'),
('2015-0004YearIIRegistration FeeRegular2015', '000000000008', 'Cash', '2014-10-01 04:01:00', '940.00'),
('2015-0004FullTuitionFee2015', '000000000008', 'Cash', '2014-10-01 04:01:00', '1723.00'),
('2015-0005YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0005YearIGeneral FeeRegular2015', '000000000009', 'Cash', '2014-10-01 04:01:00', '3823.00'),
('2015-0005YearIRegistration FeeRegular2015', '000000000009', 'Cash', '2014-10-01 04:01:00', '940.00'),
('2015-0005Other12015', '000000000009', 'Cash', '2014-10-01 04:01:00', '4500.00'),
('2015-0005TF52015', '000000000010', 'Cash', '2014-10-01 04:01:00', '2224.00'),
('2015-0005TF62015', '000000000010', 'Cash', '2014-10-01 04:01:00', '776.00'),
('2015-0006YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0006YearIGeneral FeeRegular2015', '000000000011', 'Cash', '2014-10-03 08:01:00', '3823.00'),
('2015-0006YearIRegistration FeeRegular2015', '000000000011', 'Cash', '2014-10-03 08:01:00', '940.00'),
('2015-0006TF52015', '000000000011', 'Cash', '2014-10-03 08:01:00', '237.00'),
('2015-0007YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0007YearIGeneral FeeRegular2015', '000000000012', 'Cash', '2014-10-03 09:01:00', '3823.00'),
('2015-0007YearIRegistration FeeRegular2015', '000000000012', 'Cash', '2014-10-03 09:01:00', '940.00'),
('2015-0008YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0008YearIGeneral FeeRegular2015', '000000000013', 'Cash', '2014-10-03 09:01:00', '3823.00'),
('2015-0008YearIRegistration FeeRegular2015', '000000000013', 'Cash', '2014-10-03 09:01:00', '940.00'),
('2015-0008TF52015', '000000000013', 'Cash', '2014-10-03 09:01:00', '237.00'),
('2015-0009YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009YearIIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0009YearIIGeneral FeeRegular2015', '000000000014', 'Cash', '2014-10-07 09:01:00', '2380.00'),
('2015-0009YearIIRegistration FeeRegular2015', '000000000014', 'Cash', '2014-10-07 09:01:00', '0.00'),
('2015-0009TF52015', '000000000014', 'Cash', '2014-10-07 09:01:00', '0.00'),
('2015-0009TF62015', '000000000014', 'Cash', '2014-10-07 09:01:00', '0.00'),
('2015-0009TF72015', '000000000014', 'Cash', '2014-10-07 09:01:00', '0.00'),
('2015-0009YearIIGeneral FeeRegular2015', '000000000015', 'Cash', '2014-10-07 10:01:00', '1443.00'),
('2015-0009YearIIRegistration FeeRegular2015', '000000000015', 'Cash', '2014-10-07 10:01:00', '940.00'),
('2015-0009TF52015', '000000000015', 'Cash', '2014-10-07 10:01:00', '1754.00'),
('2015-0009TF62015', '000000000015', 'Cash', '2014-10-07 10:01:00', '1754.00'),
('2015-0009TF72015', '000000000015', 'Cash', '2014-10-07 10:01:00', '1109.00'),
('2015-0010YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010YearIIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0010YearIIGeneral FeeRegular2015', '000000000016', 'Cash', '2014-10-07 11:01:00', '3823.00'),
('2015-0010YearIIRegistration FeeRegular2015', '000000000016', 'Cash', '2014-10-07 11:01:00', '177.00'),
('2015-0010Other12015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0010Other22015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0010Other32015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0010TF52015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0010TF62015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0010TF72015', '000000000016', 'Cash', '2014-10-07 11:01:00', '0.00'),
('2015-0011YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0011YearIIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0012TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0013YearIGeneral FeeRegular2015', '000000000017', 'Cash', '2014-10-08 08:01:00', '3823.00'),
('2015-0013YearIRegistration FeeRegular2015', '000000000017', 'Cash', '2014-10-08 08:01:00', '809.00'),
('2015-0013Other12015', '000000000017', 'Cash', '2014-10-08 08:01:00', '0.00'),
('2015-0013TF52015', '000000000017', 'Cash', '2014-10-08 08:01:00', '0.00'),
('2015-0013TF62015', '000000000017', 'Cash', '2014-10-08 08:01:00', '0.00'),
('2015-0013TF72015', '000000000017', 'Cash', '2014-10-08 08:01:00', '0.00'),
('2015-0013YearIRegistration FeeRegular2015', '000000000018', 'Cash', '2014-10-08 09:01:00', '132.00'),
('2015-0013Other12015', '000000000018', 'Cash', '2014-10-08 09:01:00', '1153.00'),
('2015-0013TF52015', '000000000018', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0013TF62015', '000000000018', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0013TF72015', '000000000018', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0013Other12015', '000000000019', 'Cash', '2014-10-08 09:01:00', '3347.00'),
('2015-0013TF52015', '000000000019', 'Cash', '2014-10-08 09:01:00', '1285.00'),
('2015-0013TF62015', '000000000019', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0013TF72015', '000000000019', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0014YearIIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014YearIIGeneral FeeRegular2015', '000000000020', 'Cash', '2014-10-08 09:01:00', '2382.00'),
('2015-0014YearIIRegistration FeeRegular2015', '000000000020', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0014TF52015', '000000000020', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0014TF62015', '000000000020', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0014TF72015', '000000000020', 'Cash', '2014-10-08 09:01:00', '0.00'),
('2015-0013TF62015', '000000000021', 'Cash', '2014-10-08 10:01:00', '1.50'),
('2015-0013TF72015', '000000000021', 'Cash', '2014-10-08 10:01:00', '0.00'),
('2015-0015YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0015TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016YearIBooksRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0016TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017CFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017TFYearII5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017CFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017TFYearII4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017TFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017TFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017CFYearII3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017CFYearII2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017CFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017TFYearII1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIAP BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIMath BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIHome WorkEd BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIEnglish BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIScience BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIFilipino BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIPE BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0017YearIIComputer BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0014YearIIGeneral FeeRegular2015', '000000000022', 'Cash', '2014-10-08 01:01:00', '350.50'),
('2015-0014YearIIRegistration FeeRegular2015', '000000000022', 'Cash', '2014-10-08 01:01:00', '0.00'),
('2015-0014TF52015', '000000000022', 'Cash', '2014-10-08 01:01:00', '0.00'),
('2015-0014TF62015', '000000000022', 'Cash', '2014-10-08 01:01:00', '0.00'),
('2015-0014TF72015', '000000000022', 'Cash', '2014-10-08 01:01:00', '0.00'),
('2015-0018YearIGeneral FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIRegistration FeeRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018TFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018CFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018TFYearI3rd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018CFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018TFYearI4th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018CFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018TFYearI5th PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018CFYearI2nd PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIMath BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018CFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018TFYearI1st PaymentRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIHome WorkEd BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIEnglish BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIScience BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIFilipino BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIAP BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIPE BookRegular2015', NULL, NULL, NULL, '0.00'),
('2015-0018YearIComputer BookRegular2015', NULL, NULL, NULL, '0.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblunits`
--

CREATE TABLE IF NOT EXISTS `tblunits` (
  `unit` decimal(10,1) NOT NULL,
  `cost` decimal(10,2) NOT NULL,
  PRIMARY KEY (`unit`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblunits`
--

INSERT INTO `tblunits` (`unit`, `cost`) VALUES
('0.3', '130.00'),
('1.0', '200.00'),
('1.2', '240.00'),
('1.5', '250.00'),
('2.0', '300.00');

-- --------------------------------------------------------

--
-- Table structure for table `tblyearlevel`
--

CREATE TABLE IF NOT EXISTS `tblyearlevel` (
  `yearlevelcode` varchar(30) NOT NULL,
  `yearlevelname` varchar(30) DEFAULT NULL,
  `yearorder` int(11) DEFAULT NULL,
  `yeargrade` varchar(30) DEFAULT NULL,
  `Implemented` varchar(5) NOT NULL,
  PRIMARY KEY (`yearlevelcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblyearlevel`
--

INSERT INTO `tblyearlevel` (`yearlevelcode`, `yearlevelname`, `yearorder`, `yeargrade`, `Implemented`) VALUES
('GradeI', 'Grade I', 1, 'Grade School', 'True'),
('GradeII', 'Grade II', 2, 'Grade School', 'True'),
('YearI', 'Year I', 1, 'High School', 'True'),
('YearII', 'Year II', 2, 'High School', 'True'),
('YearIII', 'Year III', 3, 'High School', 'True'),
('YearIV', 'Year IV', 4, 'High School', 'True');

-- --------------------------------------------------------

--
-- Table structure for table `tblyearlevelfee`
--

CREATE TABLE IF NOT EXISTS `tblyearlevelfee` (
  `yearlevelcode` varchar(30) DEFAULT NULL,
  `feeid` varchar(30) NOT NULL DEFAULT '',
  `fee_category` varchar(20) NOT NULL,
  `fee_name` varchar(20) DEFAULT NULL,
  `fee_amount` decimal(10,2) NOT NULL,
  `fee_paymentdate` date DEFAULT NULL,
  `schoolyeartype` varchar(7) DEFAULT NULL,
  PRIMARY KEY (`feeid`),
  KEY `schoolyearid` (`schoolyeartype`),
  KEY `yearlevelcode` (`yearlevelcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblyearlevelfee`
--

INSERT INTO `tblyearlevelfee` (`yearlevelcode`, `feeid`, `fee_category`, `fee_name`, `fee_amount`, `fee_paymentdate`, `schoolyeartype`) VALUES
('YearII', 'CFYearII5th PaymentRegular', 'Computer Fee', '5th Payment', '344.60', '2015-02-02', 'Regular'),
('YearII', 'TFYearII5th PaymentRegular', 'Tuition', '5th Payment', '1879.80', '2015-02-02', 'Regular'),
('GradeI', 'CFGradeI4th PaymentRegular', 'Computer Fee', '4th Payment', '200.00', '2015-12-02', 'Regular'),
('GradeI', 'TFGradeI4th PaymentRegular', 'Tuition', '4th Payment', '200.00', '2015-12-02', 'Regular'),
('GradeI', 'TFGradeI3rd PaymentRegular', 'Tuition', '3rd Payment', '200.00', '2015-10-02', 'Regular'),
('GradeI', 'TFGradeI2nd PaymentRegular', 'Tuition', '2nd Payment', '200.00', '2015-08-02', 'Regular'),
('GradeI', 'CFGradeI3rd PaymentRegular', 'Computer Fee', '3rd Payment', '200.00', '2015-10-02', 'Regular'),
('GradeI', 'CFGradeI2nd PaymentRegular', 'Computer Fee', '2nd Payment', '200.00', '2015-08-02', 'Regular'),
('GradeI', 'CFGradeI1st PaymentRegular', 'Computer Fee', '1st Payment', '200.00', '2015-06-02', 'Regular'),
('GradeI', 'TFGradeI1st PaymentRegular', 'Tuition', '1st Payment', '200.00', '2015-06-02', 'Regular'),
('All Grade', 'UC', 'Other Fees', 'Unit Cost', '200.00', '2014-09-01', ''),
('All Grade', 'RF', 'Other Fees', 'Reservation Fee', '200.00', '2014-09-01', ''),
('GradeII', 'GradeIIGeneral FeeRegular', 'Miscellaneous', 'General Fee', '200.00', NULL, 'Regular'),
('GradeII', 'GradeIIRegistration FeeRegular', 'Miscellaneous', 'Registration Fee', '200.00', NULL, 'Regular'),
('GradeI', 'CFGradeI5th PaymentRegular', 'Computer Fee', '5th Payment', '200.00', '2016-02-02', 'Regular'),
('GradeI', 'TFGradeI5th PaymentRegular', 'Tuition', '5th Payment', '200.00', '2016-02-02', 'Regular'),
('GradeII', 'GradeIIBooksRegular', 'Other Fees', 'Books', '200.00', NULL, 'Regular'),
('GradeII', 'CFGradeII1st PaymentRegular', 'Computer Fee', '1st Payment', '200.00', '2014-06-02', 'Regular'),
('GradeII', 'TFGradeII1st PaymentRegular', 'Tuition', '1st Payment', '200.00', '2014-06-02', 'Regular'),
('GradeII', 'CFGradeII2nd PaymentRegular', 'Computer Fee', '2nd Payment', '200.00', '2014-08-02', 'Regular'),
('GradeII', 'TFGradeII2nd PaymentRegular', 'Tuition', '2nd Payment', '200.00', '2014-08-02', 'Regular'),
('GradeII', 'CFGradeII3rd PaymentRegular', 'Computer Fee', '3rd Payment', '200.00', '2014-10-02', 'Regular'),
('GradeII', 'TFGradeII3rd PaymentRegular', 'Tuition', '3rd Payment', '200.00', '2014-10-02', 'Regular'),
('GradeII', 'CFGradeII4th PaymentRegular', 'Computer Fee', '4th Payment', '200.00', '2014-12-02', 'Regular'),
('GradeII', 'TFGradeII4th PaymentRegular', 'Tuition', '4th Payment', '200.00', '2014-12-02', 'Regular'),
('GradeII', 'CFGradeII5th PaymentRegular', 'Computer Fee', '5th Payment', '200.00', '2015-02-02', 'Regular'),
('GradeII', 'TFGradeII5th PaymentRegular', 'Tuition', '5th Payment', '200.00', '2015-02-02', 'Regular'),
('YearI', 'YearIGeneral FeeRegular', 'Miscellaneous', 'General Fee', '3823.00', NULL, 'Regular'),
('YearI', 'YearIRegistration FeeRegular', 'Miscellaneous', 'Registration Fee', '940.00', NULL, 'Regular'),
('YearI', 'TFYearI2nd PaymentRegular', 'Tuition', '2nd Payment', '1879.80', '2014-08-02', 'Regular'),
('YearI', 'CFYearI3rd PaymentRegular', 'Computer Fee', '3rd Payment', '344.60', '2014-10-02', 'Regular'),
('YearI', 'TFYearI3rd PaymentRegular', 'Tuition', '3rd Payment', '1879.80', '2014-10-02', 'Regular'),
('YearI', 'CFYearI4th PaymentRegular', 'Computer Fee', '4th Payment', '344.60', '2014-12-02', 'Regular'),
('YearI', 'TFYearI4th PaymentRegular', 'Tuition', '4th Payment', '1879.80', '2014-12-02', 'Regular'),
('YearI', 'CFYearI5th PaymentRegular', 'Computer Fee', '5th Payment', '344.60', '2015-02-02', 'Regular'),
('YearI', 'TFYearI5th PaymentRegular', 'Tuition', '5th Payment', '1879.80', '2015-02-02', 'Regular'),
('YearI', 'CFYearI2nd PaymentRegular', 'Computer Fee', '2nd Payment', '344.60', '2014-08-02', 'Regular'),
('YearII', 'YearIIGeneral FeeRegular', 'Miscellaneous', 'General Fee', '3823.00', NULL, 'Regular'),
('YearII', 'CFYearII4th PaymentRegular', 'Computer Fee', '4th Payment', '344.60', '2014-12-02', 'Regular'),
('YearII', 'TFYearII4th PaymentRegular', 'Tuition', '4th Payment', '1879.80', '2014-12-02', 'Regular'),
('YearII', 'TFYearII3rd PaymentRegular', 'Tuition', '3rd Payment', '1879.80', '2014-10-02', 'Regular'),
('YearII', 'TFYearII2nd PaymentRegular', 'Tuition', '2nd Payment', '1879.80', '2014-08-02', 'Regular'),
('YearII', 'CFYearII3rd PaymentRegular', 'Computer Fee', '3rd Payment', '344.60', '2014-10-02', 'Regular'),
('YearII', 'CFYearII2nd PaymentRegular', 'Computer Fee', '2nd Payment', '344.60', '2014-08-02', 'Regular'),
('YearII', 'CFYearII1st PaymentRegular', 'Computer Fee', '1st Payment', '344.60', '2014-06-02', 'Regular'),
('YearII', 'TFYearII1st PaymentRegular', 'Tuition', '1st Payment', '1879.80', '2014-06-02', 'Regular'),
('YearII', 'YearIIRegistration FeeRegular', 'Miscellaneous', 'Registration Fee', '940.00', NULL, 'Regular'),
('YearI', 'YearIMath BookRegular', 'Other Fees', 'Math Book', '700.00', NULL, 'Regular'),
('YearI', 'CFYearI1st PaymentRegular', 'Computer Fee', '1st Payment', '344.60', '2014-06-02', 'Regular'),
('YearI', 'TFYearI1st PaymentRegular', 'Tuition', '1st Payment', '1879.80', '2014-06-02', 'Regular'),
('YearII', 'YearIIAP BookRegular', 'Other Fees', 'AP Book', '617.00', NULL, 'Regular'),
('YearI', 'YearIHome WorkEd BookRegular', 'Other Fees', 'Home WorkEd Book', '500.00', NULL, 'Regular'),
('YearI', 'YearIEnglish BookRegular', 'Other Fees', 'English Book', '660.00', NULL, 'Regular'),
('YearI', 'YearIScience BookRegular', 'Other Fees', 'Science Book', '757.00', NULL, 'Regular'),
('YearI', 'YearIFilipino BookRegular', 'Other Fees', 'Filipino Book', '540.00', NULL, 'Regular'),
('YearI', 'YearIAP BookRegular', 'Other Fees', 'AP Book', '617.00', NULL, 'Regular'),
('YearI', 'YearIPE BookRegular', 'Other Fees', 'PE Book', '446.00', NULL, 'Regular'),
('YearI', 'YearIComputer BookRegular', 'Other Fees', 'Computer Book', '280.00', NULL, 'Regular'),
('YearII', 'YearIIMath BookRegular', 'Other Fees', 'Math Book', '700.00', NULL, 'Regular'),
('YearII', 'YearIIHome WorkEd BookRegular', 'Other Fees', 'Home WorkEd Book', '500.00', NULL, 'Regular'),
('YearII', 'YearIIEnglish BookRegular', 'Other Fees', 'English Book', '660.00', NULL, 'Regular'),
('YearII', 'YearIIScience BookRegular', 'Other Fees', 'Science Book', '757.00', NULL, 'Regular'),
('YearII', 'YearIIFilipino BookRegular', 'Other Fees', 'Filipino Book', '540.00', NULL, 'Regular'),
('YearII', 'YearIIPE BookRegular', 'Other Fees', 'PE Book', '446.00', NULL, 'Regular'),
('YearII', 'YearIIComputer BookRegular', 'Other Fees', 'Computer Book', '280.00', NULL, 'Regular'),
('YearIII', 'YearIIIGeneral FeeRegular', 'Miscellaneous', 'General Fee', '3823.00', NULL, 'Regular'),
('YearIII', 'YearIIIRegistration FeeRegular', 'Miscellaneous', 'Registration Fee', '940.00', NULL, 'Regular'),
('YearIII', 'CFYearIII1st PaymentRegular', 'Computer Fee', '1st Payment', '344.60', '2014-06-02', 'Regular'),
('YearIII', 'TFYearIII1st PaymentRegular', 'Tuition', '1st Payment', '1879.80', '2014-06-02', 'Regular'),
('YearIII', 'CFYearIII2nd PaymentRegular', 'Computer Fee', '2nd Payment', '344.60', '2014-08-02', 'Regular'),
('YearIII', 'TFYearIII2nd PaymentRegular', 'Tuition', '2nd Payment', '1879.80', '2014-08-02', 'Regular'),
('YearIII', 'CFYearIII3rd PaymentRegular', 'Computer Fee', '3rd Payment', '344.60', '2014-10-02', 'Regular'),
('YearIII', 'TFYearIII3rd PaymentRegular', 'Tuition', '3rd Payment', '1879.80', '2014-10-02', 'Regular'),
('YearIII', 'CFYearIII4th PaymentRegular', 'Computer Fee', '4th Payment', '344.60', '2014-12-02', 'Regular'),
('YearIII', 'TFYearIII4th PaymentRegular', 'Tuition', '4th Payment', '1879.80', '2014-12-02', 'Regular'),
('YearIII', 'CFYearIII5th PaymentRegular', 'Computer Fee', '5th Payment', '344.60', '2015-02-02', 'Regular'),
('YearIII', 'TFYearIII5th PaymentRegular', 'Tuition', '5th Payment', '1879.80', '2015-02-02', 'Regular'),
('YearIII', 'YearIIIMath BookRegular', 'Other Fees', 'Math Book', '700.00', NULL, 'Regular'),
('YearIII', 'YearIIIHome WorkEd BookRegular', 'Other Fees', 'Home WorkEd Book', '500.00', NULL, 'Regular'),
('YearIII', 'YearIIIEnglish BookRegular', 'Other Fees', 'English Book', '660.00', NULL, 'Regular'),
('YearIII', 'YearIIIScience BookRegular', 'Other Fees', 'Science Book', '757.00', NULL, 'Regular'),
('YearIII', 'YearIIIFilipino BookRegular', 'Other Fees', 'Filipino Book', '540.00', NULL, 'Regular'),
('YearIII', 'YearIIIAP BookRegular', 'Other Fees', 'AP Book', '617.00', NULL, 'Regular'),
('YearIII', 'YearIIIPE BookRegular', 'Other Fees', 'PE Book', '446.00', NULL, 'Regular'),
('YearIII', 'YearIIIComputer BookRegular', 'Other Fees', 'Computer Book', '280.00', NULL, 'Regular');

-- --------------------------------------------------------

--
-- Table structure for table `tblyearlevelschedule`
--

CREATE TABLE IF NOT EXISTS `tblyearlevelschedule` (
  `yearlevelschedulekey` varchar(35) NOT NULL,
  `yearlevelsectioncode` varchar(40) DEFAULT NULL,
  `sched_day` varchar(10) NOT NULL,
  `sched_starttime` time NOT NULL,
  `sched_endtime` time NOT NULL,
  `roomno` varchar(15) DEFAULT NULL,
  `subjectcode` varchar(30) DEFAULT NULL,
  `teacherid` varchar(25) DEFAULT NULL,
  `schoolyeartype` varchar(7) DEFAULT NULL,
  `schedorder` int(11) NOT NULL,
  PRIMARY KEY (`yearlevelschedulekey`),
  KEY `schoolyearid` (`schoolyeartype`),
  KEY `yearlevelsectioncode` (`yearlevelsectioncode`),
  KEY `roomno` (`roomno`),
  KEY `subjectcode` (`subjectcode`),
  KEY `teacherid` (`teacherid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblyearlevelschedule`
--

INSERT INTO `tblyearlevelschedule` (`yearlevelschedulekey`, `yearlevelsectioncode`, `sched_day`, `sched_starttime`, `sched_endtime`, `roomno`, `subjectcode`, `teacherid`, `schoolyeartype`, `schedorder`) VALUES
('Grade IAEnglishGrade IRegularM', 'Grade IA', 'M', '09:00:00', '10:00:00', '1', 'EnglishGrade I', '2014-T001', 'Regular', 1),
('Grade IAFilipinoGrade IRegularM', 'Grade IA', 'M', '08:00:00', '09:00:00', '1', 'FilipinoGrade I', '2014-T001', 'Regular', 1),
('Grade IAMathGrade IRegularM', 'Grade IA', 'M', '10:00:00', '11:00:00', '1', 'MathGrade I', '2014-T001', 'Regular', 1),
('Grade IAEnglishGrade IRegularT', 'Grade IA', 'T', '07:00:00', '08:00:00', '1', 'EnglishGrade I', '2014-T001', 'Regular', 2),
('Grade IAFilipinoGrade IRegularT', 'Grade IA', 'T', '08:00:00', '09:00:00', '1', 'FilipinoGrade I', '2014-T001', 'Regular', 2),
('Grade IAMathGrade IRegularT', 'Grade IA', 'T', '09:00:00', '10:00:00', '1', 'MathGrade I', '2014-T001', 'Regular', 2),
('Year IAEnglishYear IRegularM', 'Year IA', 'M', '10:15:00', '11:15:00', '1', 'EnglishYear I', '2014-T001', 'Regular', 1),
('Year IAMathYear IRegularM', 'Year IA', 'M', '08:00:00', '09:00:00', '1', 'MathYear I', '2014-T001', 'Regular', 1),
('Year IIAEnglishYear IIRegularM', 'Year IIA', 'M', '14:00:00', '15:00:00', '1', 'EnglishYear II', '2014-T001', 'Regular', 1),
('Year IIAMathYear IIRegularM', 'Year IIA', 'M', '10:15:00', '11:15:00', '1', 'MathYear II', '2014-T001', 'Regular', 1),
('Year IAScienceYear IRegularM', 'Year IA', 'M', '11:15:00', '12:15:00', '1', 'ScienceYear I', '2014-T001', 'Regular', 1),
('Year IABibleYear IRegularM', 'Year IA', 'M', '07:05:00', '08:00:00', '2', 'BibleYear I', '2015-T002', 'Regular', 1),
('Year IATLEYear IRegularM', 'Year IA', 'M', '09:00:00', '10:00:00', '2', 'TLEYear I', '2015-T002', 'Regular', 1),
('Year IAFilipinoYear IRegularM', 'Year IA', 'M', '12:15:00', '13:00:00', '2', 'FilipinoYear I', '2015-T002', 'Regular', 1),
('Year IAMapehYear IRegularM', 'Year IA', 'M', '13:00:00', '14:00:00', '2', 'MapehYear I', '2015-T002', 'Regular', 1),
('Year IAAraling PanlipunanYear IRegu', 'Year IA', 'M', '14:00:00', '15:00:00', '2', 'Araling PanlipunanYear I', '2015-T002', 'Regular', 1),
('Year IAPEYear IRegularM', 'Year IA', 'M', '15:00:00', '16:00:00', '2', 'PEYear I', '2015-T002', 'Regular', 1),
('Year IABibleYear IRegularT', 'Year IA', 'T', '07:05:00', '08:00:00', '2', 'BibleYear I', '2015-T002', 'Regular', 2),
('Year IAMathYear IRegularT', 'Year IA', 'T', '08:00:00', '09:00:00', '2', 'MathYear I', '2015-T002', 'Regular', 2),
('Year IATLEYear IRegularT', 'Year IA', 'T', '09:00:00', '10:00:00', '2', 'TLEYear I', '2015-T002', 'Regular', 2),
('Year IAEnglishYear IRegularT', 'Year IA', 'T', '10:15:00', '11:15:00', '1', 'EnglishYear I', '2014-T001', 'Regular', 2),
('Year IAScienceYear IRegularT', 'Year IA', 'T', '11:15:00', '12:15:00', '1', 'ScienceYear I', '2014-T001', 'Regular', 2),
('Year IAFilipinoYear IRegularT', 'Year IA', 'T', '12:15:00', '13:00:00', '2', 'FilipinoYear I', '2015-T002', 'Regular', 2),
('Year IAMapehYear IRegularT', 'Year IA', 'T', '13:00:00', '14:00:00', '2', 'MapehYear I', '2015-T002', 'Regular', 2),
('Year IAPEYear IRegularT', 'Year IA', 'T', '15:00:00', '16:00:00', '2', 'PEYear I', '2015-T002', 'Regular', 2),
('Year IABibleYear IRegularW', 'Year IA', 'W', '07:05:00', '08:00:00', '2', 'BibleYear I', '2015-T002', 'Regular', 3),
('Year IAMathYear IRegularW', 'Year IA', 'W', '08:00:00', '09:00:00', '2', 'MathYear I', '2015-T002', 'Regular', 3),
('Year IATLEYear IRegularW', 'Year IA', 'W', '09:00:00', '10:00:00', '2', 'TLEYear I', '2015-T002', 'Regular', 3),
('Year IAEnglishYear IRegularW', 'Year IA', 'W', '10:15:00', '11:15:00', '1', 'EnglishYear I', '2014-T001', 'Regular', 3),
('Year IAScienceYear IRegularW', 'Year IA', 'W', '11:15:00', '12:15:00', '1', 'ScienceYear I', '2014-T001', 'Regular', 3),
('Year IAFilipinoYear IRegularW', 'Year IA', 'W', '12:15:00', '13:00:00', '2', 'FilipinoYear I', '2015-T002', 'Regular', 3),
('Year IAMapehYear IRegularW', 'Year IA', 'W', '13:00:00', '14:00:00', '2', 'MapehYear I', '2015-T002', 'Regular', 3),
('Year IAPEYear IRegularW', 'Year IA', 'W', '15:00:00', '16:00:00', '2', 'PEYear I', '2015-T002', 'Regular', 3),
('Year IABibleYear IRegularTH', 'Year IA', 'TH', '07:05:00', '08:00:00', '2', 'BibleYear I', '2015-T002', 'Regular', 4),
('Year IAMathYear IRegularTH', 'Year IA', 'TH', '08:00:00', '09:00:00', '2', 'MathYear I', '2015-T002', 'Regular', 4),
('Year IATLEYear IRegularTH', 'Year IA', 'TH', '09:00:00', '10:00:00', '2', 'TLEYear I', '2015-T002', 'Regular', 4),
('Year IAEnglishYear IRegularTH', 'Year IA', 'TH', '10:15:00', '11:15:00', '1', 'EnglishYear I', '2014-T001', 'Regular', 4),
('Year IAScienceYear IRegularTH', 'Year IA', 'TH', '11:15:00', '12:15:00', '1', 'ScienceYear I', '2014-T001', 'Regular', 4),
('Year IAFilipinoYear IRegularTH', 'Year IA', 'TH', '12:15:00', '13:00:00', '2', 'FilipinoYear I', '2015-T002', 'Regular', 4),
('Year IAMapehYear IRegularTH', 'Year IA', 'TH', '13:00:00', '14:00:00', '2', 'MapehYear I', '2015-T002', 'Regular', 4),
('Year IAPEYear IRegularTH', 'Year IA', 'TH', '15:00:00', '16:00:00', '2', 'PEYear I', '2015-T002', 'Regular', 4),
('Year IABibleYear IRegularF', 'Year IA', 'F', '07:05:00', '08:00:00', '2', 'BibleYear I', '2015-T002', 'Regular', 5),
('Year IAMathYear IRegularF', 'Year IA', 'F', '08:00:00', '09:00:00', '2', 'MathYear I', '2015-T002', 'Regular', 5),
('Year IATLEYear IRegularF', 'Year IA', 'F', '09:00:00', '10:00:00', '2', 'TLEYear I', '2015-T002', 'Regular', 5),
('Year IAEnglishYear IRegularF', 'Year IA', 'F', '10:15:00', '11:15:00', '1', 'EnglishYear I', '2014-T001', 'Regular', 5),
('Year IAScienceYear IRegularF', 'Year IA', 'F', '11:15:00', '12:15:00', '1', 'ScienceYear I', '2014-T001', 'Regular', 5),
('Year IAFilipinoYear IRegularF', 'Year IA', 'F', '12:15:00', '13:00:00', '2', 'FilipinoYear I', '2015-T002', 'Regular', 5),
('Year IAMapehYear IRegularF', 'Year IA', 'F', '13:00:00', '14:00:00', '2', 'MapehYear I', '2015-T002', 'Regular', 5),
('Year IAPEYear IRegularF', 'Year IA', 'F', '15:00:00', '16:00:00', '2', 'PEYear I', '2015-T002', 'Regular', 5),
('Year IIAAraling PanlipunanYear IIRe', 'Year IIA', 'M', '07:05:00', '08:00:00', '3', 'Araling PanlipunanYear II', '2015-T003', 'Regular', 1),
('Year IIAScienceYear IIRegularM', 'Year IIA', 'M', '08:00:00', '09:00:00', '3', 'ScienceYear II', '2015-T003', 'Regular', 1),
('Year IIAFilipinoYear IIRegularM', 'Year IIA', 'M', '09:00:00', '10:00:00', '3', 'FilipinoYear II', '2015-T003', 'Regular', 1),
('Year IIATLEYear IIRegularM', 'Year IIA', 'M', '11:15:00', '12:15:00', '3', 'TLEYear II', '2015-T003', 'Regular', 1),
('Year IIAMapehYear IIRegularM', 'Year IIA', 'M', '12:15:00', '13:00:00', '3', 'MapehYear II', '2015-T003', 'Regular', 1),
('Year IIABibleYear IIRegularM', 'Year IIA', 'M', '13:00:00', '14:00:00', '3', 'BibleYear II', '2015-T003', 'Regular', 1),
('Year IIAPEYear IIRegularM', 'Year IIA', 'M', '15:00:00', '16:00:00', '3', 'PEYear II', '2015-T003', 'Regular', 1),
('Year IIAScienceYear IIRegularT', 'Year IIA', 'T', '08:00:00', '09:00:00', '3', 'ScienceYear II', '2015-T003', 'Regular', 2),
('Year IIAFilipinoYear IIRegularT', 'Year IIA', 'T', '09:00:00', '10:00:00', '3', 'FilipinoYear II', '2015-T003', 'Regular', 2),
('Year IIAMathYear IIRegularT', 'Year IIA', 'T', '10:15:00', '11:15:00', '3', 'MathYear II', '2015-T003', 'Regular', 2),
('Year IIATLEYear IIRegularT', 'Year IIA', 'T', '11:15:00', '12:15:00', '3', 'TLEYear II', '2015-T003', 'Regular', 2),
('Year IIAMapehYear IIRegularT', 'Year IIA', 'T', '12:15:00', '13:00:00', '3', 'MapehYear II', '2015-T003', 'Regular', 2),
('Year IIABibleYear IIRegularT', 'Year IIA', 'T', '13:00:00', '14:00:00', '3', 'BibleYear II', '2015-T003', 'Regular', 2),
('Year IIAEnglishYear IIRegularT', 'Year IIA', 'T', '14:00:00', '15:00:00', '3', 'EnglishYear II', '2015-T003', 'Regular', 2),
('Year IIAPEYear IIRegularT', 'Year IIA', 'T', '15:00:00', '16:00:00', '3', 'PEYear II', '2015-T003', 'Regular', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tblyearlevelsections`
--

CREATE TABLE IF NOT EXISTS `tblyearlevelsections` (
  `yearlevelsectioncode` varchar(40) NOT NULL,
  `yearlevelcode` varchar(30) DEFAULT NULL,
  `sectioncode` varchar(30) DEFAULT NULL,
  `sectionorder` int(11) DEFAULT NULL,
  `sectionmaximum` int(11) DEFAULT NULL,
  `adviserid` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`yearlevelsectioncode`),
  KEY `yearlevelcode` (`yearlevelcode`),
  KEY `sectioncode` (`sectioncode`),
  KEY `teacherid` (`adviserid`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblyearlevelsections`
--

INSERT INTO `tblyearlevelsections` (`yearlevelsectioncode`, `yearlevelcode`, `sectioncode`, `sectionorder`, `sectionmaximum`, `adviserid`) VALUES
('Grade IA', 'GradeI', 'A', 0, 3, NULL),
('Grade IB', 'GradeI', 'B', 1, 2, NULL),
('Year IIA', 'YearII', 'A', 0, 7, NULL),
('Year IA', 'YearI', 'A', 0, 6, NULL),
('Year IVA', 'YearIV', 'A', 0, 5, NULL),
('Year IIIA', 'YearIII', 'A', 0, 3, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblyearlevelsubjects`
--

CREATE TABLE IF NOT EXISTS `tblyearlevelsubjects` (
  `yearlevelcode` varchar(30) DEFAULT NULL,
  `subjectcode` varchar(30) DEFAULT NULL,
  KEY `yearlevelcode` (`yearlevelcode`),
  KEY `subjectcode` (`subjectcode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblyearlevelsubjects`
--

INSERT INTO `tblyearlevelsubjects` (`yearlevelcode`, `subjectcode`) VALUES
('GradeI', 'MathGrade I'),
('GradeI', 'EnglishGrade I'),
('GradeI', 'FilipinoGrade I'),
('YearII', 'MathYear II'),
('YearII', 'EnglishYear II'),
('YearI', 'MathYear I'),
('YearI', 'EnglishYear I'),
('YearI', 'ScienceYear I'),
('YearI', 'FilipinoYear I'),
('YearI', 'Araling PanlipunanYear I'),
('YearI', 'BibleYear I'),
('YearI', 'PEYear I'),
('YearII', 'PEYear II'),
('YearI', 'TLEYear I'),
('YearI', 'MapehYear I'),
('YearII', 'FilipinoYear II'),
('YearII', 'ScienceYear II'),
('YearII', 'Araling PanlipunanYear II'),
('YearII', 'BibleYear II'),
('YearII', 'TLEYear II'),
('YearII', 'MapehYear II'),
('YearIII', 'FilipinoYear III'),
('YearIII', 'EnglishYear III'),
('YearIII', 'MathYear III'),
('YearIII', 'ScienceYear III'),
('YearIII', 'Araling PanlipunanYear III'),
('YearIII', 'TLEYear III'),
('YearIII', 'MapehYear III'),
('YearIII', 'BibleYear III');

-- --------------------------------------------------------

--
-- Table structure for table `useraccess`
--

CREATE TABLE IF NOT EXISTS `useraccess` (
  `usertype` varchar(20) NOT NULL,
  `schoolyearviewing` varchar(5) NOT NULL,
  `schoolyearediting` varchar(5) NOT NULL,
  `maintainanceyear` varchar(5) NOT NULL,
  `maintainancefees` varchar(5) NOT NULL,
  `maintainancetr` varchar(5) NOT NULL,
  `maintainancewebsite` varchar(5) NOT NULL,
  `transactionsregistration` varchar(5) NOT NULL,
  `transactionsassessment` varchar(5) NOT NULL,
  `transactionspayment` varchar(5) NOT NULL,
  `transactionsrecord` varchar(5) NOT NULL,
  `manageclass` varchar(5) NOT NULL,
  `managegrades` varchar(5) NOT NULL,
  `managereservedstudent` varchar(5) NOT NULL,
  `manageaccount` varchar(5) NOT NULL,
  `backuprestore` varchar(5) NOT NULL,
  `userslimit` varchar(5) NOT NULL,
  PRIMARY KEY (`usertype`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `useraccess`
--

INSERT INTO `useraccess` (`usertype`, `schoolyearviewing`, `schoolyearediting`, `maintainanceyear`, `maintainancefees`, `maintainancetr`, `maintainancewebsite`, `transactionsregistration`, `transactionsassessment`, `transactionspayment`, `transactionsrecord`, `manageclass`, `managegrades`, `managereservedstudent`, `manageaccount`, `backuprestore`, `userslimit`) VALUES
('Cashier', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', 'True', '1');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
