using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberBadOnes : MonoBehaviour
{
    public static BugAttributes firstBugAttribs = null;
    public static BugAttributes secondBugAttribs = null;
    public static BugAttributes thirdBugAttribs = null;

    public static int attribsOnDeath1;
    public static int attribsOnDeath2;
    public static int attribsOnDeath3;

    public static bool wasClicked1;
    public static bool wasClicked2;
    public static bool wasClicked3;

    public static string[] BadList1 = new string[] {"","","" };
    public static string[] BadList2 = new string[] {"","","" };
    public static string[] BadList3 = new string[] {"","","" };

    private static bool firstassigned = false;
    private static bool secondassigned = false;
    



    public static void passBugAttribs(BugAttributes attribs, string[] badList, bool wasClicked, int attribsnow)
    {
        if (!firstassigned)
        {
            firstBugAttribs = attribs;
            firstassigned = true;
            BadList1 = badList;
            wasClicked1 = wasClicked;
            attribsOnDeath1 = attribsnow;
            
        }
        else if (!secondassigned)
        {
            secondBugAttribs = attribs;
            secondassigned = true;
            BadList2 = badList;
            wasClicked2 = wasClicked;
            attribsOnDeath2 = attribsnow;
        }
        else
        {
            thirdBugAttribs = attribs;
            BadList3 = badList;
            wasClicked3 = wasClicked;
            attribsOnDeath3 = attribsnow;
        }
    }

    public static void EraseBadOnes()
    {
        firstBugAttribs = null;
        secondBugAttribs = null;
        thirdBugAttribs = null;


        firstassigned = false;
        secondassigned = false;

        BadList1 = new string[] { "", "", "" };
        BadList2 = new string[] { "", "", "" };
        BadList3 = new string[] { "", "", "" };

    }
}
