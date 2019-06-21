using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomChar : MonoBehaviour
{
    public SpriteRenderer hairBack;
    public SpriteRenderer hairFront;
    public SpriteRenderer ear;
    public SpriteRenderer body;
    public SpriteRenderer eyebrow;
    public SpriteRenderer eye;
    public SpriteRenderer mouth;
    public SpriteRenderer effect;
    public SpriteRenderer faceOption;
    public string charName;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }
}
