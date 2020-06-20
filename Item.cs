using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Item
    {
        ushort itemID;
        String name;
       
        int cost; // цена
        ushort type; //тип предмета
        ushort volume; //количество
      





        public Item(ushort itemID,string name, int cost, int volume, int type)
        {
            this.itemID = itemID;
            if ((name == ""))
                throw new Exception("Все поля должны быть заполнены!");
            this.name = name;
               if (type < 0)
                throw new Exception("type >= 0 ");
            this.type = (ushort)type;
            if (volume < 0)
                throw new Exception("value >= 0 ");
            this.volume = (ushort)volume;
        }

        public ushort ItemID { get => itemID; set => itemID = value; }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public ushort Volume { get => volume; set => this.volume = value; }
        public ushort Type { get => type; set => type = value; }
        

        public override string ToString()
        {
            return itemID + "|" + name + "|"  + "|" + volume + "|" + type + "|" + cost + "|" ;
        }
    }
}
