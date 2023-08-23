using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pokemon.InventorySystem
{
    public class Inventory : MonoBehaviour

    {
        public List<ItemData> itemList = new List<ItemData>();
        public ItemData[] GetItemByType(ItemType targetType)
        {
            var resultList = new List<ItemData>();
            foreach (var item in itemList){
                if (item.Type == targetType){
                    resultList.Add(item);
                }
            }
            return resultList.ToArray();
        }
        public void Add(ItemData itemToAdd)
        {

        }
        public void Remove(ItemData itemToRemove)
        {

        }
    }

    [System.Serializable]
    public class ItemData
    {
        public string Name;
        public string Description;
        public Image Icon;
        public int Count;
        public ItemType Type;
    }
    public enum ItemType
    {

    }

}


