using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Postacie
{
    public GameObject postacGO;
    public int cena;
    public Text cenat;
}

public class Sklep : MonoBehaviour {

    public GameObject Info_Panel;
    public GameObject Sklep_Panel;
    public Postacie[] postaciee;
    public Text aktualnieuzywane;

	void Start () {
        Sklep_Panel.SetActive(false);
        Info_Panel.SetActive(false);
        if (PlayerPrefs.HasKey("WybranaP") == false)
        {
            PlayerPrefs.SetInt("WybranaP", 0);
        }
        if (PlayerPrefs.HasKey("Posiadane") == false)
        {
            PlayerPrefs.SetString("Posiadane", "0");
        }
        postaciee[PlayerPrefs.GetInt("WybranaP")].postacGO.SetActive(true);
        aktualnieuzywane.text = "Aktualnie używasz przedmiotu o numerze " + PlayerPrefs.GetInt("WybranaP").ToString(); ;
    }
	
	void Update () {
        for (int i = 0; i <= postaciee.Length - 1; i++)
        {
            string posiadane = PlayerPrefs.GetString("Posiadane");
            char[] posiadanechar = posiadane.ToCharArray();
            bool posiadasz = false;
            bool wybrana = false;
            if (i == PlayerPrefs.GetInt("WybranaP"))
            {
                wybrana = true;
            }
            for (int o = 0; o <= posiadanechar.Length - 1; o++)
            {
                string charstring = posiadanechar[o].ToString();
                string numers = i.ToString();
                if (charstring == numers)
                {
                    posiadasz = true;
                }
            }
            if (posiadasz == false)
            {
                postaciee[i].cenat.text = "Kliknij aby kupic za " + postaciee[i].cena.ToString();
            }
            else if (posiadasz == true)
            {
                if (wybrana == false)
                {
                    postaciee[i].cenat.text = "Kliknij aby wybrac";
                }
                else
                {
                    postaciee[i].cenat.text = "Wybrana";
                }
            }
        }
    }

    public void kupowanie(int numer)
    {
        string posiadane = PlayerPrefs.GetString("Posiadane");
        char[] posiadanechar = posiadane.ToCharArray();
        bool przepusc = true;
        for (int i = 0; i <= posiadanechar.Length-1; i++)
        {
            string charstring = posiadanechar[i].ToString();
            string numers = numer.ToString();
            if (charstring == numers)
            {
                przepusc = false;
            }
        }
        if (przepusc == true && PlayerPrefs.GetInt("Monety") >= postaciee[numer].cena)
        {
            string dodaj = PlayerPrefs.GetString("Posiadane") + numer.ToString();
            PlayerPrefs.SetString("Posiadane", dodaj);
            char[] test = PlayerPrefs.GetString("Posiadane").ToCharArray();
            PlayerPrefs.SetInt("Monety", PlayerPrefs.GetInt("Monety") - postaciee[numer].cena);     
        }
        else if (przepusc == true && PlayerPrefs.GetInt("Monety") <= postaciee[numer].cena)
        {
            Info_Panel.SetActive(true);
            StartCoroutine(Info());
        }
        else if (przepusc == false)
        {
            postaciee[PlayerPrefs.GetInt("WybranaP")].postacGO.SetActive(false);
            PlayerPrefs.SetInt("WybranaP", numer);
            postaciee[PlayerPrefs.GetInt("WybranaP")].postacGO.SetActive(true);
            aktualnieuzywane.text = "Aktualnie używasz przedmiotu o numerze " + PlayerPrefs.GetInt("WybranaP").ToString();
        }
    }

    public void otworzsklep()
    {
        Sklep_Panel.SetActive(true);
    }

    public void zamknijsklep()
    {
        Sklep_Panel.SetActive(false);
    }

    public void zamknijinfo()
    {
        Info_Panel.SetActive(false);
    }

    IEnumerator Info()
    {
        yield return new WaitForSeconds(2.7F);
        zamknijinfo();
    }
}
