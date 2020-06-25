# Plane Bomber Game

The first ever game I built , Unity is the game engine in use. The game has a simple objective of shooting down the plane. The player is a robot that can shoot two missiles at a time.

## The plane 

To make it harder to aim at the plane and shoot it down , I had to borrow the mathematical concepts of **sine** and **cosine** that made it possible for me to make the plane fly around the arena in a circle while moving up & down at a speed that doesn't make it easy for the player to aim and shoot at it.

In simple terms , the plane's objective is to escape the missiles fired from the player directly at it.

## The player

The player can move around the arena to pick up ammo and to try and get the best position to shoot down the plane. The code to generate ammo on the arena is also part of the player's script as the player exists throughout the lifecycle of the game. Two missiles can be shot by the player at a time and two missiles are subtracted from the ammo on every shot. The player can see how much ammo is left by looking at the ammo indicator on the GUI. The camera also moves with the player so the player can always try to look for the planes position.

## The ammo 

The ammo is created at different random places around the arena. The ammo is created only when there are no instances of ammo around the arena to avoid too much ammo.

## The missiles 

When the player shoots , two missiles spawn from the arms of the player robot and continue moving upwards in a forward direction in the hopes of reaching the plane. When the missiles reach the collider of the plane indicatiing that there is a hit , gravity is activated on the plane to simulate the plane crashing down.


 *It is not easy to shoot down the plane.* 

