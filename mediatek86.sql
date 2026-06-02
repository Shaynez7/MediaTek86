-- phpMyAdmin SQL Dump
-- version 5.2.3
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 02 juin 2026 à 19:58
-- Version du serveur : 8.4.7
-- Version de PHP : 8.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek86`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(0, '2026-05-06 00:00:00', '2026-05-08 00:00:00', 1),
(0, '2026-05-08 23:09:22', '2026-05-09 23:09:22', 4),
(1, '2025-01-19 00:00:00', '2025-01-24 00:00:00', 4),
(1, '2025-03-07 00:00:00', '2025-03-12 00:00:00', 4),
(1, '2025-06-05 00:00:00', '2025-06-10 00:00:00', 1),
(1, '2025-08-30 00:00:00', '2025-09-04 00:00:00', 3),
(1, '2025-11-01 00:00:00', '2025-11-06 00:00:00', 2),
(2, '2025-01-28 00:00:00', '2025-02-02 00:00:00', 3),
(2, '2025-04-18 00:00:00', '2025-04-23 00:00:00', 4),
(2, '2025-06-28 00:00:00', '2025-07-03 00:00:00', 2),
(2, '2025-07-14 00:00:00', '2025-07-19 00:00:00', 3),
(2, '2025-08-03 00:00:00', '2025-08-08 00:00:00', 1),
(3, '2025-04-05 00:00:00', '2025-04-10 00:00:00', 2),
(3, '2025-07-25 00:00:00', '2025-07-30 00:00:00', 4),
(3, '2025-09-27 00:00:00', '2025-10-02 00:00:00', 2),
(3, '2025-12-18 00:00:00', '2025-12-23 00:00:00', 1),
(3, '2026-06-02 00:00:00', '2026-06-03 00:00:00', 4),
(4, '2025-02-09 00:00:00', '2025-02-14 00:00:00', 3),
(4, '2025-04-27 00:00:00', '2025-05-02 00:00:00', 1),
(4, '2025-07-03 00:00:00', '2025-07-08 00:00:00', 2),
(4, '2025-10-20 00:00:00', '2025-10-25 00:00:00', 2),
(4, '2025-11-19 00:00:00', '2025-11-24 00:00:00', 1),
(5, '2025-01-12 00:00:00', '2025-01-17 00:00:00', 3),
(5, '2025-02-06 00:00:00', '2025-02-11 00:00:00', 4),
(5, '2025-05-03 00:00:00', '2025-05-08 00:00:00', 1),
(5, '2025-10-02 00:00:00', '2025-10-07 00:00:00', 2),
(5, '2025-11-25 00:00:00', '2025-11-30 00:00:00', 2),
(6, '2025-03-29 00:00:00', '2025-04-03 00:00:00', 4),
(6, '2025-05-15 00:00:00', '2025-05-20 00:00:00', 1),
(6, '2025-08-15 00:00:00', '2025-08-20 00:00:00', 3),
(6, '2025-09-09 00:00:00', '2025-09-14 00:00:00', 2),
(6, '2025-12-02 00:00:00', '2025-12-07 00:00:00', 4),
(7, '2025-01-05 00:00:00', '2025-01-10 00:00:00', 3),
(7, '2025-06-22 00:00:00', '2025-06-27 00:00:00', 1),
(7, '2025-09-01 00:00:00', '2025-09-06 00:00:00', 1),
(7, '2025-10-14 00:00:00', '2025-10-19 00:00:00', 2),
(7, '2025-12-01 00:00:00', '2025-12-06 00:00:00', 1),
(8, '2025-03-22 00:00:00', '2025-03-27 00:00:00', 4),
(8, '2025-06-01 00:00:00', '2025-06-06 00:00:00', 2),
(8, '2025-07-11 00:00:00', '2025-07-16 00:00:00', 1),
(8, '2025-08-09 00:00:00', '2025-08-14 00:00:00', 3),
(8, '2025-10-08 00:00:00', '2025-10-13 00:00:00', 2),
(9, '2025-02-01 00:00:00', '2025-02-06 00:00:00', 4),
(9, '2025-03-14 00:00:00', '2025-03-19 00:00:00', 4),
(9, '2025-05-21 00:00:00', '2025-05-26 00:00:00', 3),
(9, '2025-06-12 00:00:00', '2025-06-17 00:00:00', 1),
(9, '2025-08-21 00:00:00', '2025-08-26 00:00:00', 3),
(10, '2025-02-16 00:00:00', '2025-02-21 00:00:00', 3),
(10, '2025-03-11 00:00:00', '2025-03-16 00:00:00', 4),
(10, '2025-05-09 00:00:00', '2025-05-14 00:00:00', 1),
(10, '2025-09-18 00:00:00', '2025-09-23 00:00:00', 4),
(10, '2025-11-10 00:00:00', '2025-11-15 00:00:00', 3),
(13, '2026-05-09 23:30:48', '2026-05-10 23:30:48', 3),
(13, '2026-05-26 23:34:39', '2026-05-27 23:34:39', 1),
(17, '2026-06-02 21:11:57', '2026-06-03 21:11:56', 4);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prenom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tel` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `mail` varchar(128) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'September', 'Glass', '0605249310', 'ipsum.curabitur.consequat@hotmail.com', 2),
(2, 'Cameron', 'Crane', '0745462834', 'mauris.rhoncus@outlook.ca', 1),
(3, 'Jessamine', 'Delgado', '0612808225', 'leo.in@yahoo.couk', 2),
(4, 'Rooney', 'Black', '0745435607', 'eget.magna@google.couk', 1),
(5, 'Cailin', 'Guthrie', '0696872862', 'mauris.sapien@aol.ca', 3),
(6, 'Vivien', 'Conner', '0742772680', 'non.enim.mauris@google.com', 2),
(7, 'Olivia', 'Fuller', '0765309096', 'aliquet@hotmail.net', 2),
(17, 'e', 'e', 'e', 'e', 1),
(9, 'Finn', 'Sanders', '0714071531', 'ac.turpis@hotmail.ca', 3),
(10, 'Fiona', 'Scott', '0755646852', 'rutrum.eu@aol.net', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `pwd` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', 'c1a6dc631dfed24284f30e9517b305a995985bb7c95cde85be1f640275e97ae9');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
