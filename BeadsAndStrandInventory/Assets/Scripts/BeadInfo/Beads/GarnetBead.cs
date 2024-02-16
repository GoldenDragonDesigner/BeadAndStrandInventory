using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System;

public class GarnetBead : MonoBehaviour, IDataPersistence
{
    public bool save;

    public InputFieldTextHolder garnetNameInputField;
    public InputFieldTextHolder garnetBeadTypeInputField;
    public InputFieldTextHolder numberOfGarnetBeadOnStrandInputField;

    //public InputFieldTextHolder garnetBeadSizeInputField;

    public string garnetName;
    public Image garnetImage;
    public string garnetBeadType;
    public float numberOfGarnetBeadsOnStrand;
    //public float garnetBeadsOnHand;
    //public double garnetStrandPrice;
    //public double garnetBeadPrice;
    //public string garnetBeadSize;

    public TMP_Text garnetNameText;
    public TMP_Text garnetBeadTypeText;

    public TMP_Text garnetBeadSizeText;

    private void Update()
    {
        CalculateBeadPrice();
    }
    private void CalculateBeadPrice()
    {
        //numberOfBeadsOnStrand = garnetBeadsOnStrand;
        //numberOfBeadsOnHand = garnetBeadsOnHand;
        //garnetBeadSizeInputField.stringText = garnetBeadSize;
        //garnetBeadSize = garnetBeadSizeText.text;
        //priceOfBeadStrand = garnetStrandPrice;
        //pictureOfBeadSprite = garnetImage;
        //priceOfEachBead = garnetBeadPrice;
    }
    public void SaveData(ref DataForBeads bead)
    {
        bead.garnetName = garnetName = garnetNameInputField.stringText;
        bead.garnetType = garnetBeadType = garnetBeadTypeInputField.stringText;
        bead.numberOfGarnetBeadsOnStrand = numberOfGarnetBeadsOnStrand = numberOfGarnetBeadOnStrandInputField.floatText;
    }
    public void LoadData(DataForBeads bead)
    {
        garnetName = garnetNameText.text = bead.garnetName;
        garnetBeadType = garnetBeadTypeText.text = bead.garnetType;
        numberOfGarnetBeadsOnStrand = bead.numberOfGarnetBeadsOnStrand;
    }


    public void SaveBead()
    {
        DataPersistenceManager.instance.SaveButtonPress();
    }
}