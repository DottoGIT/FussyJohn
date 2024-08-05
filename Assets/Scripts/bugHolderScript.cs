using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bugHolderScript : MonoBehaviour
{
    private string type;
    private string color;
    private string cloth;
    private string hat;

    private int activeAttribs;

    private ShowAttribs showAttribs;

    public RawImage BadFeatureOneThree;
    public RawImage BadFeatureTwoThree;
    public RawImage BadFeatureThreeThree;

    public RawImage BadFeatureOneTwo;
    public RawImage BadFeatureTwoTwo;

    public RawImage Border;


    public RawImage AntBody;
    public RawImage AntFoot1;
    public RawImage AntFoot2;
    public RawImage AntFoot3;
    public RawImage AntFoot4;
    public RawImage AntFoot5;
    public RawImage AntFoot6;
    public RawImage AntCloth;
    public RawImage AntHat;

    public RawImage FlyBody;
    public RawImage FlyWing1;
    public RawImage FlyWing2;
    public RawImage FlyCloth;
    public RawImage FlyHat;


    public RawImage WormBody;
    public RawImage WormFoot1;
    public RawImage WormFoot2;
    public RawImage WormFoot3;
    public RawImage WormFoot4;
    public RawImage WormFoot5;
    public RawImage WormFoot6;
    public RawImage WormCloth;
    public RawImage WormHat;

    public Texture AntAloha;
    public Texture AntCape;
    public Texture AntCoat;
    public Texture AntRed;
    public Texture AntBlack;
    public Texture AntGreen;
    public Texture AntCap;
    public Texture AntGlasses;
    public Texture AntVisor;

    public Texture FlyAloha;
    public Texture FlyCape;
    public Texture FlyCoat;
    public Texture FlyRed;
    public Texture FlyBlack;
    public Texture FlyGreen;
    public Texture FlyCap;
    public Texture FlyGlasses;
    public Texture FlyVisor;
    
    public RawImage FlyFoot1;
    public RawImage FlyFoot2;
    public RawImage FlyFoot3;
    public RawImage FlyFoot4;
    public RawImage FlyFoot5;
    public RawImage FlyFoot6;

    public Texture WormAloha;
    public Texture WormCape;
    public Texture WormCoat;
    public Texture WormRed;
    public Texture WormBlack;
    public Texture WormGreen;
    public Texture WormCap;
    public Texture WormGlasses;
    public Texture WormVisor;


    public Texture redBorder;
    public Texture greenBorder;

    [SerializeField] private int bugNumber;
    private string[] BadList = new string[] {"","","" };

    private void Update()
    {
        if (bugNumber == 2) {
            if (activeAttribs == 3)
            {
                BadFeatureOneThree.color = new Color(1f, 1f, 1f, 1f);
                BadFeatureTwoThree.color = new Color(1f, 1f, 1f, 1f);
                BadFeatureThreeThree.color = new Color(1f, 1f, 1f, 1f);

                switch (BadList[0])
                {
                    case "Ant":
                        BadFeatureOneThree.texture = showAttribs.badAnt;
                        break;

                    case "Worm":
                        BadFeatureOneThree.texture = showAttribs.badWorm;
                        break;

                    case "Fly":
                        BadFeatureOneThree.texture = showAttribs.badFly;
                        break;

                    case "Green":
                        BadFeatureOneThree.texture = showAttribs.badGreen;
                        break;

                    case "Red":
                        BadFeatureOneThree.texture = showAttribs.badRed;
                        break;

                    case "Black":
                        BadFeatureOneThree.texture = showAttribs.badBlack;
                        break;

                    case "Cape":
                        BadFeatureOneThree.texture = showAttribs.badCape;
                        break;

                    case "Coat":
                        BadFeatureOneThree.texture = showAttribs.badCoat;
                        break;

                    case "AlohaShirt":
                        BadFeatureOneThree.texture = showAttribs.badAloha;
                        break;

                    case "Glasses":
                        BadFeatureOneThree.texture = showAttribs.badGlasses;
                        break;

                    case "Visor":
                        BadFeatureOneThree.texture = showAttribs.badVisor;
                        break;

                    case "Cap":
                        BadFeatureOneThree.texture = showAttribs.badHat;
                        break;
                }
                switch (BadList[1])
                {
                    case "Ant":
                        BadFeatureTwoThree.texture = showAttribs.badAnt;
                        break;

                    case "Worm":
                        BadFeatureTwoThree.texture = showAttribs.badWorm;
                        break;

                    case "Fly":
                        BadFeatureTwoThree.texture = showAttribs.badFly;
                        break;

                    case "Green":
                        BadFeatureTwoThree.texture = showAttribs.badGreen;
                        break;

                    case "Red":
                        BadFeatureTwoThree.texture = showAttribs.badRed;
                        break;

                    case "Black":
                        BadFeatureTwoThree.texture = showAttribs.badBlack;
                        break;

                    case "Cape":
                        BadFeatureTwoThree.texture = showAttribs.badCape;
                        break;

                    case "Coat":
                        BadFeatureTwoThree.texture = showAttribs.badCoat;
                        break;

                    case "AlohaShirt":
                        BadFeatureTwoThree.texture = showAttribs.badAloha;
                        break;

                    case "Glasses":
                        BadFeatureTwoThree.texture = showAttribs.badGlasses;
                        break;

                    case "Visor":
                        BadFeatureTwoThree.texture = showAttribs.badVisor;
                        break;

                    case "Cap":
                        BadFeatureTwoThree.texture = showAttribs.badHat;
                        break;
                }
                switch (BadList[2])
                {
                    case "Ant":
                        BadFeatureThreeThree.texture = showAttribs.badAnt;
                        break;

                    case "Worm":
                        BadFeatureThreeThree.texture = showAttribs.badWorm;
                        break;

                    case "Fly":
                        BadFeatureThreeThree.texture = showAttribs.badFly;
                        break;

                    case "Green":
                        BadFeatureThreeThree.texture = showAttribs.badGreen;
                        break;

                    case "Red":
                        BadFeatureThreeThree.texture = showAttribs.badRed;
                        break;

                    case "Black":
                        BadFeatureThreeThree.texture = showAttribs.badBlack;
                        break;

                    case "Cape":
                        BadFeatureThreeThree.texture = showAttribs.badCape;
                        break;

                    case "Coat":
                        BadFeatureThreeThree.texture = showAttribs.badCoat;
                        break;

                    case "AlohaShirt":
                        BadFeatureThreeThree.texture = showAttribs.badAloha;
                        break;

                    case "Glasses":
                        BadFeatureThreeThree.texture = showAttribs.badGlasses;
                        break;

                    case "Visor":
                        BadFeatureThreeThree.texture = showAttribs.badVisor;
                        break;

                    case "Cap":
                        BadFeatureThreeThree.texture = showAttribs.badHat;
                        break;
                }
            }
            else if (activeAttribs == 2)
            {
                BadFeatureOneTwo.color = new Color(1f, 1f, 1f, 1f);
                BadFeatureTwoTwo.color = new Color(1f, 1f, 1f, 1f);

                switch (BadList[0])
                {
                    case "Ant":
                        BadFeatureOneTwo.texture = showAttribs.badAnt;
                        break;

                    case "Worm":
                        BadFeatureOneTwo.texture = showAttribs.badWorm;
                        break;

                    case "Fly":
                        BadFeatureOneTwo.texture = showAttribs.badFly;
                        break;

                    case "Green":
                        BadFeatureOneTwo.texture = showAttribs.badGreen;
                        break;

                    case "Red":
                        BadFeatureOneTwo.texture = showAttribs.badRed;
                        break;

                    case "Black":
                        BadFeatureOneTwo.texture = showAttribs.badBlack;
                        break;

                    case "Cape":
                        BadFeatureOneTwo.texture = showAttribs.badCape;
                        break;

                    case "Coat":
                        BadFeatureOneTwo.texture = showAttribs.badCoat;
                        break;

                    case "AlohaShirt":
                        BadFeatureOneTwo.texture = showAttribs.badAloha;
                        break;

                    case "Glasses":
                        BadFeatureOneTwo.texture = showAttribs.badGlasses;
                        break;

                    case "Visor":
                        BadFeatureOneTwo.texture = showAttribs.badVisor;
                        break;

                    case "Cap":
                        BadFeatureOneTwo.texture = showAttribs.badHat;
                        break;
                }
                switch (BadList[1])
                {
                    case "Ant":
                        BadFeatureTwoTwo.texture = showAttribs.badAnt;
                        break;

                    case "Worm":
                        BadFeatureTwoTwo.texture = showAttribs.badWorm;
                        break;

                    case "Fly":
                        BadFeatureTwoTwo.texture = showAttribs.badFly;
                        break;

                    case "Green":
                        BadFeatureTwoTwo.texture = showAttribs.badGreen;
                        break;

                    case "Red":
                        BadFeatureTwoTwo.texture = showAttribs.badRed;
                        break;

                    case "Black":
                        BadFeatureTwoTwo.texture = showAttribs.badBlack;
                        break;

                    case "Cape":
                        BadFeatureTwoTwo.texture = showAttribs.badCape;
                        break;

                    case "Coat":
                        BadFeatureTwoTwo.texture = showAttribs.badCoat;
                        break;

                    case "AlohaShirt":
                        BadFeatureTwoTwo.texture = showAttribs.badAloha;
                        break;

                    case "Glasses":
                        BadFeatureTwoTwo.texture = showAttribs.badGlasses;
                        break;

                    case "Visor":
                        BadFeatureTwoTwo.texture = showAttribs.badVisor;
                        break;

                    case "Cap":
                        BadFeatureTwoTwo.texture = showAttribs.badHat;
                        break;
                }
            }

        }
    }

    void Start()
    {
        showAttribs = FindObjectOfType<ShowAttribs>();

        try
        {
            if (bugNumber == 1)
            {

                if (RememberBadOnes.wasClicked1)
                    Border.texture = redBorder;
                else Border.texture = greenBorder;

                type = RememberBadOnes.firstBugAttribs.Type;
                color = RememberBadOnes.firstBugAttribs.Color;
                cloth = RememberBadOnes.firstBugAttribs.Torso;
                hat = RememberBadOnes.firstBugAttribs.Head;
                BadList = RememberBadOnes.BadList1;
                activeAttribs = RememberBadOnes.attribsOnDeath1;
                
            }
            else if (bugNumber == 2)
            {

                if (RememberBadOnes.wasClicked2)
                    Border.texture = redBorder;
                else Border.texture = greenBorder;

                type = RememberBadOnes.secondBugAttribs.Type;
                color = RememberBadOnes.secondBugAttribs.Color;
                cloth = RememberBadOnes.secondBugAttribs.Torso;
                hat = RememberBadOnes.secondBugAttribs.Head;
                BadList = RememberBadOnes.BadList2;
                activeAttribs = RememberBadOnes.attribsOnDeath2;
            }
            else if (bugNumber == 3)
            {

                if (RememberBadOnes.wasClicked3)
                    Border.texture = redBorder;
                else Border.texture = greenBorder;

                type = RememberBadOnes.thirdBugAttribs.Type;
                color = RememberBadOnes.thirdBugAttribs.Color;
                cloth = RememberBadOnes.thirdBugAttribs.Torso;
                hat = RememberBadOnes.thirdBugAttribs.Head;
                BadList = RememberBadOnes.BadList3;
                activeAttribs = RememberBadOnes.attribsOnDeath3;
            }


            if (type == "Ant")
            {
                AntBody.color = new Color(1f, 1f, 1f, 1f);
                AntFoot1.color = new Color(1f, 1f, 1f, 1f);
                AntFoot2.color = new Color(1f, 1f, 1f, 1f);
                AntFoot3.color = new Color(1f, 1f, 1f, 1f);
                AntFoot4.color = new Color(1f, 1f, 1f, 1f);
                AntFoot5.color = new Color(1f, 1f, 1f, 1f);
                AntFoot6.color = new Color(1f, 1f, 1f, 1f);
                AntCloth.color = new Color(1f, 1f, 1f, 1f);
                AntHat.color = new Color(1f, 1f, 1f, 1f);


                switch (color)
                {
                    case "Red":
                        AntBody.texture = AntRed;
                        AntFoot1.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        AntFoot2.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        AntFoot3.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        AntFoot4.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        AntFoot5.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        AntFoot6.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        break;
                    case "Black":
                        AntBody.texture = AntBlack;
                        AntFoot1.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        AntFoot2.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        AntFoot3.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        AntFoot4.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        AntFoot5.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        AntFoot6.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        break;
                    case "Green":
                        AntBody.texture = AntGreen;
                        AntFoot1.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        AntFoot2.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        AntFoot3.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        AntFoot4.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        AntFoot5.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        AntFoot6.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        break;
                }
                switch (cloth)
                {
                    case "Cape":
                        AntCloth.texture = AntCape;
                        break;
                    case "Coat":
                        AntCloth.texture = AntCoat;
                        break;
                    case "AlohaShirt":
                        AntCloth.texture = AntAloha;
                        break;
                }
                switch (hat)
                {
                    case "Glasses":
                        AntHat.texture = AntGlasses;
                        break;
                    case "Visor":
                        AntHat.texture = AntVisor;
                        break;
                    case "Cap":
                        AntHat.texture = AntCap;
                        break;
                }

            }
            else if (type == "Fly")
            {
                FlyBody.color = new Color(1f, 1f, 1f, 1f);
                FlyWing1.color = new Color(1f, 1f, 1f, 1f);
                FlyWing2.color = new Color(1f, 1f, 1f, 1f);
                FlyHat.color = new Color(1f, 1f, 1f, 1f);
                FlyCloth.color = new Color(1f, 1f, 1f, 1f);


                switch (color)
                {
                    case "Red":
                        FlyBody.texture = FlyRed;
                        FlyFoot1.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        FlyFoot2.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        FlyFoot3.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        FlyFoot4.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        FlyFoot5.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        FlyFoot6.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        break;
                    case "Black":
                        FlyBody.texture = FlyBlack;
                        FlyFoot1.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        FlyFoot2.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        FlyFoot3.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        FlyFoot4.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        FlyFoot5.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        FlyFoot6.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        break;
                    case "Green":
                        FlyBody.texture = FlyGreen;
                        FlyFoot1.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        FlyFoot2.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        FlyFoot3.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        FlyFoot4.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        FlyFoot5.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        FlyFoot6.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        break;
                }
                switch (cloth)
                {
                    case "Cape":
                        FlyCloth.texture = FlyCape;
                        break;
                    case "Coat":
                        FlyCloth.texture = FlyCoat;
                        break;
                    case "AlohaShirt":
                        FlyCloth.texture = FlyAloha;
                        break;
                }
                switch (hat)
                {
                    case "Glasses":
                        FlyHat.texture = FlyGlasses;
                        break;
                    case "Visor":
                        FlyHat.texture = FlyVisor;
                        break;
                    case "Cap":
                        FlyHat.texture = FlyCap;
                        break;
                }
            }
            else if (type == "Worm")
            {
                WormBody.color = new Color(1f, 1f, 1f, 1f);
                WormFoot1.color = new Color(1f, 1f, 1f, 1f);
                WormFoot2.color = new Color(1f, 1f, 1f, 1f);
                WormFoot3.color = new Color(1f, 1f, 1f, 1f);
                WormFoot4.color = new Color(1f, 1f, 1f, 1f);
                WormFoot5.color = new Color(1f, 1f, 1f, 1f);
                WormFoot6.color = new Color(1f, 1f, 1f, 1f);
                WormCloth.color = new Color(1f, 1f, 1f, 1f);
                WormHat.color = new Color(1f, 1f, 1f, 1f);


                switch (color)
                {
                    case "Red":
                        WormBody.texture = WormRed;
                        WormFoot1.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        WormFoot2.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        WormFoot3.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        WormFoot4.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        WormFoot5.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        WormFoot6.color = new Color(0.9176471f, 0.3921569f, 0.3333333f, 1f);
                        break;
                    case "Black":
                        WormBody.texture = WormBlack;
                        WormFoot1.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        WormFoot2.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        WormFoot3.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        WormFoot4.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        WormFoot5.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        WormFoot6.color = new Color(0.5019608f, 0.5019608f, 0.5019608f, 1f);
                        break;
                    case "Green":
                        WormBody.texture = WormGreen;
                        WormFoot1.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        WormFoot2.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        WormFoot3.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        WormFoot4.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        WormFoot5.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        WormFoot6.color = new Color(0.4980392f, 0.8431373f, 0.5372549f, 1f);
                        break;
                }
                switch (cloth)
                {
                    case "Cape":
                        WormCloth.texture = WormCape;
                        break;
                    case "Coat":
                        WormCloth.texture = WormCoat;
                        break;
                    case "AlohaShirt":
                        WormCloth.texture = WormAloha;
                        break;
                }
                switch (hat)
                {
                    case "Glasses":
                        WormHat.texture = WormGlasses;
                        break;
                    case "Visor":
                        WormHat.texture = WormVisor;
                        break;
                    case "Cap":
                        WormHat.texture = WormCap;
                        break;
                }

            }

        }
        catch { }





    } 

}
