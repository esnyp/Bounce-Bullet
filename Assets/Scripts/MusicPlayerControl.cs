using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerControl : MonoBehaviour
{

    public AudioSource AudioSource;
    public static MusicPlayerControl instance;
    private float musicVolume = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
       AudioSource.Play(); // starts the music -
    }

    // Update is called once per frame
    void Update()
    {
        AudioSource.volume = musicVolume; 
       
    }

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    public void updateVolume(float volume)
    {
        musicVolume = volume; // this is called by the slider every update
    }
}
