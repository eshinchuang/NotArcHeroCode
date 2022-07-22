using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource audioSr;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnSliderChange(float vol)
    {
        audioSr.volume = vol;
    }
}
