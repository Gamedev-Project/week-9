# 3d Movement : week 9

![](http://i.imgur.com/wMxKI5Sh.gif)
### Full gif for essence of the game is [here](https://imgur.com/wMxKI5S)

## Hello and welcome to our mini-Game 3dMovement
* where you can move and jump and crawl and even swap weapons and turn the lights !

## Game link is [right here!](https://aviniv.itch.io/3d-movement) (instructions writen inside)

in this file we will introduce you with our job and how it done:

### Player Movement
we have several scripts for this section:
* [PlayerMovement.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/PlayerMovement.cs) 

here we have a normal WASD movement with functions for running and crawling.
for the crawling we check that our charecter that initialized with 1f for height is still in that size, if not we moving to an else situation that checks if crawl button was pressed and shrink our charechter in half so it can crawl
we also have several cases for if the running key was pressed and a normal "transform.position" helps us move the charchter more quickly 
the tilt option also is in her with Q and E key pressing which helps us with viewing angles outside of the mouse scope
* [Jump.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/Jump.cs)

here we addressed the SpaceBar as our go to key for jumping and we put a jump force Serializable field with 300 force for default and when key pressed we added "Vector3.up" to jump force.
* [RotateWithMouse.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/RotateWithMouse.cs)

this script is for mouse Mover which helps our player to tilt his view engle to his choosen view. we just used transform.rotate with every movement of the mouse and serializable field "turnspeed" which helps with sensetivity of mouse movement

###
