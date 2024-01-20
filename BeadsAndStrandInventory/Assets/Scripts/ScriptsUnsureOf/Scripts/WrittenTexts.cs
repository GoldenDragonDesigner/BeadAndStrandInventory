using UnityEngine;
using TMPro;

public class WrittenTexts : MonoBehaviour
{
    public string textInfo;

    public TMP_Text textDisplayInfo;

    void Start()
    {
        textDisplayInfo.text = textInfo;
    }
}