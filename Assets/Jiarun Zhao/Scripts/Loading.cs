using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {



    public Slider LoadingSlider;
    public float LoadingNum = 0;
    public string LevelName;

    // Update is called once per frame
    void Update ()
    {

        LoadingNum += Time.deltaTime * 10;
        if (LoadingNum < 100)
        {
            LoadingSlider.value = LoadingNum;
        }
        else
        {
            SceneManager.LoadScene("Jiarun Zhao");
        }
      
    }
}
