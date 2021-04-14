using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    Light spotlight;
    // Start is called before the first frame update
    void Start()
    {
        spotlight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    // Update is called once per frame
    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
            spotlight.enabled = ! spotlight.enabled;
        }
    }
}
