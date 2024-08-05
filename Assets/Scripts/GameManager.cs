using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class GameManager : MonoBehaviour
{
    public static bool canRequestAd = true;
    public static float gameSpeed;
    public static int Score = 0;
    public static bool startNow = false;
    public static bool isGameOver = false;
    public static bool failed = false;
    public static int hpLeft = 3;
    public static int bugsEaten = 0;

    [SerializeField] private float magnitude;
    [SerializeField] private float roughness;
    [SerializeField] private float fadeInTime;
    [SerializeField] private float fadeOutTime;
    [SerializeField] private GameObject adRequest;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] public Canvas canvas;

    public static bool adrequested = false;

    void Start()
    {
        AdManager.initialize();
        startNow = true;
    }
    
    void Update()
    {

        if (hpLeft == 3)
        {
            adrequested = false;
        }

        MovingDown.speed = -gameSpeed;

        if(failed == true && !isGameOver)
        {

            Handheld.Vibrate();
            failed = false;
            hpLeft--;
            CameraShaker.Instance.ShakeOnce(magnitude, roughness, fadeInTime, fadeOutTime);
        }
        if (hpLeft == 0 && !isGameOver && !adrequested)
        {
            SpeedButtonScript.isActive = false;
            adrequested = true;
            failed = false;
            if (canRequestAd)
            { 
                adRequest.SetActive(true);
                adRequest.GetComponent<RectTransform>().position = new Vector3(0, 0, 0);
            } else
            {
                var death = Instantiate(deathScreen, new Vector3(0.05f, 0.8f, 0), this.transform.rotation);
                death.transform.SetParent(canvas.transform);
            }
        }
    }
}
