# ProceduralLevelGenerator
Program in C# that generates a map image of a level and includes the objects and enemies in it.

The main code of the program is in the file maze, where the csCaveGenerator.cs and Program.cs scripts are.

The idea and objective of this project was to use a procedural level generation technique to generate not only the shapes and rooms of different levels but to also add elements to them such as enemies, treasures, doors, keys etc.

In order to make the levels interesting and fun to play I decided to, instead of adding these elements randomly in the map, generate them in strategical places on the map depending on the purpose of the object/enemy. This way the purpose of the algorithm wasn't only to generate a random level, but also to apply some level design principles to make it better and more entertaining.

The algorithm does the following:
1.-Using a variation of Conway's Game of Life algorithm it creates the caves or rooms of the level.

2.- Once the caves are created, it locates each of them in the map and stores them in an array with a flooding algorithm.

3.- The algorithm chooses a random cave and a location in it to spawn the player. The algorithm starts building corridors from this cave by choosing a random direction to build a corridor. If it reaches abother cave, it adds the origin and destination cave to a list of connected caves. Corridors are always built starting from a cave from this list.

4.- Every time it adds a corridor there is a chance that a door is created on it to block it. To make sure that the player can always reach the keys that he/she needs to be able to visit all the rooms,  the algorithm places a key randomly in one of the caves of the "connected caves" list.

5.- To encourage the player to explore the level, the treasures are placed in less visible spots of the level with an algorithm that checks the number of closed neighbours (walls) that a cell has. If the spot has many walls surrounding it, the algorithm will place a treasure on that location.

6.- To make the rewards harder to get and the game more challenging, enemies are spawned in locations close to the treasures. This also adds a risk/reward mechanic to the level design.

7.-Finally, the algorithms adds decorative elements in random locations of the level, but it first makes sure that they don't block the way in any case.

Once the algorithm finishes generatinig the level, the program creates a jpg image with one pixel per cell. Each cell is painted with the colour associated to the object that is placed in that position. This image can be found inside the debug/release folder after we execute the program successfully in visual studio.

The algorithm was coded using C#, and the generation of caves and corridors was based in EvilScience's algorithm to build cave systems.
