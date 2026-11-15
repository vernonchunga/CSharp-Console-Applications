# C# Console Applications

A collection of two beginner-friendly C# console applications developed to demonstrate fundamental programming concepts, object-oriented programming, input validation, arrays, methods, and automated testing.

## Applications

### 1. Number Guessing Game

A console-based guessing game where the computer generates a random number between 1 and 100.

**Features:**
- Random number generation.
- Limited attempts (5 guesses per game).
- Feedback indicating whether a guess is too high or too low.
- Input validation for invalid entries.
- Option to play multiple rounds.

### 2. Student Grade Tracker

A console-based application for managing student scores and calculating academic performance statistics.

**Features:**
- Enter student names and scores.
- Store student information using arrays.
- Automatically assign grades based on scores.
- Calculate the class average.
- Identify the highest and lowest scores.
- Display individual student results.
- Menu-driven navigation that continues until the user exits.

**Grading Scale:**

| Score Range | Grade |
|---|---|
| 80–100 | A |
| 70–79 | B |
| 60–69 | C |
| 50–59 | D |
| 0–49 | F |

## Technologies Used

- C#
- .NET
- Visual Studio
- xUnit
- Git and GitHub

## Project Structure

```text
CSharp-Console-Applications/
│
├── GuessingGame/
│   ├── Program.cs
│   └── Game.cs
│
├── GradeTracker/
│   ├── Program.cs
│   └── GradeManager.cs
│
├── ConsoleApplications.Tests/
│   ├── GuessingGameTests.cs
│   └── GradeManagerTests.cs
│
└── README.md
```

## Getting Started

### Prerequisites

- Windows, Linux, or macOS.
- .NET SDK compatible with the project's target framework.
- Visual Studio or another C# development environment.
- Git (optional, for cloning the repository).

### Installation

Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/CSharp-Console-Applications.git
```

Navigate into the project directory:

```bash
cd CSharp-Console-Applications
```

### Running the Number Guessing Game

```bash
dotnet run --project GuessingGame/GuessingGame.csproj
```

### Running the Student Grade Tracker

```bash
dotnet run --project GradeTracker/GradeTracker.csproj
```

## Automated Testing

The project uses xUnit for automated unit testing.

To execute all tests, run:

```bash
dotnet test
```

The tests cover:

- Random number generation within the expected range.
- Guessing game feedback for correct, higher, and lower guesses.
- Grade assignment for different score ranges.
- Average score calculation.
- Highest and lowest score identification.
- Handling empty score arrays.

**Current test results:** 16 passing test cases.

## Architecture and Design

The applications follow a simple separation-of-concerns approach.

### Number Guessing Game

- `Program.cs` handles application execution and replay functionality.
- `Game.cs` contains the game logic, random number generation, and feedback methods.

### Student Grade Tracker

- `Program.cs` manages the application menu and user navigation.
- `GradeManager.cs` handles student records, grade assignment, and statistical calculations.

### Testing

The `ConsoleApplications.Tests` project contains automated unit tests for both applications.

Business logic is separated into methods to improve readability, maintainability, and testability.

## Assumptions

1. The guessing game generates numbers between 1 and 100.
2. Each guessing round allows five valid attempts.
3. Invalid guesses do not consume an attempt.
4. Student scores must be between 0 and 100.
5. Each student must have a non-empty name.
6. The grading scale follows the ranges documented above.
7. Student records are stored in arrays during application execution.

## Known Limitations

- Student records are stored in memory and are not permanently saved.
- Entering a new set of student records replaces the previous records.
- The guessing game does not maintain a persistent history of previous rounds.
- The grade tracker does not use a database or external storage system.
- Automated tests focus primarily on application business logic rather than interactive console behaviour.

## Future Improvements

- Add persistent student record storage.
- Allow editing and deleting student records.
- Add student performance reports.
- Introduce difficulty levels to the guessing game.
- Track guessing game statistics.
- Add automated integration tests for console interactions.

## Author

Developed as a C# programming exercise to demonstrate fundamental programming concepts and software development practices.