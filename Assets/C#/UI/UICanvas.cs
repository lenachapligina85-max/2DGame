using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICanvas : MonoBehaviour
{
    public Image HP;
    public Image HP1;
    public TextMeshProUGUI t;
    public int m;
    public float hp=0;
    public float hp1=100;
    void Start()
    {
        t.text = "Coins: " + m.ToString();
    }
    public void SetCoins(int b)
    {
        m += b;
      t.text ="Coins: "+ m.ToString();  
    }

    
    public void UpdateHP(float D)
    {
        hp += D;
        HP.fillAmount = hp/100;
        hp1 -= D;
        HP1.fillAmount = hp1/100;
    }
}
