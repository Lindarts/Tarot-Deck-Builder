using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType{
    Mine,
    Blessing,
    Relic,
    Ritual,
    Trick,
    Unit
}
public abstract class CardObject : ScriptableObject {
    public GameObject prefab;
    public CardType type;
    [TextArea(10,15)]
    public string description;
}
