#!/usr/bin/env bash
dotnet new console -o 2-new_project
# Navigate into the new project directory
cd 2-new_project || { echo "Directory not found!"; exit 1; }

# Overwrite Program.cs with code to print "Hello World"
cat <<EOL > Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
EOL
dotnet build
dotnet run
