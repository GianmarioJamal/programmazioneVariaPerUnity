using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    /*
    int punteggio = 0;
    public Text punteggioTesto;
    */
    public GameManager _gameManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Frutta")
        {
            //punteggio++;
            //punteggioTesto.text = punteggio.ToString();
            _gameManager.Punteggio();
            Destroy(other.gameObject, 0.5f);
        }
    }
}
