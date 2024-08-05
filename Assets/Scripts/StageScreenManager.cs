using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageScreenManager : MonoBehaviour
{
    public RawImage oldAttrib;
    public RawImage newAttrib;
    public RawImage middleAttrib;

    private string StageNow;
    public float loadSpeedSpeed;
    public bool isItFirstStage;
    public bool isItSecondStage;

    public Text CurrentStageText;

    public static string oldAttribString;
    public static string newAttribString;

    private void Start()
    {


        if (StagesScript.currentStage + 1 < 10)
            StageNow = "0" + (StagesScript.currentStage + 1).ToString();
        else StageNow = (StagesScript.currentStage + 1).ToString();

        CurrentStageText.text = StageNow;


        if (isItFirstStage)
        {
            switch (BadFeatures.Type)
            {
                case "Ant":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badAnt;
                    break;

                case "Fly":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badFly;
                    break;

                case "Worm":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badWorm;
                    break;
            }

            if (BadFeatures.Hat != "")
            {
                switch (BadFeatures.Hat)
                {
                    case "Cap":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badHat;
                        break;

                    case "Glasses":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badGlasses;
                        break;

                    case "Visor":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badVisor;
                        break;
                }
            }

            else if (BadFeatures.Cloth != "")
            {
                switch (BadFeatures.Cloth)
                {
                    case "Cape":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badCape;
                        break;

                    case "Coat":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badCoat;
                        break;

                    case "AlohaShirt":
                        newAttrib.texture = FindObjectOfType<ShowAttribs>().badAloha;
                        break;
                }
            }

        }
        else if (isItSecondStage)
        {
            switch (newAttribString)
            {
                case "Green":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badGreen;
                    break;
                case "Black":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badBlack;
                    break;
                case "Red":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badRed;
                    break;
                case "Coat":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badCoat;
                    break;
                case "Cape":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badCape;
                    break;
                case "AlohaShirt":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badAloha;
                    break;
                case "Glasses":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badGlasses;
                    break;
                case "Visor":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badVisor;
                    break;
                case "Cap":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badHat;
                    break;
            }
        }
        else
        {
            switch (oldAttribString)
            {
                case "Ant":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badAnt;
                    break;
                case "Worm":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badWorm;
                    break;
                case "Fly":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badFly;
                    break;
                case "Green":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badGreen;
                    break;
                case "Black":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badBlack;
                    break;
                case "Red":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badRed;
                    break;
                case "Coat":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badCoat;
                    break;
                case "Cape":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badCape;
                    break;
                case "AlohaShirt":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badAloha;
                    break;
                case "Glasses":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badGlasses;
                    break;
                case "Visor":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badVisor;
                    break;
                case "Cap":
                    oldAttrib.texture = FindObjectOfType<ShowAttribs>().badHat;
                    break;
            }
            switch (newAttribString)
            {
                case "Green":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badGreen;
                    break;
                case "Black":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badBlack;
                    break;
                case "Red":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badRed;
                    break;
                case "Coat":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badCoat;
                    break;
                case "Cape":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badCape;
                    break;
                case "AlohaShirt":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badAloha;
                    break;
                case "Glasses":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badGlasses;
                    break;
                case "Visor":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badVisor;
                    break;
                case "Cap":
                    newAttrib.texture = FindObjectOfType<ShowAttribs>().badHat;
                    break;
            }
        }
    }


    void Update()
    {

        AnimationCommands.isSpeedButtonActiveStatic = false;



        if (GetComponent<RectTransform>().localPosition.x < 0)
            GetComponent<RectTransform>().localPosition += new Vector3(loadSpeedSpeed * Time.deltaTime, 0, 0);
        else
            StartCoroutine("moveDown");
    }

    IEnumerator moveDown()
    {
        yield return new WaitForSeconds(2.3f);
        GetComponent<RectTransform>().localPosition += new Vector3(loadSpeedSpeed * Time.deltaTime, 0, 0);
        if (GetComponent<RectTransform>().localPosition.x > 1000)
        {
            AnimationCommands.isSpeedButtonActiveStatic = true;
            Destroy(gameObject);
            yield return 0;
        }
    }

}
