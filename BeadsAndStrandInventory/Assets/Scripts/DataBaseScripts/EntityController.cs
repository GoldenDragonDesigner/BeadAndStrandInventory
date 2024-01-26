using UnityEngine;
public class EntityController : MonoBehaviour
{
    private BeadInfo dbComponent;
    public Inventory beadPriceInInventory;
    public BeadPrice beadPrice;
    private void Start() => dbComponent = GetComponent<BeadInfo>();

    //Assign first entity
    public void AssignFirst() => Assign(0);
    //Assign previous entity
    public void AssignPrevious() => Assign(dbComponent.Entity == null ? 0 : dbComponent.Entity.Index - 1);
    //Assign next entity
    public void AssignNext() => Assign(dbComponent.Entity == null ? 0 : dbComponent.Entity.Index + 1);
    //Assign last entity
    public void AssignLast() => Assign(BeadInfo.MetaDefault.CountEntities - 1);

    private void Assign(int entityIndex)
    {
        //return if out of range
        if (entityIndex < 0 || entityIndex >= BeadInfo.MetaDefault.CountEntities) return;

        dbComponent.Entity = BeadInfo.MetaDefault.GetEntity(entityIndex);
        beadPriceInInventory.individualBeadPrices.Add(beadPrice.amountOfEachBead);
        beadPriceInInventory.individualBeadName.Add(beadPrice.beadName);
    }
}