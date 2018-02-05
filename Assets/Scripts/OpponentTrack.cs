using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentTrack : MonoBehaviour
{
    public GameObject TheMarker;
    public GameObject[] Marks;
    public int MarkTracker;

    void Update()
    {
        if (MarkTracker == 0)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 1)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 2)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 3)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 4)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 5)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 6)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 7)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 8)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 9)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 10)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 11)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 12)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 13)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }
        if (MarkTracker == 14)
        {
            TheMarker.transform.position = Marks[MarkTracker].transform.position;
        }

    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Opponent")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == Marks.Length)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
