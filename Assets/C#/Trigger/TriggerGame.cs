using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGame : MonoBehaviour
{
    public CharHP hp;
    public float damage = 5f;
    private bool isTrigg = false;
    float timer;
    public float interval = 0.5f;
    private void Awake()
    {
        hp = FindObjectOfType<CharHP>();
    }
    private void Update()
    {
        if (isTrigg && timer < Time.time)
        {
            hp.TakeDamage(damage);
            timer = Time.time + interval;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTrigg = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isTrigg = false;
        }
    }
}
