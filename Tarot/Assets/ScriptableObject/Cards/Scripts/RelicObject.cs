using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Relic Object", menuName = "Card System/Cards/Relic")]
public class RelicObject : CardObject
{
    public int id;
    public void awake(){
        type = CardType.Relic;
    }
}
