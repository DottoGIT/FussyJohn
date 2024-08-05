using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCommands : MonoBehaviour
{
    public bool destroyNow = false;
    public bool stopSpowning = false;
    public bool StartSpowning = false;
    public bool KillAllBugs = false;
    public bool canTapBugs = true;

    
    public static bool killBugsStatic = false;
    public static bool canTapBugsStatic;
    public static bool isSpeedButtonActiveStatic = true;

    private static bool tapUsed = false;
    private static float oldSpeed;

    void Start()
    {
        
    }
    
    void Update()
    {
        killBugsStatic = KillAllBugs;
        canTapBugsStatic = canTapBugs;

        if(canTapBugs == false && tapUsed == false)
        {
            oldSpeed = GameManager.gameSpeed;
            GameManager.gameSpeed = 20f;
            tapUsed = true;
        }
        else
        {
            tapUsed = false;
            GameManager.gameSpeed = oldSpeed;
        }

        if(destroyNow)
        {
            Destroy(gameObject);
        }

        if (stopSpowning)
        {
            SpawningBugs.doSpawn = false;
        }

        if (StartSpowning)
        {
            SpawningBugs.doSpawn = true;
        }
    }
}
