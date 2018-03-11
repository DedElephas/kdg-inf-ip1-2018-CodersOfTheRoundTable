using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class ItemManager
    {
        private List<Item> itemList;
        private int itemCounter;
        // voor test doeleinden()
        private Random random;

        public ItemManager()
        {
            this.itemList = new List<Item>();
            itemCounter = 0;
        }
        public ItemManager(List<Item> itemList)
        {
            this.itemList = new List<Item>();
            this.itemList = itemList;
            itemCounter = this.itemList.Count; // dit klopt niet, als een gebruiker midden weg is gehaald krijgen we overlappingen => dit moet met FindLast op te lossen zijn!
        }


        public void AddItem(Item item)
        {
            // Gebruik deze niet om fouten met itemcounter te voorkomen
            itemList.Add(item);
            itemCounter++;
        }
        public void AddItem(String itemNaam, double populariteit, int vermeldingen)
        {
            itemList.Add(new Item(itemCounter++, itemNaam, populariteit, vermeldingen));
        }

        public Item[] GetItems()
        {
            return itemList.ToArray();
        }

        public Item GetItem(int itemId)
        {
            return itemList.Find(item => item.itemId == itemId);
        }

        public void UpdateItems()
        {
            random = new Random();
            itemList.ForEach(item => item.Update(random.NextDouble(), random.Next(150)));
        }
    }
}
