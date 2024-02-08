using UnityEngine;
using TMPro;

public class InputFieldTextHolder : MonoBehaviour
{
    public TMP_InputField inputText;
    public float floatText;
    public double doubleText;
    public string stringText;
    public int intText;
    public bool isFloat;
    public bool isString;
    public bool isDouble;
    public bool isInt;

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
        if (isDouble)
        {
            double.TryParse(inputText.text, out doubleText);
        }
        if (isInt)
        {
            int.TryParse(inputText.text, out intText);
        }
    }
}