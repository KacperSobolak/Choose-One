using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kolory : MonoBehaviour {

    public Color dobrykolor;
    public Color zlykolor;

    public int rgbzmiana;

    public float r;
    public float g;
    public float b;

    public int znak;

    private void Awake()
    {
        r = Random.RandomRange(30, 225);
        g = Random.RandomRange(30, 225);
        b = Random.RandomRange(30, 225);

        rgbzmiana = Random.RandomRange(1, 4);
        dobrykolor = new Color(r/255, g / 255, b / 255);

        znak = Random.RandomRange(1, 3);

        if (rgbzmiana == 1)
        {
            if (znak == 1)
            {
                r -= Random.RandomRange(1, 11) - 20;
            }
            else if (znak == 2)
            {
                r += Random.RandomRange(1, 11) + 20;
            }
        }
        else if (rgbzmiana == 2)
        {
            if (znak == 1)
            {
                g -= Random.RandomRange(1, 11) - 20;
            }
            else if (znak == 2)
            {
                g += Random.RandomRange(1, 11) + 20;
            }
        }
        else if (rgbzmiana == 3)
        {
            if (znak == 1)
            {
                b -= Random.RandomRange(1, 11) - 20;
            }
            else if (znak == 2)
            {
                b += Random.RandomRange(1, 11) + 20;
            }
        }
        zlykolor = new Color(r / 255, g / 255, b / 255);
    }
}
