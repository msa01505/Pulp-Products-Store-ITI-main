# Documentation

## What is pulp?

pulp is an ecommerce web based application built to help the client buying paper/plastic based products .

## Technologyies

ASP .net core 3, HTML ,css, js , jQurey and strip payment gateway

## Roles

- #### Admin :
  
  add , edit and remove for products , business and category.

- #### Fullfiller :
  
  accept/reject orders.

- #### Buyer :
  
  search , filter, review, buy or pay products.



## Quick install

- check connection string
  
  ```C#
  "MyConn": "Data Source=.;Initial Catalog=PulpDB;Integrated Security=True",
  "PulpProjectContextConnection": "Server=.;Database=PulpIdentity;Trusted_Connection=True;MultipleActiveResultSets=true"
  ```

- open terminal and write this command 
  
  ```C#
  update-database -context PulpProjectContext
  update-database -context myContext
  ```

- run the appliction and everything should be running perfectly
