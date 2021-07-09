# Platformer Videogame
<p align="center><img src="readme_images/platformer_level2.gif"</p>
![](readme_images/platformer_level2.gif)

### Attributions
The realization of this project was possible, thanks to the following resources: 
* Kenney: https://kenney.nl/ 
* Oculus Audio Pack: https://developer.oculus.com/downloads/package/oculus-audio-pack-1/
* Mindful Audio: https://mindful-audio.com/
* “Wallpaper”, “Cheery Monday” Kevin MacLeod (incompetech.com)  
  Licensed under Creative Commons: By Attribution 3.0  
  http://creativecommons.org/licenses/by/3.0/

## Learning Objectives :bulb:
* At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

### General
* What is an Audio Source
* What is an Audio Listener
* What is an Audio Filter
* What is an Audio Mixer
* What are snapshots
* What is a channel
* What is attenuation
* What is ducking
* How to control audio elements with scripts
## Requirements :white_check_mark:
### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x08-unity-audio to your repo
* Scenes and project assets such as Scripts must be organized as described in the tasks
* In your scripts, all your public classes and their members should have XML documentation tags
* In your scripts, all your private classes and members should be documented but without XML documentation tags
## Tasks
### Mandatory :page_with_curl:
- [x] **[0. Sound check, one two](./Assets/Scenes/MainMenu.unity)** - Duplicate 0x07-unity-animation and rename it 0x08-unity-audio
- [x] **[1. Click](./Assets/Scenes/MainMenu.unity)** - In the MainMenu scene, make button-click.ogg a child object of MenuSFX
- [x] **[2. The sound of music](./Assets/Scenes/MainMenu.unity)** - In the MainMenu scene, add Wallpaper as background music. It should start playing when the scene loads and stop when the player loads a different scene. The music should also loop
- [x] **[3. Tap-tap-tap](./Assets/Scenes/Level01.unity)** - In the Level01 scene, add footstep sound clips to the Player so that when the Player is running, the sound plays in a loop until the Player stops running
- [x] **[4. Thump](./Assets/Scenes/Level01.unity)** - In the Level01 scene, add a landing sound clip to play when the player hits the ground from falling off the platforms and restarting. If the player lands on a grassy platform, footsteps_landing_grass should play. If the player lands on a stone platform, footsteps_landing_rock should play
- [x] **[5. Cheery Monday](./Assets/Scenes/Level01.unity)** - In the Level01 scene, add CheeryMonday as background music. It should start playing when the level loads and stop when the player touches the WinFlag or returns to the MainMenu scene. The player sound effects should still play while the BGM plays and it should loop
- [x] **[6. Victory fanfare](./Assets/Scenes/Level01.unity)** - In the Level01 scene, add VictoryPiano as a win sting that plays once when the Player touches the WinFlag. The background music CheeryMonday should stop playing when VictoryPiano starts
- [x] **[7. Ambience](./Assets/Scenes/Level01.unity)** - Add ambient audio to at least one tree (birds) or at least one rock/grass/flower (crickets). This audio should be quiet or muted from a distance and grow louder as the player gets closer to the GameObject
- [x] **[8. Shhh](./Assets/Scenes/Level01.unity)** - Using Snapshots, create functionality so that when the Player pauses the game, the BGM should become muffled. (Check the playable demo to hear the desired effect.) When the player returns to the game, the sound should return to its original settings
- [x] **[9. Volume control #0](./Assets/Scenes/Options.unity)** - In the Options scene, make sure the OptionsButton and ExitButton prefabs are updated to have the button-rollover and button-click sound effect events applied
- [x] **[10. Volume control #1](./Assets/Scenes/Options.unity)** - In the Options scene and OptionsMenu.cs, script the SFXSlider so that when the slider’s value is changed by dragging the slider handle, the SFX audio decreases and increases from fully muted to max volume. These values should persist through all levels and when the game is quit and re-opened
- [x] **[11. Sound system gonna bring me back up](./Assets/Scenes/Level02.unity)** - Add music and sound effects to scenes Level02 and Level03, using the same Audio Mixer you created for Level01. Make sure your player sounds, options, etc. work in these scenes as well
- [x] **[12. We're done!](./Assets/Builds/*)** - Scenes in Build
## Author :pencil:
**Santiago Peña Mosquera** - twitter [@santiagopemo](https://twitter.com/Santiag11470161) - LinkedIn [Santiago Peña Mosquera](https://www.linkedin.com/in/santiago-pe%C3%B1a-mosquera-abaa20196/)
