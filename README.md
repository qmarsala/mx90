Solving the mx.com/90 billboard puzzle

{ g⇒8, x⇒2, y⇒3, s⇒5 }	7
{ g⇒16, x⇒3, y⇒7, s⇒8 }	
{ g⇒32, x⇒12, y⇒21, s⇒7 }	
{ g⇒64, x⇒34, y⇒45, s⇒9 }	
{ g⇒128, x⇒81, y⇒100, s⇒14 }	
{ g⇒1024, x⇒32, y⇒920, s⇒42 }

cell values are determined by the previous row (neighborhood - the 3 cells above the current cell, out of bounds are false)

[
    [1, 0, 0, 0, 0, 0, 0, 0],
    [1, 0, 1, 1, 1, 1, 1, 1],
    [1, 1, 0, 0, 0, 0, 0, 1],
    [0, 1, 0, 1, 1, 1, 0, 1],
    [0, 1, 1, 0, 0, 1, 1, 1],
    [0, 0, 1, 0, 0, 0, 0, 1],
    [1, 0, 1, 0, 1, 1, 0, 1],
    [1, 1, 1, 1, 0, 1, 1, 1]
]

cell - value (bool)
row - list of cells
neighborhood - 3 cells above the current cell

grid - size
result - start coordinant, selection of the grid

Mapping of neighborhood pattern (rules) => cell value
ex: 
(1, 0, 1) => 0
(1, 1, 0) => 1