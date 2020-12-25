# SQL

*Your assignment is to build a database from scratch. Add tables to the database, Insert data into tables and query the database. All queries should be contained in one single query-file(.sql). Submit a query file and screenshots of your table design from Visual Studio to that folder. Refer to YouTube courses, TutorialsPoint and Pluralsight for information on how to implement the required features.*

## Required Features:

* Create a database for a webshop of DVD movies with the following entities and relationships
    * Movie: The movies are the products being sold in the webshop
    * Customer: Makes an order to the webshop and supplies information for billing and delivery of order
    * Order: Order details are saved to the database
    * OrderRows: Maintains the sale details of all orders

Following diagram describes the required columns and their relationships among tables within the database

![](https://github.com/WebsterSweden/Lexicon_NET/blob/master/10_SQL_Database/images/database-1.png)

## Relation

Each Order is related to one customer and one or more OrderRows, which in turn contains the price of movies being sold in that order.

Why is the Price column included in both the Movie and the OrderRow tables? Because the Movie's DVD price may change at any time in future. For a record we can trace the older price of the movie. For example let's say a customer, Joe, buys the movie Se7en on January 12th 2015 for 179 kr. One year later, the price of Se7en was lowered to 79 kr. If we do not keep the Price column in the OrderRows table, we lose the price of the movie at the time it was sold to Joe. The Price-column in the Movie table represents the current price of the movie. However, the Price-column in the OrderRows table represents the price of the movie at the time it was sold.

### Code Requirements:

CREATE DATABASE AND TABLES
* Create all tables, as mentioned in the diagram
    * Table names and column names should be exactly the same as mentioned in the diagram, even no misspellings allowed.
* Set primary key and REFERENCES to other tables as mentioned in the diagram Create the tables in the right order, which will help you to reference the correct table.
* Select the appropriate data type for each column
    * Primary key should be automatically increased while adding new record to the table
* No column should allow NULL values. INSERT
    * Insert following data to the Movies and Customers table
* At least one record in each table should be inserted using an INSERT query. (You can also enter data directly to the table)

Write queries to create Orders and OrderRows for the following scenarios<br />
    A. On 2015-01-01, Jonas Greys purchased Interstellar and Pulp Fiction<br />
    B. On 2015-01-15, Peter Biron purchased 2 copies of The Wolf of Wall Street<br />
    C. On 2014-12-20, Jonas Greys purchased The Wolf of Wall Street. (Tip: You should create the Order first, otherwise you will not have OrderId, which will be required while creating the OrderRows.)<br />

Query example: INSERT INTO Orders VALUES(...) SELECT TOP 1 Id FROM Orders ORDER BY Id DESC - Get the latest inserted OrderId INSERT INTO OrderRows VALUES(...)

UPDATE
* Write a query that changes the price of all movies made in 2014 to 169 kr.

SELECT
* Write queries for the following SELECT operations:<br />
    A. Get Firstname, Lastname, PhoneNo and Email to all Customers.<br />
    B. Get all movies, ordered by Year from newest to oldest.<br />
    C. Get all movie titles, ordered by Price, from cheapest to most expensive.<br />
    D. Get Firstname, Lastname, DeliveryAddress, DeliveryZip, DeliveryCity for all customers who bought The Wolf of Wall Street.<br />
    E. Get Id, Date, Customer (Firstname, Lastname) and total cost of every individual order.<br />
    F. (Optional) Get Customer (Firstname, Lastname), total number of movies ordered by this customer, number of orders by this customer and total cost of all orders by this customer.<br />
    G. (Optional) Get number of orders and total cost for all orders in the database. COPY<br />

* Add a new column, CellNo to the Customers table. The column should contain the customer's cell phone number. (The old column, PhoneNo currently holds cell phone numbers only.)
* Write a query to copy the information from PhoneNo to CellNo.
    * Write a query to empty the PhoneNo column (Sets it to an empty string)

![](https://github.com/WebsterSweden/Lexicon_NET/blob/master/10_SQL_Database/images/database-2.png)

### Resources:
* https://www.sqlcourse.com/
* https://www.tutorialspoint.com/sql/

### Subjects Covered:
* SQL - Database<br />
*Create Table*<br />
*Insert Query*<br />
*Select Query*<br />
*Alter Table*<br />
*Where Clause*<br />
*Order By*<br />
*Group By*<br />
*Constraints*<br />
*Using Joins*<br />
