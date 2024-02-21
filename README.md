* Welcome to StudMag - application to support community races, to raise funds and money for charity and helping people purpose
- The application using ASP.NET 6.0 for the back-end, and ReactJs for the front-end side.
- There are no backup files for the database, though every cities and country will have to store there own data of the community
- For further development, please fill in below this document about your ideas and push that to the repo so that we can achieve the work together.



* REMINDER/NOTE:

#for Windows dev:

    => if first time cloning the project and initial empty local database, run the following command in the terminal:
        dotnet ef migrations remove
    => if already have the database locally (you are working on the features), run the following command:
        dotnet ef database update


#for MacOS dev:

    => first 
        open appsettings.Development.js to configure the connections string belong to your local db, as Mac doesnt support SQL Server CLI native, you have to connect to the database throw Azure DBMS, then by default you will have too add the following string to the connectionstring "integrated security=false;"

    => second
        => if first time cloning the project and initial empty local database, run the following command in the terminal:
            dotnet ef migrations remove
        => if already have the database locally (you are working on the features), run the following command:
            dotnet ef database update

* Ideas for discussing:
    #Yours ideas comes here