namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("learntoprogramfsharp")>]
[<assembly: AssemblyProductAttribute("learntoprogramfsharp")>]
[<assembly: AssemblyDescriptionAttribute("a book to teach people how to program")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
