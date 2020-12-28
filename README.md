# 3d Movement : week 9
![](https://i.ibb.co/gjbLty2/OurGame.gif)
![](https://i.imgur.com/KUSAF0h.gif)
### Full gif for essence of the game is [here](https://imgur.com/wMxKI5S)

## Hello and welcome to our mini-Game 3dMovement
* where you can move and jump and crawl and even swap weapons and turn the lights !

## Game link is [right here!](https://aviniv.itch.io/3d-movement) (instructions writen inside)

### we build our world with the help of "Prototyping_Pack_Free" asset from unity Store
in this file we will introduce you with our job and how it done:

### Player Movement
![](https://i.imgur.com/Vhh4IQ7.png)
we have several scripts for this section:
* [PlayerMovement.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/PlayerMovement.cs) 

here we have a normal WASD movement with functions for running and crawling.
for the crawling we check that our character that initialized with 1f for height is still in that size, if not we moving to an else situation that checks if crawl button was pressed and shrink our charechter in half so it can crawl
we also have several cases for if the running key was pressed and a normal "transform.position" helps us move the character more quickly.

the tilt option also is in her with Q and E key pressing which helps us with viewing angles outside of the mouse scope.

there is also a safe line [here](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/PlayerMovement.cs#L54) for when our character going too fast so we ending here movement with a "return;" statement.
* [Jump.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/Jump.cs)

here we addressed the SpaceBar as our go to key for jumping and we put a jump force Serializable field with 300 force for default and when key pressed we added "Vector3.up" to jump force.
* [RotateWithMouse.cs](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/RotateWithMouse.cs)

this script is for mouse Mover which helps our player to tilt his view engle to his choosen view. we just used transform.rotate with every movement of the mouse and serializable field "turnspeed" which helps with sensetivity of mouse movement

### Weapon Switching

In this [script](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/WeaponSwitching.cs) we using the scroolbar button on the mouse and when scrolling occurred we changing the weapon which inserted under Guns in our player and just setting the one the player choose by scrolling to Active.

### Lights On/Off

Here in this [Script](https://github.com/Gamedev-Project/week-9/blob/main/Assets/Scripts/LightsManger.cs) we added Prefabs of lamps and Light object on child.
with a X key press near a lamp it will turn on and off just by setting it Active value to the opposite of what it was beforehand. 

### Prefabs (lamps, weapons, boxes and walls)
![](https://i.imgur.com/1Olkq4K.png)
![](https://i.imgur.com/5mk3fW7.png)
![](https://i.imgur.com/h1ZbDld.png)
![](https://i.imgur.com/zhnRKdY.png)
![](https://i.imgur.com/D3G6X6U.png)
![](https://i.imgur.com/wdR9YXm.png)
