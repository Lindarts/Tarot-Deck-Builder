using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Trick Object", menuName = "Card System/Cards/Trick")]
public class TrickObject : CardObject
{
    public int id;
    public void awake(){
        type = CardType.Trick;
    }
}
