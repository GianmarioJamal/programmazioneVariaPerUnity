using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NuovoOggetto", menuName = "Oggetto")] 
public class Oggetto : ScriptableObject
{
    public string nomeOggetto;
    public GameObject prefabOggetto;
    
}
