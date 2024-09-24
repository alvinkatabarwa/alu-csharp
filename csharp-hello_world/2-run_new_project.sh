#!/usr/bin/env bash

#Initializing a new C# console project in the folder 2-new_project
dotnet new console -o 2-new_project

# Navigating to the new project directory
cd 2-new_project

# Building the project 
dotnet build

# Modify Program.cs to print "Hello World!"
echo 'using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}' > Program.cs

dotnet run
