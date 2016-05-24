using UnityEngine;
using System.Collections;

public class FakeBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void  OnTriggerEnter(Collider other)//Once hit by a green bullet, it will turn the platform red indicating a fake platform.
    {
        if(other.gameObject.tag=="Greenbullet")
        {
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
