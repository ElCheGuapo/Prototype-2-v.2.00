using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    //countdown variables
    float currentTime = 10f;
    float startingTime = 10f;

    bool jumpscareHappened = false;
    bool laughHappened = false;

    //movement variables
    Vector2 velocity;

    //JumpScare pre-requisits
    public AudioSource Growl;
    public AudioSource Laugh;
    public AudioSource KidsLaugh;
    public GameObject ThePlayer;
    public GameObject PlayerCam;
    public GameObject JumpCam;
    public GameObject Flickering;

    //other location to teleport player to
    public Transform target;

    void Start()
    {
        ThePlayer.SetActive(true);
        PlayerCam.SetActive(true);
        JumpCam.SetActive(false);
        Flickering.SetActive(false);
    }

    void FixedUpdate()
    {
        //define velocity.y vector
        velocity.y = Input.GetAxis("Vertical");

        if (velocity.y == 0)
        {
            currentTime -=1 * Time.deltaTime;
            Debug.Log("countdown");

            if (currentTime <= 0)
            {
                StartCoroutine(EndJump());
                jumpscareHappened = true;
                Debug.Log("jumpscare");
                currentTime = startingTime;
            }
            if (currentTime <= 4)
            {
                if (laughHappened == true) {
                    StartCoroutine(StartKidsLaugh());
                }
                Debug.Log("Woooosh woooosh, you better move hihi");
                StartCoroutine(StartLaugh());
                laughHappened = true;
                startingTime = 6f;
            }
        }
        else
        {
            currentTime = startingTime;
            Debug.Log("debug");
        }

    }

    IEnumerator StartKidsLaugh() {
        if (jumpscareHappened == false)
        {
            yield return new WaitForSeconds(4.0f);
            if (!KidsLaugh.isPlaying)
            {
                KidsLaugh.Play();
            }
        }
    }

    IEnumerator StartLaugh() {
        if (jumpscareHappened == false)
        {
            Laugh.Play();
            Flickering.SetActive(true);

            yield return new WaitForSeconds(2.03f);
            Flickering.SetActive(false);
            yield break;
        }
            
    }

    IEnumerator EndJump() {
        if (jumpscareHappened == false)
        {
            Growl.Play();
            JumpCam.SetActive(true);
            PlayerCam.SetActive(false);
            ThePlayer.SetActive(true);
            Flickering.SetActive(true);

            yield return new WaitForSeconds(2.03f);
            ThePlayer.SetActive(true);
            PlayerCam.SetActive(true);
            JumpCam.SetActive(false);
            Flickering.SetActive(false);

            ThePlayer.transform.position = target.position;
            yield break;
        }

        if (jumpscareHappened == true)
        {
            Debug.Log("game over");
        }
    }
}
