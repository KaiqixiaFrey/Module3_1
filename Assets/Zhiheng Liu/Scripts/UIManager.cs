using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public PlayerControll mPlayer;
    public List<GameObject> objs = new List<GameObject>();

    public AudioClip clip;

    public Text ui_text;

    public Image gaming;

    public Image Success;
    
    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Replay();
    }

    private void Update()
    {
        ui_text.text = $"Count: {mPlayer.mCurrentCount}";
    }

    public void ShowSuccess()
    {
        GetComponent<AudioSource>().clip = clip;
        GetComponent<AudioSource>().Play();
        Success.gameObject.SetActive(true);
    }

    public void Replay()
    {
        gaming.gameObject.SetActive(true);
        Success.gameObject.SetActive(false);
        mPlayer.mCurrentCount = 0;
        CubeControl.instance.BeginCreat();
    }
    public void ClosePanel(int index)
    {
        objs[index].SetActive(false);
    }
    public void OpenPanel(int index)
    {
        objs[index].SetActive(true);
    }
}
