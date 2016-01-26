Once you clone the solution from https://github.com/djmaximaldonado/minDisks.git, you can import from your Visual Studio.( Tested using Visual Studio 2015 Community).


All the code is in the main file.
public static int minDrives(int[] used , int[] total ) is the requested method.

The basic idea is filling the biggest drives first until the used space make zero.

Basically, the first step is of the algorithm is to calculate the sum of used space. This variable is named usedSum in the code.
Then the algorithm get the biggest hard drive ( sorting the total array descendently )
and try to "fill" the biggest drive. Then we sustract to the variable usedSum the size of the biggest drive, and sum 1
to the result variable. The next step is to get the second biggest drive ( second in the ordered total array ), and do the same.
The algorithm stops when usedSum is not greater than zero. 

public static int ReadInt32(string value) is an aux function to read an int from console

static void Main(string[] args) has a main menu and you can choose the options run the tests or insert your own information.

The executable file is located in minDisks\bin\Debug\minDisks.exe





