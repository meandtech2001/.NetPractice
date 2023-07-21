@echo off

csc factorial.cs permutation.cs combination.cs -target:library -out:Math.dll

csc program1.cs input.cs -r:Math.dll -out:Calculator.exe