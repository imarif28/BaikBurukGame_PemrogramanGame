# Object Sorting Game

## Project Description
This project implements an interactive object sorting game using Unity Engine. The game challenges players to categorize human attitudes into correct categories (Bad Attitude and Good Attitude) within a time-limited environment. The project was developed as part of the Game Programming course practicum.

## Features
- Interactive attitude sorting gameplay with dynamic object spawning
- Two distinct attitude categories: Bad Attitude and Good Attitude
- Real-time scoring system with positive and negative point mechanics
- Multiple game scenes including main menu, gameplay, team credits, and game over
- Audio feedback system for correct and incorrect attitude placements
- Automatic game progression with score-based win conditions
- Team member showcase with interactive navigation

## Technologies Used
- **Game Engine:** Unity
- **Programming Language:** C#
- **Development Environment:** Unity Editor
- **Asset Design:** Corel Draw
- **Platform:** PC/Desktop

## How the Program Works

### Main Game Mechanics
1. **Object Spawning System:**
   - Random attitude objects spawn at 1.2-second intervals
   - Attitudes fall from the top of the screen toward collection areas

2. **Sorting Logic:**
   - Players drag attitudes to appropriate category cages
   - Correct placements award 25 points
   - Incorrect placements deduct 5 points
   - Audio feedback confirms player actions

3. **Win/Lose Conditions:**
   - Game ends when score reaches 300 points (win condition)
   - Game ends when attitudes reach the bottom boundary (lose condition)

### Scene Structure
1. **Main Menu Scene:**
   - Play button to start gameplay
   - Team button to view developer credits
   - Exit button to quit application

2. **Gameplay Scene:**
   - Two category cages for attitude sorting
   - Dynamic score display
   - Background music and sound effects
   - Collision detection system

3. **Team Credits Scene:**
   - Interactive team member showcase
   - Horizontal camera movement between profiles
   - Individual member information display

4. **Game Over Scene:**
   - Restart game functionality
   - Return to main menu option
   - Final score display

## Core Scripts and Functionality

### Scene Management
- Handles transitions between different game scenes
- Implements button click events for navigation
- Manages game state persistence

### Object Detection System
- Detects attitude type using collision detection
- Validates correct category placement
- Updates score based on sorting accuracy
- Triggers appropriate audio feedback

### Audio Management
- Plays success sounds for correct placements
- Plays error sounds for incorrect placements
- Manages background music across scenes

### Game Control System
- Monitors game ending conditions
- Handles keyboard input for scene navigation
- Manages camera movement in credits scene

## Game Controls
- **Mouse:** Drag and drop attitudes to category cages
- **Enter:** Confirm selection or return to main menu
- **ESC:** Exit game or return to previous scene
- **Arrow Keys:** Navigate team member profiles in credits scene

## Program Output
1. **Main Menu:**
   - Displays game title and navigation options
   - Background music and visual interface

2. **Gameplay:**
   - Real-time attitude spawning and sorting
   - Live score updates and audio feedback
   - Dynamic visual elements

3. **Win/Lose Screen:**
   - Final score display
   - Options to restart or return to menu

4. **Credits Screen:**
   - Team member profiles with photos and roles
   - Interactive navigation between members

## Installation and Usage
1. **Setup:**
   - Open Unity Hub and import the project
   - Ensure all required assets are properly imported
   - Configure build settings for target platform

2. **Asset Organization:**
   - Images folder: Contains all game sprites and backgrounds
   - Audio folder: Contains sound effects and background music
   - Scripts folder: Contains all C# game logic files
   - Prefabs folder: Contains reusable game objects
   - Scenes folder: Contains all game scenes

3. **Build and Run:**
   - Select target platform in Build Settings
   - Build the project or run directly in Unity Editor
   - Follow on-screen instructions for gameplay

## Development Team
- **Akasha Bin Ali** - Student ID: 4.33.22.0.01
- **Aufa Bima Ngahada** - Student ID: 4.33.22.0.03
- **Bayu Tri Prayitno** - Student ID: 4.33.22.0.04
- **Ilham Muhammad Arif** - Student ID: 4.33.22.0.10
- **Maulana Bintang C.M** - Student ID: 4.33.22.0.15

**Course:** Game Programming Practicum  
**Department:** Informatics Engineering  
**Faculty:** Electrical Engineering  
**Institution:** Politeknik Negeri Semarang  
**Year:** 2024
