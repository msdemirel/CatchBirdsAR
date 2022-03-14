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
        
        if((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began) )
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Something hit");
                if(hit.collider.CompareTag("Hearts"))
                {
                    Debug.Log("Heart hit");
                    Heart = hit.transform.gameObject;
                    this.Heart.SetActive(false);
                }
            }

            
           // Destroy(Heart);
        }
    }
}
