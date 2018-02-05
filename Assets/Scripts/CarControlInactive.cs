using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlInactive : MonoBehaviour {
    public GameObject Car;
    public GameObject Opponent;

    void Start () {
        Car.GetComponent<CarController>().enabled = false;
        Car.GetComponent<CarUserControl>().enabled = false;
        Opponent.GetComponent<CarController>().enabled = false;
        Opponent.GetComponent<CarAIControl>().enabled = false;
        StartCoroutine(StopGame());
    }

    IEnumerator StopGame()
    {
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.9f;
        AudioListener.volume = 0.9f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.8f;
        AudioListener.volume = 0.8f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.7f;
        AudioListener.volume = 0.7f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.6f;
        AudioListener.volume = 0.6f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.5f;
        AudioListener.volume = 0.5f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.4f;
        AudioListener.volume = 0.4f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.3f;
        AudioListener.volume = 0.3f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.2f;
        AudioListener.volume = 0.2f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0.1f;
        AudioListener.volume = 0.1f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0f;
        AudioListener.volume = 0f;
    }
}
