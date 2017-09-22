-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hisorc_ma
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.25-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `b_contract`
--

DROP TABLE IF EXISTS `b_contract`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_contract` (
  `b_contract_id` int(11) NOT NULL AUTO_INCREMENT,
  `contract_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_method` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_contract_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_contract`
--

LOCK TABLES `b_contract` WRITE;
/*!40000 ALTER TABLE `b_contract` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_contract` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_contract_payer`
--

DROP TABLE IF EXISTS `b_contract_payer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_contract_payer` (
  `b_contract_payer_id` int(11) NOT NULL AUTO_INCREMENT,
  `contract_payer_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_payer_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_payer_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_contract_payer_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_contract_payer`
--

LOCK TABLES `b_contract_payer` WRITE;
/*!40000 ALTER TABLE `b_contract_payer` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_contract_payer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_contract_plans`
--

DROP TABLE IF EXISTS `b_contract_plans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_contract_plans` (
  `b_contract_plans_id` int(11) NOT NULL AUTO_INCREMENT,
  `contract_plans_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_active_from` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_active_to` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_pttype` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_contract_payer_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_contract_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_money_limit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_sort_index` varchar(255) COLLATE utf8_bin DEFAULT '99',
  `r_rp1853_instype_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contract_plans_hide_company` varchar(255) COLLATE utf8_bin DEFAULT '',
  `contract_plans_color` varchar(255) COLLATE utf8_bin DEFAULT '',
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_contract_plans_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_contract_plans`
--

LOCK TABLES `b_contract_plans` WRITE;
/*!40000 ALTER TABLE `b_contract_plans` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_contract_plans` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_deduct`
--

DROP TABLE IF EXISTS `b_deduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_deduct` (
  `b_deduct_id` int(11) NOT NULL AUTO_INCREMENT,
  `deduct_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `deduct_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `deduct_method` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_deduct_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_deduct`
--

LOCK TABLES `b_deduct` WRITE;
/*!40000 ALTER TABLE `b_deduct` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_deduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_deduct_condition`
--

DROP TABLE IF EXISTS `b_deduct_condition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_deduct_condition` (
  `b_deduct_condition_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_deduct_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `deduct_condition_adjustment` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `deduct_condition_draw` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_deduct_condition_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_deduct_condition`
--

LOCK TABLES `b_deduct_condition` WRITE;
/*!40000 ALTER TABLE `b_deduct_condition` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_deduct_condition` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_employee`
--

DROP TABLE IF EXISTS `b_employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_employee` (
  `b_employee_id` int(11) NOT NULL AUTO_INCREMENT,
  `employee_login` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_password` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_last_login` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_last_logout` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_service_point_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_employee_level_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_employee_rule_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_employee_authentication_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_employee_default_tab` varchar(255) COLLATE utf8_bin DEFAULT '',
  `employee_warning_dx` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_bank_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_bank_namet` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `book_bank_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `book_bank_namet` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `payment_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `payment_status_namet` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `charge` decimal(17,2) DEFAULT '0.00',
  `employee_firstnamee` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `employee_lastnamee` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `position_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `position_namet` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `status_employee` varchar(255) COLLATE utf8_bin DEFAULT '',
  `send_service_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `employee_lab_master` varchar(255) COLLATE utf8_bin DEFAULT '',
  `employee_status_approve_control_item` varchar(255) COLLATE utf8_bin DEFAULT '',
  `security_pin` varchar(255) COLLATE utf8_bin DEFAULT '',
  `limit_appointment` varchar(255) COLLATE utf8_bin DEFAULT '20',
  `doctor_lying` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_funds` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_contact` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_admission` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_physical` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `f_doctor_branch_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_employee_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_employee`
--

LOCK TABLES `b_employee` WRITE;
/*!40000 ALTER TABLE `b_employee` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_group_chronic`
--

DROP TABLE IF EXISTS `b_group_chronic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_group_chronic` (
  `b_group_chronic_id` int(11) NOT NULL AUTO_INCREMENT,
  `group_chronic_number` varchar(255) COLLATE utf8_bin NOT NULL,
  `group_chronic_description_th` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `group_chronic_description_en` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `group_chronic_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_group_chronic_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_group_chronic`
--

LOCK TABLES `b_group_chronic` WRITE;
/*!40000 ALTER TABLE `b_group_chronic` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_group_chronic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_icd10`
--

DROP TABLE IF EXISTS `b_icd10`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_icd10` (
  `b_icd10_id` int(11) NOT NULL AUTO_INCREMENT,
  `icd10_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `icd10_description` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `icd10_other_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `icd10_generate_code` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active53` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(1) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`b_icd10_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_icd10`
--

LOCK TABLES `b_icd10` WRITE;
/*!40000 ALTER TABLE `b_icd10` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_icd10` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_icd9`
--

DROP TABLE IF EXISTS `b_icd9`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_icd9` (
  `b_icd9_id` int(11) NOT NULL AUTO_INCREMENT,
  `icd9_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `icd9_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `icd9_other_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `cost` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `icd_10_tm` varchar(255) COLLATE utf8_bin DEFAULT '',
  `active` varchar(1) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`b_icd9_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_icd9`
--

LOCK TABLES `b_icd9` WRITE;
/*!40000 ALTER TABLE `b_icd9` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_icd9` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item`
--

DROP TABLE IF EXISTS `b_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item` (
  `b_item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_common_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_trade_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_nick_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_printable` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_secret` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_item_16_group_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `item_mcode` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_descriptione` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_status_doctor` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `r_rp1253_adpcode_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_unit_packing_qty` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_item_lab_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `r_rp1253_charitem_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_specified` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `cscode` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `row_color` varchar(255) COLLATE utf8_bin DEFAULT '',
  `item_alert` varchar(255) COLLATE utf8_bin DEFAULT '',
  `sort_lab` varchar(255) COLLATE utf8_bin DEFAULT '999999',
  PRIMARY KEY (`b_item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item`
--

LOCK TABLES `b_item` WRITE;
/*!40000 ALTER TABLE `b_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_16_group`
--

DROP TABLE IF EXISTS `b_item_16_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_16_group` (
  `b_item_16_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_16_group_number` varchar(255) COLLATE utf8_bin DEFAULT '',
  `item_16_group_description` varchar(255) COLLATE utf8_bin DEFAULT '',
  `item_16_group_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `billgroup_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  PRIMARY KEY (`b_item_16_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_16_group`
--

LOCK TABLES `b_item_16_group` WRITE;
/*!40000 ALTER TABLE `b_item_16_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_16_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_billing_subgroup`
--

DROP TABLE IF EXISTS `b_item_billing_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_billing_subgroup` (
  `b_item_billing_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_billing_subgroup_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_billing_subgroup_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_item_billing_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_billing_subgroup_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_billing_subgroup_descriptione` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_billing_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_billing_subgroup`
--

LOCK TABLES `b_item_billing_subgroup` WRITE;
/*!40000 ALTER TABLE `b_item_billing_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_billing_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_drug_standard`
--

DROP TABLE IF EXISTS `b_item_drug_standard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_drug_standard` (
  `b_item_drug_standard_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_drug_standard_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_drug_standard_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_drug_standard_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_drug_standard_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_drug_standard`
--

LOCK TABLES `b_item_drug_standard` WRITE;
/*!40000 ALTER TABLE `b_item_drug_standard` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_drug_standard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_drug_standard_map_item`
--

DROP TABLE IF EXISTS `b_item_drug_standard_map_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_drug_standard_map_item` (
  `b_item_drug_standard_map_item_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_item_drug_standard_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_drug_standard_map_item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_drug_standard_map_item`
--

LOCK TABLES `b_item_drug_standard_map_item` WRITE;
/*!40000 ALTER TABLE `b_item_drug_standard_map_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_drug_standard_map_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_drug_uom`
--

DROP TABLE IF EXISTS `b_item_drug_uom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_drug_uom` (
  `b_item_drug_uom_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_drug_uom_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_drug_uom_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_drug_uom_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_drug_uom_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_drug_uom`
--

LOCK TABLES `b_item_drug_uom` WRITE;
/*!40000 ALTER TABLE `b_item_drug_uom` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_drug_uom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_group`
--

DROP TABLE IF EXISTS `b_item_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_group` (
  `b_item_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_group_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_group_staff_owner` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_price` decimal(17,2) DEFAULT '0.00',
  `item_group_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `item_group` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_item_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_group`
--

LOCK TABLES `b_item_group` WRITE;
/*!40000 ALTER TABLE `b_item_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_lab_group`
--

DROP TABLE IF EXISTS `b_item_lab_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_lab_group` (
  `b_item_lab_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_lab_set_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_lab_group_item_name` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_item_lab_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_lab_group`
--

LOCK TABLES `b_item_lab_group` WRITE;
/*!40000 ALTER TABLE `b_item_lab_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_lab_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_lab_set`
--

DROP TABLE IF EXISTS `b_item_lab_set`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_lab_set` (
  `b_item_lab_set_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_lab_set_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_lab_set_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_lab_set_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_lab_set`
--

LOCK TABLES `b_item_lab_set` WRITE;
/*!40000 ALTER TABLE `b_item_lab_set` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_lab_set` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_price`
--

DROP TABLE IF EXISTS `b_item_price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_price` (
  `b_item_price_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_price_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_price_active_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_price` decimal(17,2) DEFAULT NULL,
  `item_price_cost` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_price_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_price`
--

LOCK TABLES `b_item_price` WRITE;
/*!40000 ALTER TABLE `b_item_price` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_price` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_set`
--

DROP TABLE IF EXISTS `b_item_set`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_set` (
  `b_item_set_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_item_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_price` decimal(17,2) DEFAULT '0.00',
  `item_set_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  PRIMARY KEY (`b_item_set_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_set`
--

LOCK TABLES `b_item_set` WRITE;
/*!40000 ALTER TABLE `b_item_set` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_set` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_item_subgroup`
--

DROP TABLE IF EXISTS `b_item_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_item_subgroup` (
  `b_item_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_subgroup_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_subgroup_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_item_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `item_subgroup_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_item_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_item_subgroup`
--

LOCK TABLES `b_item_subgroup` WRITE;
/*!40000 ALTER TABLE `b_item_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_item_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_ncd_group`
--

DROP TABLE IF EXISTS `b_ncd_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_ncd_group` (
  `b_ncd_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `ncd_group_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `ncd_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `ncd_group_pattern` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `ncd_group_value` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_group_chronic_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_ncd_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_ncd_group`
--

LOCK TABLES `b_ncd_group` WRITE;
/*!40000 ALTER TABLE `b_ncd_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_ncd_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_service_point`
--

DROP TABLE IF EXISTS `b_service_point`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_service_point` (
  `b_service_point_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_point_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `service_point_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_service_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_service_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `service_point_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `service_point_check` varchar(255) COLLATE utf8_bin DEFAULT '',
  `service_point_operation_room` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `service_point_color` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_service_point_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_service_point`
--

LOCK TABLES `b_service_point` WRITE;
/*!40000 ALTER TABLE `b_service_point` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_service_point` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_site`
--

DROP TABLE IF EXISTS `b_site`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_site` (
  `b_site_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_visit_office_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_full_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_house` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_moo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_tambon` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_amphur` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_changwat` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_postcode` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_admin_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_phone_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_opd_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_receipt_type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_drug_fund_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `address_english` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `site_full_namee` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `date_current` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_vn_day` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_dialog_cal` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_site_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_site`
--

LOCK TABLES `b_site` WRITE;
/*!40000 ALTER TABLE `b_site` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_site` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_visit_bed`
--

DROP TABLE IF EXISTS `b_visit_bed`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_visit_bed` (
  `b_visit_bed_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_visit_room_id` varchar(255) COLLATE utf8_bin NOT NULL,
  `b_visit_ward_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_bed_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_bed_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_bed_book` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_bed_caption` text COLLATE utf8_bin,
  PRIMARY KEY (`b_visit_bed_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_visit_bed`
--

LOCK TABLES `b_visit_bed` WRITE;
/*!40000 ALTER TABLE `b_visit_bed` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_visit_bed` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_visit_clinic`
--

DROP TABLE IF EXISTS `b_visit_clinic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_visit_clinic` (
  `b_visit_clinic_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_clinic_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_clinic_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_service_group_id` varchar(255) COLLATE utf8_bin DEFAULT '7',
  `visit_clinic_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_visit_clinic_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_visit_clinic`
--

LOCK TABLES `b_visit_clinic` WRITE;
/*!40000 ALTER TABLE `b_visit_clinic` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_visit_clinic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_visit_office`
--

DROP TABLE IF EXISTS `b_visit_office`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_visit_office` (
  `b_visit_office_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_office_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_name1` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_name2` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_minis` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_dep` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_specific` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_bed` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_changwat` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_amphur` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_tambon` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_office_moo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`b_visit_office_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_visit_office`
--

LOCK TABLES `b_visit_office` WRITE;
/*!40000 ALTER TABLE `b_visit_office` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_visit_office` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_visit_room`
--

DROP TABLE IF EXISTS `b_visit_room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_visit_room` (
  `b_visit_room_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_visit_ward_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_room_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_room_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_room_public` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_room_book` varchar(255) COLLATE utf8_bin DEFAULT '0',
  PRIMARY KEY (`b_visit_room_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_visit_room`
--

LOCK TABLES `b_visit_room` WRITE;
/*!40000 ALTER TABLE `b_visit_room` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_visit_room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `b_visit_ward`
--

DROP TABLE IF EXISTS `b_visit_ward`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `b_visit_ward` (
  `b_visit_ward_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_ward_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_ward_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_ward_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_ward_color` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`b_visit_ward_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `b_visit_ward`
--

LOCK TABLES `b_visit_ward` WRITE;
/*!40000 ALTER TABLE `b_visit_ward` DISABLE KEYS */;
/*!40000 ALTER TABLE `b_visit_ward` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_blood_group`
--

DROP TABLE IF EXISTS `f_blood_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_blood_group` (
  `f_blood_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `blood_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_blood_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_blood_group`
--

LOCK TABLES `f_blood_group` WRITE;
/*!40000 ALTER TABLE `f_blood_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_blood_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_discharge_status`
--

DROP TABLE IF EXISTS `f_discharge_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_discharge_status` (
  `f_discharge_status_id` int(11) NOT NULL AUTO_INCREMENT,
  `discharge_status_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_discharge_status_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_discharge_status`
--

LOCK TABLES `f_discharge_status` WRITE;
/*!40000 ALTER TABLE `f_discharge_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_discharge_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_education_type`
--

DROP TABLE IF EXISTS `f_education_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_education_type` (
  `f_education_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `education_type_description` varchar(255) COLLATE utf8_bin NOT NULL,
  `education_type_sort_index` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_education_type_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_education_type`
--

LOCK TABLES `f_education_type` WRITE;
/*!40000 ALTER TABLE `f_education_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_education_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_emergency_status`
--

DROP TABLE IF EXISTS `f_emergency_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_emergency_status` (
  `f_emergency_status_id` int(11) NOT NULL AUTO_INCREMENT,
  `emergency_status_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_emergency_status_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_emergency_status`
--

LOCK TABLES `f_emergency_status` WRITE;
/*!40000 ALTER TABLE `f_emergency_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_emergency_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_family_status`
--

DROP TABLE IF EXISTS `f_family_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_family_status` (
  `f_family_status_id` int(11) NOT NULL AUTO_INCREMENT,
  `family_status_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_family_status_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_family_status`
--

LOCK TABLES `f_family_status` WRITE;
/*!40000 ALTER TABLE `f_family_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_family_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_foreigner`
--

DROP TABLE IF EXISTS `f_foreigner`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_foreigner` (
  `f_foreigner_id` int(11) NOT NULL AUTO_INCREMENT,
  `foreigner_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_foreigner_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_foreigner`
--

LOCK TABLES `f_foreigner` WRITE;
/*!40000 ALTER TABLE `f_foreigner` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_foreigner` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_item_billing_group`
--

DROP TABLE IF EXISTS `f_item_billing_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_item_billing_group` (
  `f_item_billing_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_billing_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_item_billing_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_item_billing_group`
--

LOCK TABLES `f_item_billing_group` WRITE;
/*!40000 ALTER TABLE `f_item_billing_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_item_billing_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_item_group`
--

DROP TABLE IF EXISTS `f_item_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_item_group` (
  `f_item_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_item_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_item_group`
--

LOCK TABLES `f_item_group` WRITE;
/*!40000 ALTER TABLE `f_item_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_item_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_item_lab_type`
--

DROP TABLE IF EXISTS `f_item_lab_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_item_lab_type` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_item_lab_type`
--

LOCK TABLES `f_item_lab_type` WRITE;
/*!40000 ALTER TABLE `f_item_lab_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_item_lab_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_marriage`
--

DROP TABLE IF EXISTS `f_marriage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_marriage` (
  `f_marriage_id` int(11) NOT NULL AUTO_INCREMENT,
  `marriag_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_marriage_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_marriage`
--

LOCK TABLES `f_marriage` WRITE;
/*!40000 ALTER TABLE `f_marriage` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_marriage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_nation`
--

DROP TABLE IF EXISTS `f_nation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_nation` (
  `f_nation_id` int(11) NOT NULL,
  `nation_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_nation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_nation`
--

LOCK TABLES `f_nation` WRITE;
/*!40000 ALTER TABLE `f_nation` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_nation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_occupation`
--

DROP TABLE IF EXISTS `f_occupation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_occupation` (
  `f_occupation_id` int(11) NOT NULL AUTO_INCREMENT,
  `occupation_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT '3',
  PRIMARY KEY (`f_occupation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_occupation`
--

LOCK TABLES `f_occupation` WRITE;
/*!40000 ALTER TABLE `f_occupation` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_occupation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_order_status`
--

DROP TABLE IF EXISTS `f_order_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_order_status` (
  `f_order_status_id` int(11) NOT NULL AUTO_INCREMENT,
  `order_status_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_order_status_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_order_status`
--

LOCK TABLES `f_order_status` WRITE;
/*!40000 ALTER TABLE `f_order_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_order_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_prefix`
--

DROP TABLE IF EXISTS `f_prefix`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_prefix` (
  `f_prefix_id` int(11) NOT NULL AUTO_INCREMENT,
  `prefix_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_sex_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_tlock_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`f_prefix_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_prefix`
--

LOCK TABLES `f_prefix` WRITE;
/*!40000 ALTER TABLE `f_prefix` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_prefix` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_refer_cause`
--

DROP TABLE IF EXISTS `f_refer_cause`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_refer_cause` (
  `f_refer_cause_id` int(11) NOT NULL AUTO_INCREMENT,
  `refer_cause_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_refer_cause_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_refer_cause`
--

LOCK TABLES `f_refer_cause` WRITE;
/*!40000 ALTER TABLE `f_refer_cause` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_refer_cause` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_relation`
--

DROP TABLE IF EXISTS `f_relation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_relation` (
  `f_relation_id` int(11) NOT NULL AUTO_INCREMENT,
  `relation_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_relation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_relation`
--

LOCK TABLES `f_relation` WRITE;
/*!40000 ALTER TABLE `f_relation` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_relation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_religion`
--

DROP TABLE IF EXISTS `f_religion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_religion` (
  `f_religion_id` int(11) NOT NULL AUTO_INCREMENT,
  `religion_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_religion_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_religion`
--

LOCK TABLES `f_religion` WRITE;
/*!40000 ALTER TABLE `f_religion` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_religion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_service_group`
--

DROP TABLE IF EXISTS `f_service_group`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_service_group` (
  `f_service_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_group_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_service_group_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_service_group`
--

LOCK TABLES `f_service_group` WRITE;
/*!40000 ALTER TABLE `f_service_group` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_service_group` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_service_subgroup`
--

DROP TABLE IF EXISTS `f_service_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_service_subgroup` (
  `f_service_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `service_subgroup_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_service_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_service_subgroup`
--

LOCK TABLES `f_service_subgroup` WRITE;
/*!40000 ALTER TABLE `f_service_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_service_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_sex`
--

DROP TABLE IF EXISTS `f_sex`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_sex` (
  `f_sex_id` int(11) NOT NULL AUTO_INCREMENT,
  `sex_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_sex_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_sex`
--

LOCK TABLES `f_sex` WRITE;
/*!40000 ALTER TABLE `f_sex` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_sex` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_visit_ipd_discharge`
--

DROP TABLE IF EXISTS `f_visit_ipd_discharge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_visit_ipd_discharge` (
  `f_visit_ipd_discharge_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_ipd_discharge_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_visit_ipd_discharge_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_visit_ipd_discharge`
--

LOCK TABLES `f_visit_ipd_discharge` WRITE;
/*!40000 ALTER TABLE `f_visit_ipd_discharge` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_visit_ipd_discharge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_visit_ipd_discharge_type`
--

DROP TABLE IF EXISTS `f_visit_ipd_discharge_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_visit_ipd_discharge_type` (
  `f_visit_ipd_discharge_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_ipd_discharge_type_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_visit_ipd_discharge_type_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_visit_ipd_discharge_type`
--

LOCK TABLES `f_visit_ipd_discharge_type` WRITE;
/*!40000 ALTER TABLE `f_visit_ipd_discharge_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_visit_ipd_discharge_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_visit_opd_discharge`
--

DROP TABLE IF EXISTS `f_visit_opd_discharge`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_visit_opd_discharge` (
  `f_visit_opd_discharge_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_opd_discharge_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_visit_opd_discharge_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_visit_opd_discharge`
--

LOCK TABLES `f_visit_opd_discharge` WRITE;
/*!40000 ALTER TABLE `f_visit_opd_discharge` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_visit_opd_discharge` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_visit_status`
--

DROP TABLE IF EXISTS `f_visit_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_visit_status` (
  `f_visit_status_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_status_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_visit_status_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_visit_status`
--

LOCK TABLES `f_visit_status` WRITE;
/*!40000 ALTER TABLE `f_visit_status` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_visit_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `f_visit_type`
--

DROP TABLE IF EXISTS `f_visit_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `f_visit_type` (
  `f_visit_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `visit_type_description` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`f_visit_type_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `f_visit_type`
--

LOCK TABLES `f_visit_type` WRITE;
/*!40000 ALTER TABLE `f_visit_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `f_visit_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing`
--

DROP TABLE IF EXISTS `t_billing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing` (
  `t_billing_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_billing_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_billing_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_financial_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_patient_share` decimal(17,2) DEFAULT '0.00',
  `billing_payer_share` decimal(17,2) DEFAULT '0.00',
  `billing_total` decimal(17,2) DEFAULT '0.00',
  `billing_paid` decimal(17,2) DEFAULT '0.00',
  `billing_remain` decimal(17,2) DEFAULT '0.00',
  `billing_deduct` decimal(17,2) DEFAULT '0.00',
  `billing_payback` decimal(17,2) DEFAULT '0.00',
  `billing_staff_cancle` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_cancle_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing`
--

LOCK TABLES `t_billing` WRITE;
/*!40000 ALTER TABLE `t_billing` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_deduct`
--

DROP TABLE IF EXISTS `t_billing_deduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_deduct` (
  `t_billing_deduct_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_deduct_baht` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_deduct_remark` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_deduct_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_deduct`
--

LOCK TABLES `t_billing_deduct` WRITE;
/*!40000 ALTER TABLE `t_billing_deduct` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_deduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_deduct_subgroup`
--

DROP TABLE IF EXISTS `t_billing_deduct_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_deduct_subgroup` (
  `t_billing_deduct_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_invoice_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_deduct_subgroup_percent` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_deduct_subgroup_baht` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_deduct_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_deduct_subgroup`
--

LOCK TABLES `t_billing_deduct_subgroup` WRITE;
/*!40000 ALTER TABLE `t_billing_deduct_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_deduct_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_invoice`
--

DROP TABLE IF EXISTS `t_billing_invoice`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_invoice` (
  `t_billing_invoice_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_invoice_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_deposit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_payment_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_quantity` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_complete` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_patient_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_payer_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_total` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_patient_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `billing_invoice_payer_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `close_day_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_export` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `receipt_number` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `symtom` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_contract_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `member_card_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `company_responsibility` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_company_original_affiliation_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `discharge_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `company_original_affiliation` varchar(255) COLLATE utf8_bin DEFAULT '',
  `primary_symptom` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_billing_invoice_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_invoice`
--

LOCK TABLES `t_billing_invoice` WRITE;
/*!40000 ALTER TABLE `t_billing_invoice` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_invoice` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_invoice_billing_subgroup`
--

DROP TABLE IF EXISTS `t_billing_invoice_billing_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_invoice_billing_subgroup` (
  `t_billing_invoice_billing_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_invoice_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_payment_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_billing_subgroup_draw` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_billing_subgroup_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_billing_subgroup_patient_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_billing_subgroup_payer_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_billing_subgroup_total` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_billing_subgroup_patient_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `billing_invoice_billing_subgroup_payer_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `billing_invoice_item_payer_orginal` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_item_payer_status` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_invoice_billing_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_invoice_billing_subgroup`
--

LOCK TABLES `t_billing_invoice_billing_subgroup` WRITE;
/*!40000 ALTER TABLE `t_billing_invoice_billing_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_invoice_billing_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_invoice_item`
--

DROP TABLE IF EXISTS `t_billing_invoice_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_invoice_item` (
  `t_billing_invoice_item_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_invoice_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_order_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_payment_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_item_draw` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_item_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_invoice_item_patient_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_item_payer_share` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_item_total` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_item_patient_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `billing_invoice_item_payer_share_ceil` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `billing_invoice_item_payer_orginal` decimal(17,2) DEFAULT '0.00',
  `billing_invoice_item_payer_status` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_invoice_item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_invoice_item`
--

LOCK TABLES `t_billing_invoice_item` WRITE;
/*!40000 ALTER TABLE `t_billing_invoice_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_invoice_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_receipt`
--

DROP TABLE IF EXISTS `t_billing_receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_receipt` (
  `t_billing_receipt_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_paid` decimal(17,2) DEFAULT '0.00',
  `billing_receipt_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_billing_receipt_model_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `receipt_number` varchar(255) COLLATE utf8_bin DEFAULT '0',
  PRIMARY KEY (`t_billing_receipt_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_receipt`
--

LOCK TABLES `t_billing_receipt` WRITE;
/*!40000 ALTER TABLE `t_billing_receipt` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_receipt_billing_subgroup`
--

DROP TABLE IF EXISTS `t_billing_receipt_billing_subgroup`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_receipt_billing_subgroup` (
  `t_billing_receipt_billing_subgroup_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_receipt_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_invoice_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_billing_subgroup_draw` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_billing_subgroup_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_billing_subgroup_paid` decimal(17,2) DEFAULT '0.00',
  `t_billing_receipt_billing_subgroupcol` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_receipt_billing_subgroup_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_receipt_billing_subgroup`
--

LOCK TABLES `t_billing_receipt_billing_subgroup` WRITE;
/*!40000 ALTER TABLE `t_billing_receipt_billing_subgroup` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_receipt_billing_subgroup` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_receipt_detail`
--

DROP TABLE IF EXISTS `t_billing_receipt_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_receipt_detail` (
  `t_billing_receipt_detail_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_receipt_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_billing_receipt_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_billing_receipt_creditor_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_detail_creditor_code` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_detail_creditor_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_detail_credit_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_detail_remark` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_detail_paid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_receipt_detail_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_receipt_detail`
--

LOCK TABLES `t_billing_receipt_detail` WRITE;
/*!40000 ALTER TABLE `t_billing_receipt_detail` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_receipt_detail` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_billing_receipt_item`
--

DROP TABLE IF EXISTS `t_billing_receipt_item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_billing_receipt_item` (
  `t_billing_receipt_item_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_billing_receipt_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_billing_invoice_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_item_draw` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_item_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_payment_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_item_vn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_item_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `billing_receipt_item_paid` decimal(17,2) DEFAULT '0.00',
  `t_billing_receipt_itemcol` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_billing_receipt_item_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_billing_receipt_item`
--

LOCK TABLES `t_billing_receipt_item` WRITE;
/*!40000 ALTER TABLE `t_billing_receipt_item` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_billing_receipt_item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_borrow_film_xray`
--

DROP TABLE IF EXISTS `t_borrow_film_xray`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_borrow_film_xray` (
  `t_borrow_film_xray_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_xn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_prefix` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_film_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `amount_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `return_film_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `permissibly_borrow` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_cause` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_to` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_to_other` varchar(255) COLLATE utf8_bin DEFAULT '',
  `date_serv` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_staff_update` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_update_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_cancel_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`t_borrow_film_xray_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_borrow_film_xray`
--

LOCK TABLES `t_borrow_film_xray` WRITE;
/*!40000 ALTER TABLE `t_borrow_film_xray` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_borrow_film_xray` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_borrow_opdcard`
--

DROP TABLE IF EXISTS `t_borrow_opdcard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_borrow_opdcard` (
  `t_borrow_opdcard_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_opd_prefix` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_opd_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrower_opd_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opd_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `amount_date_opd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `return_opd_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opd_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `permissibly_borrow_opd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opd_cause` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opd_to` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opd_to_other` varchar(255) COLLATE utf8_bin DEFAULT '',
  `date_serv_opd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_staff_update` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_update_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_cancel_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `borrow_opdcard_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`t_borrow_opdcard_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_borrow_opdcard`
--

LOCK TABLES `t_borrow_opdcard` WRITE;
/*!40000 ALTER TABLE `t_borrow_opdcard` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_borrow_opdcard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_chronic`
--

DROP TABLE IF EXISTS `t_chronic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_chronic` (
  `t_chronic_id` int(11) NOT NULL AUTO_INCREMENT,
  `chronic_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_vn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_diagnosis_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_discharge_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_chronic_discharge_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_notice` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_icd10` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `chronic_site_treat` varchar(255) COLLATE utf8_bin DEFAULT '',
  `t_health_family_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `modify_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `cancel_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `staff_record` varchar(255) COLLATE utf8_bin DEFAULT '',
  `staff_modify` varchar(255) COLLATE utf8_bin DEFAULT '',
  `staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT '',
  `chronic_active` varchar(255) COLLATE utf8_bin DEFAULT '',
  `chronic_survey_date` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_chronic_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_chronic`
--

LOCK TABLES `t_chronic` WRITE;
/*!40000 ALTER TABLE `t_chronic` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_chronic` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_death`
--

DROP TABLE IF EXISTS `t_death`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_death` (
  `t_death_id` int(11) NOT NULL AUTO_INCREMENT,
  `death_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_primary_diagnosis` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_comorbidity` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_complication` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_others` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_external_cause_of_injury` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_cause` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_site` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_pregnant` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_gravida_week` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_vn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `death_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_health_family_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_death_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_death`
--

LOCK TABLES `t_death` WRITE;
/*!40000 ALTER TABLE `t_death` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_death` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_notify_note`
--

DROP TABLE IF EXISTS `t_notify_note`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_notify_note` (
  `t_notify_note_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_hn` varchar(255) COLLATE utf8_bin NOT NULL,
  `t_visit_id_rec` varchar(255) COLLATE utf8_bin NOT NULL,
  `f_notify_type_id` varchar(255) COLLATE utf8_bin NOT NULL,
  `note_subject` varchar(255) COLLATE utf8_bin NOT NULL,
  `note_detail` varchar(4000) COLLATE utf8_bin NOT NULL,
  `active` varchar(1) COLLATE utf8_bin NOT NULL DEFAULT '1',
  `rec_staff` varchar(255) COLLATE utf8_bin NOT NULL,
  `rec_datetime` varchar(19) COLLATE utf8_bin NOT NULL,
  `mod_datetime` varchar(19) COLLATE utf8_bin DEFAULT NULL,
  `del_datetime` varchar(19) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id_last_view` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `notify_count` decimal(17,0) NOT NULL DEFAULT '0',
  `notify_to` varchar(255) COLLATE utf8_bin DEFAULT '',
  `notify_to_des` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_notify_note_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_notify_note`
--

LOCK TABLES `t_notify_note` WRITE;
/*!40000 ALTER TABLE `t_notify_note` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_notify_note` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_opd_send_or`
--

DROP TABLE IF EXISTS `t_opd_send_or`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_opd_send_or` (
  `t_opd_send_or_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_no` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_doctor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_doctor_immediately` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_run_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_room` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_comment` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_method` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_weight` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_height` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_npo_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_set_staff` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_sender` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_appiontment_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_opd_send_or_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_opd_send_or`
--

LOCK TABLES `t_opd_send_or` WRITE;
/*!40000 ALTER TABLE `t_opd_send_or` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_opd_send_or` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_opd_send_or_doctor_member`
--

DROP TABLE IF EXISTS `t_opd_send_or_doctor_member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_opd_send_or_doctor_member` (
  `t_opd_send_or_doctor_member_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_opd_send_or_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `opd_send_or_doctor_member` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_opd_send_or_doctor_member_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_opd_send_or_doctor_member`
--

LOCK TABLES `t_opd_send_or_doctor_member` WRITE;
/*!40000 ALTER TABLE `t_opd_send_or_doctor_member` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_opd_send_or_doctor_member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_operation`
--

DROP TABLE IF EXISTS `t_operation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_operation` (
  `t_operation_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_no` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_doctor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_doctor_immediately` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_run_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_room` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_comment` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_method` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_weight` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_height` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_npo_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_sender` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_set_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `operation_appiontment_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_operation_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_operation`
--

LOCK TABLES `t_operation` WRITE;
/*!40000 ALTER TABLE `t_operation` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_operation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_operation_doctor_member`
--

DROP TABLE IF EXISTS `t_operation_doctor_member`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_operation_doctor_member` (
  `t_operation_doctor_member_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_operation_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `operation_doctor_member` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_operation_doctor_member_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_operation_doctor_member`
--

LOCK TABLES `t_operation_doctor_member` WRITE;
/*!40000 ALTER TABLE `t_operation_doctor_member` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_operation_doctor_member` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_order`
--

DROP TABLE IF EXISTS `t_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_order` (
  `t_order_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_verify` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_verify_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_execute` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_executed_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_discontinue` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_discontinue_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_dispense` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_dispense_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_service_point` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_charge_complete` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_order_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_secret` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_continue` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_billing_subgroup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_item_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_common_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_refer_out` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_request` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_order` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_complete` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_price` decimal(17,2) DEFAULT '0.00',
  `order_qty` decimal(17,2) DEFAULT '0.00',
  `order_cost` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_notice` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_drug_allergy` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `order_cause_cancel_resultlab` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_staff_report` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_report_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_home` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_item_16_group_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `doctor_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `hight_alert` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_specified` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_specified_data` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `order_time_check` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `order_status_doctor` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `result_lab_approve_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_alert` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_approve_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_approve_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_print_report_item` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `order_start_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_end_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_rate` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `order_operation_no` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `order_operation_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_no_close_day_import` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `lot_request_number` varchar(255) COLLATE utf8_bin DEFAULT '',
  `order_status_physical` varchar(255) COLLATE utf8_bin DEFAULT '',
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_order_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_order`
--

LOCK TABLES `t_order` WRITE;
/*!40000 ALTER TABLE `t_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient`
--

DROP TABLE IF EXISTS `t_patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient` (
  `t_patient_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_patient_prefix_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_xn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_sex_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_birthday` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_house` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_road` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_moo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_tambon` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_amphur` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_changwat` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_marriage_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_occupation_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_patient_race_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_nation_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_religion_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_education_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_family_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `father_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `mother_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `couple_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_move_in_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_discharge_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_discharge_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_blood_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_foreigner_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_patient_area_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `father_pid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `mather_pid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `couple_pid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_community_status` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_private_doctor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_pid` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `mother_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `father_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `couple_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_phone_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `couple_f_relation_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_phone_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_sex_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_house` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_moo` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_changwat` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_amphur` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_tambon` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_road` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_firstname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `contact_lastname` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_birthday_true` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_merged` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `date_create` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `date_modi` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `date_cancel` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `user_create` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `user_modi` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `user_cancel` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `drugallergy` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `language_for_print` varchar(255) COLLATE utf8_bin DEFAULT '',
  `mobile_phone` varchar(255) COLLATE utf8_bin DEFAULT '',
  `contact_mobile_phone` varchar(255) COLLATE utf8_bin DEFAULT '',
  `has_home_in_pcu` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `t_health_family_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `other_country_address` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `is_other_country` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_namet` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `remark1` text COLLATE utf8_bin,
  `remark2` text COLLATE utf8_bin,
  `contact_join_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_join_namet` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `ss_patient_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_soi` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_contact_soi` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_chronic` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_hiv` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `patient_status_hiv` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_f_relation_id` varchar(45) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_patient_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient`
--

LOCK TABLES `t_patient` WRITE;
/*!40000 ALTER TABLE `t_patient` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_appointment`
--

DROP TABLE IF EXISTS `t_patient_appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_appointment` (
  `t_patient_appointment_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appoint_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_doctor` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_clinic` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_notice` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_staff` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_auto_visit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_visit_queue_setup_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_status` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `patient_appointment_vn` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_staff_record` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_staff_update` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_update_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_cancel_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_appointment_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `r_rp1853_aptype_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_patient_appointment_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_appointment`
--

LOCK TABLES `t_patient_appointment` WRITE;
/*!40000 ALTER TABLE `t_patient_appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_appointment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_appointment_order`
--

DROP TABLE IF EXISTS `t_patient_appointment_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_appointment_order` (
  `t_patient_appointment_order_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_appointment_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_appointment_order_common_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_patient_appointment_order_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_appointment_order`
--

LOCK TABLES `t_patient_appointment_order` WRITE;
/*!40000 ALTER TABLE `t_patient_appointment_order` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_appointment_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_drug_allergy`
--

DROP TABLE IF EXISTS `t_patient_drug_allergy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_drug_allergy` (
  `t_patient_drug_allergy_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_drug_allergy_common_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_drug_allergy_symptom` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_item_drug_standard_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_drug_allergy_drug_standard_description` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_drug_allergy_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_patient_drug_allergy_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_drug_allergy`
--

LOCK TABLES `t_patient_drug_allergy` WRITE;
/*!40000 ALTER TABLE `t_patient_drug_allergy` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_drug_allergy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_family_history`
--

DROP TABLE IF EXISTS `t_patient_family_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_family_history` (
  `t_patient_family_history_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_family_history_description` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `patient_family_history_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_family_history_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_family_history_topic` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_patient_family_history_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_family_history`
--

LOCK TABLES `t_patient_family_history` WRITE;
/*!40000 ALTER TABLE `t_patient_family_history` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_family_history` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_ncd`
--

DROP TABLE IF EXISTS `t_patient_ncd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_ncd` (
  `t_patient_ncd_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_ncd_group_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_ncd_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_ncd_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_ncd_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_ncd_staff_modify` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_ncd_modify_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_patient_ncd_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_ncd`
--

LOCK TABLES `t_patient_ncd` WRITE;
/*!40000 ALTER TABLE `t_patient_ncd` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_ncd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_risk_factor`
--

DROP TABLE IF EXISTS `t_patient_risk_factor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_risk_factor` (
  `t_patient_risk_factor_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_risk_factor_description` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `patient_risk_factor_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_risk_factor_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `patient_risk_factor_topic` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_patient_risk_factor_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_risk_factor`
--

LOCK TABLES `t_patient_risk_factor` WRITE;
/*!40000 ALTER TABLE `t_patient_risk_factor` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_risk_factor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_patient_xn`
--

DROP TABLE IF EXISTS `t_patient_xn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_patient_xn` (
  `t_patient_xn_id` int(11) NOT NULL AUTO_INCREMENT,
  `patient_xray_number` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_xn_year` varchar(255) COLLATE utf8_bin DEFAULT '',
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `patient_xn_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  PRIMARY KEY (`t_patient_xn_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_patient_xn`
--

LOCK TABLES `t_patient_xn` WRITE;
/*!40000 ALTER TABLE `t_patient_xn` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_patient_xn` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_result_lab`
--

DROP TABLE IF EXISTS `t_result_lab`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_result_lab` (
  `t_result_lab_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_order_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_value` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_unit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_name` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_complete` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_item_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_lab_result_type_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_max` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_min` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_lab_result_group_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_index` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_item_lab_result_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_normal_flag` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_approved` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `approved_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_lab_value_old` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_approve` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_approve_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_modify_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_lab_modify_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `sort_lab` varchar(255) COLLATE utf8_bin DEFAULT '000000',
  PRIMARY KEY (`t_result_lab_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_result_lab`
--

LOCK TABLES `t_result_lab` WRITE;
/*!40000 ALTER TABLE `t_result_lab` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_result_lab` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_result_xray`
--

DROP TABLE IF EXISTS `t_result_xray`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_result_xray` (
  `t_result_xray_id` int(11) NOT NULL AUTO_INCREMENT,
  `result_xray_xn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_film_size` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_staff_execute` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_description` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `t_order_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_notice` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_complete` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_xn_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `result_xray_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `date_doctor_result` varchar(255) COLLATE utf8_bin DEFAULT '',
  `doctor_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_result_xray_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_result_xray`
--

LOCK TABLES `t_result_xray` WRITE;
/*!40000 ALTER TABLE `t_result_xray` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_result_xray` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_result_xray_position`
--

DROP TABLE IF EXISTS `t_result_xray_position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_result_xray_position` (
  `t_result_xray_position_id` int(11) NOT NULL AUTO_INCREMENT,
  `b_xray_side_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_xray_position_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_result_xray_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_order_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_result_xray_size_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_kv` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_ma` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_second` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_mas` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_position_ffd` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_result_xray_position_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_result_xray_position`
--

LOCK TABLES `t_result_xray_position` WRITE;
/*!40000 ALTER TABLE `t_result_xray_position` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_result_xray_position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_result_xray_size`
--

DROP TABLE IF EXISTS `t_result_xray_size`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_result_xray_size` (
  `t_result_xray_size_id` int(11) NOT NULL AUTO_INCREMENT,
  `t_result_xray_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_xray_film_size_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `xray_film_amount` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_size_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_size_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_size_add_order` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_order_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `result_xray_size_price` double DEFAULT '0',
  `result_xray_size_damaging_xray_film_amount` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_result_xray_size_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_result_xray_size`
--

LOCK TABLES `t_result_xray_size` WRITE;
/*!40000 ALTER TABLE `t_result_xray_size` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_result_xray_size` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_visit`
--

DROP TABLE IF EXISTS `t_visit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_visit` (
  `t_visit_id` int(11) NOT NULL,
  `visit_hn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `vn` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_visit_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_begin_visit_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_financial_discharge_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_notice` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_visit_office_id_refer_in` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_visit_office_id_refer_out` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_diagnosis_notice` text COLLATE utf8_bin,
  `f_visit_opd_discharge_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_visit_ipd_discharge_type_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_visit_ipd_discharge_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_locking` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_staff_lock` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_lock_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_visit_status_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_pregnant` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_visit_clinic_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_visit_ward_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_bed` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_observe` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_patient_type` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_queue` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_service_point_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_staff_observe` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_dx` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `status_ipd_discharge` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `status_money_discharge` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `status_doctor_discharge` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_staff_financial_discharge` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_staff_doctor_discharge` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_staff_doctor_discharge_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_an` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_dx_stat` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_begin_admit_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_deny_allergy` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_first_visit` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_patient_self_doctor` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_patient_age` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_pcu_service` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_hospital_service` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_lab_status_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_ncd` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_ncd_group_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `f_refer_cause_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `f_emergency_status_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `visit_emergency_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_appointment` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_admit` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_refer` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `t_patient_appointment_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_cal_date_appointment` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_cause_appointment` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_contract_plans_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_namet` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_join_id` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `contact_join_namet` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `surveillance_case_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_record_staff` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_financial_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_financial_record_staff` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `service_location` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_scan_sn_dx` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_lab_approve` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_lab_approve_staff` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_primary_symtom` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_visit_bed_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `b_visit_room_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `status_prepare_discharge` varchar(255) COLLATE utf8_bin DEFAULT '',
  `prepare_discharge_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `prepare_discharge_message` varchar(255) COLLATE utf8_bin DEFAULT '',
  `active` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `vn_seq` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `vn_sum` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_visit_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_visit`
--

LOCK TABLES `t_visit` WRITE;
/*!40000 ALTER TABLE `t_visit` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_visit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_visit_payment`
--

DROP TABLE IF EXISTS `t_visit_payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_visit_payment` (
  `t_visit_payment_id` int(11) NOT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_contract_plans_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `b_contract_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_card_number` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_card_issue_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_card_expire_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_main_hospital` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_sub_hospital` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_priority` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_money_limit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_used_money_limit` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_payment_staff_record` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_record_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_staff_update` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_update_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_cancel_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_payment_active` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `status_payment` varchar(255) COLLATE utf8_bin DEFAULT '0',
  `b_deduct_id` varchar(255) COLLATE utf8_bin DEFAULT '',
  `primary_symptom` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_visit_payment_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_visit_payment`
--

LOCK TABLES `t_visit_payment` WRITE;
/*!40000 ALTER TABLE `t_visit_payment` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_visit_payment` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_visit_physical_exam`
--

DROP TABLE IF EXISTS `t_visit_physical_exam`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_visit_physical_exam` (
  `t_visit_physical_exam_id` int(11) NOT NULL,
  `visit_physical_exam_body` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_physical_exam_detail` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_physical_exam_staff_execute` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_visit_physical_exam_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_visit_physical_exam`
--

LOCK TABLES `t_visit_physical_exam` WRITE;
/*!40000 ALTER TABLE `t_visit_physical_exam` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_visit_physical_exam` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_visit_primary_symptom`
--

DROP TABLE IF EXISTS `t_visit_primary_symptom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_visit_primary_symptom` (
  `t_visit_primary_symptom_id` int(11) NOT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_staff_modify` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_staff_cancel` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_active` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_general_symptom` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_main_symptom` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `visit_primary_symptom_current_illness` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`t_visit_primary_symptom_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_visit_primary_symptom`
--

LOCK TABLES `t_visit_primary_symptom` WRITE;
/*!40000 ALTER TABLE `t_visit_primary_symptom` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_visit_primary_symptom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `t_visit_vital_sign`
--

DROP TABLE IF EXISTS `t_visit_vital_sign`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `t_visit_vital_sign` (
  `t_visit_vital_sign_id` int(11) NOT NULL,
  `t_visit_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_time` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `record_date` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_height` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_weight` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_blood_presure` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_temperature` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_heart_rate` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_respiratory_rate` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_general_symptom` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `f_visit_nutrition_level_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_staff_record` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_current_illness_symptom` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `t_patient_id` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_bmi` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_note` varchar(4000) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_check_date` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_check_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_staff_modify` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_modify_date_time` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_active` varchar(255) COLLATE utf8_bin DEFAULT '1',
  `visit_waistline` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_dtx` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `visit_vital_sign_waistline` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_waistline_inch` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_chest_line` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_head_line` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_breath_in` varchar(255) COLLATE utf8_bin DEFAULT '',
  `visit_vital_sign_breath_out` varchar(255) COLLATE utf8_bin DEFAULT '',
  PRIMARY KEY (`t_visit_vital_sign_id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `t_visit_vital_sign`
--

LOCK TABLES `t_visit_vital_sign` WRITE;
/*!40000 ALTER TABLE `t_visit_vital_sign` DISABLE KEYS */;
/*!40000 ALTER TABLE `t_visit_vital_sign` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-22  7:44:08
