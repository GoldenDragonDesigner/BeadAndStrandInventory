using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpeningAmethystPanel : MonoBehaviour
{
    public TMP_InputField inputField;

    public GemkraUIManager gemkraUIManager;

    private void Start()
    {
        inputField = GetComponent<TMP_InputField>();
    }
    private void Update()
    {
        InputtingWords();
    }

    public void InputtingWords()
    {
        switch (inputField.text)
        {
            case "amethyst":
            case "crown":
            case "inflammation":
                gemkraUIManager.ActivatingAmethystPanel();
                gameObject.SetActive(false);
                break;
        }
    }
}
