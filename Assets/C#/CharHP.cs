using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHP : MonoBehaviour
{
    public Image imageRed;
    public Image imageGreen;

    public float GreenHp = 100;
    public float ReadDamage = 0;

    public void TakeDamage(float damage)
    {
        GreenHp -= damage;
        ReadDamage += damage;
        UpdateHP();
    }
    public void HealHP(float heal)
    {
        GreenHp += heal;
        ReadDamage -= heal;
        UpdateHP();
    }
    void UpdateHP()
    {
        imageGreen.fillAmount = GreenHp / 100;
        imageRed.fillAmount = ReadDamage / 100;
    }
}
