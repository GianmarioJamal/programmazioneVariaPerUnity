using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//file name e menuName (è il nome del menù a tendina)
[CreateAssetMenu(fileName = "Nuova Macchina", menuName = "Macchina")]

public class Macchina : ScriptableObject
{
    //dentro gli do tutte le caratteristiche dello scriptable object 
    public string nomeAuto;
    public GameObject prefabAuto;
    public Sprite iconaMacchina;
}
