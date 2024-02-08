using UnityEngine;
using TMPro;
using System;

public class BeadInput : MonoBehaviour//, IDataPersistence
{
    public InputFieldTextHolder nameOfBeadInputText;
    public InputFieldTextHolder numberOfBeadsOnHandInputText;
    public InputFieldTextHolder priceOfBeadStrandInputText;
    public InputFieldTextHolder numberOfBeadsOnStrandText;

    public TMP_Text amountOfEachBeadText;

    public string nameOfBead;
    public float numberOfBeadsOnHand;
    public double priceOfBeadStrand;
    public float numberOfBeadsOnStrand;
    public double priceOfEachBead;

    public bool save;

    private void Update()
    {
        InputUpdate();
        IndividualBeadPrice();
    }

    private void InputUpdate()
    {
        nameOfBead = nameOfBeadInputText.stringText;
        numberOfBeadsOnHand = numberOfBeadsOnHandInputText.floatText;
        priceOfBeadStrand = priceOfBeadStrandInputText.doubleText;
        numberOfBeadsOnStrand = numberOfBeadsOnStrandText.floatText;
    }

    private void IndividualBeadPrice()
    {
        priceOfEachBead = priceOfBeadStrand / numberOfBeadsOnStrand;
        priceOfEachBead = Math.Round(priceOfEachBead, 2, MidpointRounding.AwayFromZero);
        amountOfEachBeadText.text = priceOfEachBead.ToString();
    }

    public void AddToInventory()
    {
        save = true;
    }

    //public void SaveData(ref DataForBeads bead)
    //{
    //    if (save)
    //    {
    //        bead.beadName = this.nameOfBead;
    //    }
    //}

    //public void LoadData(DataForBeads bead)
    //{
        
    //}
}