using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolory : MonoBehaviour {

    public GameObject GameControllerGO;

    public Color dobrykolor;
    public Color zlykolor;

    public int rgbzmiana;

    public float r;
    public float g;
    public float b;

    public int MaxColor = 255;
    public int MinColor = 0;
    public int MaxColorPoczatek = 205;
    public int MinColorPoczatek = 50;

    public int Roznica = 50;
    public int znak;

    private void Awake()
    {
        GameControllerGO = GameObject.Find("GameController");
        GameController gc = GameControllerGO.gameObject.GetComponent<GameController>();

        Roznica -= gc.punkty;
        if (Roznica <= 5)
        {
            Roznica = 5;
        }
        MaxColorPoczatek += gc.punkty;
        if (MaxColorPoczatek >= 230)
        {
            MaxColorPoczatek = 220;
        }
        MinColorPoczatek -= gc.punkty;
        if (MinColorPoczatek <= 25)
        {
            MinColorPoczatek = 25;
        }

        r = Random.RandomRange(MinColorPoczatek, MaxColorPoczatek);
        g = Random.RandomRange(MinColorPoczatek, MaxColorPoczatek);
        b = Random.RandomRange(MinColorPoczatek, MaxColorPoczatek);

        rgbzmiana = Random.RandomRange(1, 4);
        /*if (gc.punkty <= 15 && rgbzmiana == 3)
        {
            while(rgbzmiana == 3)
            {
                rgbzmiana = Random.RandomRange(1, 4);
            }
        }*/
        dobrykolor = new Color(r/255, g / 255, b / 255);

        znak = Random.RandomRange(1, 3);

        if (rgbzmiana == 1)
        {
            if (znak == 1)
            {
                r -= Random.RandomRange(1, 11);
                r -= Roznica;
            }
            else if (znak == 2)
            {
                r += Random.RandomRange(1, 11) + Roznica;
            }
        }
        else if (rgbzmiana == 2)
        {
            if (znak == 1)
            {
                g -= Random.RandomRange(1, 11);
                g -= Roznica;
            }
            else if (znak == 2)
            {
                g += Random.RandomRange(1, 11) + Roznica;
            }
        }
        else if (rgbzmiana == 3)
        {
            if (znak == 1)
            {
                b -= Random.RandomRange(1, 11);
                b -= Roznica;
            }
            else if (znak == 2)
            {
                b += Random.RandomRange(1, 11) + Roznica;
            }
        }
        zlykolor = new Color(r / 255, g / 255, b / 255);
    }
}
