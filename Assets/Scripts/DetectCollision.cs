using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //when two objects marked as "trigger" collide, both will be destroyed
    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
