using UnityEngine;
using System.Collections;

public class RGBPuzzle : MonoBehaviour {
    public int RGBPoint = 0;
    public GameObject RGBKey;
	// Use this for initialization
	void Start () {
        RGBKey.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {//Once you enter all 3 houses, key appears
        if (RGBPoint == 3)
        {
            RGBKey.SetActive(true);
           
        }
        
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rroom" & RGBPoint == 0)//Get a point for going in the red room first
            RGBPoint++;
        else if (other.gameObject.tag == "Groom" & RGBPoint == 1)//Get a point for going in the green room second
            RGBPoint++;
        else if (other.gameObject.tag == "Broom" & RGBPoint == 2)//Get last point for entering blue room last.
            RGBPoint++;
        else
            RGBPoint = 0;//resets if wrong room is entered
    }
}
