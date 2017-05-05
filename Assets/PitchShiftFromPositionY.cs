using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PitchShiftFromPositionY : MonoBehaviour
{
    AudioSource auS;
    public int startingPitch = 2;

    // From go home
    public Vector2 playerLocation;
    public Vector2 homeLocation;
    public Vector2 pathToHome;
    public float newpitch;
    bool gameOver = false;
    public float heightOffset=1.5f; // note that these were originall heightOffset 1.5 and yScalar 4
    public int yScalar=1;
    // End from go home


    // Use this for initialization
    void Start()
    {
       // yScalar = 0;
       // heightOffset = 1.5f;
        auS = GetComponent<AudioSource>();
        auS.pitch = startingPitch;



        //TODO: GET LOCATION FROM CAMERA


    }

    // Update is called once per frame
    void Update()
    {
        newpitch = (Camera.main.transform.position.y + heightOffset) * yScalar;
        auS.pitch = newpitch;
       // print("Y Pitch output:"+ newpitch);
       // print("Y Position:" + Camera.main.transform.position.y);



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


