using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoButton : MonoBehaviour
{
    public GameObject InfoPop;
    public AudioClip hello;
    public AudioSource src;
    private bool isVissable;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (!isVissable)
        {
            src.PlayOneShot(hello);
            InfoPop.SetActive(true);
            isVissable = true;
        }
        else
        {
            InfoPop.SetActive(false);
            isVissable = false;
        }
    }
}
