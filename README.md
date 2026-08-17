# Recursive Number Reducer

A small **C# .NET console application** that demonstrates recursion by repeatedly applying deterministic reduction rules until an integer reaches `1`.

<p>
  <img src="https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/Recursion-Practice-238636?style=flat-square" alt="Recursion" />
  <img src="https://img.shields.io/badge/Status-Complete-238636?style=flat-square" alt="Project status: Complete" />
</p>

## Overview

Recursive Number Reducer accepts an integer, prints each recursive step, counts the number of recursive calls, and stops when the value reaches the base case of `1`.

The project is intentionally compact so the recursive control flow is easy to inspect. Each positive-number rule produces a smaller value, preventing cycles and guaranteeing progress toward termination.

## Reduction Rules

The program checks the current value in this order:

| Condition | Action |
| --- | --- |
| Value is `1` | Stop recursion |
| Value is `0` | Treat as `1` |
| Value is negative | Convert to its absolute value |
| Divisible by `4` | Divide by `4` |
| Divisible by `3` | Divide by `3` |
| Divisible by `5` | Divide by `5` |
| Even | Divide by `2` |
| Otherwise | Subtract `1` |

For every positive value greater than `1`, the next recursive value is strictly smaller than the current value.

## Features

- Recursive integer reduction
- Explicit base cases
- Input validation
- Safe handling of negative values and zero
- Recursive-call counter
- Step-by-step console trace
- Deterministic branching rules
- Guaranteed termination for accepted input

## Example

For an input such as `25`, the application follows this path:

```text
Call 1: 25
  Divisible by 5 -> divide by 5
Call 2: 5
  Divisible by 5 -> divide by 5
Call 3: 1

Final value: 1
Recursive calls: 3
```

A negative value is first normalized before the reduction rules continue.

## Why the Algorithm Terminates

The recursive method has direct base cases for `0` and `1`.

For any positive integer greater than `1`:

- Division by `2`, `3`, `4`, or `5` produces a smaller positive integer.
- An odd value that matches none of the divisibility rules is reduced by `1`.

Because every recursive step moves a positive input closer to `1`, the method cannot enter a repeating cycle.

## Technology

| Area | Technology |
| --- | --- |
| Language | C# |
| Runtime | .NET 10 |
| Interface | Console |
| Primary Concept | Recursion |

## Project Structure

```text
CountToOneRecursion/
├── CountToOneRecursion/
│   ├── Program.cs
│   └── CountToOneRecursion.csproj
└── CountToOneRecursion.slnx
```

## Running the Project

### Requirements

- .NET 10 SDK, or
- Visual Studio with .NET development support

Clone the repository:

```bash
git clone https://github.com/IPFizzy/CountToOneRecursion.git
cd CountToOneRecursion
```

Run from the repository root:

```bash
dotnet run --project CountToOneRecursion/CountToOneRecursion.csproj
```

Or open `CountToOneRecursion.slnx` in Visual Studio and run the project.

## Practice Project Context

This repository is preserved as a completed recursion exercise. It demonstrates base cases, recursive calls, branching logic, input normalization, termination reasoning, and simple instrumentation through a recursive-call counter.

## Recommended Repository Name

For a public portfolio, **`RecursiveNumberReducer`** is clearer than `CountToOneRecursion` because it describes what the program does rather than only naming the programming technique it practices.

The internal project and solution names can remain unchanged after renaming the GitHub repository.

## Author

**Keon Bushman**  
Software Development Student & IT Professional  
[GitHub Profile](https://github.com/IPFizzy)
