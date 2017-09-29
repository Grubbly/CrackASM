/*
	testMain_CrackASM.cpp
	Tristan Van Cise
	CS301 - Assembly Language Programming
	09/25/2017
	This is a test main, used to check how
	functions prototyped in crackasm.h and 
	defined in crackasm.cpp work.
*/

#include "crackasm.h"

#include <iostream>
using std::cout;
using std::endl;
using std::cin;

#include <string>
using std::string;



int main()
{
	cout << Addition(5, 4) << endl;
	cout << Subtraction(4, 2) << endl;
	cout << Multiplication(4, 2) << endl;
	cout << Division(4, 2) << endl;
	cout << Division(4, 3) << endl;
	cin.get();
}

