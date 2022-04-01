Linq To SQL2
=============

A fork of Microsoft's LINQ-to-SQL, used by LINQPad 6 and later.

This is based on [Frans Bouma's fork](https://github.com/FransBouma/LinqToSQL2/issues), which is based on the [.NET reference sourcecode](https://github.com/Microsoft/referencesource).

It includes a number of enhancements, the most important of which is that it supports .NET Core 3.1 and later.

Other enhancements include support for .NET 6's DateOnly/TimeOnly types and the addition of hooks to allow for better logging and the implementation of new authentication schemes (such as Azure MFA).

Namespace changes introduced in [Frans Bouma's fork](https://github.com/FransBouma/LinqToSQL2/issues) have been rolled back to ensure full compatiblity with .NET Framework's version of LINQ-to-SQL.

### Target Frameworks

The project file includes 3 target frameworks: .NET Standard 2.0, .NET Framework 4.5.2, and .NET 6.0. The .NET 6.0 target supports DateOnly/TimeOnly types.

### License

The original Linq to SQL code is (c) Microsoft Corporation (see License.txt). Additional code added is (c) by the contributors and is marked as such in the code files. 
