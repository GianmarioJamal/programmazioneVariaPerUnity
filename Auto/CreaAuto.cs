using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CreaAuto : MonoBehaviour
{
    //essendo un oggetto nuovo creo la variabile usando il nome dello script di prima 
    //creo un ARRAY MOLTO IMPORTNATE
    public Macchina[] macchine;

    public TMP_Text nomeMacchina;
    public Transform location;
    GameObject nuovaMacchina;

    public void CreaMacchina(int numeroMacchina) //questa cosa di int numeroMacchina è molto importate il numero serve per capire che macchina è
    {
        Destroy(nuovaMacchina);

        Debug.Log("Funziona");

        //prende il nome dello scriptable object
        nomeMacchina.text = macchine[numeroMacchina].nomeAuto;

        nuovaMacchina = Instantiate(macchine[numeroMacchina].prefabAuto);
        nuovaMacchina.transform.position = location.position;
    }
}
