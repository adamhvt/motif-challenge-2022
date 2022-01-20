# Motif Technical Challenge

In our flagship product, Fabric, we use widgets to allow putting together highly customisable web pages. Your task is to develop a simple Visual Studio Console Application which simulates a vector-based widget package. Your application should support the following drawing objects (widgets):

1. Circle
2. Rectangle
3. Square
4. Textbox

The application should be able to add widgets and print their coordinates with their shape and size.
Coordinates are x and y integer values on an imaginary page.

The size/shape depends on the widget, as follows:
- rectangle – width and height
- square – width
- circle – diameter
- textbox – bounding rectangle (width and height)

NOTE:
- integer units are fine for all dimensions
- for the textbox you only need the text to display, don’t worry about font face /size / alignment, etc. 
- please use a separate .cs file for each class

Your console application should be able to 'print out' the current drawing by printing the key details of each widget (type, location, size/shape) to the console.
You DO NOT need to worry about any input from the user, you can use a hardcoded set of widgets to test the drawing simulator.

## Grading
We will evaluate your exercise on your ability to follow requirements while demonstrating good programming practices, such as: Maintainability, Extensibility, Robustness to changing requirements, Testability and SOLID principles.
