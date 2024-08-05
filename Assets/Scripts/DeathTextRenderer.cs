using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathTextRenderer : MonoBehaviour
{
    public Text miniText;
    public Text MainText;

    //4//
    private string[] mainTexts = new string[] {"Ouch","Eeeew","Bleh","Ugh" };
    //3//
    private string[] allGood = new string[] {"I was about to eat them!","Catch them next time!","They sliped through our fingers!"};
    //4//
    private string[] allBad = new string[] {"I told you I hate these!","What did you give to me!","Disgusting!","I cant feel my tongue!","Do you want to poison me?" };
    //3//
    private string[] mixed = new string[] {"You missed some of my favorites!","What about my instructions!","No, no, no, all wrong!"};


    void Start()
    {

        MainText.text = mainTexts[Random.Range(0, 4)];

        if (!RememberBadOnes.wasClicked2 && !RememberBadOnes.wasClicked1 && !RememberBadOnes.wasClicked3)
        {
                    miniText.text = allGood[Random.Range(0, 3)];
        }

        else if (RememberBadOnes.wasClicked1 && RememberBadOnes.wasClicked2 && RememberBadOnes.wasClicked3)
        {
                    miniText.text = allBad[Random.Range(0, 4)];

        }

        else
        {
                    miniText.text = mixed[Random.Range(0, 3)];
        }

    }
}
