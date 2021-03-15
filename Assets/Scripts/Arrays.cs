using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        ArrayBeispielSimpleKlassisch();
        ArrayBeispielSimple();
        ArrayBeispielZweidimensional();
        WahrOderFalschKlassisch();
        WahrOderFalschMitArray();
        
    }

    private static void ArrayBeispielSimpleKlassisch()
    {
        string name1 = "Verena";
        string name2 = "Magdalena";
        string name3 = "Volkmar";

        Debug.Log("Erster Name lautet: " + name1);
        Debug.Log("Zweiter Name lautet: " + name2);
        Debug.Log("Dritter Name lautet: " + name3);
    }

    private static void ArrayBeispielSimple()
    {
        string[] names = new string[3];
        names[0] = "Verena";
        names[1] = "Magdalena";
        names[2] = "Volkmar";

        for (int i = 0; i < names.Length; i++)
            Debug.Log("Array pos: " + i + " " + names[i]);
    }


    private static void ArrayBeispielZweidimensional()
    {
        string[,] wohnblockMieter = new string[2, 6];     //Beistrich [,] für zwei Dimensionen; erste Dimension Stockwerk zweite Dimension Türnummer
        wohnblockMieter[0, 0] = "Huber";
        wohnblockMieter[0, 1] = "Mayer";
        wohnblockMieter[0, 2] = "Eder";
        wohnblockMieter[1, 1] = "Baldorf";
        wohnblockMieter[1, 3] = "Klausner";
        wohnblockMieter[1, 5] = "Wendler";


        MieterImStockwerkAusgeben(wohnblockMieter, 0);
        MieterImStockwerkAusgeben(wohnblockMieter, 1);


    }


    private static void MieterImStockwerkAusgeben(string[,] wohnblockMieter, int stockwerk)
    {

        for (int i = 0; i < wohnblockMieter.GetLength(1); i++)
        {
            if (wohnblockMieter[stockwerk, i] == null)
                Debug.Log("Kein Mieter im Stockwerk: " + stockwerk + " Nummer: " + (i + 1));
            else
                Debug.Log("Im Stockwerk: " + stockwerk + " wohnt in Nummer: " + (i + 1) + " Mieter: " + wohnblockMieter[stockwerk, i]);
        }

    }


    private static void WahrOderFalschKlassisch()
    {
        bool wahrFalsch1 = true;
        bool wahrFalsch2 = false;
        bool wahrFalsch3 = true;

        Debug.Log("Wahr oder falsch bei wahrFalsch1: " + wahrFalsch1);
        Debug.Log("Wahr oder falsch bei wahrFalsch2: " + wahrFalsch2);
        Debug.Log("Wahr oder falsch bei wahrFalsch3: " + wahrFalsch3);
    }


    private static void WahrOderFalschMitArray()
    {
        bool[] wahrFalsch = new bool[3];
        wahrFalsch[0] = true;
        wahrFalsch[1] = false;
        wahrFalsch[2] = true;

        for (int i = 0; i < wahrFalsch.Length; i++)
            Debug.Log("Wahr oder falsch: " + i + " " + wahrFalsch[i]);
    }


}
