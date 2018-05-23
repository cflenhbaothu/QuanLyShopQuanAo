-- phpMyAdmin SQL Dump
-- version 4.8.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 23, 2018 at 04:31 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 5.6.35

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `webphukiendt`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `idadmin` int(11) NOT NULL,
  `username` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `password` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`idadmin`, `username`, `password`) VALUES
(1, 'admin', 'thuongdeptrai');

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `id` int(11) NOT NULL,
  `fullname` varchar(11) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `createdate` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `cart`
--

INSERT INTO `cart` (`id`, `fullname`, `createdate`) VALUES
(1, '0', '2017-04-28 16:49:42'),
(2, '0', '2017-04-28 16:51:15'),
(3, '0', '2017-04-28 16:53:53'),
(4, 'Hiáº¿u', '2017-04-28 16:54:34'),
(5, 'Hiáº¿u', '2017-04-29 02:12:53'),
(6, 'Hiáº¿u', '2017-05-01 06:58:25'),
(7, 'Hiáº¿u', '2017-05-01 10:16:28'),
(8, 'Hiáº¿u', '2017-05-01 10:17:28'),
(9, 'Hiáº¿u', '2017-05-01 11:15:23'),
(10, 'admin', '2017-05-01 11:42:20'),
(11, 'admin', '2017-05-01 11:45:21'),
(12, 'admin', '2017-05-03 14:20:16'),
(13, 'admin', '2017-05-04 02:53:38'),
(14, 'admin', '2018-05-14 02:49:35'),
(15, 'phuocthuong', '2018-05-14 02:51:33');

-- --------------------------------------------------------

--
-- Table structure for table `cart_detail`
--

