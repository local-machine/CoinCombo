# Coin Combinations
### By Rochelle Roberts
-----

## Description
* Coin Combinations is a C# console app that lets a user enter an amount of cents and shows the smallest number of quarters, dimes, nickels, and pennies needed to make that change.
* Unit testing functions


## Technologies Used
* C#
* .NET
* MSTest

## Installation
* Clone project repo
* From the project's root directory, open console and type dotnet run

```sh
$ git clone https://github.com/rochellev/CoinCombinations.git
$ cd  CoinCombinations
$ cd Coin
$ dotnet restore
$ dotnet run
```

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |:------------:| :--------------:|
| if user types 0, then return need 0 coins | 0 | 0 coins |
| give user change | 25 | 1 quarter |
| use as many quarters as possible | 80 | 3 quarters, 1 nickel |

## Project Directory
1. Model Directory
    * contains project's .cs files 
    * this is where your classes go
2. Project.csproj
    * things needed to install 
    * dotnet restore -- will install dependencies

## Project.Tests Directory
1. ModelTests Directory
    * your tests will be here
2. Project.Tests.csproj
    * make sure update the ProjectReference !
    * run dotnet restore to install the dependencies
