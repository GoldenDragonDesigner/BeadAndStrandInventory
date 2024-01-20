using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class WireQuantity : ScriptableObject
{
    public string wireType;
    public string wireSize;
    public Image wireImage;
    public float wireDollarAmount;
    public string[] wireChars;
    public int wireQuantityInFeet;
}