using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugAttributes : MonoBehaviour
{
    public bool Ant = false;
    public bool Fly = false;
    public bool Worm = false;
    public string Type;
    public string Color;
    public string Torso;
    public string Head;

    public SpriteRenderer BodyRend;
    public SpriteRenderer HeadRend;
    public SpriteRenderer TorsoRend;

    public Sprite GreenSprite;
    public Sprite RedSprite;
    public Sprite BlackSprite;

    public SpriteRenderer Foot1;
    public SpriteRenderer Foot2;
    public SpriteRenderer Foot3;
    public SpriteRenderer Foot4;
    public SpriteRenderer Foot5;
    public SpriteRenderer Foot6;

    public Color GreenColor;
    public Color RedColor;
    public Color BlackColor;

    public Sprite AlohaShirt;
    public Sprite Cape;
    public Sprite Coat;

    public Sprite Cap;
    public Sprite Glasses;
    public Sprite Visor;


    void Start()
    {
        chooseColor();
        chooseTorso();
        chooseHead();
        detectType();
    }

    void Update()
    {
        if(AnimationCommands.killBugsStatic)
        {
            Destroy(gameObject);
        }
    }
    
    void chooseColor()
    {

        int ColorRand = Random.Range(1, 4);

        switch (ColorRand)
        {
            case 1:
                //Green
                    Foot1.color = GreenColor;
                    Foot2.color = GreenColor;
                    Foot3.color = GreenColor;
                    Foot4.color = GreenColor;
                    Foot5.color = GreenColor;
                    Foot6.color = GreenColor;

                BodyRend.sprite = GreenSprite;

                Color = "Green";

                break;
            case 2:
                    Foot1.color = RedColor;
                    Foot2.color = RedColor;
                    Foot3.color = RedColor;
                    Foot4.color = RedColor;
                    Foot5.color = RedColor;
                    Foot6.color = RedColor;

                BodyRend.sprite = RedSprite;

                Color = "Red";
                break;
            case 3:
                //Black
                    Foot1.color = BlackColor;
                    Foot2.color = BlackColor;
                    Foot3.color = BlackColor;
                    Foot4.color = BlackColor;
                    Foot5.color = BlackColor;
                    Foot6.color = BlackColor;

                BodyRend.sprite = BlackSprite;

                Color = "Black";
                break;
        }




    }

    void chooseTorso()
    {
        int TorsoRand = Random.Range(1, 4);
        switch (TorsoRand)
        {
            case 1:
                //Cape
                TorsoRend.sprite = Cape;
                Torso = "Cape";

                break;
            case 2:
                //Coat
                TorsoRend.sprite = Coat;
                Torso = "Coat";
                break;
            case 3:
                //AlohaShirt
                TorsoRend.sprite = AlohaShirt;
                Torso = "AlohaShirt";
                break;
        }

    }

    void chooseHead()
    {

        int HeadRand = Random.Range(1, 4);
        switch (HeadRand)
        {
            case 1:
                //Cap
                HeadRend.sprite = Cap;
                Head = "Cap";

                break;
            case 2:
                //Glasses
                HeadRend.sprite = Glasses;
                Head = "Glasses";
                break;
            case 3:
                //Visor
                HeadRend.sprite = Visor;
                Head = "Visor";
                break;
        }
    }

    void detectType()
    {
        if (Ant)
            Type = "Ant";
        else if (Fly)
            Type = "Fly";
        else if (Worm)
            Type = "Worm";
    }
}


