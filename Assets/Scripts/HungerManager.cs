using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManager : MonoBehaviour
{
    public GameObject hungerBorder;
    public GameObject hungerBar;

    public Color maxHpForBorder;
    public Color midHpForBorder;
    public Color lowHpForBorder;

    public Color maxHpForBar;
    public Color midHpForBar;
    public Color lowHpForBar;

    void Start()
    {
        
    }


    void Update()
    {
        if (StagesScript.howManyBugsToStageUp != 0)
            gameObject.transform.localScale = new Vector3(StagesScript.bugsCollectedInOneStage / StagesScript.howManyBugsToStageUp, 1, 1);

        if (GameManager.hpLeft == 3)
        {
            hungerBorder.GetComponent<RawImage>().color = maxHpForBorder;
            hungerBar.GetComponent<RawImage>().color = maxHpForBar;
        }
        else if (GameManager.hpLeft == 2)
        {
            hungerBorder.GetComponent<RawImage>().color = midHpForBorder;
            hungerBar.GetComponent<RawImage>().color = midHpForBar;

        }
        else
        {
            hungerBorder.GetComponent<RawImage>().color = lowHpForBorder;
            hungerBar.GetComponent<RawImage>().color = lowHpForBar;

        }


    }
}
