using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck System/Deck")]
public class DeckObject : ScriptableObject
{
    public List<DeckSlot> Deck = new List<DeckSlot>();
    public void AddCard(CardObject _card, int _amount)
    {
        bool hasCard = false;
        for (int i = 0; i < Deck.Count; i++)
        {
            if (Deck[i].card == _card)
            {
                Deck[i].AddAmount(_amount);
                hasCard = true;
                break;
            }
        }
        if (!hasCard)
        {
            Deck.Add(new DeckSlot(_card, _amount));
        }
    }
}

[System.Serializable]
public class DeckSlot{
    public CardObject card;
    public int amount;
    public DeckSlot(CardObject _card, int _amount){
        card = _card;
        amount = _amount;
    }
    public void AddAmount(int value){
        amount += value;
    }

}
