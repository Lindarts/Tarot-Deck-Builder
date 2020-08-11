using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mine Object", menuName = "Card System/Cards/Mine")]
public class MineObject : CardObject
{
    public int id;
    public void awake(){
        type = CardType.Mine;
    }
}
