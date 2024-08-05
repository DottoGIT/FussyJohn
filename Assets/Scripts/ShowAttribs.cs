using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAttribs : MonoBehaviour
{

    public RawImage oneThree;
    public RawImage twoThree;
    public RawImage threeThree;


    public RawImage oneTwo;
    public RawImage twoTwo;

    public RawImage oneOne;

    public Texture badAloha;
    public Texture badCape;
    public Texture badCoat;
    public Texture badAnt;
    public Texture badWorm;
    public Texture badFly;
    public Texture badGlasses;
    public Texture badHat;
    public Texture badVisor;
    public Texture badRed;
    public Texture badGreen;
    public Texture badBlack;


    public static int activeAttribs;

    void Start()
    {
        DisappearAll();
    }
    

    void Update()
    {
        CountActiveAttribs();
        ShowBlankTales();
        DrawBadAttribs();
        
    }


    private void DisappearAll(int dontDisappear = 0)
    {

        if (dontDisappear != 3)
        {
            oneThree.color = new Color(255, 255, 255, 0);
            twoThree.color = new Color(255, 255, 255, 0);
            threeThree.color = new Color(255, 255, 255, 0);
        }


        if (dontDisappear != 2)
        {
            oneTwo.color = new Color(255, 255, 255, 0);
            twoTwo.color = new Color(255, 255, 255, 0);
        }


        if (dontDisappear != 1)
        {
            oneOne.color = new Color(255, 255, 255, 0);
        }
    }
    private void CountActiveAttribs()
    {

        activeAttribs = 4;

        if (BadFeatures.Hat == "")
        {
            if (activeAttribs == 4)
                activeAttribs = 3;

            else if (activeAttribs == 3)
                activeAttribs = 2;

            else if (activeAttribs == 2)
                activeAttribs = 1;

            else if (activeAttribs == 1)
                activeAttribs = 0;
        }


        if (BadFeatures.Cloth == "")
        {
            if (activeAttribs == 4)
                activeAttribs = 3;

            else if (activeAttribs == 3)
                activeAttribs = 2;

            else if (activeAttribs == 2)
                activeAttribs = 1;

            else if (activeAttribs == 1)
                activeAttribs = 0;
        }


        if (BadFeatures.Type == "")
        {
            if (activeAttribs == 4)
                activeAttribs = 3;

            else if (activeAttribs == 3)
                activeAttribs = 2;

            else if (activeAttribs == 2)
                activeAttribs = 1;

            else if (activeAttribs == 1)
                activeAttribs = 0;
        }


        if (BadFeatures.Color == "")
        {
            if (activeAttribs == 4)
                activeAttribs = 3;

            else if (activeAttribs == 3)
                activeAttribs = 2;

            else if (activeAttribs == 2)
                activeAttribs = 1;

            else if (activeAttribs == 1)
                activeAttribs = 0;
        }
    }
    private void ShowBlankTales()
    {
        if (activeAttribs == 3)
        {

            oneThree.color = new Color(255, 255, 255, 255);
            twoThree.color = new Color(255, 255, 255, 255);
            threeThree.color = new Color(255, 255, 255, 255);


            DisappearAll(3);
        }
        else if (activeAttribs == 2)
        {
            oneTwo.color = new Color(255, 255, 255, 255);
            twoTwo.color = new Color(255, 255, 255, 255);


            DisappearAll(2);
        }
        else if (activeAttribs == 1)
        {
            oneOne.color = new Color(255, 255, 255, 255);


            DisappearAll(1);
        }
    }
    private void DrawBadAttribs()
    {


        switch (BadFeatures.Type)
        {
            case "Ant":
                switch(activeAttribs)
                {
                    case 1:
                        oneOne.texture = badAnt;
                        break;

                    case 2:
                        oneTwo.texture = badAnt;
                        break;

                    case 3:
                        oneThree.texture = badAnt;
                        break;
                }
                break;

            case "Worm":

                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badWorm;
                        break;

                    case 2:
                        oneTwo.texture = badWorm;
                        break;

                    case 3:
                        oneThree.texture = badWorm;
                        break;
                }
                break;

            case "Fly":

                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badFly;
                        break;

                    case 2:
                        oneTwo.texture = badFly;
                        break;

                    case 3:
                        oneThree.texture = badFly;
                        break;
                        
                }
                break;

            case "":

                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = null;
                        break;

                    case 2:
                        oneTwo.texture = null;
                        break;

                    case 3:
                        oneThree.texture = null;
                        break;
                }
                break;
        }

        switch (BadFeatures.Color)
        {
            case "Red":

                switch (activeAttribs)
                {
                    case 1:
                        if(BadFeatures.Type == "")
                        oneOne.texture = badRed;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badRed;
                           else twoTwo.texture = badRed;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badRed;
                        else twoThree.texture = badRed;
                        break;
                }
                break;

            case "Green":
                switch (activeAttribs)
                {
                    case 1:
                        if(BadFeatures.Type == "")
                        oneOne.texture = badGreen;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badGreen;
                        else twoTwo.texture = badGreen;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badGreen;
                        else twoThree.texture = badGreen;
                        break;
                }
                break;

            case "Black":

                switch (activeAttribs)
                {
                    case 1:
                        if(BadFeatures.Type == "")
                        oneOne.texture = badBlack;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badBlack;
                        else twoTwo.texture = badBlack;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badBlack;
                        else twoThree.texture = badBlack;
                        break;
                }
                break;

            case "":
                break;
        }

        switch (BadFeatures.Cloth)
        {
            case "AlohaShirt":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badAloha;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badAloha;
                        else twoTwo.texture = badAloha;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badAloha;
                            else if (twoThree.texture == null)
                                twoThree.texture = badAloha;
                                else threeThree.texture = badAloha;
                        break;
                }
                break;

            case "Coat":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badCoat;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badCoat;
                        else twoTwo.texture = badCoat;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badCoat;
                        else if (twoThree.texture == null)
                            twoThree.texture = badCoat;
                        else threeThree.texture = badCoat;
                        break;
                }
                break;

            case "Cape":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badCape;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badCape;
                        else twoTwo.texture = badCape;
                        break;

                    case 3:
                        if (oneThree.texture == null)
                            oneThree.texture = badCape;
                        else if (twoThree.texture == null)
                            twoThree.texture = badCape;
                        else threeThree.texture = badCape;
                        break;
                }
                break;

            case "":
                break;
        }

        switch (BadFeatures.Hat)
        {
            case "Cap":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badHat;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badHat;
                        else twoTwo.texture = badHat;
                        break;

                    case 3:
                        if (oneThree.texture == null && BadFeatures.Cloth == "")
                            oneThree.texture = badHat;
                        else if (twoThree.texture == null && BadFeatures.Cloth == "")
                            twoThree.texture = badHat;
                        else threeThree.texture = badHat;
                        break;
                }
                break;

            case "Glasses":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badGlasses;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badGlasses;
                        else twoTwo.texture = badGlasses;
                        break;

                    case 3:
                        if (oneThree.texture == null && BadFeatures.Cloth == "")
                            oneThree.texture = badHat;
                        else if (twoThree.texture == null && BadFeatures.Cloth == "")
                            twoThree.texture = badGlasses;
                        else threeThree.texture = badGlasses;
                        break;
                }
                break;

            case "Visor":
                switch (activeAttribs)
                {
                    case 1:
                        oneOne.texture = badVisor;
                        break;

                    case 2:
                        if (oneTwo.texture == null)
                            oneTwo.texture = badVisor;
                        else twoTwo.texture = badVisor;
                        break;

                    case 3:
                        if (oneThree.texture == null && BadFeatures.Cloth == "")
                            oneThree.texture = badHat;
                        else if (twoThree.texture == null && BadFeatures.Cloth == "")
                            twoThree.texture = badVisor;
                        else threeThree.texture = badVisor;
                        break;
                }
                break;

            case "":
                break;
        }

        switch (activeAttribs)
        {
            case 1:
                oneThree.texture = null;
                twoThree.texture = null;
                threeThree.texture = null;

                oneTwo.texture = null;
                twoTwo.texture = null;

                break;

            case 2:
                oneThree.texture = null;
                twoThree.texture = null;
                threeThree.texture = null;

                oneOne.texture = null;
                break;

            case 3:
                oneTwo.texture = null;
                twoTwo.texture = null;
                oneOne.texture = null;
                break;
        }
        
        


    }
}
