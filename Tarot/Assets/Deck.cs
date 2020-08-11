using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public DeckObject deck;

    public void addCardToDeck(Card card)
    {
        deck.AddCard(card.card, 1);
    }
    public void OnApplicationQuit() 
    {
        deck.Deck.Clear();
    }
}
