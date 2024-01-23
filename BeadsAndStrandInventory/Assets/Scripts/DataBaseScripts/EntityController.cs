using UnityEngine;
public class EntityController : MonoBehaviour
{
    private BeadPricing_BeadInfo dbComponent;
    private void Start() => dbComponent = GetComponent<BeadPricing_BeadInfo>();

    //Assign first entity
    public void AssignFirst() => Assign(0);
    //Assign previous entity
    public void AssignPrevious() => Assign(dbComponent.Entity == null ? 0 : dbComponent.Entity.Index - 1);
    //Assign next entity
    public void AssignNext() => Assign(dbComponent.Entity == null ? 0 : dbComponent.Entity.Index + 1);
    //Assign last entity
    public void AssignLast() => Assign(BeadPricing_BeadInfo.MetaDefault.CountEntities - 1);

    private void Assign(int entityIndex)
    {
        //return if out of range
        if (entityIndex < 0 || entityIndex >= BeadPricing_BeadInfo.MetaDefault.CountEntities) return;

        dbComponent.Entity = BeadPricing_BeadInfo.MetaDefault.GetEntity(entityIndex);
    }

    //private void AddBeadPrice(int entityIndex)
    //{
    //    if (entityIndex < 0 || entityIndex >= BeadPricing_BeadInfo.)
    //    dbComponent.Amount_Of_Each_Bead = 
    //}
}