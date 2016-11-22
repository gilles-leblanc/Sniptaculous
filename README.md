# Sniptaculous
### The most sniptacular C# snippet library for Visual Studio.

Sniptaculous is a library of Visual Studio C# snippets which are meant to complement Visual Studio's own snippets.

## Installation

Right now the snippets are distributed as a collection of files which needs to be placed somewhere on your computer. In Visual Studio open the snippets manager (`Ctrl-K, Ctrl-B`) and Add the folder where Sniptaculous is stored. To update the snippets simply do a file copy.

In the future Sniptaculous will probably be delivered in a more convenient fashion.

## Usage

Once the snippets are installed the will appear in Visual Studio. To use them type the snippet (which will appear in Intellisense) and the press `tab` twice.

Just like the Visual Studio's snippets, certain snippets are parameterized. In this case the parameters will be highlighted. You can replace parameters by typing on a selected parameter and switch between parameters with `tab`. When all the parameters have been entered press `enter`.

If a snippet requires a dll or a `using` statement it will import itself automatically when the snippet is expended.

## Cheat Sheet

Here are the snippets:

### Exceptions

| Shortcut    | Name                  |
|-------------|-----------------------|
| ea           | throw new ApplicationException                      |
| eam           | throw new ApplicationException                      |
| ear           | throw new ArgumentException                      |
| earm           | throw new ArgumentException                      |
| ean           | throw new ArgumentNullException                      |
| eanm           | throw new ArgumentNullException                      |
| eao           | throw new ArgumentOutOfRangeException                      |
| eaom           | throw new ArgumentOutOfRangeException                      |
| ee           | throw new Exception                      |
| eem           | throw new Exception                      |
| eio           | throw new InvalidOperationException                      |
| eiom           | throw new InvalidOperationException                      |
| eni           | throw new NotImplementedException                      |
| enim           | throw new NotImplementedException                      |


### General

| Shortcut    | Name                  |
|-------------|-----------------------|
| dtn           | DateTime.Now                      |


### MVC

| Shortcut    | Name                  |
|-------------|-----------------------|
| aget           | MVC Get Action                      |
| agetm           | MVC Get Action                      |
| agetma           | MVC Get Action Async                      |
| apost           | MVC Post Action                      |
| rv           | return View                      |
| rvm           | return View                      |


### Tests

| Shortcut    | Name                  |
|-------------|-----------------------|
| aaa           | AAA comments                      |
| ae           | Assert.AreEqual                      |
| afl           | Assert.Fail                      |
| ainc           | Assert.Inconclusive                      |
| af           | Assert.IsFalse                      |
| ann           | Assert.IsNotNull                      |
| an           | Assert.IsNull                      |
| at           | Assert.IsTrue                      |
| ane           | Assert.AreNotEqual                      |
| cc           | Class Cleanup                      |
| ci           | Class Initialize                      |
| testa           | Test Method AAA                      |
| tc           | Test Cleanup                      |
| ti           | Test Initialize                      |


## Name

The name is inspired by [Scriptaculous](http://script.aculo.us/) an old Javascript library. 