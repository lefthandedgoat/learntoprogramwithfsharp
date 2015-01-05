(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
### Getting Started

1. Install Visual Studio 2013 [here][vs]
2. Open Visual Studio
3. Create a new project called LearnToProgram (F# Console Application)
4. Clear the contents of the open file `Program.fs`
5. Replace content with below code
6. Press `F5` to run

  [vs]: http://www.visualstudio.com/en-us/news/vs2013-community-vs.aspx

*)
printfn "Hello World"
System.Console.ReadKey()

(**
You've just written you're first program!  Now let us add to it
*)

printfn "Enter your name then press [enter]:"
let name = System.Console.ReadLine()
printfn "Hello World, from %s" name
System.Console.ReadKey()

(**
Press `F5` to run!  The program should allow you type a name, like 'Bob', then print `Hello World, from Bob`

### What are Programs?

Programs are sets of instructions that tell a computer what to do.  Operating Systems like Windows or OSX are programs. 
Websites like online stores and search engines are programs.  Apps on your phone's App Store are programs.

Programs are written for many reasons.  This book will teach you how to write programs. 
We will start with basic programs that run from the console (MS-DOS) and grow from there.  

### What is F# (FSharp)?
  todo
  todo
  todo

### What have you seen so far?

Thus far you have seen an example of using `printfn` which prints value(s) to the console. 
You have also seen `System.Console.ReadLine()` which reads a line from the console, and set a new value named `name` with the results. 
We then used `printfn` again to print Hello World and the name that was stored in the value named `name`. 
Lastly we told the console to wait for any key press with `System.Console.ReadKey()`. 
Afer a key was pressed the last line of our program was done executing and the program was done running.

### Values
*)

let firstName = "Bob"
let lastName = "Smith"
let fullName firstName lastName = firstName + " " + lastName
let shoeSize = 12
let height = 72.5
let married = false
let dateOfBirth = System.DateTime(1977, 2, 14)

(**
Values hold information in our programs. 
Above we have many pieces of information about Bob Smith, all stored in their own value. 
We can use values with other values to create new values, as is the case with `fullName`.
Note: By default, values can not be changed once set.  They different from `variables` that you may have read about in other programming languages.

### Types

Each of the above values has a type.  Types are a way to represent data to a computer. 
There are many different types built in to F#. 
We will start with a few basic ones now, and expand on more later.

| Value          | Is of type                                       | Description                                                                                                                        |
| :------------- |:-------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------|
| `firstName`    | `string`                                         | A `string` is a series of characters. It can contain any number of characters, from 0 up to the whole contents of a book and more! |
| `lastName`     | `string`                                         |                                                                                                                                    |
| `fullName`     | `string -> string -> string`                     | This reads as `a function that takes a string, a string, and returns a string` (more on this later)                                |
| `shoeSize`     | `int`                                            | An `int` is a whole number                                                                                                         |
| `height`       | `float`                                          | `float` is used to store values with decimal places                                                                                |
| `married`      | `bool`                                           | A `bool` can only have one of two values.  It is either `true` or `false`                                                          |
| `dateOfBirth`  | `System.DateTime`                                | `System.DateTime` stores date and time information                                                                                 |

### Football Example
  todo
  todo
  todo

*)