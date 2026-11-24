using Unity.VisualScripting;
using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!

// 1a. Be a Component attached to the Tree GameObject. :check:
// 1b. Contain an ARRAY of all of the Sparrow GameObjects in the Scene (except Sparrow_Start), tunable in the inspector. :check:
// 1c. Contain a variable to represent the ‘interaction distance’ of the birds and the player. :check:
// 1d. Every frame, loop through the array of birds. Check to see which birds are within the interaction distance, and set their GameObjects to ACTIVE. :check:

public class TreeOfBirds : MonoBehaviour
{

    [SerializeField] private Bird[] _bird;
   
    [SerializeField] private Transform _player;
    [SerializeField] private float interactionDistance;
     //float dist = Vector3.Distance(Bird.position, transform.position);

    private void Update()
    {
        for (int i = 1; i < _bird.Length; i++)
        {
            Bird bird = _bird[i];
            if (Vector3.Distance(bird.transform.position, _player.position) <= interactionDistance)
            {
                gameObject.SetActive(true);

            }
            

        }
       
    }
    

}