using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public static AudioClip atmosphereSFX, growlSFX;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        atmosphereSFX = Resources.Load<AudioClip> ("background");
        growlSFX = Resources.Load<AudioClip> ("growl");

        audioSrc = GetComponent<AudioSource> ();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "growl":
                audioSrc.PlayOneShot (atmosphereSFX);
                break;
            case "atmosphere":
                audioSrc.PlayOneShot (growlSFX);
                break;
        }


    }
}
