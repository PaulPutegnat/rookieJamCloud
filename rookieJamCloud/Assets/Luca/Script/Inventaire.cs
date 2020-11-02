using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public List<Item> Deck = new List<Item>(4); // Dans l'inventaire

    public List<Item> AllItem = new List<Item>(); // Tous les item dispo

    void Start()
    {
        majItem();
    }

    void Update()
    {
        
    }

    public void majItem(){
        int counter = 0;
        if(Deck.Count == 0){
            while(Deck.Count < 4){
                Item addItem = AllItem[Random.Range(0,AllItem.Count)];
                Deck.Add(addItem);
            }
        }
    }
}
