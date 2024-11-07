-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 07. Nov 2024 um 09:18
-- Server-Version: 10.4.17-MariaDB
-- PHP-Version: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `onlineshoptest`
--
CREATE DATABASE IF NOT EXISTS `onlineshoptest` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `onlineshoptest`;

DELIMITER $$
--
-- Prozeduren
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete_Produkt` (IN `p_id` INT)  NO SQL
BEGIN
DELETE FROM produkte WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Insert_Produkt` (IN `p_artikelnummer` INT, IN `p_produktname` VARCHAR(40) CHARSET utf8, IN `p_preis` DECIMAL(7,2), IN `p_beschreibung` VARCHAR(300) CHARSET utf8, IN `p_anzahl` INT)  NO SQL
BEGIN
INSERT INTO produkte (artikelnummer, produktname, preis, beschreibung, anzahl) VALUES (p_artikelnummer, p_produktname, p_preis, p_beschreibung, p_anzahl);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Read_All_Produkte` ()  NO SQL
BEGIN
SELECT * FROM produkte;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Read_Produkt` (IN `p_id` INT)  NO SQL
BEGIN
SELECT * FROM produkte WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Read_Produktliste` ()  NO SQL
BEGIN
SELECT id, artikelnummer, produktname FROM produkte;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt` (IN `p_id` INT, IN `p_artikelnummer` INT, IN `p_produktname` VARCHAR(40), IN `p_preis` DECIMAL(7,2), IN `p_beschreibung` VARCHAR(300), IN `p_anzahl` INT)  NO SQL
BEGIN
UPDATE produkte SET artikelnummer = p_artikelnummer, produktname = p_produktname, preis = p_preis, beschreibung = p_beschreibung, anzahl = p_anzahl WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt_Anzahl` (IN `p_anzahl` INT, IN `p_id` INT)  NO SQL
BEGIN
UPDATE produkte SET anzahl = p_anzahl WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt_Artikelnummer` (IN `p_artikelnummer` INT, IN `p_id` INT)  NO SQL
BEGIN
UPDATE produkte SET artikelnummer = p_artikelnummer WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt_Beschreibung` (IN `p_beschreibung` VARCHAR(300), IN `p_id` INT)  NO SQL
BEGIN
UPDATE produkte SET beschreibung = p_beschreibung WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt_Preis` (IN `p_preis` DECIMAL(7,2), IN `p_id` INT)  NO SQL
BEGIN
UPDATE produkte SET preis = p_preis WHERE id = p_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Update_Produkt_Produktname` (IN `p_produktname` VARCHAR(40), IN `p_id` INT)  NO SQL
BEGIN
UPDATE produkte SET produktname = p_produktname WHERE id = p_id;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `produkte`
--

CREATE TABLE `produkte` (
  `id` int(10) UNSIGNED NOT NULL,
  `artikelnummer` int(10) UNSIGNED NOT NULL,
  `produktname` varchar(40) NOT NULL,
  `preis` decimal(7,2) NOT NULL,
  `beschreibung` varchar(300) DEFAULT NULL,
  `anzahl` int(10) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Daten für Tabelle `produkte`
--

INSERT INTO `produkte` (`id`, `artikelnummer`, `produktname`, `preis`, `beschreibung`, `anzahl`) VALUES
(1, 1001, 'Bohrmaschine', '45.99', 'Krasse Maschine für anspruchsvolle Bohrarbeiten', 23),
(2, 1234, 'Laubsäge', '22.95', 'Ideal zum Aussägen dünner Holzstücke!', 15),
(3, 5544, 'Hammer', '15.00', 'Toll', 14),
(4, 7845, 'Kneifzange', '12.00', 'Knipst alles ab', 41),
(6, 546454, 'Kettensäge', '9.00', 'Mäht alles um!', 0),
(14, 87955, 'Gerät', '45.00', 'Kann alles', 5),
(16, 22222, 'Korb', '12.58', 'Tragehilfe', 6),
(19, 45521, 'Löffel', '4.33', 'Abzugeben', 10),
(23, 45523, 'Mütze', '15.99', 'Bei kalten Ohren', 12),
(25, 5887, 'Futter', '12.88', 'Zum Füttern', 25),
(27, 44521, 'Gartenschere', '12.99', 'Ausgeheckt von unserem Gartencenter!', 25);

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `produkte`
--
ALTER TABLE `produkte`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `artikelnummer` (`artikelnummer`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `produkte`
--
ALTER TABLE `produkte`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
