# 3d Movement : week 9
 
![](http://i.imgur.com/wMxKI5Sh.gif)

## Hello and welcome to our mini-Game 3dMovement
* where you can move and jump and crawl and even swap weapons and turn the lights !

## Game link is [right here!](https://aviniv.itch.io/3d-movement) (instructions writen inside)

in this file we will introduce you with our job and how it done:

### Player Movement
we have several scripts for this section:
* [PlayerMovement.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/PlayerMovement.cs) 

here 
* [Jump.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/Jump.cs)

here we addressed the SpaceBar as our go to key for jumping and we put a jump force Serializable field with 300 force for default and when key pressed we added "Vector3.up" to jump force.
* [RotateWithMouse.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/RotateWithMouse.cs)

this script is for mouse Mover which helps our player to tilt his view engle to his choosen view. we just used transform.rotate with every movement of the mouse and serializable field "turnspeed" which helps with sensetivity of mouse movement

###
