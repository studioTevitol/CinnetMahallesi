using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingEventsScript : MonoBehaviour
{
    [SerializeField] private GameObject blackscreen;
    [SerializeField] private AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        
    }

    public void BlackScreenActive()
    {
        StartCoroutine(BlackActive());
    }

    public IEnumerator BlackActive()
    {
        source.Play();
        blackscreen.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("sandbox-credits");
    }

    public void BlackScreenDeActive()
    {
        blackscreen.SetActive(false);
    }
}
