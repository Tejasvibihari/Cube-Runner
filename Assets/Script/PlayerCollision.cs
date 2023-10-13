using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Playerscript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    //private void OnCollisionEnter(Collision other)
    //{
    //if(other.gameObject.name== "Green Cube")
    //{
    //    Destroy(other.gameObject);
    //}
    //if(other.gameObject.tag=="Collectables")
    //{
    //    Destroy(other.gameObject);
    //}
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.Addscore(1);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Collider")
            {
            audioSource1.Play();
                gameController.GameOver();
                playerScript.enabled = false;
            }
        }
        
    }
