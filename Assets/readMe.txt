﻿Rows are organized from left to right, so you can 
'see' what orbs should be connected to each other 
via hierarchy pannel. Row 1 = top row, 2 = row 
below, etc.
    
When creating a new row, please link all transfer points
to all the ones around them. To make a transfer point 
active, use the 'target state' script's 'current status' 
option.
 
When creating a new scene please add it to sceneManager
in the update function, the same way demoscene_1 has
been added. 
 
Please do not place a statsAndDisplay prefab in any scene
other than the main menu. It transfers between all scenes
and startGame makes a temporary one for testing if there
is none currently displayed.
 
Please do not touch the timer script, it is debugged already
for another game.

If you make any major changes or move things around 
please note in here, below, so things don't get lost or 
mixed up. Thanks! -- Tegan    
