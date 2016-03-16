# FundMaster
FundMaster Tool. WPF+EF Code First. Simple manipulations with Funds and Securities.

Given the below User Story, create a C# Winforms/WPF application that meets the Product

Owners Acceptance Criteria. There are no time constraints and you are free to use any 

resources at your disposal. 

Please consider and exhibit Object-Oriented, UI and TDD design principles in your solution.

User Story

As a Fund Manager, I want to be able to add stocks to my Fund so that I can manage and report 

on my Fund.

Acceptance Criteria descibed in email.


# HowTo:

You have to have MSSQL Express or any other versions server installed

1. Ensure connection credentials to your DB is correct in App.config file - section as below:
  
  <connectionStrings>
    <add name="FundMasterLocal" providerName="System.Data.SqlClient" connectionString="Data Source=.\;initial catalog=FundMaster;integrated security=True;multipleactiveresultsets=True;App=FundMaster" />
  </connectionStrings>
  
2. Afterward, open Nuget console in MS Visual Studio and make Migration to your database by run following:

Update-Database -ProjectName FundMaster.EntityDAL -StartUpProjectName FundMaster.EntityDAL -ConnectionStringName "FundMasterLocal"

After that it should be created DB structure with initial data seeding

3. Feel free to run application where you will find 3 tabs:
	a. Create Fund
	b. Create Security
	c. Summary Information

# Implementation Notes:

Application works and return result as decribed in User story.
It could be refactored with following well known points:
	a. It was created solution structure, including test project, but code is not covered with the scope of tests due to time spendings. So, point to improve - add tests.
	b. In ideal case WPF application should follow MVVM pattern, so - using VieModel is also point to improve and refactor.
	c. Add logging to the application like log4net for example
	d. Add validation on border values for grids, comboboxes and text fields

 