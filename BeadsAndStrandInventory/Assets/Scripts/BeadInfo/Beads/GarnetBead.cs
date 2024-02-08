using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class GarnetBead : MonoBehaviour, IDataPersistence
{
    public bool save;

    public InputFieldTextHolder garnetBeadSizeInputField;

    //public string garnetName;
    //public Image garnetImage;
    //public string garnetBeadType;
    //public float garnetBeadsOnStrand;
    //public float garnetBeadsOnHand;
    //public double garnetStrandPrice;
    //public double garnetBeadPrice;
    public string garnetBeadSize;

    public TMP_Text garnetBeadSizeText;

    private void Update()
    {
        CalculateBeadPrice();
    }

    private void CalculateBeadPrice()
    {
        //beadName = garnetName;
        //beadType = garnetBeadType;
        //numberOfBeadsOnStrand = garnetBeadsOnStrand;
        //numberOfBeadsOnHand = garnetBeadsOnHand;
        garnetBeadSizeInputField.stringText = garnetBeadSizeText.text;
        garnetBeadSize = garnetBeadSizeText.text;
        //priceOfBeadStrand = garnetStrandPrice;
        //pictureOfBeadSprite = garnetImage;
        //priceOfEachBead = garnetBeadPrice;
    }

    public void LoadData(DataForBeads bead)
    {
        //this.garnetName = bead.garnetName;
        //this.beadsOnHand.garnet4mmBeadsOnHand = bead.numberOfGarnetBeadsOnHand;
        //this.beadsOnHand.garnet4mmBeadsOnStrand = bead.numberOfGarnetBeadsOnStrand;
        //this.amountOfStrand.garnetStrandAmount = bead.priceOfGarnetBeadStrand;
        //this.priceOfEachBead = bead.garnetBeadPrice;
        this.garnetBeadSize = bead.garnetBeadSize;
    }

    public void SaveData(ref DataForBeads bead)
    {
        if (save)
        {
            //bead.garnetName = this.garnetName;
            //bead.numberOfGarnetBeadsOnHand = this.
            //bead.numberOfGarnetBeadsOnStrand = this.beadsOnHand.garnet4mmBeadsOnStrand;
            //bead.priceOfGarnetBeadStrand = this.amountOfStrand.garnetStrandAmount;
            //bead.garnetBeadPrice = this.priceOfEachBead;
            bead.garnetBeadSize = this.garnetBeadSize;
        }
    }

    public void SaveBead()
    {
        save = true;
    }
}