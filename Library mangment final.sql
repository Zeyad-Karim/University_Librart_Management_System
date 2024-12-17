
-- Create the database
CREATE DATABASE [library mangment];
GO

USE [library mangment];
GO

-- Create tables within the database
CREATE TABLE ADDS (
   ADMIN_ID             INT                  NOT NULL,
   BOOK_ID              INT                  NOT NULL,
   CONSTRAINT PK_ADDS PRIMARY KEY (ADMIN_ID, BOOK_ID)
);

CREATE TABLE ADMIN (
   ADMIN_ID             INT                  NOT NULL,
   ADMIN_USERNAME       VARCHAR(45)          NOT NULL,
   PASSWORD             VARCHAR(45)          NOT NULL,
   FIRST_NAME           VARCHAR(45)          NOT NULL,
   LAST_NAME            VARCHAR(45)          NOT NULL,
   EMAIL                VARCHAR(45)          NOT NULL,
   PHONE                VARCHAR(45)          NULL,
   BORROWED_BOOKID      INT                  NULL,
   CONSTRAINT PK_ADMIN PRIMARY KEY (ADMIN_ID)
);

CREATE TABLE BOOK (
   BOOK_ID              INT                  NOT NULL,
   AUTHOR_NAME          VARCHAR(45)          NOT NULL,
   TITLE                VARCHAR(45)          NOT NULL,
   PUBLICATION_YEAR     DATETIME             NULL,
   ADMIN_ID             INT                  NULL,
   PUBLISHER_ID         INT                  NULL,
   CONSTRAINT PK_BOOK PRIMARY KEY (BOOK_ID)
);

CREATE TABLE BOOK_COPY (
   COPY_ID              INT                  NOT NULL,
   BK_ID                INT                  NOT NULL,
   AVALABILE_COPIES     NUMERIC(38, 0)       NULL, -- Adjusted precision
   IS_BORROWED          BIT                  NULL,
   ADMIN_ID             INT                  NOT NULL,
   CONSTRAINT PK_BOOK_COPY PRIMARY KEY (COPY_ID, BK_ID),
   CONSTRAINT FK_BOOK_COPY_ADMIN_ID FOREIGN KEY (ADMIN_ID) REFERENCES ADMIN(ADMIN_ID)
);

CREATE TABLE BORROWS (
   BOR_BOOK_ID          INT                  NOT NULL,
   RETURNDATE           DATETIME             NULL,
   BORROW_DATE          DATETIME             NULL,
   CONSTRAINT PK_BORROWS PRIMARY KEY (BOR_BOOK_ID)
);

CREATE TABLE PUBLISHER (
   PUBLISHER_ID         INT                  NOT NULL,
   PUBLISHER_NAME       VARCHAR(45)          NULL,
   ADDRESS              VARCHAR(45)          NULL,
   PHONE                VARCHAR(45)          NULL,
   CONSTRAINT PK_PUBLISHER PRIMARY KEY (PUBLISHER_ID)
);

CREATE TABLE "USER" (
   USER_ID              INT                  NOT NULL,
   ADMIN_ID             INT                  NOT NULL,
   USERNAME             VARCHAR(45)          NOT NULL,
   PASSWORD             VARCHAR(45)          NOT NULL,
   FIRSTNAME            VARCHAR(45)          NOT NULL,
   LAST_NAME            VARCHAR(45)          NOT NULL,
   EMAIL                VARCHAR(45)          NOT NULL,
   BOOK_ID              INT                  NULL,
   PHONE                VARCHAR(45)          NULL,
   CONSTRAINT PK_USER PRIMARY KEY (USER_ID),
   CONSTRAINT FK_USER_BORROWS2_BORROWS FOREIGN KEY (BOOK_ID) REFERENCES BORROWS(BOR_BOOK_ID),
   CONSTRAINT FK_USER_REGISTER2_ADMIN FOREIGN KEY (ADMIN_ID) REFERENCES ADMIN(ADMIN_ID)
);

-- **Insert data into tables**

