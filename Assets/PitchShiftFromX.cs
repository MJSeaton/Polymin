using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PitchShiftFromPositionX : MonoBehaviour
{
    AudioSource auS;
    public int startingPitch = 2;

    // From go home
    public Vector2 playerLocation;
    public Vector2 homeLocation;
    public Vector2 pathToHome;
    bool gameOver = false;
    // End from go home


    // Use this for initialization
    void Start()
    {
        auS = GetComponent<AudioSource>();
        auS.pitch = startingPitch;



        //TODO: GET LOCATION FROM CAMERA


    }

    // Update is called once per frame
    void Update()
    {

        auS.pitch = Camera.main.transform.position.x + 1;
        //print(Camera.main.transform.position.x);


        /*  if (!gameOver)
        {
            UpdateMovement(KeyCode.LeftArrow, new Vector2(-1, 0), 0);
            UpdateMovement(KeyCode.RightArrow, new Vector2(1, 0), 0);
            UpdateMovement(KeyCode.UpArrow, new Vector2(0, 1), .001f);
            UpdateMovement(KeyCode.DownArrow, new Vector2(0, -1), -.001f);
        }
        */

    }
    private void UpdateMovement(KeyCode kc, Vector2 movementVector, float PS)
    {
        /* if (Input.GetKeyDown(kc))
         {
             //print ("key pressed.");
             playerLocation = playerLocation + movementVector;
             auS.pitch += PS;


             // print ("Location X:  " + playerLocation.x);
             // print ("Location Y:  " + playerLocation.y);
             // print ("Location Z:  " + playerLocation.z);

     */
    }
}


