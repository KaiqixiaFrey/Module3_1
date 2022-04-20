using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{

  

    public void Playthegame(string  Name)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Name);
    }

}
