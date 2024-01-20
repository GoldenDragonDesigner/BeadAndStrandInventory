using UnityEngine;
using UnityEngine.UI;

public class BoolHolder : MonoBehaviour
{
    public Toggle inputToggle;
    public bool boolHolder;

    private void Start()
    {
        inputToggle = GetComponent<Toggle>();
    }

    private void Update()
    {
        if (inputToggle.isOn)
        {
            boolHolder = true;
        }
        else
        {
            boolHolder = false;
        }
    }
}
