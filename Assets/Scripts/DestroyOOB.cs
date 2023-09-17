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
        //When GameObject passes the top of the map, "If" function destroys it
        //Will destroy food projectile
        objPosition = transform.position;
        if (objPosition.z > topBound)
        {
            Destroy(gameObject);
        }
        //When GameObject passes the bottom of the map, "Else if" function destroys it
        //Will destroy animals mob
        else if (objPosition.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        } 
    }
}
