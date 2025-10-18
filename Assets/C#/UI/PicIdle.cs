using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicIdle : MonoBehaviour
{
    public UICanvas ui;
    void OnMouseDown()
    {
        ui.SetCoins(1);  
        gameObject.SetActive(false);
    }

    void Start()
    {
     ui= FindObjectOfType<UICanvas>();
    }
}
