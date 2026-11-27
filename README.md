# MG7
## Devlog
### Question Prompt Answers

In about a paragraph, explain your TreeOfBirds script. Mention both how an array is 
used in this script and how vectors are used. 
Write about a paragraph. 

TreeOfBirds is a class attached to the Tree GameObject in the Hierarchy, and controls the birds that pop out from it. It also makes the birds pop out when the player is at a certain distance. This is done by creating an array that stores every bird in the tree. However, this array doesn't take into account the starting bird that is also visible. This is because only the GameObjects that have the Bird component added are put into the array. The Bird script is what dictates how they pop up, and how fast. The array runs through every bird in the array by using _bird.Length, and that way there doesn't need to be a set amount put into the for loop. This loop is run every frame by Update(), and checks for the distance between the player and the tree using Vector3.Distance. This distance checks both the tree's position and the player's. It checks for when this distance becomes less than the interactionDistance float, which I set up as editable in the inspector to about 6 units. When this happens, the birds GameObjects are made active, and rise up. They are not set active by default because this would make them pop out immediately.


## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
