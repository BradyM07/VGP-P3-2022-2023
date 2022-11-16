using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject); 
        
        } else if (transform.position.z < lowerBound);
        {  
            Destroy(gameObject);
 }      }
}
