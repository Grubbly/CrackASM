#include "crackasm.h"

int __stdcall Addition(int a, int b)
{
	int sum;

	__asm
	{
		mov eax, a //why can I just move the value of a into eax? a isn't a register... does it act like an alias? a=argument passed?
		add eax, b
		mov sum, eax
	}

	return sum;

}

int __stdcall Subtraction(int a, int b)
{
	int difference;

	__asm
	{
		mov eax, a
		sub eax, b
		mov difference, eax;
	}

	return difference;
}

int __stdcall Multiplication(int a, int b)
{
	int product;

	__asm
	{
		mov eax, a
		imul eax, b
		mov product, eax
	}

	return product;
}

int __stdcall Division(int a, int b)
{
	int quotient = 0;

	/*__asm
	{
		mov eax, a
		mov ecx, b
		div eax, ecx
		mov quotient, eax
	}*/

	return quotient;
}
