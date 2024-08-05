using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedButtonScript : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioSource audiosrc;
    public static bool isActive = false;
    public Sprite activeButton;
    public Sprite dissactivatedButton;
    public Button button;

    public static float normalSpeed;
    public static float normalFreq;
    public static float boostedSpeed;
    public static float boostedFreq;

    void Start()
    {
        normalSpeed = 1;
        normalFreq = 6;
    }


    void Update()
    {
        if (!AnimationCommands.isSpeedButtonActiveStatic)
        {
            isActive = false;
        }

        if (!isActive && AnimationCommands.isSpeedButtonActiveStatic)
        {

            GameManager.gameSpeed = normalSpeed;
            SpawningBugs.FrequencyInSec = normalFreq;
            normalSpeed = GameManager.gameSpeed;
            normalFreq = SpawningBugs.FrequencyInSec;
            button.GetComponent<Image>().sprite = dissactivatedButton;


            boostedFreq = normalFreq * 0.2f;
            boostedSpeed = normalSpeed * 5f;
        }
        else if (isActive)
        {
            button.GetComponent<Image>().sprite = activeButton;
            GameManager.gameSpeed = boostedSpeed;
            SpawningBugs.FrequencyInSec = boostedFreq;
        }



     
    }

    
    public void OnSpeed()
    {

        if (isActive && AnimationCommands.isSpeedButtonActiveStatic)
        {
            audiosrc.PlayOneShot(buttonClick);
            isActive = false;
        }

        else if (!isActive && AnimationCommands.isSpeedButtonActiveStatic)
        {
            audiosrc.PlayOneShot(buttonClick);
            isActive = true;
        }
    }
}
