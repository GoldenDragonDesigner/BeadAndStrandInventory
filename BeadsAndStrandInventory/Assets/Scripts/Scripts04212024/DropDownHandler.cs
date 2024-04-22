using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;

public class DropDownHandler : MonoBehaviour
{
    public List<string> beadTypes;
    public TMP_Dropdown beadTypeDropdown;
    public int index;

    void Start()
    {
        beadTypeDropdown = GetComponent<TMP_Dropdown>();

        index = beadTypeDropdown.value;

        foreach(string beadType in beadTypes)
        {
            beadTypeDropdown.options.Add(new TMP_Dropdown.OptionData() { text = beadType });
        }

        beadTypeDropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(); });
    }

    private void DropdownItemSelected()
    {
        index = beadTypeDropdown.value;
    }


}
