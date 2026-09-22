# TechPhoneApplication


- This is only to demonstrate a simple CRUD operations using entity framework.
- This contains Create, Edit, Delete, View, and Search

# Model
- I created first the model to define the properties of Product
- Entity Framework maps this model directly to a database table


# Controller
- Next, I added controller by creating mvc with views and entity framework
- This created the views for this application (Note: I only added a search bar in index.cshtml and updated to add the column currency since i just added it after i created everything)
- This controller handles all the process requests:
- Index > to display products
- Create > handles httppost requests (adding new product)
- Edit > httppost that updates existing product
- Delete > remove product
- Details > view product details per product
- Search > filter products and displays it in index 

# Data/Migrations
- This automatically created the table or changes in the database, using entity framework and using the model
- I had an update that added a column that also updates the database using entity framework

# API Integration
- I added a ConvertedPrice in the Product model to cater the final price
- I integrate https://api.frankfurter.dev/ so I can convert the price to PHP
whenever it added a different currency in real time
- I created a service for the currency conversion integration
- I deserialized frankfurter to get the response from it
- I store both the original price and convertedprice value in the database


# Assumptions
- Frankfurter doesnt need an authentication
- Supported currencies are available
- Can still use both original and converted values

# Tradeoffs
- In saving both values, it uses more space but in auditing or investigating the data will be easier.
- In API integration, it makes easier to use or convert the currency base on the real time rates
and it makes the code clean

