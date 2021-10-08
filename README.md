# logic-engineering
## Requirements
To run this project, Visual Studio, .NET Core and Graphviz are required

## Project description
In this project, propositional logical formulas are being parsed. The input format of the formulas however, have to be in ASCII as can be seen in the figure below.

![proposition_format](https://user-images.githubusercontent.com/60514926/136556363-fb618380-04b1-48cc-8732-e33b3235bc4c.png)

 Propositional formulas are parsed into a binary tree using recursion and after that, the following operations are being performed:
- A truth table is created from the binary tree
- A simplified truth table is created from the truth table
- A DNF formula of the propositional formula is created from the truth table and the simplified truth table
- A NAND formula is created from the binary tree

## Project design
The project is built by using OO design principles as can be seen in the figure below.

![uml](https://user-images.githubusercontent.com/60514926/136556840-f9bde959-2cba-4e3c-a4fe-ca68ccc5d85e.png)
