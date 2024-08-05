using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    public AudioMixer master;
    public AudioClip buttonClick;
    public AudioSource audiosrc;
    public Sprite mutedButton;
    public Sprite activeButton;
    public Button button;

    private static bool isActive = true;

    private void Start()
    {
        if(isActive)
            button.GetComponent<Image>().sprite = activeButton;
        if(!isActive)
            button.GetComponent<Image>().sprite = mutedButton;
    }

    public void MuteClick()
    {
        if(isActive)
        {
            isActive = false;
            master.SetFloat("MyExposedParam", -80f);
            audiosrc.PlayOneShot(buttonClick);
            button.GetComponent<Image>().sprite = mutedButton;
        }
        else if (!isActive)
        {
            button.GetComponent<Image>().sprite = activeButton;
            master.SetFloat("MyExposedParam", 0f);
            isActive = true;
            audiosrc.PlayOneShot(buttonClick);
        }
    }
}
