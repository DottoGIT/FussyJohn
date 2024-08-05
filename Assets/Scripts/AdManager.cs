using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsListener
{
    private bool donow = false;
    private float pitchnow;
    private static string storeId = "3418278";
    private static bool isReady;
    private static string videoAd = "rewardedVideo";
    public GameObject deathScreen;
    public Button mybutton;

   // void Start()
   // {
   //     Advertisement.AddListener(this);
   //     AnimationCommands.canTapBugsStatic = false;
   //     AnimationCommands.isSpeedButtonActiveStatic = false;
   //
   //     isReady = Advertisement.IsReady(videoAd);
   //
   // }
   //
    private void Update()
    {
        Advertisement.AddListener(this);
        AnimationCommands.canTapBugsStatic = false;
        AnimationCommands.isSpeedButtonActiveStatic = false;

        isReady = Advertisement.IsReady(videoAd);

        if (donow && FindObjectOfType<Camera>().gameObject.GetComponent<AudioSource>().pitch >= pitchnow)
        {
            FindObjectOfType<Camera>().gameObject.GetComponent<AudioSource>().pitch -= 0.01f;
        }
    }

    private void whenWatched()
    {
        pitchnow = FindObjectOfType<Camera>().gameObject.GetComponent<AudioSource>().pitch;
        GameManager.canRequestAd = false;
        GameManager.hpLeft = 3;
        gameObject.GetComponent<RectTransform>().position = new Vector3(200,0,0);
        GameManager.gameSpeed = -4;
        FindObjectOfType<Camera>().gameObject.GetComponent<AudioSource>().pitch *= 1.5f;




        Invoke("killBugs", 3f);
        Invoke("destroyAfterTime", 3.5f);
    }

    private void killBugs()
    {
        donow = true;
        AnimationCommands.killBugsStatic = true;
    }

    private void destroyAfterTime()
    {
        
        AnimationCommands.killBugsStatic = false;
        AnimationCommands.canTapBugsStatic = true;
        AnimationCommands.isSpeedButtonActiveStatic = true;
        try
        {
            donow = false;
            gameObject.SetActive(false);
        }
        catch { }
    }



    public void denyButton()
    {
        var death = Instantiate(deathScreen, new Vector3(0.05f, 0.8f, 0), this.transform.rotation);
        death.transform.SetParent(FindObjectOfType<Canvas>().transform);


        gameObject.SetActive(false);
    }

    public void showAd()
    {
        if (isReady)
        {
            Advertisement.Show(videoAd);
        }


    }

    public static void initialize()
    {
        Advertisement.Initialize(storeId, false);
    }



    public void OnUnityAdsReady(string placementId)
    {
    }

    public void OnUnityAdsDidError(string message)
    {
    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            whenWatched();
        }
        else if (showResult == ShowResult.Skipped)
        {

            var death = Instantiate(deathScreen, new Vector3(0.05f, 0.8f, 0), this.transform.rotation);
            death.transform.SetParent(FindObjectOfType<Canvas>().transform);

            Destroy(gameObject);

        }
        else if (showResult == ShowResult.Failed)
        {
            var death = Instantiate(deathScreen, new Vector3(0.05f, 0.8f, 0), this.transform.rotation);
            death.transform.SetParent(FindObjectOfType<Canvas>().transform);

            Destroy(gameObject);
        }
    }
}
