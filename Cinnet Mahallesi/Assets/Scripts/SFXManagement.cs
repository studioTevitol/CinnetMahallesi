using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManagement : MonoBehaviour
{

    public AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySovereignSulu()
    {
        source.Play();
    }
}
