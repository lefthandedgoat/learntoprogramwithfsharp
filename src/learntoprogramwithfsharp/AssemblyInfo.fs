namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("learntoprogramwithfsharp")>]
[<assembly: AssemblyProductAttribute("learntoprogramwithfsharp")>]
[<assembly: AssemblyDescriptionAttribute("a book to teach people how to program")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
