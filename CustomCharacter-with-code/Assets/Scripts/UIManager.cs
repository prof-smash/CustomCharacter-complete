using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private CustomChar cc;

    public InputField nameInput;
    public Text message;

    public void HairBackAssign(Sprite selection)
    {
        cc.hairBack.sprite = selection;
    }

    public void HairFrontAssign(Sprite selection)
    {
        cc.hairFront.sprite = selection;
    }

    public void BodyAssign(Sprite selection)
    {
        cc.body.sprite = selection;
    }

    public void EarAssign(Sprite selection)
    {
        cc.ear.sprite = selection;
    }

    public void EyeAssign(Sprite selection)
    {
        cc.eye.sprite = selection;
    }

    public void EyebrowAssign(Sprite selection)
    {
        cc.eyebrow.sprite = selection;
    }

    public void MouthAssign(Sprite selection)
    {
        cc.mouth.sprite = selection;
    }

    public void EffectOn()
    {
        if (cc.effect.enabled == true)
            cc.effect.enabled = false;
        else
            cc.effect.enabled = true;
    }

    public void FaceOptionOn()
    {
        if (cc.faceOption.enabled == true)
            cc.faceOption.enabled = false;
        else
            cc.faceOption.enabled = true;
    }

    public void UpdateText()
    {
        cc.charName = nameInput.text;
        message.text = "Hello! My name is... " + cc.charName;
    }

    public void ToNextScene()
    {
        SceneManager.LoadScene("New Scene");
    }
}

