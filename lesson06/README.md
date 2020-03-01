Create your own projects!

Your goal here to to create a setup that mimics those in the earlier tests:

1: A folder called lesson06 that contains a dotnet class library and a class called Calculator with a method called Add that takes two numbers and returns the sum om those numbers

2: A folder called lesson06 that contains a dotnet class library with a xUnit test that calls the Add method above and verifies that 5 + 6 is 11.

3: In the root folder there should be a solution file (.sln) that contains references to the two projects above.

#### Some hints

To create a dotnet application, try running ```dotnet new```

To add nuget packages execute ```dotnet add package NameOfPackage``` in the folder of the project you want to add it to.

To figure out which packages you need to run tests look at other lessons and be inspired =)

You can also add things besides packages. Try ```dotnet add project```.

You can create other new things to. Maybe there is a way to create a solution file somehow? When you have a solution you can also explorer ```dotnet sln```