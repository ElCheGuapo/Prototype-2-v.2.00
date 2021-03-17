using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip footstepSound, growlSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        footstepSound = Resources.Load<AudioClip> ("footsteps");
        growlSound = Resources.Load<AudioClip> ("growl");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "growl":
                audioSrc.PlayOneShot (growlSound);
                break;
            case "footsteps":
                audioSrc.PlayOneShot (footstepSound);
                break;
        }
    }
}
