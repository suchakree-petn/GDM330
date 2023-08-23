using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pokemon.InventorySystem
{
    public class InventoryPresenter : MonoBehaviour
    {
        public int currentItemIndex;
        public int currentCategoryIndex;

        public int page;
        public int maxItemIndex;
        public int maxCategoryIndex;

        //[SerializeField] private  List<CategoryData> categoryDataList = new List<CategoryData>();
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                PrevItem();
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                NextItem();
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                PrevCategory();
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {

                NextCategory();
            }
        }
        private void PrevItem()
        {
            if (currentItemIndex <= 0)
            {
                return;
            }
            currentItemIndex--;
        }
        private void NextItem()
        {
            if (currentItemIndex >= maxItemIndex)
            {
                return;
            }
            currentItemIndex++;
        }



        private void PrevCategory()
        {
            if (currentCategoryIndex <= 0)
            {
                return;
            }
            currentCategoryIndex--;


        }
        private void NextCategory()
        {
            if (currentCategoryIndex >= maxCategoryIndex)
            {
                return;
            }
            currentCategoryIndex++;

        }
        private void Refresh(){

        }

    }

}
