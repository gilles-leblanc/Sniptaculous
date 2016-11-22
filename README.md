# Sniptaculous
### The most sniptacular C# snippet library for Visual Studio.

Sniptaculous is a library of Visual Studio C# snippets which are meant to complement's Visual Studio's own snippets.

## Installation

Right now the snippets are distributed as a collection of files which need to be placed somewhere on your computer. Then in Visual Studio open the snippets manager (`Ctrl-K, Ctrl-B`) and Add the folder where Sniptaculous is stored. The update the snippets simply do a file copy.

In the future Sniptaculous will probably be delivered in a more convenient fashion.

## Usage

Once the snippets are installed the will appear in Visual Studio. To use them type the snippet (which will appear in Intellisense) and the press `tab` twice.

Just like the Visual Studio's snippets, certain snippets are parameterized. In this case the parameters will be highlighted. You can replace parameters by typing on a selected parameter and switch between parameters with `tab`. When all the parameters have been entered press `enter`.

If a snippet requires a dll or a `using` statement it will import itself automatically when the snippet is expended.

## Cheat Sheet

Here are the snippets:

### Tests

| Shortcut    | Name                  |
|-------------|-----------------------|
| aaa         | AAA comments          |


## Name

The name is inspired by [Scriptaculous](http://script.aculo.us/) an old Javascript library. 