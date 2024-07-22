using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Personaggio", menuName = "personaggio")]
public class Personaggio : ScriptableObject
{
    public GameObject prefabPersonaggio;

    public string nome;
    public string età;
    public Sprite foto;
}
