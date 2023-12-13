# Tic Tac Toe  FormsApp
This is a simple Tic Tac Toe game implemented in Windows Forms using C#. The game supports different modes, including player vs. computer and player vs. player. The project consists of multiple forms to handle different game modes.


# File Structure
- HomeForm.cs
    - Main Form that allows user to choose between different game modes.

- Play1Form.cs
    - Form for Player vs. Computer mode. Allows the user to enter their name and start the game against the computer.
      
- Play1vCForm.cs
    - Form for the actual gameplay of Player vs. Computer mode. Implements the logic for player moves, computer moves, and checks for a winner.
      
- Play2Form.cs
   - Form for Player vs. Player mode. Allows both players to enter their names and start the game.
     
- Play1v1Form.cs
    - Form for the actual gameplay of Player vs. Player mode. Implements the logic for two players to take turns and checks for a winner.

 
## How to Play
1. HomeForm
      - Run the application.
      - Choose between Player vs. Computer and Player vs. Player modes.
    
2. Play1Form (Player vs. Computer)
      - Enter your name.
      - Click on the "Start" button to begin the game against the computer.
     
3. Play1vCForm (Player vs. Computer Gameplay)
      - The player makes a move by clicking on an available button.
      - The computer responds with its move.
      - The game continues until there's a winner or a draw.

4. Play2Form (Player vs. Player)
      - Enter names for Player 1 and Player 2.
      - Click on the "Start" button to begin the game.

5. Play1v1Form (Player vs. Player Gameplay)
      - Players take turns making moves by clicking on the available buttons.
      - The game continues until there's a winner or a draw.

    
# Additional Features
- Restart Game Button
  - All game forms include a button to restart the game without restarting the application.

- Exit Button
  - All game forms include a button to exit the game or return to the main menu.


# How To Run 
Open the provided C# project in your preferred development environment.
Compile and run the program.
Follow the on-screen prompts to play the game.

Feel free to explore and modify the code to suit your preferences and add additional features to the Tic Tac Toe game.
