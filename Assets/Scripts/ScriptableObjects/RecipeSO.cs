using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Scriptable Objects/Recipe")]
public class RecipeSO : ScriptableObject
{

    public List<KitchenObjectSO> kitchenObjectSOList;
    public string recipeName;
}
