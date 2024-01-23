using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using BansheeGz.BGDatabase;

public class BeadPrice : MonoBehaviour
{
    #region Variables
    private BeadPricing_BeadInfo beadPrice;

    public string beadName;
    public string typeOfBead;
    public float numberOfBeadsOnStrand;
    public float priceOfBeadStrand;
    public double amountOfEachBead;

    public TMP_Text beadNameText;
    public TMP_Text typeOfBeadText;
    public TMP_Text numberOfBeadsOnStrandText;
    public TMP_Text priceOfBeadStrandText;
    public TMP_Text amountOfEachBeadText;
    public Image pictureOfBeadSprite;
    public Button nextBeadButton;
    public Button lastBeadButton;

    #endregion Variables

    void Start()
    {
        beadPrice = GetComponent<BeadPricing_BeadInfo>();
    }

    void Update()
    {
        CalculateBeadPrice();
    }

    private void CalculateBeadPrice()
    {
        if(beadPrice != null)
        {
            beadName = beadPrice.name;
            beadNameText.text = beadName;
            typeOfBead = beadPrice.Type_Of_Bead;
            typeOfBeadText.text = typeOfBead;
            numberOfBeadsOnStrand = beadPrice.Number_Of_Beads_On_Strand;
            numberOfBeadsOnStrandText.text = numberOfBeadsOnStrand.ToString();
            priceOfBeadStrand = beadPrice.Price_Of_BeadStrand;
            priceOfBeadStrandText.text = priceOfBeadStrand.ToString();
            pictureOfBeadSprite.sprite = beadPrice.Picture_Of_Bead;
        }
        PriceOfEachBead();
    }

    public void PriceOfEachBead()
    {
        amountOfEachBead = priceOfBeadStrand / numberOfBeadsOnStrand;
        amountOfEachBead = Math.Round(amountOfEachBead, 2, MidpointRounding.AwayFromZero);
        amountOfEachBeadText.text = amountOfEachBead.ToString();
    }
}