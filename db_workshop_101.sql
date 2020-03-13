-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 07, 2019 at 08:43 PM
-- Server version: 10.3.15-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_workshop_101`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `Category _ID` varchar(10) NOT NULL,
  `Category _Name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`Category _ID`, `Category _Name`) VALUES
('CT00000001', 'กระยาสารทเล็ก'),
('CT00000002', 'กระยาสารทกลาง'),
('CT00000003', 'กระยาสารทใหญ่');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `Customer_ID` varchar(10) NOT NULL,
  `Customer_Name` varchar(20) NOT NULL,
  `Customer_Address` varchar(100) NOT NULL,
  `Customer_Tel` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`Customer_ID`, `Customer_Name`, `Customer_Address`, `Customer_Tel`) VALUES
('CS00000001', 'นายดำ ขำขัน', '23 ม.2 ตำบลในเมือง อำเภอเมือง จังหวัดนครราชสีมา 30000', '0876453279'),
('CS00000002', 'นางวาริดา นารา', '23 ม.2 ตำบลในเมือง อำเภอเมือง จังหวัดนครราชสีมา 30000', '0983456478');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_order`
--

CREATE TABLE `tbl_order` (
  `Order_ID` varchar(10) NOT NULL,
  `Order_Date` datetime NOT NULL,
  `Order_Place` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ordering`
--

CREATE TABLE `tbl_ordering` (
  `Order_ID` varchar(10) NOT NULL,
  `Ordering_Total` int(11) NOT NULL,
  `Product_ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `Product _ID` varchar(10) NOT NULL,
  `Product _Name` varchar(50) NOT NULL,
  `Product_Sprice` double NOT NULL,
  `Category _ID` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`Product _ID`, `Product _Name`, `Product_Sprice`, `Category _ID`) VALUES
('PD00000001', 'ขนมกระยาสารท สีม่วง', 25, 'CT00000001'),
('PD00000002', 'ขนมกระยาสารท สีม่วง', 35, 'CT00000002'),
('PD00000003', 'ขนมกระยาสารท สีม่วง', 45, 'CT00000003');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saleproduct`
--

CREATE TABLE `tbl_saleproduct` (
  `Saleslip_ID` varchar(10) NOT NULL,
  `Customer_ID` varchar(10) NOT NULL,
  `SalesDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_saleproduct`
--

INSERT INTO `tbl_saleproduct` (`Saleslip_ID`, `Customer_ID`, `SalesDate`) VALUES
('SL00000001', 'CS00000001', '2019-06-04 06:12:06');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_saleslip`
--

CREATE TABLE `tbl_saleslip` (
  `Saleslip _ID` varchar(10) NOT NULL,
  `Saleslip _Income` double NOT NULL,
  `Saleslip_Total` int(11) NOT NULL,
  `Product_ID` varchar(10) NOT NULL,
  `Saleslip_Change` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_saleslip`
--

INSERT INTO `tbl_saleslip` (`Saleslip _ID`, `Saleslip _Income`, `Saleslip_Total`, `Product_ID`, `Saleslip_Change`) VALUES
('SL00000001', 300, 10, 'PD00000001', 50);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_userauthen`
--

CREATE TABLE `tbl_userauthen` (
  `user_name` varchar(10) NOT NULL,
  `user_password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tbl_userauthen`
--

INSERT INTO `tbl_userauthen` (`user_name`, `user_password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`Category _ID`);

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`Customer_ID`);

--
-- Indexes for table `tbl_order`
--
ALTER TABLE `tbl_order`
  ADD PRIMARY KEY (`Order_ID`);

--
-- Indexes for table `tbl_ordering`
--
ALTER TABLE `tbl_ordering`
  ADD PRIMARY KEY (`Order_ID`),
  ADD KEY `Order_ID` (`Order_ID`),
  ADD KEY `Product_ID` (`Product_ID`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`Product _ID`),
  ADD KEY `Category _ID` (`Category _ID`),
  ADD KEY `Category _ID_2` (`Category _ID`);

--
-- Indexes for table `tbl_saleproduct`
--
ALTER TABLE `tbl_saleproduct`
  ADD PRIMARY KEY (`Saleslip_ID`),
  ADD KEY `Customer_ID` (`Customer_ID`);

--
-- Indexes for table `tbl_saleslip`
--
ALTER TABLE `tbl_saleslip`
  ADD PRIMARY KEY (`Saleslip _ID`),
  ADD KEY `Saleslip _ID` (`Saleslip _ID`),
  ADD KEY `Product_ID` (`Product_ID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_ordering`
--
ALTER TABLE `tbl_ordering`
  ADD CONSTRAINT `tbl_ordering_ibfk_1` FOREIGN KEY (`Order_ID`) REFERENCES `tbl_order` (`Order_ID`),
  ADD CONSTRAINT `tbl_ordering_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `tbl_product` (`Product _ID`);

--
-- Constraints for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD CONSTRAINT `tbl_product_ibfk_1` FOREIGN KEY (`Category _ID`) REFERENCES `tbl_category` (`Category _ID`);

--
-- Constraints for table `tbl_saleproduct`
--
ALTER TABLE `tbl_saleproduct`
  ADD CONSTRAINT `tbl_saleproduct_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `tbl_customer` (`Customer_ID`);

--
-- Constraints for table `tbl_saleslip`
--
ALTER TABLE `tbl_saleslip`
  ADD CONSTRAINT `tbl_saleslip_ibfk_1` FOREIGN KEY (`Saleslip _ID`) REFERENCES `tbl_saleproduct` (`Saleslip_ID`),
  ADD CONSTRAINT `tbl_saleslip_ibfk_2` FOREIGN KEY (`Product_ID`) REFERENCES `tbl_product` (`Product _ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
