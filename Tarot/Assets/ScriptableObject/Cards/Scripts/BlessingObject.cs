using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Blessing Object", menuName = "Card System/Cards/Blessing")]
public class BlessingObject : CardObject
{
    public int id;
    public void awake(){
        type = CardType.Blessing;
    }
}
