using UnityEngine;
using UnityEngine.UI;

public class PlateIconsSingleUI : MonoBehaviour
{
    
    [SerializeField] private Image image;

    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO)
    {
        // Logic to set the KitchenObjectSO for this icon
        image.sprite = kitchenObjectSO.sprite;
    }
}
