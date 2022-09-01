using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public AudioSource audioPlayer;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        audioPlayer.Play();
    }

}
