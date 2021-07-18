# Mars Rover Solution in C#
-----------------------------------------------------------------------------------------------------------------------

# Input:

-> The first line of input is position of the rover, where it consists of the coordinates (x and y ) and  direction it's facing e.g. (4 2 E)
"The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the direction it's facing".
-> The second line is a command_string telling the rover how to explore the planet.
-----------------------------------------------------------------------------------------------------------------------

# Output:
The output for each rover should be its final co-ordinates and heading, but since there is obstacles the rover might face,
so in case if the rover face an obstacle the output will increase the position of the obstacle before heading it and command_string that the rover savely move through.
-----------------------------------------------------------------------------------------------------------------------

***Test case 1***

Test Input:

4 2 E
FLFFFRFLB

Expected Output:

6 4 N

***Test case 2***

Test Input:

1 3 N
FBBLFRLLB

Expected Output:

obtsacle (1, 3) N STOPPED
Put you can savely move through:
BBBLFRLLB
0 1 S