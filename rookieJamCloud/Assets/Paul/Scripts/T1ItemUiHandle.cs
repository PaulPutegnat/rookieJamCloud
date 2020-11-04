using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class T1ItemUiHandle : MonoBehaviour
{
    public List<Sprite> Armes = new List<Sprite>();
    public Image ImageWeapon;

    public void getRandomweapon()
    {
        int id = Random.Range(0, Armes.Count);
        ImageWeapon.sprite = Armes[id];
    }
}