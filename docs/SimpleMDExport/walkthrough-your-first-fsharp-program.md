---
title: "Walkthrough: Your First F# Program | Microsoft Docs"
ms.custom: ""
ms.date: "04/27/2017"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "F# programming, creating your first program"
ms.assetid: b44d69fe-437f-41db-8568-e3e56c9934aa
caps.latest.revision: 32
ms.author: "billchi"
manager: "douge"
---
# Walkthrough: Your First F# Program
[!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] includes a new programming language, F#. F# is a multiparadigm language that supports functional programming in addition to traditional object-oriented programming and .NET concepts. The following examples introduce some of its features and syntax. The examples show how to declare simple variables, to write and test functions, to create tuples and lists, and to define and use a class.  
  
 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]  
  
### To create a new console application  
  
1.  On the **File** menu, point to **New**, and then click **Project**.  
  
2.  If you cannot see Visual F# in the **Templates Categories** pane, click **Other Languages**, and then click **Visual F#**. The **Templates** pane in the center lists the F# templates.  
  
3.  Look at the top of the **Templates** pane to make sure that **.NET Framework 4** appears in the **Target Framework** box.  
  
4.  Click **F# Application** in the list of templates.  
  
5.  Type a name for your project in the **Name** field.  
  
6.  Click **OK**.  
  
     The new project appears in **Solution Explorer**.  
  
### To use the let keyword to declare and use identifiers  
  
1.  Copy and paste the following code into **Program.fs**. You are binding each identifier, `anInt`, `aString`, and `anIntSquared`, to a value.  
  
     [!code-fs[FsConTour#1](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#1)]  
  
    > [!NOTE]
    >  If you cannot see the code in Classic view, make sure that the **Language Filter** in the header below the topic title is set to include F#.  
  
### To see results in the F# Interactive window  
  
1.  Select the `let` expressions in the previous procedure.  
  
2.  Right-click the selected area and then click **Send to Interactive**. Alternatively, press ALT+ENTER.  
  
3.  The **F# Interactive** window opens and the results of interpreting the `let` expressions are displayed, as shown in the following lines. The types are inferred from the specified values.  
  
     `val anInt : int = 5`  
  
     `val aString : string = "Hello"`  
  
     `val anIntSquared : int = 25`  
  
### To see the results in a Command Prompt window  
  
1.  Add the following lines to **Program.fs**.  
  
     [!code-fs[FsConTour#2](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#2)]  
  
2.  Press CTRL+F5 to run the code. A Command Prompt window appears that contains the following values.  
  
     `5`  
  
     `Hello`  
  
     `25`  
  
     You can verify the inferred types by resting the mouse pointer on the identifier names `anInt`, `aString`, and `anIntSquared` in the previous `WriteLine` statements.  
  
### To define and run a function  
  
1.  Use a `let` expression to define a squaring function, as shown in the following code. The function has one parameter, `n`, and returns the square of the argument sent to `n`.  
  
     [!code-fs[FsConTour#3](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#3)]  
  
2.  Press CTRL+F5 to run the code. The result displayed is 25.  
  
3.  A recursive function requires a `let rec` expression. The following example defines a function that calculates the factorial of parameter `n`.  
  
     [!code-fs[FsConTour#4](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#4)]  
  
4.  Press CTRL+F5 to run the function. The result displayed is 120, the factorial of 5.  
  
### To create collections: lists and tuples  
  
1.  One way to aggregate values is by using a tuple, as shown in the following code.  
  
     [!code-fs[FsConTour#5](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#5)]  
  
2.  Another way to aggregate values is by using a list, as shown in the following code.  
  
     [!code-fs[FsConTour#7](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#7)]  
  
     Add a new best friend to the list by using the "cons" operator (::). Note that the operation does not change the value of `bffs`. The value of `bffs` is immutable and cannot be changed.  
  
     [!code-fs[FsConTour#8](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#8)]  
  
     Use `printfn` to display the lists. Function `printfn` shows the individual elements that are contained in structured values.  
  
     [!code-fs[FsConTour#9](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#9)]  
  
3.  You can view the results either by pressing CTRL+F5 or by selecting a section of the code and then pressing ALT+ENTER.  
  
### To create and use a class  
  
1.  The following code creates a `Person` class that has two properties, `Name` and `Age`. `Name` is a read-only property. Its value is immutable, as are most values in functional programming. You can create mutable values in F# if you need them, but you must explicitly define them as mutable. In the following class definition, the value of `Age` is stored in a mutable local variable, `internalAge`. The value of `internalAge` can be changed.  
  
     [!code-fs[FsConTour#10](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#10)]  
  
2.  To test the class, declare two `Person` objects, make some changes, and display the results, as shown in the following code.  
  
     [!code-fs[FsConTour#11](../samples/snippets/fsharp/VS_Snippets_Fsharp/fscontour/fs/creatingfirstprogram.fs#11)]  
  
     The following lines are displayed.  
  
     `Name:  John`  
  
     `Age:   44`  
  
     `Name:  Mary`  
  
     `Age:   15`  
  
     `False`  
  
### To view other examples in the F# tutorial  
  
1.  On the **File** menu, point to **New**, and then click **Project**.  
  
2.  If you cannot see Visual F# in the **Templates Categories** pane, click **Other Languages**, and then click **Visual F#**. The **Templates** pane in the center lists the F# templates.  
  
3.  Look at the top of the **Templates** pane to make sure that **.NET Framework 4** appears in the **Target Framework** box.  
  
4.  Click **F# Tutorial** in the list of templates.  
  
5.  Click **OK**.  
  
6.  The tutorial appears in **Solution Explorer**.  
  
## Next Steps  
 For more information about functional programming and additional examples, see [Functions as First-Class Values](http://msdn.microsoft.com/en-us/a9669418-52e3-4fa4-b04f-99d0d4b3f1fa). For more information about tuples, lists, let expressions, function definitions, classes, members, and many other topics, see [F# Language Reference](http://msdn.microsoft.com/en-us/16b706f8-b5f2-4ff7-b2c1-64df33cd6adf).  
  
## See Also  
 [Visual F#](http://msdn.microsoft.com/en-us/66f52f8a-a034-4c32-bb83-fa5b030faa4d)   
 [F# Language Reference](http://msdn.microsoft.com/en-us/16b706f8-b5f2-4ff7-b2c1-64df33cd6adf)   
 [Functions as First-Class Values](http://msdn.microsoft.com/en-us/a9669418-52e3-4fa4-b04f-99d0d4b3f1fa)