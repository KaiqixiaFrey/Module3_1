using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AudioManager : MonoBehaviour
{

    public AudioSource[] audioSources;
    public Slider[] sliders;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {

        audioSources[0].volume = sliders[0].value;
        audioSources[1].volume = sliders[1].value;

        if (Input.GetMouseButtonDown(0))
        {
            audioSources[1].Play();
        }
    }
    public void ZanTing()
    {
        Time.timeScale = 0;
    }
    public void NoZanTing()
    {
        Time.timeScale = 1;
    }

    public void ChongLai()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
