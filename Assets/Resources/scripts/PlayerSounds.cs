using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    public AudioSource Laughing;

    // Start is called before the first frame update
    void Start()
    {
        Laughing = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Deco")
        {
            Laughing.Play();
            Debug.Log("kids laughing");
        }
    }
}
