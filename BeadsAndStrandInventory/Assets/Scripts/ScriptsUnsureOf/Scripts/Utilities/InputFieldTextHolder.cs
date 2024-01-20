using UnityEngine;
using TMPro;

public class InputFieldTextHolder : MonoBehaviour
{
    public TMP_InputField inputText;
    public float floatText;
    public string stringText;
    public bool isFloat;
    public bool isString;

    void Start()
    {
        inputText = GetComponent<TMP_InputField>();
    }

    void Update()
    {
        if (isFloat)
        {
            float.TryParse(inputText.text, out floatText);
        }
        if (isString)
        {
            stringText = inputText.text;
        }
    }
}