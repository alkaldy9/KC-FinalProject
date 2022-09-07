using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
     
    float speed = 10;
    float car_speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 0.09f));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -0.09f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.09f, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-0.09f, 0, 0));
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -car_speed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, car_speed * Time.deltaTime, 0));
        }
    }
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("hit detected");
        }
   
    
}
