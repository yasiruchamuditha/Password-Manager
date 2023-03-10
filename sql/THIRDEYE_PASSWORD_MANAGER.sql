--DATABASE
CREATE DATABASE THIRDEYE_PASSWORD_MANAGER

--RESISTRATION TABLE
CREATE TABLE REGISTRATIONS
(
USER_USERNAME VARCHAR(100) NOT NULL PRIMARY KEY,
USER_EMAIL VARCHAR(100) NOT NULL,
USER_PASSWORD VARCHAR(100) NOT NULL,
USER_CONFIRMPASSWORD VARCHAR(100) NOT NULL
);

INSERT INTO REGISTRATIONS(USER_USERNAME,USER_EMAIL,USER_PASSWORD,USER_CONFIRMPASSWORD)
VALUES('GH','DD','GH','GH')

--EMAILS DATA TABLES
CREATE TABLE EMAILS
(
EMAIL_ACCOUNTNAME VARCHAR(100) PRIMARY KEY NOT NULL,
EMAIL_PASSWORD VARCHAR(100) NOT NULL,
COMMENT VARCHAR(100) 
);


--APPLICATION DATA TABLE
CREATE TABLE APPLICATIONS
(
APPLICATION_NAME VARCHAR(100) NOT NULL,
APPLICATION_LOGIN VARCHAR(100) PRIMARY KEY NOT NULL,
APPLICATION_PASSWORD VARCHAR(100) NOT NULL,
COMMENT VARCHAR(100) 
);

--BANKCARD DATA TABLE
CREATE TABLE BANKCARDS
(
CARD_NUMBER VARCHAR(100) PRIMARY KEY NOT NULL,
CARD_HOLDER VARCHAR(100) NOT NULL,
EXPIRE_DATE VARCHAR(25) NOT NULL,
CVV INT NOT NULL,
PIN_NUMBER INT NOT NULL,
CARD_ISSUER VARCHAR(100) NOT NULL,
COMMENT VARCHAR(100) 
);


--WEBSITE DATA TABLE
CREATE TABLE WEBSITES
(
WEBSITE_ADDRESS VARCHAR(100) PRIMARY KEY NOT NULL,
WEBSITE_LOGIN VARCHAR(100) NOT NULL,
WEBSITE_PASSWORD VARCHAR(100) NOT NULL,
COMMENT VARCHAR(100)
);
 
