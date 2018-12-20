
-- main table
CREATE TABLE IF NOT EXISTS `inventory` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ITEM` varchar(100) NOT NULL,
  `QTY_IN` int(11) NOT NULL,
  `QTY_OUT` int(11) NOT NULL,  
  `QTY_CNST` int(11) NOT NULL,
  `QTY_UNIT` varchar(100) NOT NULL,
  `PRICE_BUY` int(11) NOT NULL,
  `PRICE_SELL` int(11) NOT NULL,
  `CAT` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--example when inputing

INSERT INTO `inventory` (`ID`, `ITEM`, `QTY_IN`, `QTY_OUT`, `QTY_CNST`, `QTY_UNIT`, `PRICE_BUY`, `PRICE_SELL`, `CAT` ) VALUES
(1, 'chicken', 10,21,30, 'KG', 300,350,'MEAT'),
(2, 'spoons', 14,15,17, 'PCS', 14,0,'TBL');

--calls the whole table of inventory

SELECT * FROM inventory;

--calls sales table without NET

SELECT * FROM inventory WHERE QTY_OUT > 0;

--calls sales table 

SELECT ID,ITEM,QTY_OUT,QTY_UNIT,PRICE_BUY,PRICE_SELL, (QTY_OUT*PRICE_BUY-PRICE_SELL) as NET FROM sales;

--creates provider table
CREATE TABLE IF NOT EXISTS `provider` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ITEM` varchar(100) NOT NULL,
  `QTY_CNST` int(11) NOT NULL,
  `QTY_UNIT` varchar(100) NOT NULL,
  `PRICE_BUY` int(11) NOT NULL,
  `CAT` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;



--Consumer TABLE
CREATE TABLE IF NOT EXISTS `consumer` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `BUNDLE` varchar(100) NOT NULL,
  `PAID` float NOT NULL,
  `DUE` float NOT NULL,
 `C_NAME` varchar(100) NOT NULL,
 `C_ADD` varchar(100) NOT NULL,
 `C_CONT` varchar(100) NOT NULL,
 `D_ORDER` date NOT NULL,
 `D_SERV` date NOT NULL,
 `D_PAID` date NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--date is set as YYYY-MM-DD

--Bundle table
CREATE TABLE IF NOT EXISTS `Bundles` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `BUNDLE` varchar(100) NOT NULL,
  `PRICE_TOTAL` float NOT NULL,
  `NUM_G` int NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;
--where num G is number of guests acomodated 

--Each bundle entered will create a table for that bundle, named with the bundle ID
CREATE TABLE IF NOT EXISTS `Bundle_ID` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `MENU` varchar(100) NOT NULL,
  `PRICE` float NOT NULL,
  `NUM_G` int NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;


-- individual food table, each food can be broken down into the ingredients used, named with it's food ID, only visible in inventory
CREATE TABLE IF NOT EXISTS `FOOD_ID` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `INGREDIENTS` varchar(100) NOT NULL,
  `PRICE` float NOT NULL,
  `QTY_IN` int(11) NOT NULL,
  `QTY_UNIT` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
)ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;


--worker table
--payroll
--profit table

