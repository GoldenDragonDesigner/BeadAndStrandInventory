using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class BeadDataTemplate : ScriptableObject
{
    public string beadName;
    public Sprite beadSprite;
    public string beadType;
    public float numberOfBeadsOnHand;
    public float amountOfStrand;
    public float individualBeadDollarAmount;
}
