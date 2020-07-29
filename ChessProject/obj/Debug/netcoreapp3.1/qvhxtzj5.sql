  IF EXISTS(SELECT 1 FROM information_schema.tables 
  WHERE table_name = '
'__EFMigrationsHistory'' AND table_schema = DATABASE()) 
BEGIN
CREATE TABLE `__EFMigrationsHistory` (
    `MigrationId` varchar(150) NOT NULL,
    `ProductVersion` varchar(32) NOT NULL,
    PRIMARY KEY (`MigrationId`)
);

END;

CREATE TABLE `Board` (
    `Id` int NOT NULL AUTO_INCREMENT,
    PRIMARY KEY (`Id`)
);

CREATE TABLE `Game` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` text NULL,
    `PlayerWhite` text NULL,
    `PlayerBlack` text NULL,
    `BeginPlay` datetime NOT NULL,
    `BoardId` int NOT NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Game_Board_BoardId` FOREIGN KEY (`BoardId`) REFERENCES `Board` (`Id`) ON DELETE CASCADE
);

CREATE TABLE `Piece` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` text NULL,
    `PositionX` text NULL,
    `PositionY` text NULL,
    `Color` text NULL,
    `Dead` bit NOT NULL,
    `BoardId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Piece_Board_BoardId` FOREIGN KEY (`BoardId`) REFERENCES `Board` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Square` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `PositionX` text NULL,
    `PositionY` text NULL,
    `Color` text NULL,
    `Empty` bit NOT NULL,
    `PieceId` int NOT NULL,
    `BoardId` int NULL,
    PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Square_Board_BoardId` FOREIGN KEY (`BoardId`) REFERENCES `Board` (`Id`) ON DELETE RESTRICT,
    CONSTRAINT `FK_Square_Piece_PieceId` FOREIGN KEY (`PieceId`) REFERENCES `Piece` (`Id`) ON DELETE CASCADE
);

CREATE INDEX `IX_Game_BoardId` ON `Game` (`BoardId`);

CREATE INDEX `IX_Piece_BoardId` ON `Piece` (`BoardId`);

CREATE INDEX `IX_Square_BoardId` ON `Square` (`BoardId`);

CREATE INDEX `IX_Square_PieceId` ON `Square` (`PieceId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20200729130407_InitialCreate', '3.1.6');

