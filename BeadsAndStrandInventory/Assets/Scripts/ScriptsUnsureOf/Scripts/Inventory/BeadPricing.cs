using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BeadPricing : MonoBehaviour
{
    public BeadData beadInfo;
    public InputFieldTextHolder beadNameInputText;
    //public Sprite beadSpriteImage;
    public InputFieldTextHolder beadTypeInputText;
    public InputFieldTextHolder numberOfBeadsOnHandInputText;
    public InputFieldTextHolder amountOfStrandInputText;
    public TMP_Text individualBeadDollarAmountText;
    public float individualBeadDollarAmount;
    //public string beadSize;
    //public TMP_Dropdown beadSizeDropDownBox;
    //public float numberOfBeadOnHand;

    private void Update()
    {
        CalculateBeadAmount();
    }
    public void AddingBeadNameToList()
    {
        beadInfo.beadName.Add(beadNameInputText.stringText);
        beadInfo.beadType.Add(beadTypeInputText.stringText);
        beadInfo.numberOfBeadsOnHand.Add(numberOfBeadsOnHandInputText.floatText);
        beadInfo.amountOfStrand.Add(amountOfStrandInputText.floatText);
        beadInfo.individualBeadDollarAmount.Add(individualBeadDollarAmount);
        //beadInfo.beadSprite.Add(beadSpriteImage);
    }

    private void CalculateBeadAmount()
    {
        individualBeadDollarAmount = amountOfStrandInputText.floatText / numberOfBeadsOnHandInputText.floatText;
        individualBeadDollarAmountText.text = individualBeadDollarAmount.ToString();
    }
}
