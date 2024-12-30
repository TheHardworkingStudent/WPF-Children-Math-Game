# Kids Math Game
![Screenshot 2024-12-30 151706](https://github.com/user-attachments/assets/c4ab5d87-5ec9-48ea-b2f2-9122408eecb1)
![Screenshot 2024-12-30 151913](https://github.com/user-attachments/assets/c3b6cb9c-775f-4c7c-b43d-229362f80bea)
![Screenshot 2024-12-30 151924](https://github.com/user-attachments/assets/52b2a46c-9841-4ac4-a5d9-7e0276548edd)
## Description

The Kids Math Game is a themed educational game for young children, developed using WPF. It provides an engaging way to practice basic arithmetic (addition, subtraction, multiplication, and division) while tracking performance and progress. The game includes visuals, sounds, and a user-friendly interface, making learning math fun for kids aged 3 to 10.

The game consists of three main windows:

    Main Menu Window: Allows users to input their name, age, and select the game type.
    Game Window: Displays math questions and tracks the game progress.
    Final Score Window: Summarizes the user's performance after completing the game.

Features
Main Menu Window

    User Input:
        Collects the player's name and age.
        Validates input:
            Name must not be blank.
            Age must be a number between 3 and 10.
            A game type must be selected.
        Displays red error labels for invalid input.
    Game Type Selection:
        Offers four options via radio buttons: Add, Subtract, Multiply, Divide.
    Begin Game:
        Starts the game when valid information is provided.

Game Window

    Randomized Questions:
        Generates 10 random math questions based on the selected game type.
        Ensures questions are appropriate for children:
            No negative results for subtraction.
            Only whole-number results for division.
    Game Timer:
        Displays elapsed time during the game.
        Starts when the game begins and stops when all questions are answered.
    Question and Answer Handling:
        Displays one question at a time.
        Allows players to submit answers via a "Submit" button or the Enter key.
        Provides feedback on whether the answer is correct.
    Cancel Game Option:
        Allows players to return to the main menu at any point.
    Child-Friendly Theme:
        Includes fun visuals and sounds based on the chosen theme (e.g., Star Wars, sports).

Final Score Window

    Performance Summary:
        Displays the user's name, age, number of correct/incorrect answers, and the time taken to complete the game.
    Replay Option:
        Allows users to return to the main menu to start a new game.

Class Design
User Class

    Stores user information:
        Name
        Age

Game Class

    Handles game logic:
        Generates random questions based on the selected game type.
        Validates answers and tracks correctness.
        Ensures child-appropriate question generation (e.g., no negative or fractional results).

How to Play

    Start a Game:
        Enter your name and age in the main menu window.
        Select a game type (Add, Subtract, Multiply, Divide) using the radio buttons.
        Click "Begin Game" to start.

    Answer Questions:
        Solve each question displayed in the game window.
        Submit your answer using the "Submit" button or the Enter key.
        Receive feedback on your answer before moving to the next question.

    Track Progress:
        Observe the timer and question feedback during the game.

    View Results:
        After all questions are answered, view your final score, including the number of correct and incorrect answers and the time taken.

    Play Again:
        Close the final score window to return to the main menu and start a new game.

Thematic Features

    Visuals: Fun, themed background images and buttons.
    Sounds: Play .wav files for correct answers or game events (e.g., cheering crowd or themed sound effects).

Requirements

    Environment: WPF application
    Development Tools: Visual Studio
    Languages and Frameworks: C# and .NET Framework/Core

Error Handling

    Validation:
        Ensures the player's name and age are valid before starting the game.
    Exception Handling:
        All methods include exception handling to prevent crashes and provide meaningful feedback to the user.

Future Improvements

    Expand the question pool with more difficulty levels.
    Add more themes for customization.
    Introduce multiplayer or leaderboard functionality.
