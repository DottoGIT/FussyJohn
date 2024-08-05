using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagesScript : MonoBehaviour
{

    public AudioSource audiosrc;
    public AudioClip nextStage;
    public AudioSource soundtrack;
    public static float currentStage;
    private bool timeToShuffle = false;
    private int oldScore;
    public static float howManyBugsToStageUp = 6;
    public static float bugsCollectedInOneStage = 0;
    private bool changeOldScore=true;
    public bool LevelUp = false;
    public ShowAttribs showAttribs;
    public Canvas canvas;
    private bool doSearch = true;

    public GameObject StageLoadScreen;
    public GameObject NewStageLoadScreen;
    public GameObject SecondStageLoadScreen;
    
    void Update()
    {

        if (!GameManager.isGameOver)
        {

            if (GameManager.startNow == true)
            {
                GameManager.canRequestAd = true;
                soundtrack.pitch = 1f;
                BadFeatures.ClearAll();
                currentStage = 0;
                timeToShuffle = true;
                GameManager.startNow = false;
                CalculateBugsToEat();

                var loadScreen = Instantiate(NewStageLoadScreen, new Vector3(-8, 1, 0), this.transform.rotation);
                loadScreen.transform.SetParent(canvas.transform);
            }

            //FOR STAGE ZERO

            if (currentStage == 0 && timeToShuffle == true)
            {

                timeToShuffle = false;
                switch (Random.Range(1, 4))
                {
                    case 1: BadFeatures.Type = "Ant";
                        break;
                    case 2: BadFeatures.Type = "Worm";
                        break;
                    case 3: BadFeatures.Type = "Fly";
                        break;
                }

                switch (Random.Range(4, 10))
                {
                    case 4:
                        BadFeatures.Hat = "Cap";
                        break;
                    case 5:
                        BadFeatures.Hat = "Glasses";
                        break;
                    case 6:
                        BadFeatures.Hat = "Visor";
                        break;

                    case 7:
                        BadFeatures.Cloth = "AlohaShirt";
                        break;
                    case 8:
                        BadFeatures.Cloth = "Coat";
                        break;
                    case 9:
                        BadFeatures.Cloth = "Cape";
                        break;


                }

            }

            //FOR STAGE ONE

            if (currentStage == 1 && timeToShuffle == true)
            {
                timeToShuffle = false;

                switch (Random.Range(4, 10))
                {

                    case 4:
                        if (BadFeatures.Hat == "")
                        {
                            BadFeatures.Hat = "Cap";
                            StageScreenManager.newAttribString = "Cap";
                        }
                        else
                        {
                            StageScreenManager.newAttribString = "AlohaShirt";
                            BadFeatures.Cloth = "AlohaShirt";
                        }
                        break;
                    case 5:
                        if (BadFeatures.Hat == "")
                        {
                            StageScreenManager.newAttribString = "Glasses";
                            BadFeatures.Hat = "Glasses";
                        }
                        else
                        {
                            StageScreenManager.newAttribString = "Coat";
                            BadFeatures.Cloth = "Coat";
                        }
                        break;
                    case 6:
                        if (BadFeatures.Hat == "")
                        {
                            StageScreenManager.newAttribString = "Visor";
                            BadFeatures.Hat = "Visor";
                        }
                        else
                        {
                            BadFeatures.Cloth = "Cape";
                            StageScreenManager.newAttribString = "Cape";
                        }
                        break;

                    case 7:
                        if (BadFeatures.Cloth == "")
                        {
                            BadFeatures.Cloth = "AlohaShirt";
                            StageScreenManager.newAttribString = "AlohaShirt";
                        }
                        else
                        {
                            BadFeatures.Hat = "Cap";
                            StageScreenManager.newAttribString = "Cap";
                        }
                        break;
                    case 8:
                        if (BadFeatures.Cloth == "")
                        {
                            BadFeatures.Cloth = "Coat";
                            StageScreenManager.newAttribString = "Coat";
                        }
                        else
                        {
                            BadFeatures.Hat = "Glasses";
                            StageScreenManager.newAttribString = "Glasses";
                        }
                        break;
                    case 9:
                        if (BadFeatures.Cloth == "")
                        {
                            BadFeatures.Cloth = "Cape";
                            StageScreenManager.newAttribString = "Cape";
                        }
                        else
                        {
                            BadFeatures.Hat = "Visor";
                            StageScreenManager.newAttribString = "Visor";
                        }
                        break;


                }
                var loadScreen = Instantiate(SecondStageLoadScreen, new Vector3(-8, 1, 0), this.transform.rotation);
                loadScreen.transform.SetParent(canvas.transform);
            }

            //FOR STAGE TWO

            if (currentStage == 2 && timeToShuffle == true)
            {
                StageScreenManager.oldAttribString = BadFeatures.Type;
                BadFeatures.Type = "";
                timeToShuffle = false;



                switch (Random.Range(1, 4))
                {
                    case 1:
                        BadFeatures.Color = "Green";
                        StageScreenManager.newAttribString = "Green";
                        break;
                    case 2:
                        BadFeatures.Color = "Red";
                        StageScreenManager.newAttribString = "Red";
                        break;
                    case 3:
                        BadFeatures.Color = "Black";
                        StageScreenManager.newAttribString = "Black";
                        break;
                }


                var loadScreen = Instantiate(StageLoadScreen, new Vector3(-8, 1, 0), this.transform.rotation);
                loadScreen.transform.SetParent(canvas.transform);

            }

            //FOR STAGE TWO+

            if (currentStage > 2 && timeToShuffle == true)
            {
                timeToShuffle = false;
                doSearch = true;

                while (doSearch)
                {
                    switch (Random.Range(1, 10))
                    {
                        case 1:
                            if (BadFeatures.Hat != "Cap")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Hat;
                                StageScreenManager.newAttribString = "Cap";
                                BadFeatures.Hat = "Cap";
                                doSearch = false;
                            }
                            break;

                        case 2:

                            if (BadFeatures.Hat != "Glasses")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Hat;
                                StageScreenManager.newAttribString = "Glasses";
                                BadFeatures.Hat = "Glasses";
                                doSearch = false;
                            }
                            break;

                        case 3:

                            if (BadFeatures.Hat != "Visor")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Hat;
                                StageScreenManager.newAttribString = "Visor";
                                BadFeatures.Hat = "Visor";
                                doSearch = false;
                            }
                            break;

                        case 4:
                            if (BadFeatures.Color != "Red")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Color;
                                StageScreenManager.newAttribString = "Red";
                                BadFeatures.Color = "Red";
                                doSearch = false;
                            }
                            break;

                        case 5:
                            if (BadFeatures.Color != "Black")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Color;
                                StageScreenManager.newAttribString = "Black";
                                BadFeatures.Color = "Black";
                                doSearch = false;
                            }
                            break;

                        case 6:
                            if (BadFeatures.Color != "Green")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Color;
                                StageScreenManager.newAttribString = "Green";
                                BadFeatures.Color = "Green";
                                doSearch = false;
                            }
                            break;

                        case 7:
                            if (BadFeatures.Cloth != "Cape")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Cloth;
                                BadFeatures.Cloth = "Cape";
                                StageScreenManager.newAttribString = "Cape";
                                showAttribs.twoThree.texture = showAttribs.badCape;
                                doSearch = false;
                            }
                            break;

                        case 8:
                            if (BadFeatures.Cloth != "Coat")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Cloth;
                                StageScreenManager.newAttribString = "Coat";
                                BadFeatures.Cloth = "Coat";
                                showAttribs.twoThree.texture = showAttribs.badCoat;
                                doSearch = false;
                            }
                            break;

                        case 9:

                            if (BadFeatures.Cloth != "AlohaShirt")
                            {
                                StageScreenManager.oldAttribString = BadFeatures.Cloth;
                                StageScreenManager.newAttribString = "AlohaShirt";
                                BadFeatures.Cloth = "AlohaShirt";
                                showAttribs.twoThree.texture = showAttribs.badAloha;
                                doSearch = false;
                            }
                            break;
                    }
                }



                var loadScreen = Instantiate(StageLoadScreen, new Vector3(-8, 1, 0), this.transform.rotation);
                loadScreen.transform.SetParent(canvas.transform);
            }



            if (changeOldScore)
            {
                changeOldScore = false;
                oldScore = GameManager.Score;
            }


            if (GameManager.Score != oldScore)
            {
                changeOldScore = true;
                if (oldScore < GameManager.Score)
                    bugsCollectedInOneStage++;
                else
                {
                    bugsCollectedInOneStage = 0;
                    currentStage = 0;
                }
            }
            if (bugsCollectedInOneStage == howManyBugsToStageUp)
            {
                RememberBadOnes.EraseBadOnes();
                shuffleNextStageAudio();
                soundtrack.pitch += 0.05f;
                currentStage++;
                CalculateBugsToEat();
                timeToShuffle = true;
                bugsCollectedInOneStage = 0;
                GameManager.hpLeft = 3;
                GameManager.Score = 0;
            }

            if (LevelUp)
            {
                RememberBadOnes.EraseBadOnes();
                shuffleNextStageAudio();
                soundtrack.pitch += 0.05f;
                currentStage++;
                CalculateBugsToEat();
                timeToShuffle = true;
                bugsCollectedInOneStage = 0;
                GameManager.hpLeft = 3;
                GameManager.Score = 0;
                LevelUp = false;
            }
            
        }

    }

    private void CalculateBugsToEat()
    {
        if (currentStage == 0)
        {
            GameManager.gameSpeed = 0.8f;
            SpawningBugs.FrequencyInSec = 6;
            
        }
        else if (currentStage == 1)
        {
            GameManager.gameSpeed = 1f;
            SpawningBugs.FrequencyInSec = 5.5f;

            
        }
        else if (currentStage == 2)
        {

            GameManager.gameSpeed = 1f;
            SpawningBugs.FrequencyInSec = 5f;

        }
        else if (currentStage > 2)
        {

            if (currentStage <= 10)
            {
                GameManager.gameSpeed += 0.07f;
                SpawningBugs.FrequencyInSec -= 0.42f;
            }
            else if (currentStage <= 20)
            {
                GameManager.gameSpeed+= 0.1f;
                SpawningBugs.FrequencyInSec -= 0.12f;
            }
            else if (currentStage <= 30)
            {
                GameManager.gameSpeed += 0.15f;
                SpawningBugs.FrequencyInSec -= 0.03f;
            }
            else
            {
                GameManager.gameSpeed = 4;
                SpawningBugs.FrequencyInSec = 0.5f;
            }
        }

        SpeedButtonScript.normalSpeed = GameManager.gameSpeed;
        SpeedButtonScript.normalFreq = SpawningBugs.FrequencyInSec;

    }

    private void shuffleNextStageAudio()
    {
                audiosrc.PlayOneShot(nextStage, 2f);
    }

}
