using UnityEngine;
using System.Collections;

public class PadPuzzle : MonoBehaviour {
    public GameObject MazeKey;
	// Use this for initialization
	void Start () {
        MazeKey.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Pad")//Touch the pad in the maze to turn on the key
        { 
            MazeKey.SetActive(true);
            other.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
