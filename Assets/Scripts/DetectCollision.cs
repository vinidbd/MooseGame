using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
//    public Counters script;
    //when two objects marked as "trigger" collide, both will be destroyed
    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
        Counters.points++;
        Debug.Log (Counters.points);
    }
}