/* 1. ADMIN */
INSERT INTO ADMIN (ADMIN_ID, ADMIN_USERNAME, PASSWORD, FIRST_NAME, LAST_NAME, EMAIL, PHONE)
VALUES
  (1, 'admin1', 'password123', 'John', 'Doe', 'admin1@library.com', '123-456-7890'),
  (2, 'admin2', 'password456', 'Jane', 'Smith', 'admin2@library.com', '987-654-3210'),
  (3, 'admin3', 'password789', 'Michael', 'Lee', 'admin3@library.com', '555-123-4567');

/* 2. PUBLISHER */
INSERT INTO PUBLISHER (PUBLISHER_ID, PUBLISHER_NAME, ADDRESS, PHONE)
VALUES
  (1, 'Big Publishing House', '1 Main St, Anytown, CA 12345', '415-555-1212'),
  (2, 'Medium Press', '2nd Ave, Otherville, NY 54321', '646-555-3434'),
  (3, 'Small Indie Books', '3rd St, Smalltown, TX 98765', '903-555-5656');

/* 3. BOOK */
INSERT INTO BOOK (BOOK_ID, AUTHOR_NAME, TITLE, PUBLICATION_YEAR, ADMIN_ID, PUBLISHER_ID)
VALUES
  (1, 'J.R.R. Tolkien', 'The Lord of the Rings', '1954-12-15', 1, 1),
  (2, 'George R.R. Martin', 'A Song of Ice and Fire', '1996-08-01', 2, 2),
  (3, 'Harper Lee', 'To Kill a Mockingbird', '1960-07-11', 3, 3),
  (4, 'Agatha Christie', 'And Then There Were None', '1939-01-01', 1, 1),
  (5, 'F. Scott Fitzgerald', 'The Great Gatsby', '1925-04-10', 2, 2),
  (6, 'Gabriel García Márquez', 'One Hundred Years of Solitude', '1967-06-05', 3, 3);

INSERT INTO BOOK_COPY (COPY_ID, BK_ID, ADMIN_ID, AVALABILE_COPIES, IS_BORROWED)
VALUES
  (1, 1, 1, 2, 1),  -- One copy borrowed, one available
  (2, 2, 2, 1, 1),  -- One copy borrowed, none available
  (3, 3, 3, 3, 0),  -- Three copies available
  (4, 4, 1, 5, 0),  -- Five copies available
  (5, 5, 2, 2, 1),  -- One copy borrowed, one available
  (6, 6, 3, 4, 0);  -- Four copies available

/* 5. BORROWS (at least one book borrowed for each user) */
INSERT INTO BORROWS (BOR_BOOK_ID, RETURNDATE, BORROW_DATE)
VALUES
  (1, '2024-06-18', '2024-05-15'),  -- Borrowed book 1
  (2, '2024-07-22', '2024-05-16'),  -- Borrowed book 2
  (3, '2024-08-10', '2024-05-17');  -- Borrowed book 3

/* 6. USER */
INSERT INTO "USER" (USER_ID, ADMIN_ID, USERNAME, PASSWORD, FIRSTNAME, LAST_NAME, EMAIL, BOOK_ID, PHONE)
VALUES
  (1, 1, 'user1', 'userpass1', 'Alice', 'Brown', 'user1@library.com', 1, '234-567-8901'),
  (2, 2, 'user2', 'userpass2', 'Bob', 'Johnson', 'user2@library.com', 2, '345-678-1234'),
  (3, 2, 'user3', 'userpass3', 'Charlie', 'Williams', 'user3@library.com', 3, '456-789-0123');


INSERT INTO ADDS (ADMIN_ID, BOOK_ID)
VALUES (1, 101),  -- Admin ID 1 adds book ID 101
       (2, 102),  -- Admin ID 2 adds book ID 102
       (3, 103);  -- Admin ID 3 adds book ID 103




-- Select all admins
SELECT * FROM ADMIN;

-- Select all users
SELECT * FROM "USER";

-- Select all publishers
SELECT * FROM PUBLISHER;

-- Select all books
SELECT * FROM BOOK;

-- Select all book copies
SELECT * FROM BOOK_COPY;

-- Select all borrows (might be empty if no borrows yet)
SELECT * FROM BORROWS;

-- Select all adds (might be empty if no relationships added)
SELECT * FROM ADDS;