using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pokemon.InventorySystem
{
    public class UIItem : MonoBehaviour
    {
        [SerializeField] private Text itemNameText;
        [SerializeField] private Text countText;
        [SerializeField] private Image pointerImage;

        public void SetData(ItemData data)
        {
            itemNameText.name = data.Name;
            countText.name = data.Count.ToString();
            //pointerImage.gameObject.SetActive(false);
        }
    }

    public class UIItem_Data
    {
        public ItemData itemData;
        public bool isSelect;

        public UIItem_Data(ItemData itemData, bool isSelect)
        {
            this.itemData = itemData;
            this.isSelect = isSelect;
        }
    }
}

