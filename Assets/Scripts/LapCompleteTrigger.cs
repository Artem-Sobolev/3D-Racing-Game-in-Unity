using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour {
    public GameObject Result;
    public GameObject ControlsActive;
    public GameObject ControlsInactive;
    bool IsLapCompleted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !IsLapCompleted && HalfWayCompleted.IsHalfWayCompleted)
        {
            IsLapCompleted = true;
            Result.SetActive(true);
            ControlsActive.SetActive(false);
            ControlsInactive.SetActive(true);
            Result.GetComponent<Text>().text = "Victory";
        }
        else if(other.tag == "Opponent" && !IsLapCompleted)
        {
            IsLapCompleted = true;
            Result.SetActive(true);
            ControlsActive.SetActive(false);
            ControlsInactive.SetActive(true);
            Result.GetComponent<Text>().text = "Defeat";
        }

    }
}
