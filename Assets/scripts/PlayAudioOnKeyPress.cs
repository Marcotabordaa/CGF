using UnityEngine;

public class PlayAudioOnKeyPress : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.Play();
        }
    }
}
