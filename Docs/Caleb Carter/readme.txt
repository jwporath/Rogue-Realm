The CDG Enemy Prefab is a well rounded simple platform with lots of customizability and potential for modification. The purpose of which is to serve as a quick addition to any beginners game that would require some sort of entity that would seek out the player. This of course, can be refitted for any number of game objects such as power ups that move to the player or something else! 


        The way that it works is very simple. Upon spawning into the scene, it will immediately acquire any object in the same scene labeled as “Player” (changeable) and will want to seek this game object out. However, you can modify the minimum distance that this object must be within before it begins to move by changing the Enemy Aggression field in the components.


        There are plenty of other values that can be changed to fit your needs as well! Some prototypes have already been made in the createEnemy() function within the enemyBehavior.cs script. This prefab is modular, changeable, and ready to be inserted into any 2D game you could need!