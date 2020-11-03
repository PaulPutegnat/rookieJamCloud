using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventaireT1 : MonoBehaviour
{
    public List<ItemT1> Deck = new List<ItemT1>(4); // Dans l'inventaire

    public List<ItemT1> AllItem = new List<ItemT1>(); // Tous les item dispo

    public int maxItem;

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
            while(Deck.Count < maxItem){
                ItemT1 addItem = AllItem[Random.Range(0,AllItem.Count)];
                Deck.Add(addItem);

                var visu = GameObject.Find("Object (" + counter +")");
                visu.GetComponent<Image>().sprite = Deck[counter].image;

                counter +=1;
            }
        }else{
            while(counter < Deck.Count){
                var visu = GameObject.Find("Object (" + counter +")");
                visu.GetComponent<Image>().sprite = Deck[counter].image;
                counter += 1;

            }
            while(counter == Deck.Count && counter < maxItem){
                ItemT1 addItem = AllItem[Random.Range(0,AllItem.Count)];
                Deck.Add(addItem);
                var visu = GameObject.Find("Object (" + counter +")");
                visu.GetComponent<Image>().sprite = Deck[counter].image;
                counter += 1;
            }
        }
        counter = 0;
        var nameItem = GameObject.Find("Nom");
        nameItem.GetComponent<Text>().text = Deck[counter].name;

        var nameDesc = GameObject.Find("Description");
        nameDesc.GetComponent<Text>().text = Deck[counter].description;

    }


    public void Deleteitem(){
        Deck.RemoveAt(0);
        majItem();
    }
}
