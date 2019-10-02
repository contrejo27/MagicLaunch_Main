using UnityEngine;

public class AudioHelper : MonoBehaviour
{
    AudioSource mainAudioSource;
    public bool playClipOnStart;
    public AudioClip currentClip;

    void OnEnable()
    {
        mainAudioSource = GameObject.FindObjectOfType<AudioSource>();
        if (playClipOnStart) PlayClip();
    }

    public void PlayClip()
    {
        print("PlayingClip");
        mainAudioSource.clip = currentClip;
        mainAudioSource.Play();
    }

    void OnDisable()
    {
        mainAudioSource.Stop();
        mainAudioSource.clip = null;
    }
}
