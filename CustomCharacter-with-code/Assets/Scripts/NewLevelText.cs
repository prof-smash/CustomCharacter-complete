using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewLevelText : MonoBehaviour
{
    private Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        string character = GameObject.Find("Character").GetComponent<CustomChar>().charName;
        levelText = GetComponent<Text>();
        levelText.text = "Greetings! I am " + character + ", and I hope you have a wonderful day!";
    }
}
