using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    int punteggio = 0;
    public Text punteggioTesto;

    public void Punteggio()
    {
        punteggio++;
        punteggioTesto.text = punteggio.ToString();
    }
}
