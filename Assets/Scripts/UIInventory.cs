using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Pokemon.InventorySystem;
public class UIInventory : MonoBehaviour
{
    [SerializeField] private Image categoryIconImage;
    [SerializeField] private Text categoryText;

    [SerializeField] private Image currentItemIconImage;
    [SerializeField] private Text currentItemText;

    public void SetCategory(ItemData itemData)
    {
        categoryIconImage = itemData.Icon;
    }

}
