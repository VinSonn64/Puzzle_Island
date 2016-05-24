using UnityEngine;
using System.Collections;

public class NewsPuzzle : MonoBehaviour {
    private float rayDistance;
    public int NewsPoints=0;
    public GameObject NEWSKey;
	// Use this for initialization
	void Start () {
        NEWSKey.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(0.5f * Screen.width, 0.5f * Screen.height, 0f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 10)) //ray is origin, hit is destination, within 100m
        {
          
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.red);//draws out a ray

             if (hit.transform.gameObject.name == "NSphere" && hit.distance < 10 && NewsPoints==0)//Check if player has the right amount of points to get another point 
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
                NewsPoints = 1;
           
            }
             else if (hit.transform.gameObject.name == "ESphere" && hit.distance < 10 && NewsPoints == 1)//Check if player has the right amount of points to get another point 
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
                NewsPoints = 2;
                
            }
             else if (hit.transform.gameObject.name == "WSphere" && hit.distance < 10 && NewsPoints == 2)//Check if player has the right amount of points to get another point 
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
                NewsPoints = 3;
                
            }
             else if (hit.transform.gameObject.name == "SSphere" && hit.distance < 10 && NewsPoints == 3)//Check if player has the right amount of points to get another point 
            {
                hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.green;
                NewsPoints = 4;
            }
            
           
            if(NewsPoints==4)//Activates key when reach 4 points than makes it 5 to makes sure they don't get another.
            {
                NEWSKey.SetActive(true);
                NewsPoints = 5;
            }
        }
	
	}
}
