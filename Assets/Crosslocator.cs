using UnityEngine;
using System.Collections;

public class Crosslocator : MonoBehaviour {
    public GameObject chordInfoPrefab;
    public ChordInfoTag instance;
	// Use this for initialization
	void Start () {
        GameObject instanceO = Instantiate(chordInfoPrefab, new Vector3((transform.position.x+.15f), transform.position.y, transform.position.z), Quaternion.identity);
        instance = instanceO.GetComponent<ChordInfoTag>();
        //instance.transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y, transform.position.z);
        int x=1;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void setChordInfoTag(string note1, string note2, string note3, string chord1, string chord2)
    {
        TextMesh[] meshes=GetComponentsInChildren<TextMesh>();
        meshes[1].text = note1;
        meshes[2].text = note2;
        meshes[3].text = note3;
        meshes[5].text = chord1;
        meshes[6].text = chord2;
      //  instance.GetComponent("Note1") as 
    }
}
