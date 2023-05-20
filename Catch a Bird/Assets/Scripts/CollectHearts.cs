using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectHearts : MonoBehaviour
{
    public GameObject Heart;
   
    // Update is called once per frame
    void Update()
    {
            // Detect Touches
            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
            // Detect what ray hits
            if (Physics.Raycast(ray, out hit))
                {   
                    //If its "Hearts" collect them
                    if (hit.collider.CompareTag("Hearts"))
                    {
                        Heart = hit.transform.gameObject;
                        // Start score
                        ScoreManager.score += 1;
                        //Spawn new heart
                        SpawnHeart();
                        // Destroy the touched object
                        Destroy(this.gameObject);
                    }
                }
            }          
    }
    // Spawn new heart randomly
    void SpawnHeart()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(Heart, position, transform.rotation);
    }
}
