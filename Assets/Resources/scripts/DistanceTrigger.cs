using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTrigger : MonoBehaviour
{
    public float minDist;
    public float currDist;
    public bool eventHappened = false;
 
    public Transform player;
    public AudioSource sfx;
    public GameObject Flickering;

    void Update () {
 
        currDist = Vector3.Distance (transform.position, player.transform.position);
        if (currDist < minDist) {
            if(!sfx.isPlaying) {
                StartCoroutine(StartEvent());
            }
        }
    }

    IEnumerator StartEvent() {
        if (eventHappened == false)
        {
            sfx.Play();
            Flickering.SetActive(true);
            eventHappened = true;

            yield return new WaitForSeconds(8.03f);
            Flickering.SetActive(false);
            yield break;
        }
            
    }
}
