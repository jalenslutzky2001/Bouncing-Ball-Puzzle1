using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenCube : MonoBehaviour
{
    public AudioSource audioPlayer;
    // Start is called before the first frame update
   private void OnCollisionEnter(Collision player)
    {
        Destroy (gameObject);
        audioPlayer.Play();
    }
}
