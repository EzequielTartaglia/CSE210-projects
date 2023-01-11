# cse210-student-template
This is the starter code for Ezequiel M. Tartaglia in CSE 210.

This repository contains the starter code for many different projects. They are arranged as follows:

* `sandbox` - An empty project that you can use to play around with any concepts you like.
* `csharp-prep` - Starter projects for each of the C# Prep assignments.
* `prepare` - Starter projects for each of the preparation Learning Activities.
* `prove` - Starter projects for each of the prove Developer projects.
* `final` - Starter projects for final project.


•Projects:
 
 ♦ Personal journal project with Classes in C# .net:
   - Source: prove\Develop02
   - Features: With date counter, enter entries and save them to an external csv file, load from that external file, and exit the program.
       
       Aditional information:
       
       Classes: We need to this project a Class named Entry for example to receive every entry inside the Journal. For other part we need to make a Class Journal to storage all the data. 

       •Journal - Behaviors: The Behavior of this Class will be "like a storage" for all the data. That Journal can transfer the information about the list for other files (ex. myFile.csv), then we could load that information again from the file. Also we could display all the Entries inside the List. 

       •Journal - Attributes: We need to have the propieties of: _name and _entries inside the Class, the first is to make the principal character from the user   (Something more to add creativity), for other part the _entries(from the list) to display all the information about that entry. In relationship with the methods, in this case, is necessary to use Display( ) to display all the information about the list of entries. 

       •Entry - Behaviors: The behavior of this Class will be the information particulary about one Date in order to answer a specific question. The user receive one input asking a question about the that or to ponder. Then, the user write that answer and, with a process, convert the first letter of the answer to a capital letter, and create a new entry with (date,prompt and answer).

       •Entry - Attributes: The attributes to this Class will be: _message (come from a list of random questions), _response (to save the input in a variable and could print that later, with the capital letter in the beggining of that output) _date (applied with the date of the entry, and pass to the "header" of the entry). About methods, we need to use the method Display( ), to show the data in a order.

       •Saving/Loading: In this program, the handle about the data from the Jornal, we need to put the infomation about the _entries in the List of entries, to send those to an external file (ex. myFile.csv). When that was saved, will countinue running. If we need to load the list in the file, we need to ask for the name of the file (the same as when we was saving) and then print all the data to continue using the information. To use this things we use tools like:

       System.IO.File.ReadAllLines()
       using (StreamWriter outputFile = new StreamWriter(file))
       outputFile.WriteLine()
       •Prompt Generation: The prompt generation in this program will be created with the Random function provices from c#, saving all the different phases in a List and then, put the numbers int the int num =random.Next(0,x) using x as the lenght of the list, provided by Random. then in the new Entry created, we will be assign the variable num to the entry_message like this:

       entry1._message = notificationsList[num]
       •Interaction:  I exaplain before about the behaviors between the classes. Something to add is the menu provide the interaction user-app, The menu will provide interaction between design elements, working with a closer user application. We will use the behavior of the classes to be able to manipulate the information independently, for specific properties or information, or by inherence when, for example, we bring the Journal Entries.

  ♦ Personal Memory Game project with Classes in C# .net:
  
       •Classes: In this assignment we will use at least 3 classes: The "Reference" class that will include the information of the scripture passage, the "Scripture" class that will include the information of the verses (the text) and the "Word" class that will provide the use to hide or show the words. The objects will be created and all will be invoked in the Main class (in program.cs)

     Reference     →

     Scripture       →     Program   

     Word             →



     •Scripture: The Scripture class has the behavior of being created with different constructors depending on the data that the user enters to receive and send parameters (through getters and setters), in addition to functions such as send GetCompleteScripture which we will execute from the Main class. About the attributes of this class will contain the property _phase which will contain the phrase believe, so that it can be manipulated later.

     •Reference: The Reference class It has the behavior of being created with different constructors depending on the data that the user enters to receive (and that will also influence the output, since it is not the same that we put 2 verses than 1 only, because it will have a - divisor between both) and sending parameters (through getters and setters), as well as functions like sending GetCompleteReference which we will execute from the Main class. On the attributes of this class it will contain the property _book which will contain the requested book, _chapter the chapter, _verse the verse and _verse2 in case the user wants to memorize more than one verse at a time, so that they can be manipulated later.

     •Word: The Word class has the behavior of being created with different constructors depending on the data the user enters to receive and send parameters (via getters and setters), as well as functions like show/hide. On the attributes of this class it will contain the _word and _hidden property so that if it is active it changes the letters to "-" and otherwise shows the complete word.

     •Constructors; The classes will be created with differents contructors, one for a "default class" is the class when the user create a new object or the program with some values as a default value ("" or 0 or false), other constructors created with differents uses for some different ocations (we will create one constructor for each parameter put in the object (if the object have 3 parameters, have 4 constructors in total) 

     •Interaction: The Interaction in the design will be all inside the class Main (about the propieties and methods created in the other classes), using the constructors in the other classes and mix the methods to create the diferent functions inside the program. 
