using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class AudioManager : MonoBehaviour
{

    public AudioClip[] Musica;
    public string[] SongNames;
    private int CurrentSong;

    private AudioSource AudioSource;
    private int RandomSong;

    public TextMeshProUGUI SongsName;

    // Start is called before the first frame update
    void Start()
    {
       AudioSource = GetComponent<AudioSource>();

        AudioSource.PlayOneShot(Musica[CurrentSong], 1);

        RandomSong = Random.Range(1, 5);

        


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentSong);

        AudioSource.clip = Musica[CurrentSong];

        SongsName.text = $"{SongNames[CurrentSong]}";


        
    }

    public void BackSong()
    {
        AudioSource.Stop();

        CurrentSong--;

        if (CurrentSong <= -1)
        {
            CurrentSong = 4;
        }

        AudioSource.PlayOneShot(Musica[CurrentSong], 1);
    }

    public void NextSong()
    {
        AudioSource.Stop();

        CurrentSong++;

        if (CurrentSong >= 5)
        {
            CurrentSong = 0;
        }

        AudioSource.PlayOneShot(Musica[CurrentSong], 1);

        
    }


    public void Pause()
    {
        AudioSource.Pause();
    }

    public void Play()
    {
        AudioSource.UnPause();
    }

    public void RandomSoong()
    {
        AudioSource.Stop();

        AudioSource.PlayOneShot(Musica[RandomSong], 1);
    }
}
