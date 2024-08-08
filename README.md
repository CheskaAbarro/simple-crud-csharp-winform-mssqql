# CRUDSampleWinForms
**This is just a simple CRUD functions using WinForms and MS SQL Server. Created with .NET 8 and MSSQL v20. This includes a simple error try and catch and does not include dependency injection and does not use MVVM format. This is just for beginner's practice guide!**

### How to run this CRUD system on your device? 
**Step 1: Set up your database in MS SQL Server**
Database details: 
```
Database: CRUDWinForms
Table: CRUD_Basic
Table contents: ID(int, Identity Specification:Yes), Name(varchar 50), Age(int)
Note: You can decide if you want to create this database created a query or not.
```

**Step 2: Establish connection**
You can find your server name when connecting your MS SQL Server. 
Update the connectionString variable with your server name and database name. 
```
string connectionString = "Data Source=SERVERNAME;Initial Catalog=CRUDWinForms;Integrated Security=True;TrustServerCertificate=True";
```

**Step 3: Run the application and enjoy learning!**
Update the connectionString variable with your server name and database name. 

![image](https://github.com/user-attachments/assets/5b0f24b8-f6be-4440-8949-559e81e31010)

**Tip: Read all the comments and try to debug line by line in order to study it better.**

### If you encounter an error, please leave a comment of your error and I will try to answer as soon as possible. 
### Happy learning!
