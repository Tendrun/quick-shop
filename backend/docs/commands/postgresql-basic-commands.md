1. Connect via cmd 
docker exec -it workshop-db psql -U dev -d workshop

2. show all tables 
\dt

3. Show all databases on server
\l

4. Show users
\du

5. See records form table, in this example table products is used
SELECT * FROM "Products";