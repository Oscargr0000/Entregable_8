using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] Musica;
    private int CurrentSong;

    private AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
       AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentSong);

        AudioSource.clip = Musica[CurrentSong];
        
    }

    public void BackSong()
    {
        CurrentSong--;

        if (CurrentSong <= -1)
        {
            CurrentSong = 4;
        }
    }

    public void NextSong()
    {
        CurrentSong++;

        if (CurrentSong >= 5)
        {
            CurrentSong = 0;
        }
    }
}
