using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private Vector3 objPosition;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        objPosition = transform.position;
        if (objPosition.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (objPosition.z < lowerBound)
        {
            Destroy(gameObject);
        } 
    }
}
