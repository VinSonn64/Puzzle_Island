using UnityEngine;
using System.Collections;

public class KeyCollector : MonoBehaviour {
    public int Keys;
    public GUIText status;
    public GUIText keyAmount;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        keyAmount.GetComponent<GUIText>().text= "Keys: "+Keys.ToString()+ "/4";//Tells the player how many keys they have
        if(Keys==4)
        { keyAmount.GetComponent<GUIText>().text = "Open the Golden Chest"; }//Once they have 4 keys, tellls the player to open chest
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Keys++;//Colliding with key adds to key counter
            other.gameObject.SetActive(false);//Touching key turns it off
        }
        if (other.gameObject.tag=="Finish" && Keys==4)//Once 4 keys are reached, colliding with the chest wins
        { status.text="You Win!"; }
    }
}
