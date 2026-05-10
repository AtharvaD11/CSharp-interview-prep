/*   What is .NET?
    
    .NET is a free, open-source, cross-platform developer platform built by Microsoft that allows us to build many different types
    of applications including web, mobile, cloud, desktop, Iot, etc.

    At core, it has 2 key things:
        1. Runtime - called as the Common Language Runtime (CLR). This executes the code, manages memory through garbage collection,
                    handles exception and provides type safety.

        2. A large class library - called as Base Class Library(BCL). Gives us pre-build API's for I/O, networking, collections, 
		               database access, etc

        We can write C#, F# and Visual Basic code in .Net. The code compiles down to an Intermediate Language(IL). The IL then 
        Just-In Time(JIT) compiles it to native machine code at runtime
 */


// A simple .NET Console Application in C#

using System;
using System.Collections.Generic;

namespace WhatIsDotNet
{
    class WhatIsDotNet
    {
        static void Main(string[] args)
        {
            // BCL in action - using built-in List<T> from System.Collections.Generic base class library
            List<string> frameworks = new List<string>
            {
                "ASP.Net Core",
                "Blazor",
                "MAUI",
                "WPF",
                "Entity Framework Core"
            };
            Console.WriteLine("Welcome to .NET!");
            Console.WriteLine("Things you can build with .NET:\n");

            foreach (var framework in frameworks)
            {
                Console.WriteLine($" ✔ {framework}");
            }

            // CLR handles memory. No manual memory management needed.
            Console.WriteLine("\n.NET's CLR takes care of memory management and garbage collection for you!");
        }
    }
}


/*
 Follow-Ups
 
 Q1.What is the difference between.NET Framework, .NET Core, and .NET 5/6/7/8+?
.NET Framework

Oldest version of .NET
Windows-only
Used mainly for traditional desktop and older web applications
Runs only on Windows and is now in maintenance mode

.NET Core

Introduced as a modern, lightweight, cross-platform version of .NET
Runs on Windows, Linux, and macOS
Better performance and suitable for cloud, APIs, and microservices
Open-source and modular

.NET (.NET 5/6/7/8+)

Unified platform that replaced .NET Core naming
Cross-platform, high-performance, and actively developed
Supports web, desktop, cloud, mobile, and AI applications
.NET 6 and .NET 8 are LTS (Long-Term Support) versions commonly used in industry
------------------------------------------------------------------------------------------------------------------------------

2. What is JIT
=>
  JIT compiles IL code into native machine code at runtime so the application can execute on the target machine.


3. What is the BCL (Base Class Library)?
=>
    It's the standard library that ships with .NET. It includes namespaces like:

    System — core types (string, int, DateTime)
    System.Collections — List, Dictionary, etc.
    System.IO — file and stream operations
    System.Net — networking
    System.Threading — concurrency


4. What is NuGet?
=>
    NuGet is the package manager for .NET — similar to npm for Node.js or pip for Python. 
    It lets you add third-party libraries to your project easily via the CLI or Visual Studio.
 
 */