CREATE TABLE `cart_detail` (
  `id` int(11) NOT NULL,
  `cart_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL DEFAULT '1',
  `quantity` int(11) NOT NULL,
  `price` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `cart_detail`
--

INSERT INTO `cart_detail` (`id`, `cart_id`, `product_id`, `quantity`, `price`) VALUES
(1, 1, 62, 0, '0'),
(2, 2, 60, 1, '50'),
(3, 2, 61, 1, '50'),
(4, 3, 45, 5, '60'),
(5, 4, 39, 1, '50'),
(6, 5, 62, 1, '50'),
(7, 6, 38, 1, '50'),
(8, 6, 39, 1, '50'),
(9, 6, 45, 1, '60'),
(10, 7, 40, 1, '50'),
(11, 7, 48, 1, '60'),
(12, 8, 48, 1, '60,000'),
(13, 9, 84, 7, '199000'),
(14, 10, 81, 5, '1290000'),
(15, 10, 79, 3, '1990000'),
(16, 10, 65, 1, '199'),
(17, 11, 83, 3, '199000'),
(18, 12, 86, 1, '27000000'),
(19, 12, 67, 8, '249900'),
(20, 12, 85, 1, '12000000'),
(21, 12, 72, 1, '40000'),
(22, 13, 86, 3, '27000000'),
(23, 13, 84, 1, '199000'),
(24, 14, 1, 15, '150000'),
(25, 15, 2, 1, '175000');

-- --------------------------------------------------------

--
-- Table structure for table `dangky`
--

CREATE TABLE `dangky` (
  `id_khachhang` int(11) NOT NULL,
  `tenkhachhang` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `email` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `matkhau` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `dienthoai` int(11) NOT NULL,
  `diachinhan` varchar(200) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `dangky`
--

INSERT INTO `dangky` (`id_khachhang`, `tenkhachhang`, `email`, `matkhau`, `dienthoai`, `diachinhan`) VALUES
(33, 'Hiáº¿u', 'admin', 'doimatkhau', 3, '3'),
(34, 'Hiáº¿u', 'admin', 'doimatkhau', 3, '3'),
(35, 'Hiáº¿u', 'admin', 'doimatkhau', 3, '3'),
(36, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(37, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(38, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(39, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(40, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(41, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 909090909, '2'),
(42, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 909090909, '2'),
(43, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 909090909, '2'),
(44, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(45, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(46, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(47, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(48, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(49, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(50, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(51, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(52, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(53, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(54, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(55, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 5435, '5'),
(56, 'TrÆ°Æ¡ng Ngá»c Táº¥n Hiáº¿u', 'admin', 'doimatkhau', 1222, '1'),
(57, '', 'admin', 'doimatkhau', 0, ''),
(58, 'Nguyen Phuoc Thuong', 'phuocthuong1213@gmail.com', '123456', 2147483647, 'xuan loc'),
(59, 'Quang Tá»¥ng', 'the.sad.songs96@gmail.com', '123', 123456789, 'abc'),
(60, 'Quang Tá»¥ng', 'the.sad.songs96@gmail.com', '123', 123456789, 'abc'),
(61, 'qung tung', 'the.sad.songs96@gmail.com', 'qunagtung96', 12345678, 'ajdnakj');

-- --------------------------------------------------------

--
-- Table structure for table `gallery`
--

CREATE TABLE `gallery` (
  `id_gallery` int(11) NOT NULL,
  `id_sp` int(11) NOT NULL,
  `hinhanhsp` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `gallery`
--

INSERT INTO `gallery` (`id_gallery`, `id_sp`, `hinhanhsp`) VALUES
(23, 60, 'featured-section-new-to-imac_2x1493467732.jpg'),
(24, 60, 'image0011493467732.png'),
(25, 60, 'image001_21493467732.jpg'),
(26, 60, 'image001_111493467732.jpg'),
(29, 63, '5190001_sa (1) - Copy1493468586.jpg'),
(30, 63, '5190001_sa (1)1493468586.jpg'),
(31, 63, '1466960633738_19141493468586.jpg'),
(32, 63, '1466960633738_19141493468706.jpg'),
(33, 63, 'featured-section-new-to-imac_2x1493468926.jpg'),
(34, 63, '5190001_sa (1) - Copy1493469597.jpg'),
(38, 61, '1466960639886_19201493470147.jpg'),
(43, 62, '5190001_sa (1) - Copy1493471267.jpg'),
(44, 62, '5190001_sa (1)1493471267.jpg'),
(45, 62, 'featured-section-new-to-imac_2x1493471267.jpg'),
(46, 51, '5190001_sa (1) - Copy1493612642.jpg'),
(47, 51, '5190001_sa (1)1493612643.jpg'),
(48, 45, '5190001_sa (1) - Copy1493616068.jpg'),
(49, 45, '5190001_sa (1)1493616068.jpg'),
(50, 45, '1466960633738_19141493616068.jpg'),
(51, 85, '2-a89056cf-a3ca-4d58-952e-5dcfaaae8d8b1493695704.jpg'),
(52, 85, '3-4a620da2-d3d1-46b3-82b7-6522066a48ed1493695704.jpg'),
(53, 85, 'canon-eos-1d-x-1-1-min1493695704.jpg'),
(54, 85, 'canon-eos-1d-x-2-1-min1493695704.jpg'),
(55, 86, '2-a89056cf-a3ca-4d58-952e-5dcfaaae8d8b1493696681.jpg'),
(56, 86, 'canon-6d-1-1-min1493696682.jpg'),
(57, 86, 'canon-eos-1d-x-2-1-min1493696682.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `hieusp`
--

CREATE TABLE `hieusp` (
  `idhieusp` int(11) NOT NULL,
  `tenhieusp` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `tinhtrang` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `hieusp`
--

INSERT INTO `hieusp` (`idhieusp`, `tenhieusp`, `tinhtrang`) VALUES
(1, 'AKUBA', '1'),
(3, 'ALE JEANS', '1'),
(4, 'ALIEN ARMOUR', '1'),
(5, 'BAO AN', '1'),
(6, 'BE JAPAN', '1'),
(7, 'BENPLAY', '1'),
(8, 'COLO', '1'),
(9, 'ECO JEAN', '1'),
(10, 'KUMAS', '1'),
(11, 'JACKIES', '1'),
(12, 'JESSIE EX', '1'),
(13, 'WISE', '1');

-- --------------------------------------------------------

--
-- Table structure for table `loaisp`
--

CREATE TABLE `loaisp` (
  `idloaisp` int(11) NOT NULL,
  `tenloaisp` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `tinhtrang` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `loaisp`
--

INSERT INTO `loaisp` (`idloaisp`, `tenloaisp`, `tinhtrang`) VALUES
(24, 'Quáº§n Jean Skinny Nam', '1'),
(25, 'Quáº§n Jeans RÃ¡ch Kiá»ƒu Nam', '1'),
(26, 'Quáº§n Jean Skinny Ná»¯', '1'),
(27, 'Quáº§n Jeans RÃ¡ch Kiá»ƒu Ná»¯', '1'),
(28, 'Quáº§n Jeans á»ng Äá»©ng Nam', '1'),
(29, 'Quáº§n Jeans á»ng Äá»©ng Ná»¯', '1'),
(30, 'Quáº§n Kaki Nam', '1'),
(32, 'Ão SÆ¡ Mi Nam', '1'),
(33, 'Ão SÆ¡ Mi Ná»¯', '1'),
(34, 'Ão SÆ¡ Mi Cá»• Trá»¥ Nam', '1'),
(35, 'Ão SÆ¡ Mi Cá»• Trá»¥ ', '1'),
(36, 'Ão SÆ¡ Mi Cá»• Trá»¥ Ná»¯', '1'),
(37, 'Ão SÆ¡ Mi Cá»• TrÃ²n Nam', '1'),
(38, 'Ão SÆ¡ Mi Cá»• TrÃ²n Ná»¯', '1'),
(39, 'Quáº§n TÃ¢y CÃ´ng Sá»Ÿ Nam', '1'),
(40, 'Quáº§n Thá»ƒ Thao Nam', '1'),
(41, 'Quáº§n Thá»ƒ Thao Ná»¯', '1'),
(42, 'Quáº§n Short Nam', '1'),
(43, 'Quáº§n Short Ná»¯', '1'),
(44, 'Ão KhoÃ¡c Nam', '1');

-- --------------------------------------------------------

--
-- Table structure for table `sanpham`
--

CREATE TABLE `sanpham` (
  `idsanpham` int(11) NOT NULL,
  `tensp` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `masp` varchar(255) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `hinhanh` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `giadexuat` float NOT NULL,
  `giagiam` float NOT NULL,
  `soluong` int(11) NOT NULL,
  `loaisp` int(11) NOT NULL,
  `nhasx` int(11) NOT NULL,
  `tinhtrang` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `noidung` longtext COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `sanpham`
--

INSERT INTO `sanpham` (`idsanpham`, `tensp`, `masp`, `hinhanh`, `giadexuat`, `giagiam`, `soluong`, `loaisp`, `nhasx`, `tinhtrang`, `noidung`) VALUES
(1, 'Ão SÆ¡ Mi Äá» DÃ´', '100010', 'ao-so-mi-do-do-asm918_2_small-8934-t.jpg', 150000, 0, 15, 22, 1, '1', ''),
(2, 'Ão SÆ¡ Mi Xanh', '100011', 'ao-so-mi-han-quoc-trang-asm937_2_small-9142-t.jpg', 175000, 0, 20, 22, 1, '1', ''),
(3, 'Quáº§n jeans skinny Äen', '000', '1000000000.jpg', 250000, 0, 30, 24, 1, '1', ''),
(4, 'Quáº§n jeans skinny Xanh Nháº¡t', '001', '1000000001.jpg', 299000, 0, 40, 24, 3, '1', ''),
(5, 'Quáº§n jeans skinny Xanh', '002', '1000000002.jpg', 240000, 0, 20, 24, 1, '1', ''),
(6, 'Quáº§n jeans rÃ¡ch kiá»ƒu Äen', '009', '1000000009.jpg', 350000, 0, 40, 25, 3, '1', ''),
(7, 'Quáº§n jeans rÃ¡ch kiá»ƒu Xanh Nháº¡t', '010', '1000000010.jpg', 400000, 0, 80, 25, 7, '1', ''),
(8, 'Quáº§n jeans rÃ¡ch kiá»ƒu Xanh', '011', '1000000011.jpg', 350000, 0, 70, 25, 4, '1', ''),
(9, 'Quáº§n jeans rÃ¡ch kiá»ƒu MÃ u KhÃ³i', '012', '1000000012.jpg', 400000, 0, 90, 25, 5, '1', ''),
(10, 'Quáº§n jeans skinny Äen', '004', '1000000004.jpg', 600000, 0, 85, 26, 1, '1', ''),
(11, 'Quáº§n jeans skinny Xanh', '006', '1000000005.jpg', 350000, 0, 40, 26, 1, '1', ''),
(12, 'Quáº§n jeans skinny Xanh Äáº­m', '005', '1000000006.jpg', 500000, 0, 80, 26, 1, '1', ''),
(13, 'Quáº§n jeans rÃ¡ch kiá»ƒu Xanh Äáº­m', '013', '1000000013.jpg', 350000, 0, 15, 27, 4, '1', ''),
(14, 'Quáº§n jeans rÃ¡ch kiá»ƒu Äen', '016', '1000000014.jpg', 400000, 0, 35, 27, 3, '1', ''),
(15, 'Quáº§n jeans rÃ¡ch kiá»ƒu Xanh', '015', '1000000015.jpg', 399000, 0, 45, 27, 5, '1', ''),
(16, 'Quáº§n Jeans á»ng Äá»©ng Xanh', '019', '019.jpg', 250000, 0, 40, 28, 6, '1', ''),
(17, 'Quáº§n Jeans á»ng Äá»©ng Äen', '018', '018.jpg', 350000, 0, 15, 28, 1, '1', ''),
(18, 'Quáº§n Jeans á»ng Äá»©ng Xanh', '020', '020.jpg', 350000, 0, 40, 28, 3, '1', ''),
(19, 'Quáº§n jeans rÃ¡ch kiá»ƒu MÃ u KhÃ³i', '014', '014.jpg', 500000, 0, 30, 27, 1, '1', ''),
(20, 'Ão SÆ¡ Mi Äen', '074', '074.jpg', 350000, 0, 40, 32, 6, '1', ''),
(21, 'Ão SÆ¡ Mi Tráº¯ng', '075', '075.jpg', 250000, 0, 80, 32, 11, '1', ''),
(22, 'Ão SÆ¡ Mi Há»“ng', '076', '076.jpg', 250000, 0, 45, 32, 8, '1', ''),
(23, 'Ão SÆ¡ Mi TÃ­m', '077', '077.jpg', 175000, 0, 35, 32, 8, '1', ''),
(24, 'Ão SÆ¡ Mi Äá»', '078', '078.jpg', 150000, 0, 35, 32, 12, '1', ''),
(25, 'Ão SÆ¡ Mi Äá» ÄÃ´', '079', '079.jpg', 200000, 0, 35, 32, 8, '1', ''),
(26, 'Ão SÆ¡ Mi Xanh', '080', '080.jpg', 250000, 0, 15, 32, 8, '1', ''),
(27, 'Ão SÆ¡ Mi Xanh Äen', '081', '081.jpg', 320000, 0, 35, 32, 6, '1', ''),
(28, 'Ão SÆ¡ Mi Tráº¯ng', '082', '082.jpg', 400000, 0, 35, 33, 6, '1', ''),
(29, 'Ão SÆ¡ Mi Há»“ng', '083', '083.jpg', 500000, 0, 40, 33, 10, '1', ''),
(30, 'Ão SÆ¡ Mi Äá» ÄÃ´', '084', '084.jpg', 250000, 0, 35, 33, 11, '1', ''),
(31, 'Ão SÆ¡ Mi TÃ­m', '085', '085.jpg', 250000, 0, 34, 33, 11, '1', ''),
(32, 'Ão SÆ¡ Mi VÃ ng', '086', '086.jpg', 175000, 0, 35, 33, 6, '1', ''),
(33, 'Ão SÆ¡ Mi Cá»• Trá»¥ Tráº¯ng', '087', '087.jpg', 299000, 0, 40, 34, 3, '1', ''),
(34, 'Ão SÆ¡ Mi Cá»• Trá»¥ Äen', '088', '088.jpg', 350000, 0, 20, 34, 7, '1', ''),
(35, 'Ão SÆ¡ Mi Cá»• Trá»¥ Xanh Äáº­m', '089', '089.jpg', 250000, 0, 23, 34, 1, '1', ''),
(36, 'Ão SÆ¡ Mi Cá»• Trá»¥ Xanh', '090', '090.jpg', 250000, 0, 35, 34, 5, '1', ''),
(37, 'Ão SÆ¡ Mi Cá»• Trá»¥ VÃ ng', '091', '091.jpg', 350000, 0, 40, 36, 3, '1', ''),
(38, 'Ão SÆ¡ Mi Cá»• Trá»¥ TÃ­m', '093', '093.jpg', 400000, 0, 35, 36, 1, '1', ''),
(39, 'Ão SÆ¡ Mi Cá»• Trá»¥ Tráº¯ng', '094', '094.jpg', 350000, 0, 40, 36, 1, '1', ''),
(40, 'Ão SÆ¡ Mi Cá»• TrÃ²n Tráº¯ng', '095', '095.jpg', 250000, 0, 35, 37, 1, '1', ''),
(41, 'Ão SÆ¡ Mi Cá»• TrÃ²n Äen', '096', '096.jpg', 500000, 0, 40, 37, 3, '1', ''),
(43, 'Ão SÆ¡ Mi Cá»• TrÃ²n Há»“ng', '097', '097.jpg', 250000, 0, 35, 37, 1, '1', ''),
(44, 'Ão SÆ¡ Mi Cá»• TrÃ²n Äá» Äáº­m', '098', '098.jpg', 350000, 0, 40, 37, 6, '1', ''),
(45, 'Ão SÆ¡ Mi Cá»• TrÃ²n Tráº¯ng', '099', '099.jpg', 250000, 0, 30, 38, 1, '1', ''),
(46, 'Ão SÆ¡ Mi Cá»• TrÃ²n Há»“ng', '100', '100.jpg', 350000, 0, 15, 38, 13, '1', ''),
(47, 'Ão SÆ¡ Mi Cá»• TrÃ²n TÃ­m', '101', '101.jpg', 500000, 0, 40, 38, 1, '1', ''),
(48, 'Ão SÆ¡ Mi Cá»• TrÃ²n VÃ ng', '102', '102.jpg', 550000, 0, 35, 38, 1, '1', ''),
(49, 'Quáº§n Jeans Skinny MÃ u KhÃ³i', '003', '003.jpg', 250000, 0, 35, 24, 1, '1', ''),
(50, 'Quáº§n Jeans Skinny MÃ u KhÃ³i', '007', '007.jpg', 350000, 0, 40, 26, 1, '1', ''),
(51, 'Quáº§n Jeans Skinny MÃ u Tráº¯ng', '008', '008.jpg', 400000, 0, 35, 26, 1, '1', ''),
(52, 'Quáº§n jeans rÃ¡ch kiá»ƒu Báº¡c', '017', '017.jpg', 350000, 0, 35, 27, 1, '1', ''),
(53, 'Quáº§n Jeans á»ng Äá»©ng Äen', '021', '021.jpg', 400000, 0, 35, 29, 1, '1', ''),
(54, 'Quáº§n Jeans á»ng Äá»©ng Báº¡c', '022', '022.jpg', 500000, 0, 15, 29, 1, '1', ''),
(55, 'Quáº§n Jeans á»ng Äá»©ng Xanh', '023', '023.jpg', 175000, 0, 35, 29, 1, '1', ''),
(56, 'Quáº§n Kaki Äen', '024', '024.jpg', 350000, 0, 35, 30, 1, '1', ''),
(57, 'Quáº§n Kaki MÃ u Coffee', '025', '025.jpg', 250000, 0, 80, 30, 1, '1', ''),
(58, 'Quáº§n Kaki Äá» ÄÃ´', '026', '026.jpg', 500000, 0, 40, 30, 1, '1', ''),
(59, 'Quáº§n Kaki Báº¡c', '027', '027.jpg', 450000, 0, 20, 30, 1, '1', ''),
(60, 'Quáº§n TÃ¢y CÃ´ng Sá»Ÿ Äen', '028', '028.jpg', 250000, 0, 40, 39, 8, '1', ''),
(61, 'Quáº§n TÃ¢y CÃ´ng Sá»Ÿ Báº¡c', '029', '029.jpg', 350000, 0, 35, 39, 5, '1', ''),
(62, 'Quáº§n TÃ¢y Caro Tráº¯ng Äen', '030', '030.jpg', 400000, 0, 20, 39, 1, '1', ''),
(63, 'Quáº§n TÃ¢y Co GiÃ£n Äen', '031', '031.jpg', 250000, 0, 15, 39, 1, '1', ''),
(64, 'Quáº§n TÃ¢y Co GiÃ£n NÃ¢u', '032', '032.jpg', 400000, 0, 40, 39, 1, '1', ''),
(65, 'Quáº§n Thá»ƒ Thao Ba Sá»c Äen', '058', '058.jpg', 400000, 0, 35, 40, 8, '1', ''),
(66, 'Quáº§n Thá»ƒ Thao Äen', '060', '060.jpg', 175000, 0, 40, 40, 5, '1', ''),
(67, 'Quáº§n Thá»ƒ Thao NÃ¢u', '061', '061.jpg', 175000, 0, 40, 40, 1, '1', ''),
(68, 'Quáº§n Thá»ƒ Thao Báº¡c', '062', '062.jpg', 150000, 0, 15, 40, 1, '1', ''),
(69, 'Quáº§n Thá»ƒ Thao Äá» ÄÃ´', '063', '063.jpg', 175000, 0, 40, 40, 1, '1', ''),
(70, 'Quáº§n Táº­p Gym Äen', '068', '068.jpg', 175000, 0, 35, 40, 1, '1', ''),
(71, 'Quáº§n Táº­p Gym Báº¡c', '069', '069.jpg', 150000, 0, 15, 40, 3, '1', ''),
(72, 'Quáº§n Táº­p Gym MÃ u KhÃ³i', '070', '070.jpg', 175000, 0, 15, 40, 1, '1', ''),
(73, 'Quáº§n Táº­p Gym Äen', '071', '071.jpg', 150000, 0, 40, 41, 1, '1', ''),
(74, 'Quáº§n Táº­p Gym Báº¡c', '072', '072.jpg', 175000, 0, 80, 41, 1, '1', ''),
(75, 'Quáº§n Táº­p Gym MÃ u KhÃ³i', '073', '073.jpg', 175000, 0, 15, 41, 1, '1', ''),
(76, 'Quáº§n Thá»ƒ Thao Tráº¯ng', '064', '064.jpg', 150000, 0, 40, 41, 1, '1', ''),
(77, 'Quáº§n Thá»ƒ Thao Äen', '065', '065.jpg', 175000, 0, 40, 41, 1, '1', ''),
(78, 'Quáº§n Thá»ƒ Thao Báº¡c', '066', '066.jpg', 175000, 0, 15, 41, 1, '1', ''),
(79, 'Quáº§n Thá»ƒ Thao Äá» ÄÃ´', '067', '067.jpg', 175000, 0, 35, 41, 1, '1', ''),
(80, 'Quáº§n Short Jeans Äen', '033', '033.jpg', 250000, 0, 35, 42, 1, '1', ''),
(81, 'Quáº§n Short Jeans Xanh Äáº­m', '034', '034.jpg', 200000, 0, 40, 42, 1, '1', ''),
(82, 'Quáº§n Short Jeans Xanh', '035', '035.jpg', 250000, 0, 15, 42, 1, '1', ''),
(83, 'Quáº§n Short Jeans Xanh Äáº­m', '036', '036.jpg', 175000, 0, 80, 43, 1, '1', ''),
(84, 'Quáº§n Short Jeans Báº¡c', '037', '037.jpg', 250000, 0, 15, 43, 1, '1', ''),
(85, 'Quáº§n Short Kaki Äen', '038', '038.jpg', 250000, 0, 40, 42, 1, '1', ''),
(86, 'Quáº§n Short Kaki Xanh', '039', '039.jpg', 350000, 0, 35, 42, 1, '1', ''),
(87, 'Quáº§n Short Kaki Äá»', '040', '040.jpg', 250000, 0, 80, 42, 1, '1', ''),
(88, 'Quáº§n Short Kaki Xanh LÃ¡', '041', '041.jpg', 250000, 0, 40, 42, 1, '1', ''),
(89, 'Quáº§n Short Kaki NÃ¢u', '042', '042.jpg', 350000, 0, 40, 42, 1, '1', ''),
(90, 'Quáº§n Short Kaki Tráº¯ng', '043', '043.jpg', 350000, 0, 35, 42, 1, '1', ''),
(91, 'Quáº§n Short Kaki MÃ u KhÃ³i', '044', '044.jpg', 500000, 0, 35, 43, 1, '1', ''),
(92, 'Quáº§n Short Kaki Äen', '045', '045.jpg', 400000, 0, 40, 43, 1, '1', ''),
(93, 'Quáº§n Short Kaki Báº¡c', '046', '046.jpg', 350000, 0, 40, 43, 1, '1', ''),
(94, 'Quáº§n Short Kaki Äá»', '047', '047.jpg', 175000, 0, 40, 43, 1, '1', ''),
(95, 'Quáº§n Short Kaki Há»“ng', '048', '048.jpg', 350000, 0, 35, 43, 1, '1', ''),
(96, 'Quáº§n Short Kaki Cam', '049', '049.jpg', 250000, 0, 35, 43, 1, '1', ''),
(97, 'Quáº§n Short Kaki Tráº¯ng', '050', '050.jpg', 250000, 0, 35, 43, 1, '1', ''),
(98, 'Quáº§n Short Thun Äá»', '051', '051.jpg', 350000, 0, 35, 42, 1, '1', ''),
(99, 'Quáº§n Short Thun Äen', '052', '052.jpg', 350000, 0, 40, 42, 1, '1', ''),
(100, 'Quáº§n Short Thun Xanh Äáº­m', '053', '053.jpg', 250000, 0, 35, 42, 1, '1', ''),
(101, 'Quáº§n Short Thun Báº¡c', '054', '054.jpg', 400000, 0, 40, 42, 1, '1', ''),
(102, 'Quáº§n Short Thun Tráº¯ng', '055', '055.jpg', 350000, 0, 40, 43, 1, '1', ''),
(103, 'Quáº§n Short Thun Há»“ng', '056', '056.jpg', 175000, 0, 40, 43, 1, '1', ''),
(104, 'Quáº§n Short Thun Äá»', '057', '057.jpg', 350000, 0, 35, 43, 1, '1', ''),
(105, 'Ão KhoÃ¡c Da Äen', '105', '105.jpg', 500000, 0, 40, 44, 6, '1', ''),
(106, 'Ão KhoÃ¡c Da Äen CÃ³ NÃ³n', '106', '106.jpg', 550000, 0, 40, 44, 3, '1', ''),
(107, 'Ão KhoÃ¡c Da Äá»•', '107', '107.jpg', 600000, 0, 45, 44, 4, '1', ''),
(108, 'Ão KhoÃ¡c Da Äá»• Máº­n', '108', '108.jpg', 750000, 0, 40, 44, 6, '1', ''),
(109, 'Ão KhoÃ¡c Da NÃ¢u', '109', '109.jpg', 700000, 0, 35, 44, 4, '1', ''),
(111, 'Ão KhoÃ¡c Da NÃ¢u Äen', '110', '110.jpg', 600000, 0, 40, 44, 1, '1', ''),
(112, 'Ão KhoÃ¡c Da Xanh', '111', '111.jpg', 650000, 0, 40, 44, 1, '1', ''),
(113, 'Ão KhoÃ¡c Da Xanh NÃ¢u', '112', '112.jpg', 700000, 0, 40, 44, 1, '1', ''),
(114, 'Ão KhoÃ¡c Jeans Xanh Nháº¡t', '113', '113.jpg', 350000, 0, 40, 44, 1, '1', ''),
(115, 'Ão KhoÃ¡c Jeans Xanh', '114', '114.jpg', 400000, 0, 40, 44, 1, '1', ''),
(116, 'Ão KhoÃ¡c Jeans Xanh Äáº­m', '115', '115.jpg', 350000, 0, 35, 44, 1, '1', ''),
(117, 'Ão KhoÃ¡c Kaki Äen', '116', '116.jpg', 550000, 0, 40, 44, 1, '1', ''),
(118, 'Ão KhoÃ¡c Kaki RÃªu', '117', '117.jpg', 700000, 0, 40, 44, 1, '1', ''),
(119, 'Ão KhoÃ¡c Kaki XÃ¡m Chuá»™t', '118', '118.jpg', 500000, 0, 40, 44, 1, '1', ''),
(120, 'Ão KhoÃ¡c Kaki Tráº¯ng', '119', '119.jpg', 400000, 0, 40, 44, 1, '1', ''),
(121, 'Ão KhoÃ¡c Kaki Xanh Äen', '120', '120.jpg', 350000, 0, 40, 44, 1, '1', ''),
(122, 'Ão KhoÃ¡c Phao Äen', '121', '121.jpg', 400000, 0, 40, 44, 1, '1', ''),
(123, 'Ão KhoÃ¡c Phao Äá» ÄÃ´', '122', '122.jpg', 350000, 0, 40, 44, 1, '1', ''),
(124, 'Ão KhoÃ¡c Phao Xanh', '123', '123.jpg', 900000, 550000, 40, 44, 1, '1', '');

-- --------------------------------------------------------

--
-- Table structure for table `tintuc`
--

CREATE TABLE `tintuc` (
  `idtintuc` int(11) NOT NULL,
  `tentintuc` tinytext COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `matin` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `hinhanh` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `noidung` longtext COLLATE utf8mb4_vietnamese_ci NOT NULL,
  `tinhtrang` varchar(100) COLLATE utf8mb4_vietnamese_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_vietnamese_ci;

--
-- Dumping data for table `tintuc`
--

INSERT INTO `tintuc` (`idtintuc`, `tentintuc`, `matin`, `hinhanh`, `noidung`, `tinhtrang`) VALUES
(1, 'jfksdjfk', '124512', '040.jpg', '<p>fkdsfksduf</p>', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`idadmin`);

--
-- Indexes for table `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cart_detail`
--
ALTER TABLE `cart_detail`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dangky`
--
ALTER TABLE `dangky`
  ADD PRIMARY KEY (`id_khachhang`);

--
-- Indexes for table `gallery`
--
ALTER TABLE `gallery`
  ADD PRIMARY KEY (`id_gallery`);

--
-- Indexes for table `hieusp`
--
ALTER TABLE `hieusp`
  ADD PRIMARY KEY (`idhieusp`);

--
-- Indexes for table `loaisp`
--
ALTER TABLE `loaisp`
  ADD PRIMARY KEY (`idloaisp`);

--
-- Indexes for table `sanpham`
--
ALTER TABLE `sanpham`
  ADD PRIMARY KEY (`idsanpham`);

--
-- Indexes for table `tintuc`
--
ALTER TABLE `tintuc`
  ADD PRIMARY KEY (`idtintuc`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `idadmin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `cart`
--
ALTER TABLE `cart`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `cart_detail`
--
ALTER TABLE `cart_detail`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `dangky`
--
ALTER TABLE `dangky`
  MODIFY `id_khachhang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- AUTO_INCREMENT for table `gallery`
--
ALTER TABLE `gallery`
  MODIFY `id_gallery` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `hieusp`
--
ALTER TABLE `hieusp`
  MODIFY `idhieusp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `loaisp`
--
ALTER TABLE `loaisp`
  MODIFY `idloaisp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `sanpham`
--
ALTER TABLE `sanpham`
  MODIFY `idsanpham` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;

--
-- AUTO_INCREMENT for table `tintuc`
--
ALTER TABLE `tintuc`
  MODIFY `idtintuc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
