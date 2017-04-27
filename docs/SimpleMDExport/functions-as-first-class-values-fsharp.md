---
title: "Functions as First-Class Values (F#) | Microsoft Docs"
ms.custom: ""
ms.date: "04/27/2017"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "functions [F#]"
  - "functions [F#], first-class values"
ms.assetid: a9669418-52e3-4fa4-b04f-99d0d4b3f1fa
caps.latest.revision: 37
ms.author: "billchi"
manager: "douge"
---
# Functions as First-Class Values (F#)
A defining characteristic of functional programming languages is the elevation of functions to first-class status. You should be able to do with a function whatever you can do with values of the other built-in types, and be able to do so with a comparable degree of effort.  
  
 Typical measures of first-class status include the following:  
  
-   Can you bind an identifier to the value? That is, can you give it a name?  
  
-   Can you store the value in a data structure, such as a list?  
  
-   Can you pass the value as an argument in a function call?  
  
-   Can you return the value as the value of a function call?  
  
 The last two measures define what are known as *higher-order operations* or *higher-order functions*. Higher-order functions accept functions as arguments and return functions as the value of function calls. These operations support such mainstays of functional programming as mapping functions and composition of functions.  
  
## Give the Value a Name  
 If a function is a first-class value, you must be able to name it, just as you can name integers, strings, and other built-in types. This is referred to in functional programming literature as binding an identifier to a value. F# uses [let expressions](http://msdn.microsoft.com/en-us/c3b2cc64-04e1-4366-bfba-e8c71b96d86c) to bind names to values: `let <identifier> = <value>`. The following code shows two examples.  
  
 [!code-fs[FsConTour#20](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#20)]  
  
 You can name a function just as easily. The following example defines a function named `squareIt` by binding the identifier `squareIt` to the [lambda expression](http://msdn.microsoft.com/en-us/556283bc-c82d-4cb5-b20a-d24b346b619d)`fun n -> n * n`. Function `squareIt` has one parameter, `n`, and it returns the square of that parameter.  
  
 [!code-fs[FsConTour#21](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#21)]  
  
 F# provides the following more concise syntax to achieve the same result with less typing.  
  
 [!code-fs[FsConTour#22](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#22)]  
  
 The examples that follow mostly use the first style, `let <function-name> = <lambda-expression>`, to emphasize the similarities between the declaration of functions and the declaration of other types of values. However, all the named functions can also be written with the concise syntax. Some of the examples are written in both ways.  
  
## Store the Value in a Data Structure  
 A first-class value can be stored in a data structure. The following code shows examples that store values in lists and in tuples.  
  
 [!code-fs[FsConTour#23](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#23)]  
  
 To verify that a function name stored in a tuple does in fact evaluate to a function, the following example uses the `fst` and `snd` operators to extract the first and second elements from tuple `funAndArgTuple`. The first element in the tuple is `squareIt` and the second element is `num`. Identifier `num` is bound in a previous example to integer 10, a valid argument for the `squareIt` function. The second expression applies the first element in the tuple to the second element in the tuple: `squareIt num`.  
  
 [!code-fs[FsConTour#24](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#24)]  
  
 Similarly, just as identifier `num` and integer 10 can be used interchangeably, so can identifier `squareIt` and lambda expression `fun n -> n * n`.  
  
 [!code-fs[FsConTour#25](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#25)]  
  
## Pass the Value as an Argument  
 If a value has first-class status in a language, you can pass it as an argument to a function. For example, it is common to pass integers and strings as arguments. The following code shows integers and strings passed as arguments in F#.  
  
 [!code-fs[FsConTour#26](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#26)]  
  
 If functions have first-class status, you must be able to pass them as arguments in the same way. Remember that this is the first characteristic of higher-order functions.  
  
 In the following example, function `applyIt` has two parameters, `op` and `arg`. If you send in a function that has one parameter for `op` and an appropriate argument for the function to `arg`, the function returns the result of applying `op` to `arg`. In the following example, both the function argument and the integer argument are sent in the same way, by using their names.  
  
 [!code-fs[FsConTour#27](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#27)]  
  
 The ability to send a function as an argument to another function underlies common abstractions in functional programming languages, such as map or filter operations. A map operation, for example, is a higher-order function that captures the computation shared by functions that step through a list, do something to each element, and then return a list of the results. You might want to increment each element in a list of integers, or to square each element, or to change each element in a list of strings to uppercase. The error-prone part of the computation is the recursive process that steps through the list and builds a list of the results to return. That part is captured in the mapping function. All you have to write for a particular application is the function that you want to apply to each list element individually (adding, squaring, changing case). That function is sent as an argument to the mapping function, just as `squareIt` is sent to `applyIt` in the previous example.  
  
 F# provides map methods for most collection types, including [lists](http://msdn.microsoft.com/en-us/a2264ba3-2d45-40dd-9040-4f7aa2ad9788), [arrays](http://msdn.microsoft.com/en-us/0cda8040-9396-40dd-8dcd-cf48542165a1), and [sets](http://msdn.microsoft.com/en-us/61efa732-d55d-4c32-993f-628e2f98e6a0). The following examples use lists. The syntax is `List.map <the function> <the list>`.  
  
 [!code-fs[FsConTour#28](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#28)]  
  
 For more information, see [Lists](http://msdn.microsoft.com/en-us/83102799-f251-42e1-93ef-64232e8c5b1d).  
  
## Return the Value from a Function Call  
 Finally, if a function has first-class status in a language, you must be able to return it as the value of a function call, just as you return other types, such as integers and strings.  
  
 The following function calls return integers and display them.  
  
 [!code-fs[FsConTour#29](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#29)]  
  
 The following function call returns a string.  
  
 [!code-fs[FsConTour#30](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#30)]  
  
 The following function call, declared inline, returns a Boolean value. The value displayed is `True`.  
  
 [!code-fs[FsConTour#31](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#31)]  
  
 The ability to return a function as the value of a function call is the second characteristic of higher-order functions. In the following example, `checkFor` is defined to be a function that takes one argument, `item`, and returns a new function as its value. The returned function takes a list as its argument, `lst`, and searches for `item` in `lst`. If `item` is present, the function returns `true`. If `item` is not present, the function returns `false`. As in the previous section, the following code uses a provided list function, [List.exists](http://msdn.microsoft.com/en-us/15a3ebd5-98f0-44c0-8220-7dedec3e68a8), to search the list.  
  
 [!code-fs[FsConTour#32](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#32)]  
  
 The following code uses `checkFor` to create a new function that takes one argument, a list, and searches for 7 in the list.  
  
 [!code-fs[FsConTour#33](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#33)]  
  
 The following example uses the first-class status of functions in F# to declare a function, `compose`, that returns a composition of two function arguments.  
  
 [!code-fs[FsConTour#34](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#34)]  
  
> [!NOTE]
>  For an even shorter version, see the following section, "Curried Functions."  
  
 The following code sends two functions as arguments to `compose`, both of which take a single argument of the same type. The return value is a new function that is a composition of the two function arguments.  
  
 [!code-fs[FsConTour#35](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#35)]  
  
> [!NOTE]
>  F# provides two operators, `<<` and `>>`, that compose functions. For example, `let squareAndDouble2 = doubleIt << squareIt` is equivalent to `let squareAndDouble = compose doubleIt squareIt` in the previous example.  
  
 The following example of returning a function as the value of a function call creates a simple guessing game. To create a game, call `makeGame` with the value that you want someone to guess sent in for `target`. The return value from function `makeGame` is a function that takes one argument (the guess) and reports whether the guess is correct.  
  
 [!code-fs[FsConTour#36](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#36)]  
  
 The following code calls `makeGame`, sending the value `7` for `target`. Identifier `playGame` is bound to the returned lambda expression. Therefore, `playGame` is a function that takes as its one argument a value for `guess`.  
  
 [!code-fs[FsConTour#37](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#37)]  
  
## Curried Functions  
 Many of the examples in the previous section can be written more concisely by taking advantage of the implicit *currying* in F# function declarations. Currying is a process that transforms a function that has more than one parameter into a series of embedded functions, each of which has a single parameter. In F#, functions that have more than one parameter are inherently curried. For example, `compose` from the previous section can be written as shown in the following concise style, with three parameters.  
  
 [!code-fs[FsConTour#38](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#38)]  
  
 However, the result is a function of one parameter that returns a function of one parameter that in turn returns another function of one parameter, as shown in `compose4curried`.  
  
 [!code-fs[FsConTour#39](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#39)]  
  
 You can access this function in several ways. Each of the following examples returns and displays 18. You can replace `compose4` with `compose4curried` in any of the examples.  
  
 [!code-fs[FsConTour#40](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#40)]  
  
 To verify that the function still works as it did before, try the original test cases again.  
  
 [!code-fs[FsConTour#41](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#41)]  
  
> [!NOTE]
>  You can restrict currying by enclosing parameters in tuples. For more information, see "Parameter Patterns" in [Parameters and Arguments](http://msdn.microsoft.com/en-us/70462ad2-905a-40dc-8d15-0d5fce7ce9d4).  
  
 The following example uses implicit currying to write a shorter version of `makeGame`. The details of how `makeGame` constructs and returns the `game` function are less explicit in this format, but you can verify by using the original test cases that the result is the same.  
  
 [!code-fs[FsConTour#42](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#42)]  
  
 For more information about currying, see "Partial Application of Arguments" in [Functions](http://msdn.microsoft.com/en-us/a54734f3-15e1-4266-b66f-aae2562b0cb1).  
  
## Identifier and Function Definition Are Interchangeable  
 The variable name `num` in the previous examples evaluates to the integer 10, and it is no surprise that where `num` is valid, 10 is also valid. The same is true of function identifiers and their values: anywhere the name of the function can be used, the lambda expression to which it is bound can be used.  
  
 The following example defines a `Boolean` function called `isNegative`, and then uses the name of the function and the definition of the function interchangeably. The next three examples all return and display `False`.  
  
 [!code-fs[FsConTour#43](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#43)]  
  
 To take it one step further, substitute the value that `applyIt` is bound to for `applyIt`.  
  
 [!code-fs[FsConTour#44](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#44)]  
  
## Functions Are First-Class Values in F#  
 The examples in the previous sections demonstrate that functions in F# satisfy the criteria for being first-class values in F#:  
  
-   You can bind an identifier to a function definition.  
  
     [!code-fs[FsConTour#21](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#21)]  
  
-   You can store a function in a data structure.  
  
     [!code-fs[FsConTour#45](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#45)]  
  
-   You can pass a function as an argument.  
  
     [!code-fs[FsConTour#46](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#46)]  
  
-   You can return a function as the value of a function call.  
  
     [!code-fs[FsConTour#32](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#32)]  
  
 For more information about F#, see [F# Language Reference](http://msdn.microsoft.com/en-us/16b706f8-b5f2-4ff7-b2c1-64df33cd6adf).  
  
## Example  
  
### Description  
 The following code contains all the examples in this topic.  
  
### Code  
 [!code-fs[FsConTour#47](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/firstclasscitizen.fs#47)]  
  
## See Also  
 [Lists](http://msdn.microsoft.com/en-us/83102799-f251-42e1-93ef-64232e8c5b1d)   
 [Tuples](http://msdn.microsoft.com/en-us/520b10aa-76f5-47a4-84ba-5c35ab6305ef)   
 [Functions](http://msdn.microsoft.com/en-us/a54734f3-15e1-4266-b66f-aae2562b0cb1)   
 [let Bindings](http://msdn.microsoft.com/en-us/c3b2cc64-04e1-4366-bfba-e8c71b96d86c)   
 [lambda Expressions](http://msdn.microsoft.com/en-us/556283bc-c82d-4cb5-b20a-d24b346b619d)