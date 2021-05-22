using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float minDist;
    public float currDist;
    public bool eventHappened = false;

    public GameObject image;
 
    public Transform player;
    // Start is called before the first frame update
    void Update()
    {
        currDist = Vector3.Distance (transform.position, player.transform.position);
        if (currDist < minDist) {
            StartCoroutine(StartEvent());
        }
    }

    IEnumerator StartEvent() {
        yield return new WaitForSeconds(8.4f);
        image.SetActive(true);
        yield break;
            
    }
}
