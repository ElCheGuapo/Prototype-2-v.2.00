﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    //countdown variables
    float currentTime = 4f;
    float startingTime = 4f;

    bool jumpscareHappened = false;

    //movement variables
    Vector2 velocity;

    //JumpScare pre-requisits
    public AudioSource Growl;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject Flickering;

    //other location to teleport player to
    public Transform target;

    void Start()
    {
        ThePlayer.SetActive(true);
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
            Debug.Log(currentTime);
            if (currentTime <= 0)
            {
                StartCoroutine(EndJump());
                jumpscareHappened = true;
                Debug.Log("jumpscare");
                currentTime = startingTime;
            }
        }
        else
        {
            currentTime = startingTime;
        }

    }

    IEnumerator EndJump() {
        if (jumpscareHappened == false)
        {
            Growl.Play();
            JumpCam.SetActive(true);
            ThePlayer.SetActive(false);
            Flickering.SetActive(true);

            yield return new WaitForSeconds(2.03f);
            ThePlayer.SetActive(true);
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
