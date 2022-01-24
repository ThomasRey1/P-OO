-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Lun 24 Janvier 2022 à 09:59
-- Version du serveur :  5.7.11
-- Version de PHP :  5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `db_p_oo`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_file`
--

CREATE TABLE `t_file` (
  `idFile` char(1) NOT NULL,
  `filName` varchar(255) NOT NULL,
  `filType` varchar(5) NOT NULL,
  `filPath` char(255) NOT NULL,
  `idIndex` char(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `t_index`
--

CREATE TABLE `t_index` (
  `idIndex` char(1) NOT NULL,
  `indDateIndexation` varchar(10) NOT NULL,
  `indNumberIndex` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables exportées
--

--
-- Index pour la table `t_file`
--
ALTER TABLE `t_file`
  ADD PRIMARY KEY (`idFile`),
  ADD UNIQUE KEY `ID_t_file_IND` (`idFile`),
  ADD KEY `FKR_IND` (`idIndex`);

--
-- Index pour la table `t_index`
--
ALTER TABLE `t_index`
  ADD PRIMARY KEY (`idIndex`),
  ADD UNIQUE KEY `ID_t_index_IND` (`idIndex`);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `t_file`
--
ALTER TABLE `t_file`
  ADD CONSTRAINT `FKR_FK` FOREIGN KEY (`idIndex`) REFERENCES `t_index` (`idIndex`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
