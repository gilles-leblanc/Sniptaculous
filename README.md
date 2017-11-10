# Sniptaculous
### The most sniptacular C# snippet library for Visual Studio.

Sniptaculous is a library of Visual Studio C# snippets which are meant to complement Visual Studio's own snippets.

## Installation

The snippets are distributed as a zip file, [Sniptaculous](https://github.com/gilles-leblanc/Sniptaculous/raw/master/Sniptaculous.zip), which needs to be placed somewhere on your computer. In Visual Studio open the snippets manager (`Ctrl-K, Ctrl-B`) and Add the folder where Sniptaculous is stored. To update the snippets simply do a file copy.

## Usage

Once the snippets are installed the will appear in Visual Studio. To use them type the snippet (which will appear in Intellisense) and the press `tab` twice.

Just like the Visual Studio's snippets, certain snippets are parameterized. In this case the parameters will be highlighted. You can replace parameters by typing on a selected parameter and switch between parameters with `tab`. When all the parameters have been entered press `enter`.

If a snippet requires a dll or a `using` statement it will import itself automatically when the snippet is expended.

## Cheat Sheet

Here are the snippets:




### Automapper

| Shortcut    | Name                  |
|-------------|-----------------------|
| amc           | CreateMap                      |
| amm           | ForMember                      |
| amp           | RecognizePrefixes                      |


### Exceptions

| Shortcut    | Name                  |
|-------------|-----------------------|
| ea           | throw new ApplicationException                      |
| eam           | throw new ApplicationException with a message                      |
| ean           | throw new ArgumentNullException                      |
| eanm           | throw new ArgumentNullException with a message                      |
| eao           | throw new ArgumentOutOfRangeException                      |
| eaom           | throw new ArgumentOutOfRangeException with a message                      |
| ear           | throw new ArgumentException                      |
| earm           | throw new ArgumentException with a message                      |
| ee           | throw new Exception                      |
| eem           | throw new Exception with a message                      |
| eio           | throw new InvalidOperationException                      |
| eiom           | throw new InvalidOperationException with a message                      |
| eni           | throw new NotImplementedException                      |
| enim           | throw new NotImplementedException with a message                      |


### General

| Shortcut    | Name                  |
|-------------|-----------------------|
| ctor1p           | Constructor with 1 parameter                      |
| ctor2p           | Constructor with 2 parameters                      |
| ctor3p           | Constructor with 3 parameters                      |
| ctor4p           | Constructor with 4 parameters                      |
| dm           | DataMember Attribute                      |
| dtn           | DateTime.Now                      |
| pcl           | public class                      |
| propb           | bool Property                      |
| propdb           | double Property                      |
| propdc           | decimal Property                      |
| propdt           | DateTime Property                      |
| propi           | int Property                      |
| propid           | int Id Property                      |
| propls           | List Property                      |
| props           | string Property                      |
| snw           | string IsNullOrWhiteSpace                      |


### Moq

| Shortcut    | Name                  |
|-------------|-----------------------|
| mnm           | New Mock                      |
| msp           | Setup Property                      |
| mv           | Verify                      |
| mvn           | Verify Never                      |
| mvo           | Verify Once                      |


### MVC

| Shortcut    | Name                  |
|-------------|-----------------------|
| agetm           | MVC Get Action with model Async                      |
| apostm           | MVC Post Action with model Async                      |
| ara           | MVC Redirect To Action                      |
| dal           | Data Annotation for Localized display value                      |
| das           | Data Annotation for String Length constraint                      |
| get           | MVC Get Action                      |
| getm           | MVC Get Action with model                      |
| post           | MVC Post Action                      |
| postm           | MVC Post Action with model                      |
| rv           | return View                      |
| rvm           | return View with model                      |


### Tests

| Shortcut    | Name                  |
|-------------|-----------------------|
| aaa           | AAA comments                      |
| ae           | Assert.AreEqual                      |
| af           | Assert.IsFalse                      |
| afl           | Assert.Fail                      |
| ainc           | Assert.Inconclusive                      |
| an           | Assert.IsNull                      |
| ane           | Assert.AreNotEqual                      |
| ann           | Assert.IsNotNull                      |
| at           | Assert.IsTrue                      |
| cc           | Class Cleanup                      |
| ci           | Class Initialize                      |
| tc           | Test Cleanup                      |
| testa           | Test Method AAA                      |
| ti           | Test Initialize                      |


### WebApi

| Shortcut    | Name                  |
|-------------|-----------------------|
| wap           | WebApi Post Action                      |




## Name

The name is inspired by [Scriptaculous](http://script.aculo.us/) an old Javascript library. 
