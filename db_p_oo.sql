-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : ven. 20 mai 2022 à 09:41
-- Version du serveur :  5.7.11
-- Version de PHP : 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `db_p_oo`
--

-- --------------------------------------------------------

--
-- Structure de la table `t_file`
--

CREATE TABLE `t_file` (
  `idFile` int(11) NOT NULL,
  `filName` varchar(255) NOT NULL,
  `filType` varchar(5) NOT NULL,
  `filPath` varchar(255) NOT NULL,
  `fkIndex` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `t_index`
--

CREATE TABLE `t_index` (
  `idIndex` int(11) NOT NULL,
  `indDateIndexation` varchar(20) NOT NULL,
  `indPath` varchar(270) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `t_file`
--
ALTER TABLE `t_file`
  ADD PRIMARY KEY (`idFile`),
  ADD KEY `fkIndex` (`fkIndex`);

--
-- Index pour la table `t_index`
--
ALTER TABLE `t_index`
  ADD PRIMARY KEY (`idIndex`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `t_file`
--
ALTER TABLE `t_file`
  MODIFY `idFile` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=285;

--
-- AUTO_INCREMENT pour la table `t_index`
--
ALTER TABLE `t_index`
  MODIFY `idIndex` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `t_file`
--
ALTER TABLE `t_file`
  ADD CONSTRAINT `fkIndex` FOREIGN KEY (`fkIndex`) REFERENCES `t_index` (`idIndex`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
