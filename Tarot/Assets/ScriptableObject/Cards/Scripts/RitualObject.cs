using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ritual Object", menuName = "Card System/Cards/Ritual")]
public class RitualObject : CardObject
{
    public int id;
    public void awake(){
        type = CardType.Ritual;
    }
}
