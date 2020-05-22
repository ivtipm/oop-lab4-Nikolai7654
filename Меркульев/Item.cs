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
        ushort value; // значение
        ushort type; //тип предмета
        ushort status;//качество
        ushort durability; //прочность
        ushort spell;//способность
        ushort level;//уровень
        ushort chance;//шанс выпадения
        

        public Item(ushort itemID,string name, int cost, int value, int type, int status, int durability, int spell, int chance, int level)
        {
            this.itemID = itemID;
            if ((name == ""))
                throw new Exception("Все поля должны быть заполнены!");
            this.name = name;
            if (cost < 0)
                throw new Exception("cost >= 0 ");
            this.cost = cost;
            if (value < 0)
                throw new Exception("value >= 0 ");
            this.value = (ushort)value;
            if (type < 0)
                throw new Exception("type >= 0 ");
            this.type = (ushort)type;
            if ((status < 0) || (status > 3))
                throw new Exception("(status >= 0)or(status <=3)");
            this.status = (ushort)status;
            if ((durability < 0) || (durability > 100))
                throw new Exception("(durability >= 0)or(durability <= 100) ");
            this.durability = (ushort)durability;
            if (spell < 0)
                throw new Exception("spell >= 1");
            this.spell = (ushort)spell;
            if ((chance < 0) || (chance > 100))
                throw new Exception("(chance >= 0)or(chance <= 100) ");
            this.chance = (ushort)chance;
            if (level < 1)
                throw new Exception("level >= 1");
            this.level = (ushort)level;
        }

        public ushort ItemID { get => itemID; set => itemID = value; }
        public string Name { get => name; set => name = value; }
        public int Cost { get => cost; set => cost = value; }
        public ushort Value { get => value; set => this.value = value; }
        public ushort Type { get => type; set => type = value; }
        public ushort Status { get => status; set => status = value; }
        public ushort Durability { get => durability; set => durability = value; }
        public ushort Spell { get => spell; set => spell = value; }
        public ushort Chance { get => chance; set => chance = value; }
        public ushort Level { get => level; set => level = value; }

        public override string ToString()
        {
            return itemID + "|" + name + "|" + chance + "|" + value + "|" + type + "|" + level + "|" + durability + "|" + cost + "|" + spell + "|" + status;
        }
    }
}
