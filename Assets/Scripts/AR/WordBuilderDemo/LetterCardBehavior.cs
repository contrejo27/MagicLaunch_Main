using System.Collections;
using UnityEngine;

public class LetterCardBehavior : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip spawnSound;
    public AudioClip wordSound;
    public bool firstLetter;
    bool triggerSpawnSound = true;
    public GameObject wordAsset;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    public void letterSpawn()
    {

        if (triggerSpawnSound && audioSource)
        {
            audioSource.clip = spawnSound;
            audioSource.Play();
            audioSource.loop = false;
            triggerSpawnSound = false;
            StartCoroutine("SoundWait");
        }
    }
    private void Update()
    {

    }
    public void WordConnect()
    {
        audioSource.clip = wordSound;
        audioSource.Play();
        audioSource.loop = false;
        wordAsset.SetActive(true);
    }

    IEnumerator SoundWait()
    {
        yield return new WaitForSeconds(3.0f);
        triggerSpawnSound = true;
    }
}
