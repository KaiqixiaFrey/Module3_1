using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginAndRegister : MonoBehaviour
{

    public Button BtnEntry;

    public string LevelName;

    // Start is called before the first frame update
    void Start()
    {

        BtnEntry.onClick.AddListener(PlayListener);

    }

    void Update()
    {
    
    }

    void PlayListener()
    {
        SceneManager.LoadScene(LevelName);
    }

   
}
