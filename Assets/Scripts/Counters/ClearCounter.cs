using UnityEngine;

public class ClearCounter : BaseCounter
{

    [SerializeField] private KitchenObjectSO KitchenObjectSO;

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
            // There is a KitchenObject here
            if (player.HasKitchenObject())
            {
                // Player has a KitchenObject;
                if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
                {
                    // Player is holding a Plate
                    if (plateKitchenObject.TryAddIngredient(GetKitchenObject().GetKitchenObjectSO()))
                    {
                        GetKitchenObject().DestroySelf();
                    }

                }
                else
                {
                    // Player is not carrying Plate but something else
                    if (GetKitchenObject().TryGetPlate(out plateKitchenObject))
                    {
                        // Counter has a Plate
                        if (plateKitchenObject.TryAddIngredient(player.GetKitchenObject().GetKitchenObjectSO()))
                        {
                            player.GetKitchenObject().DestroySelf();
                        }
                    }
                    else
                    {
                        // Counter has a KitchenObject that is not a Plate
                        Debug.Log("Counter has a KitchenObject that is not a Plate.");
                    }
                }

            }
            else
            {
                // Player does not have a KitchenObject
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }

}
