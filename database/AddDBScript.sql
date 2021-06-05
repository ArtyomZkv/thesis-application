-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema it-cube
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema it-cube
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `it-cube` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `it-cube` ;

-- -----------------------------------------------------
-- Table `it-cube`.`directions`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`directions` (
  `iddirection` CHAR(36) NOT NULL,
  `diractionname` VARCHAR(100) NULL DEFAULT NULL,
  `hoursqunatity` INT NULL DEFAULT NULL,
  PRIMARY KEY (`iddirection`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it-cube`.`globalgroup`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`globalgroup` (
  `globalgrpID` CHAR(36) NOT NULL,
  `groupname` VARCHAR(100) NOT NULL,
  `groupdirection` VARCHAR(100) NOT NULL,
  `groupsize` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`globalgrpID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it-cube`.`students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`students` (
  `ID` CHAR(36) NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `dateofbirth` DATE NOT NULL,
  `parentsname` VARCHAR(100) NULL DEFAULT NULL,
  `district` VARCHAR(100) NOT NULL,
  `city` VARCHAR(100) NOT NULL,
  `study` VARCHAR(100) NULL DEFAULT NULL,
  `phone` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `date` DATE NOT NULL,
  `groupid` CHAR(36) NOT NULL,
  `directionid` CHAR(36) NOT NULL,
  `parentsphone` CHAR(12) NULL DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE INDEX `id_UNIQUE` (`ID` ASC) VISIBLE,
  INDEX `directionid_idx` (`directionid` ASC) VISIBLE,
  INDEX `globalgrpID_idx` (`groupid` ASC) VISIBLE,
  CONSTRAINT `directionid`
    FOREIGN KEY (`directionid`)
    REFERENCES `it-cube`.`directions` (`iddirection`),
  CONSTRAINT `globalgrpID`
    FOREIGN KEY (`groupid`)
    REFERENCES `it-cube`.`globalgroup` (`globalgrpID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it-cube`.`projects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`projects` (
  `idproject` CHAR(36) NOT NULL,
  `projectname` VARCHAR(100) NOT NULL,
  `idstudent` CHAR(36) NOT NULL,
  PRIMARY KEY (`idproject`),
  UNIQUE INDEX `idproject_UNIQUE` (`idproject` ASC) VISIBLE,
  INDEX `idstudent` (`idstudent` ASC) VISIBLE,
  CONSTRAINT `idstudent`
    FOREIGN KEY (`idstudent`)
    REFERENCES `it-cube`.`students` (`ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it-cube`.`academicperfomance`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`academicperfomance` (
  `idacademicperfomance` CHAR(36) NOT NULL,
  `Idstudent` CHAR(36) NOT NULL,
  `attendance` VARCHAR(2) NULL DEFAULT NULL,
  `lessontopic` VARCHAR(100) NULL DEFAULT NULL,
  `date` CHAR(20) NOT NULL,
  `idproject` CHAR(36) NOT NULL,
  PRIMARY KEY (`idacademicperfomance`),
  UNIQUE INDEX `idacademicperfomance_UNIQUE` (`idacademicperfomance` ASC) VISIBLE,
  INDEX `idstudents_idx` (`Idstudent` ASC) VISIBLE,
  INDEX `Idproject_idx` (`idproject` ASC) VISIBLE,
  CONSTRAINT `Idproject`
    FOREIGN KEY (`idproject`)
    REFERENCES `it-cube`.`projects` (`idproject`),
  CONSTRAINT `Idstudents`
    FOREIGN KEY (`Idstudent`)
    REFERENCES `it-cube`.`students` (`ID`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it-cube`.`auth`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`auth` (
  `login` VARCHAR(50) NOT NULL,
  `password` VARCHAR(50) NOT NULL,
  `admrole` TINYINT(1) NULL DEFAULT NULL,
  `pincode` CHAR(4) NULL DEFAULT NULL,
  PRIMARY KEY (`login`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `it-cube`.`classplan`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `it-cube`.`classplan` (
  `idclassplan` CHAR(36) NOT NULL,
  `idsubject` CHAR(36) NOT NULL,
  `directionname` VARCHAR(45) NOT NULL,
  `hoursqunatity` VARCHAR(45) NOT NULL,
  `beginingdate` DATE NOT NULL,
  `endingdate` DATE NOT NULL,
  PRIMARY KEY (`idclassplan`),
  UNIQUE INDEX `idacademicperfomance_UNIQUE` (`idclassplan` ASC) VISIBLE,
  UNIQUE INDEX `idsubject_UNIQUE` (`idsubject` ASC) VISIBLE,
  CONSTRAINT `classplan_ibfk_1`
    FOREIGN KEY (`idsubject`)
    REFERENCES `it-cube`.`directions` (`iddirection`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
