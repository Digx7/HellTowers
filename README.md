
<h6>top</h6>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
<!--[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url] -->

![](banner.png)

<h2></h2>

<h3><u>General Information</u></h3>

|		                   |	                                                        |
|--------------------------|------------------------------------------------------------|
| <b>Genre</b>             | Tower Defense                                              |
| <b>Number of Players</b> | Single-Player                                              | 
| <b>Game Elements</b>     | - Resource Management                                        |
|                          | - Problem Solving                                            |
|                          | - Crisis Management                                          |

<h2></h2>

<h3><u>The Team</h3></u>

|               |                 |                   |                  |
|---------------|-----------------|-------------------|------------------| 
|<b>Lead</b>    | <b>Art Team</b> | <b>Audio Team</b> | <b>Programming Team</b> | 
|name : @handle | name : @handle  | name : @handle    | name : @handle   | 
|               | name : @handle  | name : @handle    | name : @handle   | 
|               | name : @handle  | name : @handle    | name : @handle   | 
|               | name : @handle  | name : @handle    | name : @handle   | 



<h2></h2>

[Back to top ^](#top)

<h2></h2>

<h3><u> Technical Specs</h3></u>  

|		                   |	                                                                       |
|--------------------------|---------------------------------------------------------------------------|
| <b>Engine</b>            | Unity 2021.1.20f1
| <b>Platform</b>          | [Itch.io](https://itch.io/)                                               |
| <b>Language</b>          | C#                                                                        |
| <b>Device</b>            | PC                                                                        |
| <b>Resolution</b>        |                                                                           |
| <b>Technical Form</b>    | 3D - game enviroment                                                      |
|                          | 2D - game interface                                                       |
| <b>View</b>              | [3/4 View](https://tvtropes.org/pmwiki/pmwiki.php/Main/ThreeQuartersView) |
|                          | [2.5D](https://tvtropes.org/pmwiki/pmwiki.php/Main/TwoAndAHalfD)          |
| <b>Control</b>           | Gamepad                                                                   |
|                          | Mouse/Keyboard (for debugging)                                            |
  
<h2></h2>

[Back to top ^](#top)

  <h2></h2>

<h3><u>Game Play</h3></u>

**Synopsis:**

[comment]:<> (Start of Entry Body)

  >The Player wakes up on a blank map next to their powered down S.O.S. beacon.  This beacon is all that will get the player off the planet.  However, the local aliens seem to be drawn by it’s power.  Keep them away by constructing defenses using scrap metal lying around the map. The player can explore this map and set up their defenses. But once they turn on the S.O.S. beacon the aliens will start swarm in.  Coming in waves the player must use all their resources to keep the aliens from destroying them or the beacon. 
  
 #TODO *expand synopsis possible*

[comment]:<> (End of Entry Body)
  
  <h2></h2>

**Game Play Outline**

* Opening the game application
	* Opening the game application
   * The following splash screens should play
      * Digx7 Studios (Logo)
      * Made in Unity (Logo)
   * The start screen should open up
      * Main Theme starts
      * This will have the game title and a ‘Press any button to start’ option
      * Once any button is pressed the main menu opens up
* Game options
   * Main Menu
      * Play game
      * How to Play
      * Credits
      * Quit Game
   * Play game
      * This should fade to black and load up the first level
   * How to play
      * This should be on a single screen with the controls, win condition, and a few tips
      * One option ‘Back’ returns to Main Menu
   * Credits
      * A new screen of scrolling credits listing the following
         * All project team members by their preferred name and role
         * All paying VGDC members under a ‘Backers’ section
      * One option ‘Back’ returns to Main Menu
   * Quit Game
      * One text prompt asking the user “Are you sure you want to quit?”
      * One option ‘no’ returns to the Main Menu
      * One option ‘yes’ closes the application
* Story synopsis
   * After a botched expedition and hasty retreat for the hostile planet, the engineer (player) has been left behind.  With few resources remaining they found a working S.O.S. beacon and turned it on.  Hoping help would arrive eventually.  In the meantime, they need to use all remaining resources to keep the angry aliens from destroying the beacon, or themselves.  After all, help is on the way, right?
* Modes
   * Arcade (The default we will shoot for, all other modes can be seen as stretch goals)
      * The player must survive for 8 minutes until a rescue shuttle arrives
         * In this time an endless number of ever-increasing enemy waves will keep coming in
      * The player will be scored at the end on the following (stretch goal)
         * Number of enemies destroyed
         * Remaining health of S.O.S. beacon
         * Remaining player health
         * Resources used (the fewer the better)
   * Campaign (stretch goal)
      * A series of levels that the player can unlock, playthrough, and has a simple narrative woven throughout
   * Survival (stretch goal)
      * An endless game mode where the player can see how long they can survive
      * The player is scored based on the amount of time they lasted
* Game elements
   * Player
      * The engineer
      * Will be controlled around the map using WASD or Left stick (gamepad)
      * Can interact with any and all defenses (Leveling them up or repairing them)
         * The player must get right up to the defense (or very close) to interact with them
      * Has a fixed amount of health that can be decreased by the following
         * Getting hit/ touched by an alien
         * Getting hit by a projectile from their own defenses
      * The player loses the game if they run out of health
   * Defenses
      * What the player can build to keep out and stop the aliens
      * Current types of defenses
         * Wall
            * A simple wall capable of blocking aliens and their projectiles
            * They have set health and will enter a broken state if they run out of health
               * Broken walls will not stop aliens forward progress or their projectiles but can be repaired by the player (if they have the resources)
            * They lose health by being hit by an aliens projectile or melee attack
            * Aliens will only melee attack a wall if it is in their direct path and they are touching it
         * Turret
            * Auto targets aliens that are within its detection radius
            * Shoots rapid-fire bullets
            * Will only target one alien at a time
            * Will shoot regardless of whether the player or another defense is in the way
               * Hitting a player or other defense will cause it to lose health
            * Has a set amount of heath that can be depleted by getting hit by an aliens projectile, melee attack, or another defense
            * In its broken state, it will not fire at anything, but it can be repaired by the player (if they have the resources)
         * Land mine
            * Once the player builds one it takes 1 second to arm
            * Once armed it will detonate if any aliens or the player walks over top of it (or close enough)
            * When it detonates it damages everything in its set radius (Aliens, Players, and Defenses)
            * Land mines have no health and can not be damaged by anything
            * Land mines have no broken state and do not need to be repaired 
   * Aliens
      * Will spawn from outside the map and walk toward the S.O.S. beacon
      * All aliens have a melee attack and will use it on anything in their path (Wall’s, defenses, players, or the S.O.S. beacon) 
         * Once their path is unobstructed they will continue moving
      * Some aliens have a projectile attack that they will fire out at set intervals
      * All aliens will have health that can be depleted by any of the player’s defenses
      * If an aliens health reaches 0 it will die and disappear 
   * Map
      * The map will be a one-screen top-down desert environment
      * Enemies will spawn from off-screen and head toward the S.O.S. Beacon
      * The player character can move around the map but not off of the map
      * The player can only place defenses on the map
      * Resources will occasionally spawn on the map
      * The environment will be mostly flat with a few rocks forming walls and barriers (whether this is purely cosmetic or affects gameplay can be determined later)
* Game levels
   * We will focus on one map for the MVP
   * Any other maps will be variations on the one map
   * [See Map section above]
* Player’s controls
   * Action …………………… Keyboard / GamePad 
   * Move the Engineer …… WASD / Left Stick
   * Interact …………………. Space / South Face Button
   * Build Mode (Hold) ……… Left Shift / Left Bumper Button
* Winning
   * Survive for 8 minutes (in Arcade mode)
   * [See Modes for other win conditions]
* Losing
   * The Player dies (takes enough damage to reach zero)
   * The S.O.S. beacon gets destroyed by aliens
* End
   * We show the player their score
   * The player can then replay the level as many times as they want
   * They can also quit the game
* Why is all this fun?
   * It is fun because it is a rapid resource management challenge
   * The player must figure out how to make the resources they have work on the fly
   * The player feels like they have just a little to much to juggle but that they might be able to do it


<h2></h2>

**Core Design Pillars**  : 
* *Navigating Chaos*  
* Defenses that can harm or hinder both the player and enemies
* Rapid resource management

<h2></h2>

[Back to top ^](#top)

<h2></h2>

<h3><u>Design Document</h3></u>
<!--
>This document describes how GameObjects behave, how they’re controlled and their properties. This is often referred to as
the “mechanics” of the game. This documentation is primarily concerned with
the game itself. This part of the document is meant to be modular, meaning you could have several different Game Design Documents attached to the Concept Document.
-->
<h2></h2>

<b>Design Guidelines</b>
<!--
>This is an important statement about any creative restrictions that need to be considered and includes brief statements
about the general (i.e., overall) goal of the design.
-->

While the overall inspiration for the game is HellDivers, we are not aiming for the same art style as HellDivers. 

**Art influences:**
* Borderlands
* Star Wars
* Rugged Gundam anime style

**Music influences:**
* #TODO

**Designs:**
* 3D Models
	* The Engineer
	* The Defenses
	* The Aliens
	* The Map
    * 2D Art Assets
    * UI elements
    * Status effects (Broken, upgraded)

<h2></h2>

<!--
<b>Game Design Definitions</b>

>This section established the definition of the game play. Definitions should include how a player wins, loses, transitions
between levels, and the main focus of the gameplay.

[comment]:<> (Start of Entry Body)

#TODO

[comment]:<> (End of Entry Body)

<h2></h2>

<b>Game Flowchart</b>

>The game flowchart provides a visual of how the different game elements and their properties interact. Game flowcharts
should represent Objects, Properties, and Actions present in the game. Each of these items should have a number reference
to where they exist within the game mechanics document.

- Menu  
- Synopsis  
- Game Play  
- Player Control  
- Game Over (Winning and Losing  

[comment]:<> (Start of Entry Body)

#TODO

[comment]:<> (End of Entry Body)

-->

<b>Player Definitions</b>

[comment]:<> (Start of Entry Body)
* Health: 
	* the amount of damage that the player can take before they die and lose the game
* Resources: 
	* how many resources they have collected from around the map.  
	* These are spent to build, upgrade, and repair defenses around the map
* Build mode: 
	* by holding a set button all player’s movement stops and they will enter build mode.  
	* While in this mode a new UI menu appears in the corner of the screen showing the combos for the defenses the player can make.  
		* If the player inputs the right combo well the menu is open they will build the new defense where they stand. 

[comment]:<> (End of Entry Body)

<!--
<h2></h2>

<b>Player Properties</b>

>Each property should mention a feedback as a result of the property changing.

[comment]:<> (Start of Entry Body)

#TODO

[comment]:<> (End of Entry Body)

-->

<h2></h2>

<b>Player Rewards (power-ups and pick-ups)</b>

<!-- >Make a list of all objects that affect the player in a positive way (e.g., health replenished) -->

[comment]:<> (Start of Entry Body)

* Resources: 
	* Piles of scrap metal that the player can interact with to gain one resource.  
	* They can then spend those on 
		* building
		* upgrading
		* repairing defenses

[comment]:<> (End of Entry Body)

<h2></h2>

<b>User Interface (UI)</b>

<!-- >This is where you’ll include a description of the user’s control of the game. Think about which buttons on a device would be
best suited for the game. Consider what the worst layout is, then ask yourself if your UI is it still playable. A visual
representation can be added where you relate the physical controls to the actions in the game. When designing the UI, it may
be valuable to research quality control and user interface (UI) design information. -->

[comment]:<> (Start of Entry Body)

* Player Health: 
	* always on screen 
	* displays the players remaining health
* Resource: 
	* always on screen
	* shows how many resources the player currently has
* Build Mode: 
	* Only shows up when the player enters build mode
	* shows: 
		* what the player can currently build
		* the resource cost
		* the combos needed to activate them
* Upgrade screen: 
	* Only shows up when the player interacts with a non-destroyed defense
	* shows upgrade cost and combo needed for the given Defense
* Repair screen: 
	* Only shows up when the player interacts with a destroyed defense  
	* shows the repair cost, and combo needed for the Defense

[comment]:<> (End of Entry Body)

<h2></h2>

[Back to top ^](#top)

<h2></h2>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[contributors-shield]: https://img.shields.io/github/contributors/Digx7/HellTowers.svg?style=for-the-badge
[contributors-url]: https://github.com/Digx7/HellTowers/graphs/contributors

[forks-shield]: https://img.shields.io/github/forks/Digx7/HellTowers.svg?style=for-the-badge
[forks-url]: https://github.com/Digx7/HellTowers/network/members

[stars-shield]: https://img.shields.io/github/stars/Digx7/HellTowers.svg?style=for-the-badge
[stars-url]: https://github.com/Digx7/HellTowers/stargazers

[issues-shield]: https://img.shields.io/github/issues/Digx7/HellTowers.svg?style=for-the-badge
[issues-url]: https://github.com/Digx7/HellTowers/issues

<!-- [license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: -->

<!-- [linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew -->

[product-screenshot]: images/screenshot.png