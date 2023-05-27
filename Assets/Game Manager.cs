using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text mainText;
    public Button hinzu;
    public Button Enter_all;

    void Start()
    {
        hinzu.GetComponentInChildren<Text>().text = "+";
        Enter_all.GetComponentInChildren<Text>().text = "Neufelsen Hinzufugen";
    }

    
}
