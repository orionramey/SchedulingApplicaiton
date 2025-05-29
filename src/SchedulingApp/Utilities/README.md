I am unsure of what architecture I will use going forward. After doing some research I think I want to setup three seperate classes

1. Time
2. CustomerRepository
3. AddressRepository

2 & 3 will handle all CRUD operations with the DB. Let's remember to iterate through defensive coding with built in blocks & tests. I also need to strictly implement encapsualtion logic for the database. Further building on this I need to ensure no blanck attributes get used in any crud operations. EX. specifying something like if phone num blank make value N/A.

Comments to be built out. 


// Defensive String handling
isnullorwhitespace for designated filed. the field becomes "N/A"

// Defensive Integer validation

//timestamps 
