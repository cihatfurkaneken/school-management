
# School Management System

### Student, Course and Instructor Management
- Developed with .Net Core MVC 
- N-Tier Architecture
- Login System
- CRUD operations students and Courses
- Tracking students courses grade and discontinuity
- Courses Lecturers

**Student Screen**

![stud](https://user-images.githubusercontent.com/48259639/116787856-3e878680-aaaf-11eb-8d1b-55e13cb91344.png)


**Student Editing**

![edit](https://user-images.githubusercontent.com/48259639/116787857-3f201d00-aaaf-11eb-98ef-c96683502ace.png)

**Adding Course**

![add](https://user-images.githubusercontent.com/48259639/116787858-3fb8b380-aaaf-11eb-8584-c7feb8028d5a.png)

**Student Information for grades and discontinuity**

![desc](https://user-images.githubusercontent.com/48259639/116787860-3fb8b380-aaaf-11eb-9b53-4c7979caf9c8.png)

**Login Screen**

![login](https://user-images.githubusercontent.com/48259639/116787861-40514a00-aaaf-11eb-8112-e9d410211c9b.png)

**Courses Screen**

![ders](https://user-images.githubusercontent.com/48259639/116787863-40514a00-aaaf-11eb-9505-3e9fca28f584.png)



## SETUP

I added the database file as .mdf to the project files. After adding this to SQL Server,
You need to replace the sql connection string with yours in the file.

> WebOBSDbContext.cs file in the  
> WebOBS \ WebOBS.DataAccess \ Concrete \ EntityFrameworkCore folder

`optionsBuilder.UseSqlServer(@"Data Source=**WRITE YOUR OWN SQL SERVER HERE**;Database=ObsDB;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");`

Same way,
The connection string in the _appsettings.json_ file in the 
> WebOBS \ WebObs.MVC folder 
is also you have to replace it with yours.

`"DbConnection": "Server=**WRITE YOUR OWN SQL SERVER HERE**;Database=ObsDB;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True"`

After running the program;
For the Login;
email: cihatfurkaneken@gmail.com
Password: Cihat2020. (don't forget the point)

Although the register event is not required for the program. Maybe you would like to see and try the login system.
I opened 2 records. If you want, you can open a new account with the registration system.

As a result of the features I added, in order for the record to be accepted, the password must contain at least one uppercase letter, one lowercase letter, number and sign.
If successful, it will redirect to the login page. If it fails, the register page is reloaded.

The **[Authorize]** attribute on the top of the files in the controller section adds that those parts cannot be accessed without logging in.
If you delete it, you can access the pages without logging in. In case of that, it cannot be accessed without logging in.


> _The application is designed in Turkish but can be easily modified._