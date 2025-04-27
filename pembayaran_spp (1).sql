-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 02, 2025 at 10:53 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pembayaran_spp`
--

-- --------------------------------------------------------

--
-- Table structure for table `biaya`
--

CREATE TABLE `biaya` (
  `id_spp` char(7) NOT NULL,
  `deskripsi` varchar(50) NOT NULL,
  `tahun` varchar(9) NOT NULL,
  `nominal` int(10) NOT NULL,
  `date` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `biaya`
--

INSERT INTO `biaya` (`id_spp`, `deskripsi`, `tahun`, `nominal`, `date`) VALUES
('1232123', 'uang m', '2024/2025', 800000, '2025-01-27 11:06:46'),
('B879027', 'uang gerbang', '2025', 40000, '2025-02-02 15:54:43');

-- --------------------------------------------------------

--
-- Table structure for table `kelas`
--

CREATE TABLE `kelas` (
  `id_kelas` char(6) NOT NULL,
  `kelas` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kelas`
--

INSERT INTO `kelas` (`id_kelas`, `kelas`) VALUES
('343243', '11'),
('K21234', '57');

-- --------------------------------------------------------

--
-- Table structure for table `pembayaran`
--

CREATE TABLE `pembayaran` (
  `id_pembayaran` char(7) NOT NULL,
  `id_petugas` char(7) NOT NULL,
  `nis` char(10) NOT NULL,
  `id_spp` char(7) NOT NULL,
  `id_kelas` char(6) NOT NULL,
  `jumlah_bayar` int(8) NOT NULL,
  `bulan_bayar` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `id_petugas` char(7) NOT NULL,
  `no_telp` varchar(13) NOT NULL,
  `nama_petugas` varchar(60) NOT NULL,
  `alamat` text NOT NULL,
  `username` char(5) NOT NULL,
  `password` char(5) NOT NULL,
  `jabatan` enum('admin','petugas','','') NOT NULL,
  `jenis_kelamin` enum('laki-laki','perempuan','','') NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`id_petugas`, `no_telp`, `nama_petugas`, `alamat`, `username`, `password`, `jabatan`, `jenis_kelamin`) VALUES
('P407585', '89', 'gfgf', 'vbv', 'kjkk', 'nbb', 'petugas', 'laki-laki'),
('P563300', '085236572', 'adi maulana', 'desa jangur kc sumberasih', '11111', '22222', 'admin', 'laki-laki');

-- --------------------------------------------------------

--
-- Table structure for table `siswa`
--

CREATE TABLE `siswa` (
  `nis` char(10) NOT NULL,
  `nama` varchar(60) NOT NULL,
  `alamat` text NOT NULL,
  `jenis_kelamin` enum('laki-laki','perempuan','','') NOT NULL,
  `status` enum('aktif','tidak aktif','berhenti','') NOT NULL,
  `id_spp` char(7) NOT NULL,
  `tahun_ajar` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `siswa`
--

INSERT INTO `siswa` (`nis`, `nama`, `alamat`, `jenis_kelamin`, `status`, `id_spp`, `tahun_ajar`) VALUES
('123', 'adi maulana', 'jangur', 'laki-laki', 'aktif', '1232123', 2029),
('23453234', 'siti', 'yoo', 'laki-laki', 'aktif', '1232123', 2028),
('3434565432', 'dewangga', 'ala', 'laki-laki', 'aktif', '1232123', 2024);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `biaya`
--
ALTER TABLE `biaya`
  ADD PRIMARY KEY (`id_spp`);

--
-- Indexes for table `kelas`
--
ALTER TABLE `kelas`
  ADD PRIMARY KEY (`id_kelas`);

--
-- Indexes for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD PRIMARY KEY (`id_pembayaran`),
  ADD KEY `id_petugas` (`id_petugas`),
  ADD KEY `nis` (`nis`),
  ADD KEY `id_kelas` (`id_kelas`),
  ADD KEY `id_spp` (`id_spp`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`id_petugas`);

--
-- Indexes for table `siswa`
--
ALTER TABLE `siswa`
  ADD PRIMARY KEY (`nis`),
  ADD KEY `id_spp` (`id_spp`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `pembayaran`
--
ALTER TABLE `pembayaran`
  ADD CONSTRAINT `pembayaran_ibfk_3` FOREIGN KEY (`id_petugas`) REFERENCES `petugas` (`id_petugas`),
  ADD CONSTRAINT `pembayaran_ibfk_4` FOREIGN KEY (`id_kelas`) REFERENCES `kelas` (`id_kelas`),
  ADD CONSTRAINT `pembayaran_ibfk_5` FOREIGN KEY (`id_spp`) REFERENCES `biaya` (`id_spp`);

--
-- Constraints for table `siswa`
--
ALTER TABLE `siswa`
  ADD CONSTRAINT `siswa_ibfk_1` FOREIGN KEY (`id_spp`) REFERENCES `biaya` (`id_spp`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
