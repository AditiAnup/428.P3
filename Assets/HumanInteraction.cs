using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanInteraction : MonoBehaviour
{
    public AudioSource Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!Sound.isPlaying)
        {
            Sound.Play();
        }
    }
}
