using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillItem : MonoBehaviour
{
    CharHP HP;
    public float heal = 25;
    void Start()
    {
        HP = FindObjectOfType<CharHP>();
    }
    void OnMouseDown()
    {
        HP.HealHP(heal);
    }

    
}
