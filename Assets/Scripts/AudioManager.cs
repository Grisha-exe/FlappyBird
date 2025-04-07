using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private List<AudioClip> _clips;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void AddScoreClip()
    {
        _audioSource.PlayOneShot(_clips[4]);
    }

    public void DieClip()
    {
        _audioSource.PlayOneShot(_clips[0]);
    }

    public void FlyClip()
    {
        _audioSource.PlayOneShot(_clips[8]);
    }
}
