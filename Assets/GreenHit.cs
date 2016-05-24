using UnityEngine;
using System.Collections;

public class GreenHit : MonoBehaviour
{

    public GameObject LoopKey;//Key for loop puzzle
    // Use this for initialization
    void Start()
    {//Turns key off at start
        LoopKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)//once an instance of a green bullet enters the loop, it will turn the key on
    {
        if (other.gameObject.tag == "Greenbullet")
        {
            { LoopKey.SetActive(true); }
        }
      
    }
}