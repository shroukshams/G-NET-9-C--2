using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");



            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //is used to organize and group code into collapsible sections,
            //making large code files easier to navigate and maintain.
            // ══════════════════════════════════════════════════════════════════════

            //Nested Region Example

            /*
                  #region Data Access Layer
                  #region Read Operations
                  public User GetById(int id) { }
                  public List<User> GetAll() { }
                  #endregion
                  #region Write Operations
                  public void Add(User user) { }
                  #endregion
                  #endregion
               
             */


            #endregion

            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.

            //Explicit variable
            //declaration involves explicitly stating the data type of a variable at the time of its declaration.

            //Implicit variable
            //declaration, introduced with the var keyword in C# 3.0,
            //allows the compiler to infer the data type of a local variable based on the value assigned to it during initialization.
            // ══════════════════════════════════════════════════════════════════════

            // EXPLICIT DECLARATION 
            // int X = 10;

            // IMPLICIT DECLARATION 
            // var number = 10; 
            #endregion

            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?

            //      const DataType ConstantName = Value;
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples
            // const double Pi = 3.14159;
            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.

            // Class-level scope means that a variable or member is accessible from any method within the class.
            // Method-level scope means that a variable is only accessible within the method it is declared in.

            //    class MyClass
            //{
            //    private int _classLevel = 1;  // Class scope - accessible anywhere in class

            //    public void MyMethod(int param)  // param: Method scope
            //    {
            //        int methodLevel = 2;         // Method scope

            //        if (true)
            //        {
            //            int blockLevel = 3;     //  Block scope - only here!
            //        }
            //    }
            //}

            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope?
            //  Block-level scope means that a variable is only accessible within the block
            // (denoted by curly braces {}) in which it is declared.

            // Give an example showing a variable that is only accessible within a specific block.
            //  {
            //      int blockVar = 10; // block-level scope}
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            // Variable lifetime refers to the duration a variable exists in memory during program execution.
            // Local variables exist only during the execution of the method they are declared in.
            // Static variables exist for the lifetime of the application domain.

            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?

            // The Garbage Collector (GC) in C# is an automatic memory management system that
            // periodically frees up memory occupied by objects that are no longer in use,
            // thus affecting the lifetime of objects by reclaiming memory when they are no longer reachable.

            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?


            // Variable shadowing occurs when a variable declared in an inner scope has the same name as a variable in an outer scope,
            // effectively "hiding" the outer variable within the inner scope.
            // C# does allow shadowing in nested blocks within the same method.

            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.

            // 1. Variable names must start with a letter or an underscore (_).
            // 2. Variable names can only contain letters, digits, and underscores.
            // 3. Variable names cannot be the same as C# reserved keywords.
            // 4. Variable names are case-sensitive.
            // 5. Variable names should be descriptive and follow camelCase convention for local variables.
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            // Recommended Naming Conventions:
            // (a) Local Variables: camelCase (e.g., myVariable)
            // (b) Class Names: PascalCase (e.g., MyClass)
            // (c) Constants: PascalCase or ALL_CAPS_WITH_UNDERSCORES (e.g., MyConstant or MAX_VALUE)

            // ═══════════════════════════════════════════════════════════════════
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.

            // Syntax Errors: These occur when the code violates the rules of the C# language.
            // Example: Missing semicolon at the end of a statement.
            // Runtime Errors: These occur during the execution of the program, often due to invalid operations.
            // Example: Dividing by zero.
            // Logical Errors: These occur when the program runs without crashing but produces incorrect results due to flawed logic.
            // Example: Using incorrect formula for calculations.


            //══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?

            // Exception handling is important in C# because it allows developers to manage and respond to runtime errors gracefully,
            // preventing application crashes and providing a better user experience.
            // If exceptions are not handled, the application may terminate unexpectedly,
            // leading to data loss, poor user experience, and difficulty in diagnosing issues.

            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.


            // The finally block executes after the try and catch blocks,
            // regardless of whether an exception was thrown or caught.
            // It is typically used for cleanup code that must run regardless of the outcome of the try-catch.
            // EXAMPLE:
            // try
            // {
            //     // Code that may throw an exception
            // }
            // catch (Exception ex)
            // {
            //     // Code to handle the exception
            // }
            // finally
            // {
            //     // Code that always executes
            //}
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            // 1. NullReferenceException: Occurs when trying to access a member on a null object reference.
            // 2. IndexOutOfRangeException: Occurs when trying to access an array or collection with an invalid index.
            // 3. DivideByZeroException: Occurs when attempting to divide a number by zero.
            // 4. InvalidOperationException: Occurs when a method call is invalid for the object's current state.
            // 5. FormatException: Occurs when the format of an argument is invalid, such as when parsing a string to a number.
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.

            // The order of catch blocks is important because C# evaluates them from top to bottom.
            // More specific exceptions should be caught before more general ones to ensure that the correct handler is executed.
            // Example of correct ordering:

            // try    
            // {
            //     // Code that may throw exceptions/
            // }
            // catch (NullReferenceException ex)
            //  {
            //     // Handle NullReferenceException
            // }
            // catch (Exception ex)
            // {
            //     // Handle all other exceptions
            // }

            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?

            //  The difference between 'throw' and 'throw ex' when re-throwing an exception is that   
            // 'throw' preserves the original stack trace, while 'throw ex' resets it.
            // It is recommended to use 'throw' when re-throwing exceptions.

            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?

            // Stack memory is used for static memory allocation and stores value types and method call information.
            // Heap memory is used for dynamic memory allocation and stores reference types, such as objects and arrays.
            // Value types are stored on the stack, while reference types are stored on the heap.
            // When a value type is assigned to another variable, a copy of the value is made.
            // When a reference type is assigned to another variable, a reference to the same object is used.
            // This means that changes made to the object through one reference will be reflected in all references to that object.
            //
            //
            // ══════════════════════════════════════════════════════════════════════


            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.


            // Value Types Example
            // int a = 10;
            // int b = a; // b gets a copy of a's value
            // b = 20;    // Changing b does not affect a


            // Reference Types Example
            // class MyClass
            // {
            //     public int Value;
            // }
            // MyClass obj1 = new MyClass();
            // obj1.Value = 10;
            // MyClass obj2 = obj1; // obj2 references the same object as obj1
            // obj2.Value = 20;     // Changing obj2 affects obj1

            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            // 'object' is considered the base type of all types in C# because every type,
            // both value types and reference types, ultimately derives from System.Object.                         
            // Every type in C# inherits the following methods from System.Object:
            // 1. ToString()
            // 2. Equals(object obj)
            // 3. GetHashCode()
            // 4. GetType()
            // 5. MemberwiseClone()

            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

        }



    }


}