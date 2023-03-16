using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip[] Sound;

    public void SoundPlay(int SoundNumber)
    {
        GetComponent<AudioSource>().PlayOneShot(Sound[SoundNumber]);
    }

}
