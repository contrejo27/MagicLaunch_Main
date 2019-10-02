using System.Collections;
using System.Collections.Generic;
using UMP;
using UnityEngine;

public class VideoHelper : MonoBehaviour
{
    private UniversalMediaPlayer mediaPlayer;
    // Start is called before the first frame update
    void Start()
    {
        mediaPlayer = GameObject.FindObjectOfType<UniversalMediaPlayer>();
        mediaPlayer.Play();
    }
    void OnEnable()
    {
        mediaPlayer = GameObject.FindObjectOfType<UniversalMediaPlayer>();

        mediaPlayer.Play();

    }
    void OnDisable()
    {
        mediaPlayer.Pause();

    }
}
