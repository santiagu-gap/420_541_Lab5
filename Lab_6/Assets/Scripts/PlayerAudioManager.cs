using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioManager : MonoBehaviour
{

    private AudioSource audioSource;
    private Animator animator;

<<<<<<< HEAD
=======
    // Start is called before the first frame update
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

<<<<<<< HEAD
    public void PlayPunchSound()
=======
    // Update is called once per frame
    void PlayPunchSound()
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    {
        audioSource.Play();
    }
}
<<<<<<< HEAD


=======
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
