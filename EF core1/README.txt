EF core1 - ReadMore Books

1. Open "EF core1.sln" in Visual Studio 2022.
2. Make sure SQL Server Express LocalDB is installed.
3. Restore NuGet packages if Visual Studio asks.
4. Run the console project (Ctrl + F5).
5. The program creates ReadMoreBooksDB if needed, then checks the three tables.

To view the tables in Visual Studio:
View > SQL Server Object Explorer > (localdb)\MSSQLLocalDB > Databases > ReadMoreBooksDB > Tables

The database starts empty because the assignment only asks to create it.
The default SQL Server connection is in Data/BookstoreContext.cs.
Change it if you use SQL Server instead of LocalDB.

EF Core conventions are used for primary keys and relationships.
No Fluent API or data annotations are used.
