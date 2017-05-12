using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class DataManager : MonoBehaviour {

    public List<NoteInfo> noteInfos;
    public Dictionary<string, float> xFrequencies;
    public Dictionary<string, float> yFrequencies;
    public Dictionary<string, float> zFrequencies;
    public float[] scalar= new float[] { 1,4,1};//x,y,z
    public float[] offset = new float[] {0,1.5f,0} ;
    public float[] normalize = new float[3] { 32.7f, 32.7f, 32.7f };
    public GameObject Crosslocator;
    public GameObject OriginMarker;
    public GameObject preFab;
    public GameObject chordInfoPrefab;

    [System.Serializable]
    public class NoteInfo
    {

        public string note;
        public float frequency;


        public static NoteInfo CreateFromJSON(string jsonString)
        {

            {
                NoteInfo NI = JsonUtility.FromJson<DataManager.NoteInfo>(jsonString);
                return (JsonUtility.FromJson<NoteInfo>(jsonString));
                return new NoteInfo();
            }
        }

    }


    // Use this for initialization
    void Start()
    {
        //crosslocator = Resources.Load("Crosslocator") as GameObject;
        //////////
        ////
        noteInfos = new List<NoteInfo>();
        string[] jsonStringList;
        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "notes.json");
        string thestring = "assets/resources/notes.json";
        using (StreamReader r = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read)))
        {
            string json = r.ReadToEnd();
            json = json.Replace("\\t", "");
            json = json.Replace(" ", "");
            json = json.Replace(System.Environment.NewLine, "");
            json = json.Replace("\n", "");
            string splitString = "},";
            string[] ar = new string[1];
            ar[0] = splitString;
            jsonStringList = json.Split(ar, System.StringSplitOptions.None);
            for (int i = 0; i < jsonStringList.Length; i++)
            {
                jsonStringList[i] = jsonStringList[i].Replace("\n", "");
                jsonStringList[i] = jsonStringList[i].Replace("\t", "");
                jsonStringList[i] = jsonStringList[i].Replace("\\t", "");
                jsonStringList[i] = jsonStringList[i].Replace("\\", "");

                jsonStringList[i] = jsonStringList[i];
                jsonStringList[i] += "}";

                string jsonStringX = jsonStringList[i];
                noteInfos.Add(NoteInfo.CreateFromJSON(jsonStringX));
                int u = 0;
            }
            ///////
            ///////
            xFrequencies = new Dictionary<string, float>();
            yFrequencies = new Dictionary<string, float>();
            zFrequencies = new Dictionary<string, float>();
            

        }
        ///
        ///
        for (int i=0; i< noteInfos.Count; i++)
        {
            xFrequencies.Add(noteInfos[i].note, TransformFromFreq(noteInfos[i].frequency, scalar[0], offset[0], normalize[0]));
            yFrequencies.Add(noteInfos[i].note, TransformFromFreq(noteInfos[i].frequency, scalar[1], offset[1], normalize[1]));
            zFrequencies.Add(noteInfos[i].note, TransformFromFreq(noteInfos[i].frequency, scalar[2], offset[2], normalize[2]));
        }
        PlaceInSpace("A1", "C#1", "E1");
        PlaceInSpace("C#1", "E1", "A1");
        PlaceInSpace("A0", "C0", "E0");
        PlaceInSpace("C#0", "E0", "A0");

        PlaceInSpace("C1", "D#1", "G1");
      //  GameObject instance = (GameObject)Instantiate(Resources.Load("OriginMarker"), new Vector3(0, 0, 0), Quaternion.identity);

    }
    float TransformFromFreq(float freq, float scalar, float offset, float normalize)
    {
        float toReturn= (((freq/normalize)+offset)/scalar);
        return toReturn;
    }
    /*Note: the list of "frequencies" is actually the list of coordinates*/



/*PlaceInSpace(string xNote, string yNote, string zNote) takes in positional coordinates and instansiates a marker at that point in space */
   public void PlaceInSpace(string xNote, string yNote, string zNote)
    {
        
        float xLoc=-132f;
        float yLoc=-132f;
        float zLoc = -132f;
        xFrequencies.TryGetValue(xNote, out xLoc);
        yFrequencies.TryGetValue(yNote, out yLoc);
        zFrequencies.TryGetValue(zNote, out zLoc);
        
        if (xLoc == 0 || zLoc == 0 || yLoc == 0)
        {
            Instantiate(preFab, new Vector3(1, 1, 1), Quaternion.identity);
            print(" one of the locations is returning a default value");
        }
        else
        {
            //GameObject instance = (GameObject)Instantiate(Resources.Load("Crosslocator"), new Vector3(xLoc, yLoc, zLoc), Quaternion.identity);
            GameObject instance =(Instantiate(Crosslocator, new Vector3(xLoc, yLoc, zLoc), Quaternion.Euler(0,0,0)));
            
            //Instantiate(preFab, new Vector3(0, 0, 0), Quaternion.identity);
            //ChordInfoTag infoTag = instance.GetComponent<ChordInfoTag>();
           // print(infoTag.testString);
           // infoTag.SetChordInfoTag(xNote, yNote, zNote, "Chord Data Here", "Chord Data 2");
        }
        return;
    }
        
        // Update is called once per frame
    void Update () {
	
	}
}
