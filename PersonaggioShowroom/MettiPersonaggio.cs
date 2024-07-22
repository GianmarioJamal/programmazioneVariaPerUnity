using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class MettiPersonaggio : MonoBehaviour
{
    public Personaggio[] personaggio;
    public TMP_Text nome;
    public TMP_Text et�;
    public Image foto;
    public Transform location;

    GameObject nuovoPersonaggio;

    public void InserisciPersonaggio(int numero)
    {
        Destroy(nuovoPersonaggio);
        Debug.Log("Il bottone funziona  broooo");

        nome.text = personaggio[numero].nome;
        et�.text = personaggio[numero].et�;
        foto.sprite = personaggio[numero].foto;

        nuovoPersonaggio = Instantiate(personaggio[numero].prefabPersonaggio);
        nuovoPersonaggio.transform.position = location.position;
    }
}
