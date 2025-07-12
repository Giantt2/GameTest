using UnityEngine;

public class CuttingCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player has a KitchenObject, so we can give it to the counter
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                // Player does not have a KitchenObject

            }
        }
        else
        {
            if (player.HasKitchenObject())
            {
                // Player has a KitchenObject;
            }
            else
            {
                // Player does not have a KitchenObject
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
    
    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();

            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}

