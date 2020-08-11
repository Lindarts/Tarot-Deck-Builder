using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayCards : MonoBehaviour
{
    public DeckObject deck;

    public int SPACE_BETWEEN_CARDS;
    public int Y_START;

    Dictionary<DeckSlot, GameObject> cardsDisplayed = new Dictionary<DeckSlot, GameObject>();

    void Start() 
    {
        CreateDisplay();    
    }

    void Update() 
    {
        UpdateDisplay();
    }
    
    public void CreateDisplay()
    {
        for (int i = 0; i < deck.Deck.Count; i++)
        {
            var obj = Instantiate(deck.Deck[i].card.prefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponent<CardInDeck>().cardName.text = deck.Deck[i].card.name;
            obj.GetComponent<CardInDeck>().cardQuantity.text = deck.Deck[i].amount.ToString("n0");
            cardsDisplayed.Add(deck.Deck[i], obj);        
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(0f, Y_START + (-SPACE_BETWEEN_CARDS * i), 0f);
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < deck.Deck.Count; i++)
        {
            if (cardsDisplayed.ContainsKey(deck.Deck[i]))
            {
                cardsDisplayed[deck.Deck[i]].GetComponent<CardInDeck>().cardName.text = deck.Deck[i].card.name;
                cardsDisplayed[deck.Deck[i]].GetComponent<CardInDeck>().cardQuantity.text = deck.Deck[i].amount.ToString("n0");
            }else{
                var obj = Instantiate(deck.Deck[i].card.prefab, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                obj.GetComponent<CardInDeck>().cardName.text = deck.Deck[i].card.name;
                obj.GetComponent<CardInDeck>().cardQuantity.text = deck.Deck[i].amount.ToString("n0");
                cardsDisplayed.Add(deck.Deck[i], obj);
            }
        }
    }



}
