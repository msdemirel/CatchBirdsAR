using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectHearts : MonoBehaviour
{
    public GameObject Heart;
   

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;
                


                if (Physics.Raycast(ray, out hit))
                {
                   

                    if (hit.collider.CompareTag("Hearts"))
                    {

                        Heart = hit.transform.gameObject;
                        
                        ScoreManager.score += 1;
                        SpawnHeart();
                    Destroy(this.gameObject);





                    }
                }
            }
        
        
    }

    void SpawnHeart()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), 1, Random.Range(-10.0F, 10.0F));
        Instantiate(Heart, position, transform.rotation);
    }
}
