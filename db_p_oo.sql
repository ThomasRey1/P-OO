-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost
-- Généré le : lun. 14 mars 2022 à 10:18
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
  `indDateIndexation` varchar(255) NOT NULL,
  `indPath` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `t_index`
--

INSERT INTO `t_index` (`idIndex`, `indDateIndexation`, `indPath`) VALUES
(1, '2014-03-20', 'F:\\année2\\Semestre2\\Projet\\P_OO\\P-OO-Thomas\\Code\\model\\P-OO_Thesaurus-Thomas-Alexandre'),
(2, '2014-03-20', 'F:\\année2\\Semestre2\\Projet\\P_OO\\P-OO-Thomas\\Code\\model\\P-OO_Thesaurus-Thomas-Alexandre'),
(4, '2022-03-14', 'F:\\'),
(5, '2022-03-14', 'F:\\'),
(6, '2022-03-14', 'F:\\année2\\Semestre2'),
(7, '2022-03-14', 'F:\\'),
(8, '14.03.2022 11:12:0811:12:08', 'F:\\'),
(9, '14.03.2022 11:13:1311:13', 'F:\\'),
(10, '14.03.2022 11:14:0311', 'F:\\'),
(11, '14.03.2022 11:14:0911', 'F:\\'),
(12, '14.03.2022 11:15:2811', 'F:\\'),
(13, '14.03.2022 11:16:2811', 'F:\\'),
(14, '14.03.2022 11:17:46', 'F:\\');

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
  MODIFY `idFile` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `t_index`
--
ALTER TABLE `t_index`
  MODIFY `idIndex` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

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
