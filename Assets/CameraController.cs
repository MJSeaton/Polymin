using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
          
                UpdateMovement(KeyCode.LeftArrow, new Vector2(-1, 0), 0);
                UpdateMovement(KeyCode.RightArrow, new Vector2(1, 0), 0);
                UpdateMovement(KeyCode.UpArrow, new Vector2(0, 1), .001f);
                UpdateMovement(KeyCode.DownArrow, new Vector2(0, -1), -.001f);
        UpdateMovement(KeyCode.W, new Vector2(-1, 0), 0);
        UpdateMovement(KeyCode.A, new Vector2(1, 0), 0);
        UpdateMovement(KeyCode.S, new Vector2(0, 1), .001f);
        UpdateMovement(KeyCode.D, new Vector2(0, -1), -.001f);
        UpdateMovement(KeyCode.Space, new Vector2(0, 0), 0);
                UpdateMovement(KeyCode.Alpha0, new Vector2(0, 0), 0);
        UpdateMovement(KeyCode.Alpha9, new Vector2(0, 0), 0);
        UpdateMovement(KeyCode.Alpha1, new Vector2(0, 0), 0);
        UpdateMovement(KeyCode.Alpha2, new Vector2(0, 0), 0);



    }
    private void UpdateMovement(KeyCode kc, Vector2 movementVector, float PS)
    {
        Camera c = GetComponent<Camera>();

        if (Input.GetKeyDown(kc))
         {
            print ("key pressed.");
           // print(kc.ToString());
            if (kc == KeyCode.LeftArrow) {
                c.transform.Translate(-1, 0, 0);
            }
            if (kc == KeyCode.RightArrow)
            {
                c.transform.Translate(1, 0, 0);
            }
            if (kc == KeyCode.UpArrow)
            {
                c.transform.Translate(0, 1, 0);
            }
            if (kc == KeyCode.DownArrow)
            {
                c.transform.Translate(0, -1, 0);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("space pressed!");
                c.transform.Translate(0, 0 , -1);
            }
            if (kc == KeyCode.Alpha2)
            {
                c.transform.Translate(0, 0, 1);
            }
            if (kc == KeyCode.Alpha1)
            {
                c.transform.Translate(0, 0, -1);
            }
            if (kc == KeyCode.Alpha0)
            {
                c.transform.Translate(0, 0, .1f);
            }
            if (kc == KeyCode.Alpha9)
            {
                c.transform.Translate(0, 0, -.1f);
            }
            
            if (kc == KeyCode.A)
            {
                c.transform.Translate(-.1f, 0, 0);
            }
            if (kc == KeyCode.D)
            {
                c.transform.Translate(.1f, 0, 0);
            }
            if (kc == KeyCode.W)
            {
                c.transform.Translate(0, .1f, 0);
            }
            if (kc == KeyCode.S)
            {
                c.transform.Translate(0,-.1f, 0);
            }
            /////
            if(kc == KeyCode.Z)
            {
                c.transform.Translate(0, 0, 1);
            }
            if (kc == KeyCode.X)
            {
                c.transform.Translate(0, 0, -1);
            }
            if (kc == KeyCode.N)
            {
                c.transform.Translate(0, 0, .1f);
            }
            if (kc == KeyCode.M)
            {
                c.transform.Translate(0, 0, -.1f);
            }
            


            // print ("Location X:  " + playerLocation.x);
            // print ("Location Y:  " + playerLocation.y);
            // print ("Location Z:  " + playerLocation.z);


        }
    }
}
