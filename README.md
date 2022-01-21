# Motif Technical Challenge 🐱‍💻

In our flagship product, Fabric, we use widgets to allow putting together highly customisable web pages. Your task is to develop a simple Visual Studio Console Application which simulates a vector-based widget package. Your application should support the following drawing objects (widgets):

- Circle
- Rectangle
- Textbox

The application should be able to store widgets in a List and print their coordinates with their shape and size (not their area, just their dimensions).
For that you need to create a simple widget repository, through which you can add widgets and get the full list of widgets.

Coordinates are x and y integer values on an imaginary page.
\
The size/shape depends on the widget, as follows:
- Circle – diameter
- Rectangle – width and height
- Textbox – bounding rectangle (width and height)

NOTE:
- integer units are fine for all dimensions
- for the textbox you will also need to store the text to display, but don’t worry about font face /size / alignment, etc. 
- please use a separate .cs file for each class

Your console application should be able to 'print out' the current drawing by printing the key details of each widget (type, location, size/shape) to the console.

You DO NOT need to worry about any input from the user, you can use a hardcoded set of widgets to test the drawing simulator.

We have created the Visual Studio project with some interfaces already added to help you get started quickly. Make sure to implement and extend these interfaces as neccessary.

Also, don't forget to utilise inheritence and try adding validations for the data when creating widgets. You can use any solution for validations, throwing and catching exceptions are preferred.

## Grading ✔
We will evaluate your exercise on your ability to follow requirements while demonstrating good programming practices, such as: Maintainability, Extensibility, Robustness to changing requirements, Testability and SOLID principles.

## Required Output
In Main method add the following widgets:

- Rectangle x=15, y=20, width= 40, height=60
- Circle x=10, y=0, size=240
- Textbox x=30, y=5, width=200, height=10, text="Sample Text"

\
Your console must output the following when the required Print function is called:

Rectangle (15,20) width=40 height=60
\
Circle (10,0) size=240
\
Textbox (30,5) width=200 height=10 text="Sample Text"

### Good luck!
