using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    public float speed = 40.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move object forward, based on "speed" var
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
