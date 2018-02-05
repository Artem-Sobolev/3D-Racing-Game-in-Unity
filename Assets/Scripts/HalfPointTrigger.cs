using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour {
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LapCompleteTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
            HalfWayCompleted.IsHalfWayCompleted = true;
        }
        else
        {
            LapCompleteTrig.SetActive(true);
        }
    }
    
}
