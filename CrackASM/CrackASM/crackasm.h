/*
	crackasm.h
	Tristan Van Cise
	CS 301 Assembly Language Programming
	09/25/2017
	Header file for DLL CrackASM functions.
	Functions are prototyped in c++ but are defined
	using inline assembly code denoted by __asm in crackasm.cpp
*/

#ifndef DLL_CRACKASM_H_INCLUDED
#define DLL_CRACKASM_H_INCLUDED

extern "C" __declspec(dllexport) int __stdcall Addition(int a, int b);
extern "C" __declspec(dllexport) int __stdcall Subtraction(int a, int b);
extern "C" __declspec(dllexport) int __stdcall Multiplication(int a, int b);
extern "C" __declspec(dllexport) int __stdcall Division(int a, int b);


#endif // !DLL_CRACKASM_H_INCLUDED
