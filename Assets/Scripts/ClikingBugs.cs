using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ClikingBugs : MonoBehaviour
{

    private AudioSource audiosrc;
    public AudioClip LickOne, LickTwo, LickThree, LickFour;
    public AudioClip BleOne, BleTwo, BleThree, BleFour, BleFive, BleSix;
    public GameObject clickBorder;
    
    void Start()
    {
        audiosrc = FindObjectOfType<GameManager>().gameObject.GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        
            Touch touch = Input.GetTouch(0);

            if (touch.position.y > 175.5f && AnimationCommands.canTapBugsStatic)
            {
                if (gameObject.GetComponent<BugAttributes>().Color != BadFeatures.Color &&
                    gameObject.GetComponent<BugAttributes>().Torso != BadFeatures.Cloth &&
                    gameObject.GetComponent<BugAttributes>().Type != BadFeatures.Type &&
                    gameObject.GetComponent<BugAttributes>().Head != BadFeatures.Hat)
                {
                    PlayShuffleLick();

                    GameManager.Score++;
                    GameManager.bugsEaten++;


                }
                else
                {
                    GameManager.failed = true;

                PlayShuffleFail();

                    if (ShowAttribs.activeAttribs == 3)
                    {
                        if (BadFeatures.Type == "")
                            RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Color, BadFeatures.Cloth, BadFeatures.Hat }, true, ShowAttribs.activeAttribs);
                        else if (BadFeatures.Color == "")
                            RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Cloth, BadFeatures.Hat }, true, ShowAttribs.activeAttribs);
                    }
                    else if (ShowAttribs.activeAttribs == 2)
                    {

                        if (BadFeatures.Cloth == "")
                            RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Hat, "" }, true, ShowAttribs.activeAttribs);
                        else if (BadFeatures.Hat == "")
                            RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Cloth, "" }, true, ShowAttribs.activeAttribs);
                    }



                }
                Destroy(gameObject);
            }

        
    }

    public void CheckOnDeathZone()
    {
        if (AnimationCommands.canTapBugsStatic)
        {
            if (gameObject.GetComponent<BugAttributes>().Color != BadFeatures.Color &&
                gameObject.GetComponent<BugAttributes>().Torso != BadFeatures.Cloth &&
                gameObject.GetComponent<BugAttributes>().Type != BadFeatures.Type &&
                gameObject.GetComponent<BugAttributes>().Head != BadFeatures.Hat)
            {
                GameManager.failed = true;
                PlayShuffleFail();
       
       
                if (ShowAttribs.activeAttribs == 3)
                {
                    if (BadFeatures.Type == "")
                        RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Color, BadFeatures.Cloth, BadFeatures.Hat }, false, ShowAttribs.activeAttribs);
                    else if (BadFeatures.Color == "")
                        RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Cloth, BadFeatures.Hat }, false, ShowAttribs.activeAttribs);
                }
                else if (ShowAttribs.activeAttribs == 2)
                {
       
                    if (BadFeatures.Cloth == "")
                        RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Hat, "" }, false, ShowAttribs.activeAttribs);
                    else if (BadFeatures.Hat == "")
                        RememberBadOnes.passBugAttribs(gameObject.GetComponent<BugAttributes>(), new string[] { BadFeatures.Type, BadFeatures.Cloth, "" }, false, ShowAttribs.activeAttribs);
                }
            }
       
        }
       
        Destroy(gameObject);

       
    }

    private void PlayShuffleLick()
    {
        switch (Random.Range(1,5))
        {
            case 1:
                audiosrc.PlayOneShot(LickOne, 1f);
                break;
            case 2:
                audiosrc.PlayOneShot(LickTwo, 1f);
                break;
            case 3:
                audiosrc.PlayOneShot(LickThree, 1f);
                break;
            case 4:
                audiosrc.PlayOneShot(LickFour, 1f);
                break;

        }
    }

    private void PlayShuffleFail()
    {
        switch (Random.Range(1, 7))
        {
            case 1:
                audiosrc.PlayOneShot(BleOne, 1f);
                break;
            case 2:
                audiosrc.PlayOneShot(BleTwo, 1f);
                break;
            case 3:
                audiosrc.PlayOneShot(BleThree, 1f);
                break;
            case 4:
                audiosrc.PlayOneShot(BleFour, 1f);
                break;
            case 5:
                audiosrc.PlayOneShot(BleFive, 1f);
                break;
            case 6:
                audiosrc.PlayOneShot(BleSix, 1f);
                break;

        }
    }
}
