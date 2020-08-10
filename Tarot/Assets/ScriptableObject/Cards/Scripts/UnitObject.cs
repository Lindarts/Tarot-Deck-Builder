using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit Object", menuName = "Card System/Cards/Unit")]
public class UnitObject : CardObject
{
    public void awake(){
        type = CardType.Unit;
    }
}
