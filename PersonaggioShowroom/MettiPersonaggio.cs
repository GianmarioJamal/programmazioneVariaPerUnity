using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class MettiPersonaggio : MonoBehaviour
{
    public Personaggio[] personaggio;
    public TMP_Text nome;
    public TMP_Text età;
    public Image foto;
    public Transform location;

    GameObject nuovoPersonaggio;

    public void InserisciPersonaggio(int numero)
    {
        Destroy(nuovoPersonaggio);
        Debug.Log("Il bottone funziona  broooo");

        nome.text = personaggio[numero].nome;
        età.text = personaggio[numero].età;
        foto.sprite = personaggio[numero].foto;

        nuovoPersonaggio = Instantiate(personaggio[numero].prefabPersonaggio);
        nuovoPersonaggio.transform.position = location.position;
    }
}
