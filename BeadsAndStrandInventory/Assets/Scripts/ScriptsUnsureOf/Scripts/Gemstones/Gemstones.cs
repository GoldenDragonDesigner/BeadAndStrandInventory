using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gemstones : MonoBehaviour
{
    #region Variables

    [Tooltip("Is the Gemstone Panel Active")]
    public bool gemIsActive = true;

    [Tooltip("Put the Gemstone Picture Here")]
    public Sprite gemstonePicture;

    [Tooltip("Put the name of the Gemstone Here")]
    public string gemstoneName;

    [Tooltip("What is the first Major Characteristic?")]
    public string firstMajorCharacteristic;

    [Tooltip("What is the Second Major Characteristic?")]
    public string secondMajorCharacteristic;

    [Tooltip("What is the third Major Characteristic?")]
    [SerializeField]
    protected string thirdMajorCharacteristic;

    [Tooltip("What is the size of the bead?")]
    public string beadSize;

    [Tooltip("What type of bead is it?  Flat? Round?")]
    public string beadType;

    [Tooltip("What is the amount per bead?")]
    public string beadAmount;

    public Image gemstoneImage;
    public TMP_Text gemstoneNameText;
    public TMP_Text firstMajorCharText;
    public TMP_Text secondMajorCharText;
    public TMP_Text thirdMajorCharText;
    public TMP_Text sizeOfBead;
    public TMP_Text typeOfBead;
    public TMP_Text amountOfBead;

    #endregion Variables

    #region Start

    private void Start()
    {
        IsPanelActive();
    }

    #endregion Start

    #region Functions

    private void IsPanelActive()
    {
        if (gemIsActive)
        {
            GemstonePicture();
            GemstoneName();
            FirstMajorCharacteristic();
            SecondMajorCharacteristic();
            ThirdMajorCharacteristic();
            SizeOfBead();
            TypeOfBead();
            AmountOfBead();
        }
    }

    private void AmountOfBead()
    {
        amountOfBead.text = beadAmount;
    }

    private void TypeOfBead()
    {
        typeOfBead.text = beadType;
    }

    private void SizeOfBead()
    {
        sizeOfBead.text = beadSize;
    }
    private void ThirdMajorCharacteristic()
    {
        thirdMajorCharText.text = thirdMajorCharacteristic;
    }

    private void SecondMajorCharacteristic()
    {
        secondMajorCharText.text = secondMajorCharacteristic;
    }

    private void FirstMajorCharacteristic()
    {
        firstMajorCharText.text = firstMajorCharacteristic;
    }

    private void GemstoneName()
    {
        gemstoneNameText.text = gemstoneName;
    }

    private void GemstonePicture()
    {
        gemstoneImage.sprite = gemstonePicture;
    }
    #endregion Functions
}