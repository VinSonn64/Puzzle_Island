using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public Rigidbody blockPrefab;//Bullet Prefab
    public Transform blockTransform;//The bullet will instantiate here on the player camera
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))//Attaches bullet instantiation on left click
        {   Rigidbody blockInstance;
            blockInstance = Instantiate(blockPrefab, blockTransform.position, blockTransform.rotation) as Rigidbody;//Creates the bullet
            blockInstance.AddForce(Camera.main.ScreenPointToRay(new Vector3(0.5f * Screen.width, 0.5f * Screen.height, 0f)).direction * 1000);//Shoots it foward according to the direction of the player camera
        }
    
	}
}
