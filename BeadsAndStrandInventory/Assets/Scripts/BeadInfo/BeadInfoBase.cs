using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[System.Serializable]
public class BeadInfoBase : MonoBehaviour
{
    //////protected InputFieldTextHolder beadSizeInputField1;
    //////protected InputFieldTextHolder beadSizeInputField2;
    //////protected InputFieldTextHolder beadSizeInputField3;
    //////protected InputFieldTextHolder beadSizeInputField4;
    //////protected InputFieldTextHolder beadSizeInputField5;
    //////protected InputFieldTextHolder beadSizeInputField6;


    //[Tooltip("This is the bead name")]
    //[SerializeField]
    //////protected string beadName;
    //[Tooltip("This is the type of bead")]
    //[SerializeField]
    //////protected string beadType;
    //[Tooltip("This is the the number of beads on hand")]
    //[SerializeField]
    protected float numberOfBeadsOnHand;
    //[SerializeField]
    protected float numberOfBeadsAdded;
    //[Tooltip("This is the number of beads on Strand")]
    //[SerializeField]
    protected float numberOfBeadsOnStrand;
    //[Tooltip("The price of the Bead Strand")]
    //[SerializeField]
    protected double priceOfBeadStrand;
    //[Tooltip("The price of each bead")]
    //[SerializeField]
    protected double priceOfEachBead;
    
    
    
    
    
    
    //[Tooltip("The bead Size")]
    //[SerializeField]
    //protected string beadSize;





    //[Tooltip("Add the beadNameText text box here")]
    //[SerializeField]
    protected TMP_Text beadNameText;
    //[Tooltip("Add typeOfBead text box here")]
    //[SerializeField]
    protected TMP_Text typeOfBeadText;
    //[Tooltip("Add numberOfBeadsOnHandText Box here")]
    //[SerializeField]
    protected TMP_Text numberOfBeadsOnHandText;
    //[Tooltip("Add priceOfBeadsStrandsText Box here")]
    //[SerializeField]
    protected TMP_Text priceOfBeadsStrandText;
    //[Tooltip("Add the amountOfEachBeadText box here")]
    //[SerializeField]
    protected TMP_Text amountOfEachBeadText;
    //[Tooltip("Add the the Image box here")]
    //[SerializeField]
    protected Image pictureOfBeadSprite;





    //[Tooltip("Add the beadSizeText Box here")]
    //[SerializeField]
    //protected TMP_Text beadSizeText;

    protected virtual void Update()
    {
        CalculateBeadPrice();
        AddingToNumberOfBeadsOnHand();
    }

    protected virtual void CalculateBeadPrice()
    {
        //////beadNameText.text = beadName;
        //////typeOfBeadText.text = beadType;
        numberOfBeadsOnHandText.text = numberOfBeadsOnHand.ToString();
        //beadSizeInputField.stringText = beadSizeText.text;
        //beadSizeText.text = beadSize;
        priceOfBeadsStrandText.text = priceOfBeadStrand.ToString();

        PriceOfEachBead();
    }

    protected virtual void PriceOfEachBead()
    {
        priceOfEachBead = priceOfBeadStrand / numberOfBeadsOnStrand;
        priceOfEachBead = Math.Round(priceOfEachBead, 2, MidpointRounding.AwayFromZero);
        amountOfEachBeadText.text = priceOfEachBead.ToString();
    }

    protected virtual void AddingToNumberOfBeadsOnHand()
    {
        if(numberOfBeadsOnHand <= 0)
        {
            //numberOfBeadsOnHand = InputFieldTextHolder.floatText;
        }
        else
        {
            //numberOfBeadsOnHand = numberOfBeadsOnHand + InputFieldTextHolder.floatText;
        }
    }
}