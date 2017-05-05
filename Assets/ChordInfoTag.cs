using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChordInfoTag : MonoBehaviour {
    public Camera cameraReference;
    public string testString;
	// Use this for initialization
	void Start () {
        cameraReference = Camera.main;
        testString = "test";
	}
	
	// Update is called once per frame
	void Update () {
        BillBoarding();
	}
    void BillBoarding()
    {
        transform.LookAt(cameraReference.transform.position, Vector3.up);
    }
    public void SetChordInfoTag(string note1, string note2, string note3, string chord1, string chord2)
    {
        TextMesh[] meshes = GetComponentsInChildren<TextMesh>();
        meshes[1].text = note1;
        meshes[2].text = note2;
        meshes[3].text = note3;
        meshes[5].text = chord1;
        meshes[6].text = chord2;
        //  instance.GetComponent("Note1") as 
    }
}
