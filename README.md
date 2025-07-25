# Rock Paper Scissors Game - Unity

A simple yet modular Rock Paper Scissors game built in Unity, demonstrating key OOP principles, design patterns (Strategy Pattern), and SOLID principles. Includes full UI navigation, sound settings, and persistent preferences.

##  How to Play

1. **Launch the game**.
2. From the **Main Menu**, click `Start Game`.
3. Choose one of:
   - 🪨 Rock
   - 📄 Paper
   - ✂️ Scissors
4. Click the **Shoot** button to see what the computer picks.
5. The game will display the result:
   - Rock beats Scissors
   - Scissors beats Paper
   - Paper beats Rock
6. Click **Replay** to play again.


##  Game Rules

- Rock crushes Scissors  
- Scissors cuts Paper  
- Paper covers Rock


## 🔧 Features

-  **UI System**
  - Main Menu with `Start`, `Settings`, `How to Play`, `About`, `Exit`
  - In-game UI with sprite visuals and result display

-  **Audio Settings**
  - Toggle Background Music (BGM)
  - Volume preferences saved using slider

-  **Customization**
  - Change background color from Settings

-  **OOP + Strategy Pattern**
  - Choices (Rock, Paper, Scissors) use the Strategy Pattern for game logic
  - Controller handles game flow and delegates rule-checking


##  How to Run the Game

### In Unity Editor

1. Open the project in **Unity (2021.3 or newer)**.
2. Open the `MenuScene` and click **Play** in the Editor.
3. From Main Menu, click **Start Game** to play.

### In Standalone Build

1. Go to **File > Build Settings**
2. Add both:
   - `MenuScene`
   - `GameScene`
3. Click **Build and Run**
4. Run the executable and enjoy the game.


##  Developer Info

- **Project Name**: Rock Paper Scissors Game  
- **Developer**: Taiwo Adegboyega  
- **Unity Version**: `2021.3.x` or newer  
- **Programming Language**: C#  
- **Pattern Used**: Strategy Pattern  
- **Principles**: OOP, SOLID


##  Project Structure

```plaintext
Assets/
│
├── Scenes/
│   ├── MenuScene.unity
│   └── GameScene.unity
│
├── Scripts/
│   ├── GameController/
│   │   ├── RPSGameController.cs
│   │   └── IChoiceStrategy.cs
│   ├── Strategies/
│   │   ├── RockStrategy.cs
│   │   ├── PaperStrategy.cs
│   │   └── ScissorsStrategy.cs
│   ├── UI/
│   │   ├── SceneLoader.cs
│   │   └── SettingsManager.cs
│
├── Audio/
│   ├── bgm.mp3
│   └── sfx_click.wav
│
└── Sprites/
    ├── rock.png
    ├── paper.png
    └── scissors.png
 Contributions
Pull requests are welcome! Feel free to open issues for suggestions or bugs.

 License
This project is for educational/demo purposes and is not intended for commercial use.

