#To create a unit test csproj

dotnet new xunit

add a C# file and write your code in it

In the unit test's csproj file, add <GenerateProgramFile>false</GenerateProgramFile> under "PropertyGroup" section to avoid multiple entry points.


write your testacses in testfile.cs

#to run test
dotnet test

