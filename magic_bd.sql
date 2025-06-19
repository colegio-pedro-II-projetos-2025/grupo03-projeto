-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 19/06/2025 às 19:49
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `magic_bd`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cartas`
--

CREATE TABLE `cartas` (
  `nome` varchar(100) DEFAULT NULL,
  `id` int(5) NOT NULL,
  `mana` int(2) NOT NULL,
  `tipo` varchar(100) DEFAULT NULL,
  `descrição` varchar(100) DEFAULT NULL,
  `poder` int(2) DEFAULT NULL,
  `resistencia` int(2) DEFAULT NULL,
  `cor` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cartas`
--

INSERT INTO `cartas` (`nome`, `id`, `mana`, `tipo`, `descrição`, `poder`, `resistencia`, `cor`) VALUES
('Air Elemental', 2, 5, 'Creature — Elemental', 'Flying', 4, 4, 'Azul'),
('Ancestral Recall', 3, 1, 'Instant', 'Target player draws three cards.', NULL, NULL, 'Azul'),
('Animate Artifact', 4, 4, 'Enchantment — Aura', 'Enchant artifact As long as enchanted artifact isn’t a creature, it’s an artifact creature with powe', NULL, NULL, 'Azul'),
('Animate Dead', 5, 2, 'Enchantment — Aura', 'Enchant creature card in a graveyard When this Aura enters, if it’s on the battlefield, it loses “en', NULL, NULL, 'Preta'),
('Animate Wall', 6, 1, 'Enchantment — Aura', 'Enchant Wall Enchanted Wall can attack as though it didn’t have defender.', NULL, NULL, 'Branco'),
('Ankh of Mishra', 7, 2, 'Artifact', 'Whenever a land enters, this artifact deals 2 damage to that land’s controller.', NULL, NULL, 'Incolor'),
('Armageddon', 8, 4, 'Sorcery', 'Destroy all lands.', NULL, NULL, 'Branco'),
('Aspect of Wolf', 9, 2, 'Enchantment — Aura', 'Enchant creature Enchanted creature gets +X/+Y, where X is half the number of Forests you control, r', NULL, NULL, 'Verde'),
('Badlands', 10, 0, 'Land — Swamp Mountain', '{T}: Add {B} or {R}.', NULL, NULL, 'Incolor'),
('Bad Moon', 11, 2, 'Enchantment', 'Black creatures get +1/+1.', NULL, NULL, 'Preto'),
('Balance', 12, 2, 'Sorcery', 'Each player chooses a number of lands they control equal to the number of lands controlled by the pl', NULL, NULL, 'Branco'),
('Basalt Monolith', 13, 3, 'Artifact', 'This artifact doesn’t untap during your untap step.{T}: Add {C}{C}{C}.{3}: Untap this artifact.', NULL, NULL, 'Incolor'),
('Bayou', 14, 0, 'Land — Swamp Forest', '{T}: Add {B} or {G}.', NULL, NULL, 'Incolor'),
('Benalish Hero', 15, 1, 'Creature — Human Soldier', 'Banding', 1, 1, 'Branco'),
('Berserk', 16, 1, 'Instant', 'Cast this spell only before the combat damage step. Target creature gains trample and gets +X/+0 unt', NULL, NULL, 'Verde'),
('Birds of Paradise', 17, 1, 'Creature — Bird', 'Flying {T}: Add one mana of any color.', 0, 1, 'Verde'),
('Black Knight', 18, 2, 'Creature — Human Knight', 'First strike Protection from white', 2, 2, 'Preto'),
('Black Lotus', 19, 0, 'Artifact', '{T}, Sacrifice this artifact: Add three mana of any one color.', NULL, NULL, 'Incolor'),
('Black Vise', 20, 1, 'Artifact', 'As this artifact enters, choose an opponent. At the beginning of the chosen player’s upkeep, this ar', NULL, NULL, 'Incolor'),
('Black Ward', 21, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has protection from black. This effect doesn’t remove this Aura.', NULL, NULL, 'Branco'),
('Blaze of Glory', 22, 1, 'Instant', 'Cast this spell only during combat before blockers are declared. Target creature defending player co', NULL, NULL, 'Branco'),
('Blessing', 23, 2, 'Enchantment — Aura', 'Enchant creature {W}: Enchanted creature gets +1/+1 until end of turn.', NULL, NULL, 'Branco'),
('Blue Elemental Blast', 24, 1, 'Instant', 'Choose one — • Counter target red spell. • Destroy target red permanent.', NULL, NULL, 'Azul'),
('Blue Ward', 25, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has protection from blue. This effect doesn’t remove this Aura.', NULL, NULL, 'Branco'),
('Bog Wraith', 26, 4, 'Creature — Wraith', 'Swampwalk', 3, 3, 'Preto'),
('Braingeyser', 27, 2, 'Sorcery', 'Target player draws X cards.', NULL, NULL, 'Azul'),
('Burrowing', 28, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has mountainwalk.', NULL, NULL, 'Vermelho'),
('Camouflage', 29, 1, 'Instant', 'Cast this spell only during your declare attackers step. This turn, instead of declaring blockers, e', NULL, NULL, 'Verde'),
('Castle', 30, 4, 'Enchantment', 'Untapped creatures you control get +0/+2.', NULL, NULL, 'Branco'),
('Celestial Prism', 31, 3, 'Artifact', '{2}, {T}: Add one mana of any color.', NULL, NULL, 'Incolor'),
('Channel', 32, 2, 'Sorcery', 'Until end of turn, any time you could activate a mana ability, you may pay 1 life. If you do, add {C', NULL, NULL, 'Verde'),
('Chaoslace', 33, 1, 'Instant', 'Target spell or permanent becomes red.', NULL, NULL, 'Vermelho'),
('Chaos Orb', 34, 2, 'Artifact', '{1}, {T}: If this artifact is on the battlefield, flip it onto the battlefield from a height of at l', NULL, NULL, 'Incolor'),
('Circle of Protection: Blue', 35, 2, 'Enchantment', '{1}: The next time a blue source of your choice would deal damage to you this turn, prevent that dam', NULL, NULL, 'Branco'),
('Circle of Protection: Green', 36, 2, 'Enchantment', '{1}: The next time a green source of your choice would deal damage to you this turn, prevent that da', NULL, NULL, 'Branco'),
('Circle of Protection: Red', 37, 2, 'Enchantment', '{1}: The next time a red source of your choice would deal damage to you this turn, prevent that dama', NULL, NULL, 'Branco'),
('Circle of Protection: White', 38, 2, 'Enchantment', '{1}: The next time a white source of your choice would deal damage to you this turn, prevent that da', NULL, NULL, 'Branco'),
('Clockwork Beast', 39, 6, 'Artifact Creature — Beast', 'This creature enters with seven +1/+0 counters on it. At end of combat, if this creature attacked or', 0, 4, 'Incolor'),
('Clone', 40, 4, 'Creature — Shapeshifter', 'You may have this creature enter as a copy of any creature on the battlefield.', 0, 0, 'Azul'),
('Cockatrice', 41, 5, 'Creature — Cockatrice', 'Flying Whenever this creature blocks or becomes blocked by a non-Wall creature, destroy that creatur', 2, 4, 'Verde'),
('Consecrate Land', 42, 1, 'Enchantment — Aura', 'Enchant land Enchanted land has indestructible and can’t be enchanted by other Auras.', NULL, NULL, 'Branco'),
('Conservator', 43, 4, 'Artifact', '{T}: Prevent the next 2 damage that would be dealt to you this turn.', NULL, NULL, 'Incolor'),
('Contract from Below', 44, 1, 'Sorcery', 'Remove Contract from Below from your deck before playing if you’re not playing for ante.n Discard yo', NULL, NULL, 'Preto'),
('Control Magic', 45, 4, 'Enchantment — Aura', 'Enchant creature You control enchanted creature.', NULL, NULL, 'Azul'),
('Conversion', 46, 4, 'Enchantment', 'At the beginning of your upkeep, sacrifice this enchantment unless you pay {W}{W}. All Mountains are', NULL, NULL, 'Branco'),
('Copper Tablet', 47, 2, 'Artifact', 'At the beginning of each player’s upkeep, this artifact deals 1 damage to that player.', NULL, NULL, 'Incolor'),
('Copy Artifact', 48, 2, 'Enchantment', 'You may have this enchantment enter as a copy of any artifact on the battlefield, except it’s an enc', NULL, NULL, 'Azul'),
('Counterspell', 49, 2, 'Instant', 'Counter target spell.', NULL, NULL, 'Azul'),
('Craw Wurm', 50, 6, 'Creature — Wurm', '', 6, 4, 'Verde'),
('Creature Bond', 51, 2, 'Enchantment — Aura', 'Enchant creature When enchanted creature dies, this Aura deals damage equal to that creature’s tough', NULL, NULL, 'Azul'),
('Crusade', 52, 2, 'Enchantment', 'White creatures get +1/+1.', NULL, NULL, 'Branco'),
('Crystal Rod', 53, 1, 'Artifact', 'Whenever a player casts a blue spell, you may pay {1}. If you do, you gain 1 life.', NULL, NULL, 'Incolor'),
('Cursed Land', 54, 4, 'Enchantment — Aura', 'Enchant land At the beginning of the upkeep of enchanted land’s controller, this Aura deals 1 damage', NULL, NULL, 'Preto'),
('Cyclopean Tomb', 55, 4, 'Artifact', '{2}, {T}: Put a mire counter on target non-Swamp land. That land is a Swamp for as long as it has a ', NULL, NULL, 'Incolor'),
('Darkpact', 56, 3, 'Sorcery', 'Remove Darkpact from your deck before playing if you’re not playing for ante. You own target card in', NULL, NULL, 'Preto'),
('Dark Ritual', 57, 1, 'Instant', 'Add {B}{B}{B}.', NULL, NULL, 'Preto'),
('Deathgrip', 58, 2, 'Enchantment', '{B}{B}: Counter target green spell.', NULL, NULL, 'Preto'),
('Deathlace', 59, 1, 'Instant', 'Target spell or permanent becomes black.', NULL, NULL, 'Preto'),
('Death Ward', 60, 1, 'Instant', 'Regenerate target creature.', NULL, NULL, 'Branco'),
('Demonic Attorney', 61, 3, 'Sorcery', 'Remove Demonic Attorney from your deck before playing if you’re not playing for ante. Each player an', NULL, NULL, 'Preto');

-- --------------------------------------------------------

--
-- Estrutura para tabela `deck`
--

CREATE TABLE `deck` (
  `id` int(5) NOT NULL,
  `dono` varchar(100) DEFAULT NULL,
  `nome_deck` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `deck_cartas`
--

CREATE TABLE `deck_cartas` (
  `carta` int(5) DEFAULT NULL,
  `quantidade` int(2) DEFAULT NULL,
  `pertence` int(5) DEFAULT NULL,
  `deck` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `email` varchar(255) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cartas`
--
ALTER TABLE `cartas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices de tabela `deck`
--
ALTER TABLE `deck`
  ADD PRIMARY KEY (`id`),
  ADD KEY `dono` (`dono`);

--
-- Índices de tabela `deck_cartas`
--
ALTER TABLE `deck_cartas`
  ADD KEY `carta` (`carta`),
  ADD KEY `deck` (`deck`);

--
-- Índices de tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`email`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cartas`
--
ALTER TABLE `cartas`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=62;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `deck`
--
ALTER TABLE `deck`
  ADD CONSTRAINT `deck_ibfk_1` FOREIGN KEY (`dono`) REFERENCES `usuario` (`nome`);

--
-- Restrições para tabelas `deck_cartas`
--
ALTER TABLE `deck_cartas`
  ADD CONSTRAINT `deck_cartas_ibfk_1` FOREIGN KEY (`carta`) REFERENCES `cartas` (`id`),
  ADD CONSTRAINT `deck_cartas_ibfk_2` FOREIGN KEY (`deck`) REFERENCES `deck` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
