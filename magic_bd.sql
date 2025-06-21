-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21/06/2025 às 04:48
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
  `descricao` varchar(100) DEFAULT NULL,
  `poder` int(2) DEFAULT NULL,
  `resistencia` int(2) DEFAULT NULL,
  `cor` varchar(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cartas`
--

INSERT INTO `cartas` (`nome`, `id`, `mana`, `tipo`, `descricao`, `poder`, `resistencia`, `cor`) VALUES
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
('Demonic Attorney', 61, 3, 'Sorcery', 'Remove Demonic Attorney from your deck before playing if you’re not playing for ante. Each player an', NULL, NULL, 'Preto'),
('Demonic Hordes', 62, 6, 'Creature — Demon', '{T}: Destroy target land. At the beginning of your upkeep, unless you pay {B}{B}{B}, tap this creatu', 5, 5, 'Preto'),
('Demonic Tutor', 63, 2, 'Sorcery', 'Search your library for a card, put that card into your hand, then shuffle.', NULL, NULL, 'Preto'),
('Dingus Egg', 64, 4, 'Artifact', 'Whenever a land is put into a graveyard from the battlefield, this artifact deals 2 damage to that l', NULL, NULL, 'Incolor'),
('Disenchant', 65, 2, 'Instant', 'Destroy target artifact or enchantment.', NULL, NULL, 'Branco'),
('Disintegrate', 66, 1, 'tipo', 'Disintegrate deals X damage to any target. If it’s a creature, it can’t be regenerated this turn, an', NULL, NULL, 'Vermelho'),
('Disrupting Scepter', 67, 3, 'Artifact', '{3}, {T}: Target player discards a card. Activate only during your turn.', NULL, NULL, 'Incolor'),
('Dragon Whelp', 68, 4, 'Creature — Dragon', 'Flying {R}: This creature gets +1/+0 until end of turn. If this ability has been activated four or m', 2, 3, 'Vermelho'),
('Drain Life', 69, 2, 'Sorcery', 'Spend only black mana on X. Drain Life deals X damage to any target. You gain life equal to the dama', NULL, NULL, 'Preto'),
('Drain Power', 70, 2, 'Sorcery', 'Target player activates a mana ability of each land they control. Then that player loses all unspent', NULL, NULL, 'Azul'),
('Drudge Skeletons', 71, 2, 'Creature — Skeleton', '{B}: Regenerate this creature.', 1, 1, 'Preto'),
('Dwarven Demolition Team', 72, 3, 'Creature — Dwarf', '{T}: Destroy target Wall.', 1, 1, 'Vermelho'),
('Dwarven Warriors', 73, 3, 'Creature — Dwarf Warrior', '{T}: Target creature with power 2 or less can’t be blocked this turn.', 1, 1, 'Vermelho'),
('Earthbind', 74, 1, 'Enchantment — Aura', 'Enchant creature When Earthbind enters, if enchanted creature has flying, Earthbind deals 2 damage t', NULL, NULL, 'Vermelho'),
('Earth Elemental', 75, 5, 'Creature — Elemental', '', 4, 5, 'Vermelho'),
('Earthquake', 76, 1, 'Sorcery', 'Earthquake deals X damage to each creature without flying and each player.', NULL, NULL, 'Vermelho'),
('Elvish Archers', 77, 2, 'Creature — Elf Archer', 'First strike', 1, 2, 'Verde'),
('Evil Presence', 78, 1, 'Enchantment — Aura', 'Enchant land Enchanted land is a Swamp.', NULL, NULL, 'Preto'),
('False Orders', 79, 1, 'Instant', 'Cast this spell only during the declare blockers step. Remove target creature defending player contr', NULL, NULL, 'Vermelho'),
('Farmstead', 80, 3, 'Enchantment — Aura', 'Enchant land Enchanted land has “At the beginning of your upkeep, you may pay {W}{W}. If you do, you', NULL, NULL, 'Branco'),
('Fastbond', 81, 1, 'Enchantment', 'You may play any number of lands on each of your turns. Whenever you play a land, if it wasn’t the f', NULL, NULL, 'Verde'),
('Fear', 82, 2, 'Enchantment — Aura', 'Enchant creature Enchanted creature has fear.', NULL, NULL, 'Preto'),
('Feedback', 83, 3, 'Enchantment — Aura', 'Enchant enchantment At the beginning of the upkeep of enchanted enchantment’s controller, this Aura ', NULL, NULL, 'Preto'),
('Fireball', 84, 1, 'Sorcery', 'This spell costs {1} more to cast for each target beyond the first. Fireball deals X damage divided ', NULL, NULL, 'Vermelho'),
('Firebreathing', 85, 1, 'Enchantment — Aura', 'Enchant creature {R}: Enchanted creature gets +1/+0 until end of turn.', NULL, NULL, 'Vermelho'),
('Fire Elemental', 86, 5, 'Creature — Elemental', '', 5, 4, 'Vermelho'),
('Flashfires', 87, 4, 'Sorcery', 'Destroy all Plains.', NULL, NULL, 'Vermelho'),
('Flight', 88, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has flying.', NULL, NULL, 'Azul'),
('Fog', 89, 1, 'Instant', 'Prevent all combat damage that would be dealt this turn.', NULL, NULL, 'Verde'),
('Forcefield', 90, 3, 'Artifact', '{1}: The next time an unblocked creature of your choice would deal combat damage to you this turn, p', NULL, NULL, 'Incolor'),
('Forest', 91, 0, 'Basic Land — Forest', '{T}: Add {G}.', NULL, NULL, 'Incolor'),
('Fork', 92, 2, 'Instant', 'Copy target instant or sorcery spell, except that the copy is red. You may choose new targets for th', NULL, NULL, 'Vermelho'),
('Force of Nature', 93, 6, 'Creature — Elemental', 'Trample At the beginning of your upkeep, this creature deals 8 damage to you unless you pay {G}{G}{G', 8, 8, 'Verde'),
('Frozen Shade', 94, 3, 'Creature — Shade', '{B}: This creature gets +1/+1 until end of turn.', 0, 1, 'Preto'),
('Fungusaur', 95, 4, 'Creature — Fungus Dinosaur', 'Whenever this creature is dealt damage, put a +1/+1 counter on it.', NULL, NULL, 'Verde'),
('Gaeas Liege', 96, 6, 'Creature — Avatar', 'As long as Gaea’s Liege isn’t attacking, its power and toughness are each equal to the number of For', 0, 0, 'Verde'),
('Gauntlet of Might', 97, 4, 'Artifact', 'Red creatures get +1/+1. Whenever a Mountain is tapped for mana, its controller adds an additional {', NULL, NULL, 'Incolor'),
('Giant Growth', 98, 1, 'Instant', 'Target creature gets +3/+3 until end of turn.', NULL, NULL, 'Verde'),
('Giant Spider', 99, 4, 'Creature — Spider', 'Reach', 2, 4, 'Verde'),
('Glasses of Urza', 100, 1, 'Artifact', '{T}: Look at target player’s hand.', NULL, NULL, 'Incolor'),
('Gloom', 101, 3, 'Enchantment', 'White spells cost {3} more to cast. Activated abilities of white enchantments cost {3} more to activ', NULL, NULL, 'Preto'),
('Goblin Balloon Brigade', 102, 1, 'Creature — Goblin Warrior', '{R}: This creature gains flying until end of turn.', 1, 1, 'Vermelho'),
('Goblin King', 103, 3, 'Creature — Goblin', 'Other Goblins get +1/+1 and have mountainwalk.', 2, 2, 'Vermelho'),
('Granite Gargoyle', 104, 3, 'Creature — Gargoyle', 'Flying {R}: This creature gets +0/+1 until end of turn.', 2, 2, 'Vermelho'),
('Gray Ogre', 105, 3, 'Creature — Ogre', '', 2, 2, 'Vermelho'),
('Green Ward', 106, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has protection from green. This effect doesn’t remove this Aura.', NULL, NULL, 'Branco'),
('Grizzly Bears', 107, 2, 'Creature — Bear', '', 2, 2, 'Verde'),
('Guardian Angel', 108, 1, 'Instant', 'Prevent the next X damage that would be dealt to any target this turn. Until end of turn, you may pa', NULL, NULL, 'Branco'),
('Healing Salve', 109, 1, 'Instant', 'Choose one — • Target player gains 3 life. • Prevent the next 3 damage that would be dealt to any ta', NULL, NULL, 'Branco'),
('Helm of Chatzuk', 110, 1, 'Artifact', '{1}, {T}: Target creature gains banding until end of turn. (', NULL, NULL, 'Incolor'),
('Hill Giant', 111, 4, 'Creature — Giant', '', 3, 3, 'Vermelho'),
('Holy Armor', 112, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature gets +0/+2. {W}: Enchanted creature gets +0/+1 until end of turn', NULL, NULL, 'Branco'),
('Holy Strength', 113, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature gets +1/+2.', NULL, NULL, 'Branco'),
('Howl from Beyond', 114, 1, 'Instant', 'Target creature gets +X/+0 until end of turn.', NULL, NULL, 'Preto'),
('Howling Mine', 115, 2, 'Artifact', 'At the beginning of each player’s draw step, if this artifact is untapped, that player draws an addi', NULL, NULL, 'Incolor'),
('Hurloon Minotaur', 116, 3, 'Creature — Minotaur', '', 2, 3, 'Vermelho'),
('Hurricane', 117, 1, 'Sorcery', 'Hurricane deals X damage to each creature with flying and each player.', NULL, NULL, 'Verde'),
('Hypnotic Specte', 118, 3, 'Creature — Specter', 'Whenever this creature deals damage to an opponent, that player discards a card at random.', 2, 2, 'Preto'),
('Ice Storm', 119, 3, 'Sorcery', 'Destroy target land.', NULL, NULL, 'Verde'),
('Icy Manipulator', 120, 4, 'Artifact', '{1}, {T}: Tap target artifact, creature, or land.', NULL, NULL, 'Incolor'),
('Illusionary Mask', 121, 2, 'Artifact', '{X}: You may choose a creature card in your hand whose mana cost could be paid by some amount of, or', NULL, NULL, 'Incolor'),
('Invisibility', 122, 2, 'Enchantment — Aura', 'Enchant creature Enchanted creature can’t be blocked except by Walls.', NULL, NULL, 'Azul'),
('Ironclaw Orcs', 123, 2, 'Creature — Orc', 'This creature can’t block creatures with power 2 or greater.', 2, 2, 'Vermelho'),
('Ironroot Treefolk', 124, 5, 'Creature — Treefolk', '', 3, 5, 'Verde'),
('Instill Energy', 125, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature can attack as though it had haste. {0}: Untap enchanted creature', NULL, NULL, 'Verde'),
('Iron Star', 126, 1, 'Artifact', 'Whenever a player casts a red spell, you may pay {1}. If you do, you gain 1 life.', NULL, NULL, 'Incolor'),
('Island', 127, 0, 'Basic Land — Island', '{T}: Add {U}.', NULL, NULL, 'Incolor'),
('Island Sanctuary', 128, 2, 'Enchantment', 'If you would draw a card during your draw step, instead you may skip that draw. If you do, until you', NULL, NULL, 'Branco'),
('Ivory Cup', 129, 1, 'Artifact', 'Whenever a player casts a white spell, you may pay {1}. If you do, you gain 1 life.', NULL, NULL, 'Incolor'),
('Jade Monolith', 130, 4, 'Artifact', '{1}: The next time a source of your choice would deal damage to target creature this turn, that sour', NULL, NULL, 'Incolor'),
('Jade Statue', 131, 4, 'Artifact', '{2}: This artifact becomes a 3/6 Golem artifact creature until end of combat. Activate only during c', NULL, NULL, 'Incolor'),
('Jayemdae Tome', 132, 4, 'Artifact', '{4}, {T}: Draw a card.', NULL, NULL, 'Incolor'),
('Juggernaut', 133, 4, 'Artifact Creature — Juggernaut', 'This creature attacks each combat if able. This creature can’t be blocked by Walls.', 5, 3, 'Incolor'),
('Jump', 134, 1, 'Instant', 'Target creature gains flying until end of turn.', NULL, NULL, 'Azul'),
('Karma', 135, 5, 'Enchantment', 'At the beginning of each player’s upkeep, this enchantment deals damage to that player equal to the ', NULL, NULL, 'Branco'),
('Keldon Warlord', 136, 4, 'Creature — Human Barbarian', 'Keldon Warlord’s power and toughness are each equal to the number of non-Wall creatures you control.', 0, 0, 'Vermelho'),
('Kormus Bell', 137, 4, 'Artifact', 'All Swamps are 1/1 black creatures that are still lands.', NULL, NULL, 'Incolor'),
('Kudzu', 138, 3, 'Enchantment — Aura', 'Enchant land When enchanted land becomes tapped, destroy it. That land’s controller may attach this ', NULL, NULL, 'Verde'),
('Lance', 139, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has first strike.', NULL, NULL, 'Branco'),
('Ley Druid', 140, 3, 'Creature — Human Druid', '{T}: Untap target land.', 1, 1, 'Verde'),
('Library of Leng', 141, 1, 'Artifact', 'You have no maximum hand size. If an effect causes you to discard a card, discard it, but you may pu', NULL, NULL, 'Incolor'),
('Lich', 142, 4, 'Enchantment', 'As this enchantment enters, you lose life equal to your life total. You don’t lose the game for havi', NULL, NULL, 'Preto'),
('Lifeforce', 143, 2, 'Enchantment', '{G}{G}: Counter target black spell.', NULL, NULL, 'Verde'),
('Lifelace', 144, 1, 'Instant', 'Target spell or permanent becomes green.', NULL, NULL, 'Verde'),
('Lifetap', 145, 2, 'Enchantment', 'Whenever a Forest an opponent controls becomes tapped, you gain 1 life.', NULL, NULL, 'Azul'),
('Lightning Bolt', 146, 1, 'Instant', 'Lightning Bolt deals 3 damage to any target.', NULL, NULL, 'Vermelho'),
('Living Artifact', 147, 1, 'Enchantment — Aura', 'Enchant artifact Whenever you’re dealt damage, put that many vitality counters on this Aura. At the ', NULL, NULL, 'Verde'),
('Living Lands', 148, 4, 'Enchantment', 'All Forests are 1/1 creatures that are still lands.', NULL, NULL, 'Verde'),
('Living Wall', 149, 4, 'Artifact Creature — Wall', 'Defender {1}: Regenerate Living Wall.', 0, 6, 'Incolor'),
('Llanowar Elves', 150, 1, 'Creature — Elf Druid', '{T}: Add {G}.', 1, 1, 'Verde'),
('Lord of Atlantis', 151, 2, 'Creature — Merfolk', 'Other Merfolk get +1/+1 and have islandwalk.', 2, 2, 'Azul'),
('Lord of the Pit', 152, 7, 'Creature — Demon', 'Flying, trample At the beginning of your upkeep, sacrifice a creature other than this creature. If y', 7, 7, 'Preto'),
('Lure', 153, 3, 'Enchantment — Aura', 'Enchant creature All creatures able to block enchanted creature do so.', NULL, NULL, 'Verde'),
('Magical Hack', 154, 1, 'Instant', 'Change the text of target spell or permanent by replacing all instances of one basic land type with ', NULL, NULL, 'Azul'),
('Mahamoti Djinn', 155, 6, 'Creature — Djinn', 'Flying ', 5, 6, 'Azul'),
('Manabarbs', 156, 4, 'Enchantment', 'Whenever a player taps a land for mana, this enchantment deals 1 damage to that player.', NULL, NULL, 'Vermelho'),
('Mana Flare', 157, 3, 'Enchantment', 'Whenever a player taps a land for mana, that player adds one mana of any type that land produced.', NULL, NULL, 'Vermelho'),
('Mana Short', 158, 3, 'Instant', 'Tap all lands target player controls and that player loses all unspent mana.', NULL, NULL, 'Azul'),
('Mana Vault', 159, 1, 'Artifact', 'This artifact doesn’t untap during your untap step. At the beginning of your upkeep, you may pay {4}', NULL, NULL, 'Incolor'),
('Meekstone', 160, 1, 'Artifact', 'Creatures with power 3 or greater don’t untap during their controllers’ untap steps.', NULL, NULL, 'Incolor'),
('Merfolk of the Pearl Trident', 161, 1, 'Creature — Merfolk', '', 1, 1, 'Azul'),
('Mesa Pegasus', 162, 2, 'Creature — Pegasus', 'Flying; banding', 1, 1, 'Branco'),
('Mind Twist', 163, 1, 'Sorcery', 'Target player discards X cards at random.', NULL, NULL, 'Preto'),
('Monss Goblin Raiders', 164, 1, 'Creature — Goblin', '', 1, 1, 'Vermelho'),
('Mountain', 165, 1, 'Basic Land — Mountain', '{T}: Add {R}.', NULL, NULL, 'Incolor'),
('Mox Emerald', 166, 0, 'Artifact', '{T}: Add {G}.', NULL, NULL, 'Incolor'),
('Mox Jet', 167, 0, 'Artifact', '{T}: Add {B}.', NULL, NULL, 'Incolor'),
('Mox Pearl', 168, 0, 'Artifact', '{T}: Add {W}.', NULL, NULL, 'Incolor'),
('Mox Ruby', 169, 0, 'Artifact', '{T}: Add {R}.', NULL, NULL, 'Incolor'),
('Mox Sapphire', 170, 0, 'Artifact', '{T}: Add {U}.', NULL, NULL, 'Incolor'),
('Natural Selection', 171, 1, 'Instant', 'Look at the top three cards of target player’s library, then put them back in any order. You may hav', NULL, NULL, 'Verde'),
('Nether Shadow', 172, 2, 'Creature — Spirit', 'Haste At the beginning of your upkeep, if this card is in your graveyard with three or more creature', 1, 1, 'Preto'),
('Nettling Imp', 173, 3, 'Creature — Imp', '{T}: Choose target non-Wall creature the active player has controlled continuously since the beginni', 1, 1, 'Preto'),
('Nevinyrrals Disk', 174, 4, 'Artifact', 'This artifact enters tapped. {1}, {T}: Destroy all artifacts, creatures, and enchantments.', NULL, NULL, 'Incolor'),
('Nightmare', 175, 6, 'Creature — Nightmare Horse', 'Flying Nightmare’s power and toughness are each equal to the number of Swamps you control.', NULL, NULL, 'Preto'),
('Northern Paladin', 176, 4, 'Creature — Human Knight', '{W}{W}, {T}: Destroy target black permanent.', 3, 3, 'Branco'),
('Obsianus Golem', 177, 6, 'Artifact Creature — Golem', '', 4, 6, 'Incolor'),
('Orcish Artillery', 178, 3, 'Creature — Orc Warrior', '{T}: This creature deals 2 damage to any target and 3 damage to you.', 1, 3, 'Vermelho'),
('Orcish Oriflamme', 179, 4, 'Enchantment', 'Attacking creatures you control get +1/+0.', NULL, NULL, 'Vermelho'),
('Paralyze', 180, 1, 'Enchantment — Aura', 'Enchant creature When this Aura enters, tap enchanted creature. Enchanted creature doesn’t untap dur', NULL, NULL, 'Preto'),
('Pearled Unicorn', 181, 3, 'Creature — Unicorn', '', 2, 2, 'Branco'),
('Personal Incarnation', 182, 6, 'Creature — Avatar Incarnation', '{0}: The next 1 damage that would be dealt to this creature this turn is dealt to its owner instead.', 6, 6, 'Branco'),
('Pestilence', 183, 4, 'Enchantment', 'At the beginning of the end step, if no creatures are on the battlefield, sacrifice this enchantment', NULL, NULL, 'Preto'),
('Phantasmal Forces', 184, 4, 'Creature — Illusion', 'Flying At the beginning of your upkeep, sacrifice this creature unless you pay {U}.', 4, 1, 'Azul'),
('Phantasmal Terrain', 185, 2, 'Enchantment — Aura', 'Enchant land As this Aura enters, choose a basic land type. Enchanted land is the chosen type.', NULL, NULL, 'Azul'),
('Phantom Monster', 186, 4, 'Creature — Illusion', 'Flying', 3, 3, 'Azul'),
('Pirate Ship', 187, 5, 'Creature — Human Pirate', 'This creature can’t attack unless defending player controls an Island. {T}: This creature deals 1 da', 4, 3, 'Azul'),
('Plague Rats', 188, 3, 'Creature — Rat', 'Plague Rats’s power and toughness are each equal to the number of creatures named Plague Rats on the', 0, 0, 'Preto'),
('Plains', 189, 0, 'Basic Land — Plains', '{T}: Add {W}.', NULL, NULL, 'Incolor'),
('Plateau', 190, 0, 'Land — Mountain Plains', '{T}: Add {R} or {W}.', NULL, NULL, 'Incolor'),
('Power Leak', 191, 2, 'Enchantment — Aura', 'Enchant enchantment At the beginning of the upkeep of enchanted enchantment’s controller, that playe', NULL, NULL, 'Azul'),
('Power Sink', 192, 1, 'Instant', 'Counter target spell unless its controller pays {X}. If that player doesn’t, they tap all lands with', NULL, NULL, 'Azul'),
('Power Surge', 193, 2, 'Enchantment', 'At the beginning of each player’s upkeep, this enchantment deals X damage to that player, where X is', NULL, NULL, 'Vermelho'),
('Psionic Blast', 194, 3, 'Instant', 'Psionic Blast deals 4 damage to any target and 2 damage to you.', NULL, NULL, 'Azul'),
('Psychic Venom', 195, 2, 'Enchantment — Aura', 'Enchant land Whenever enchanted land becomes tapped, this Aura deals 2 damage to that land’s control', NULL, NULL, 'Azul'),
('Purelace', 196, 1, 'Instant', 'Target spell or permanent becomes white.', NULL, NULL, 'Branco'),
('Prodigal Sorcerer', 197, 3, 'Creature — Human Wizard', '{T}: This creature deals 1 damage to any target.', 1, 1, 'Azul'),
('Raging River', 198, 2, 'Enchantment', 'Whenever one or more creatures you control attack, each defending player divides all creatures witho', NULL, NULL, 'Vermelho'),
('Raise Dead', 199, 1, 'Sorcery', 'Return target creature card from your graveyard to your hand.', NULL, NULL, 'Preto'),
('Red Elemental Blast', 200, 1, 'Instant', 'Choose one —• Counter target blue spell.• Destroy target blue permanent.', NULL, NULL, 'Vermelho'),
('Red Ward', 201, 1, 'Enchantment — Aura', 'Enchant creature Enchanted creature has protection from red. This effect doesn’t remove this Aura.', NULL, NULL, 'Branco'),
('Regeneration', 202, 2, 'Enchantment — Aura', 'Enchant creature {G}: Regenerate enchanted creature.', NULL, NULL, 'Verde'),
('Regrowth', 203, 2, 'Sorcery', 'Return target card from your graveyard to your hand.', NULL, NULL, 'Verde'),
('Resurrection', 204, 4, 'Sorcery', 'Return target creature card from your graveyard to the battlefield.', NULL, NULL, 'Branco'),
('Reverse Damage', 205, 3, 'Instant', 'The next time a source of your choice would deal damage to you this turn, prevent that damage. You g', NULL, NULL, 'Branco'),
('Righteousness', 206, 1, 'Instant', 'Target blocking creature gets +7/+7 until end of turn.', NULL, NULL, 'Branco'),
('Rock Hydra', 207, 2, 'Creature — Hydra', 'This creature enters with X +1/+1 counters on it. For each 1 damage that would be dealt to this crea', 0, 0, 'Vermelho'),
('Roc of Kher Ridges', 208, 4, 'Creature — Bird', 'Flying', 3, 3, 'Vermelho'),
('Rod of Ruin', 209, 4, 'Artifact', '{3}, {T}: This artifact deals 1 damage to any target.', NULL, NULL, 'Incolor');

-- --------------------------------------------------------

--
-- Estrutura para tabela `deck`
--

CREATE TABLE `deck` (
  `id` int(11) NOT NULL,
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
  `deck` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuario`
--

CREATE TABLE `usuario` (
  `email` varchar(255) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `partidas` int(3) DEFAULT NULL,
  `vitorias` int(3) DEFAULT NULL
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
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=210;

--
-- AUTO_INCREMENT de tabela `deck`
--
ALTER TABLE `deck`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

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
