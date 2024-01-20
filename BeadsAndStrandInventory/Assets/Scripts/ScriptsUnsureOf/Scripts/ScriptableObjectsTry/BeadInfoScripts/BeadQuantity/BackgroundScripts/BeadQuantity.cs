using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu]
public class BeadQuantity : ScriptableObject
{
    public int amethystRoughQuantity;
    public int lapisLazuliQuantity;
    public int sodaliteQuantity;
    public int aventurineQuantity;
    public int citrineQuantity;
    public int tigersEyeQuantity;
    public int carnelianQuantity;
    public int garnetQuantity;
    public int abaloneShellQuantity;
    public int clearQuartzQuantity;

    public List<int> beadQuantities = new List<int>();
}