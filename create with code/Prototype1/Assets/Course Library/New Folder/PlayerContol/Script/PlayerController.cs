using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       public float speed = 5.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        // we'll move the vehicle forward
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
