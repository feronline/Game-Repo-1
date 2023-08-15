
using UnityEngine;

public class SFP : MonoBehaviour
{
    public AudioSource src;
    public AudioClip sfx;

    public void Button()
    {
        src.clip = sfx;
        src.Play();
    }
}
