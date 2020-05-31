using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.IO;

namespace Database
{
    class WorkBD
    {
        ArrayList itemList = new ArrayList();

        public ArrayList ItemList
        {
            get
            {
                return itemList;
            }
        }
        /// <summary>
        /// Добавление предмета в коллекцию
        /// </summary>
        public void AddItem(Item item)
        {
            itemList.Add(item);
        }

        /// <summary>
        /// Удаление всей коллекции
        /// </summary>
        public void DeleteItemList() => itemList.Clear();

        /// <summary>
        /// Удаление элемента коллекции по индексу
        /// </summary>
        public void DeleteItem(int number) => itemList.RemoveAt(number);

        /// <summary>
        /// Изменить имя элемента
        /// </summary>
        public void ChangeName(string name, int index)
        {
            Item it = (Item)itemList[index];
            it.Name = name;
        }

        /// <summary>
        /// Изменить стоймость элемента
        /// </summary>
        public void ChangeCost(int cost, int index)
        {
            Item it = (Item)itemList[index];
            if (cost < 0)
                throw new Exception("cost >= 0 ");
            it.Cost = cost;
        }

        /// <summary>
        /// Изменить значение элемента
        /// </summary>
        public void ChangeValue(ushort value, int index)
        {
            Item it = (Item)itemList[index];
            if (value < 0)
                throw new Exception("value >= 0 ");
            it.Value = (ushort)value;
        }

        /// <summary>
        /// Изменить тип элемента
        /// </summary>
        public void ChangeType(ushort type, int index)
        {
            Item it = (Item)itemList[index];
            if (type < 0)
                throw new Exception("type >= 0 ");
            it.Type = type;
        }

        /// <summary>
        /// Изменить статус элемента
        /// </summary>
        public void ChangeStatus(ushort status, int index)
        {
            Item it = (Item)itemList[index];
            if ((status < 0)||(status > 3))
                throw new Exception("(status >= 0)or(status <=3)");
            it.Status = status;
        }

        /// <summary>
        /// Изменить прочность элемента
        /// </summary>
        public void ChangeDurability(ushort durability, int index)
        {
            Item it = (Item)itemList[index];
            if ((durability < 0)||(durability >100))
                throw new Exception("(durability >= 0)or(durability <= 100) ");
            it.Durability = durability;
        }

        /// <summary>
        /// Изменить spell элемента
        /// </summary>
        public void ChangeSpell(ushort spell, int index)
        {
            Item it = (Item)itemList[index];
            if (spell < 0)
                throw new Exception("spell >= 0");
            it.Spell = spell;
        }

        /// <summary>
        /// Изменить шанс элемента
        /// </summary>
        public void ChangeChance(ushort chance, int index)
        {
            Item it = (Item)itemList[index];
            if ((chance < 0) || (chance > 100))
                throw new Exception("(chance >= 0)or(chance <= 100) ");
            it.Chance = chance;
        }

        /// <summary>
        /// Изменить level элемента
        /// </summary>
        public void ChangeLevel(ushort level, int index)
        {
            Item it = (Item)itemList[index];
            if (level < 1)
                throw new Exception("level >= 1");
            it.Level = level;
        }

        /// <summary>
        /// Сохранение коллекции в файл
        /// </summary>
        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                foreach (Item s in itemList)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        /// <summary>
        /// Восстанавливает коллекцию, записанную в файл
        /// </summary>
        public void OpenFile(string filename)
        {
            if (!System.IO.File.Exists(filename))
                throw new Exception("Файл не существует");
            if (itemList.Count != 0)
                DeleteItemList();
            using (StreamReader sw = new StreamReader(filename))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);

                    ushort id = (ushort)Convert.ToInt32(dataFromFile[0]);
                    string name = dataFromFile[1];
                    ushort chance = (ushort)Convert.ToInt32(dataFromFile[2]);
                    ushort value = (ushort)Convert.ToInt32(dataFromFile[3]);
                    ushort type = (ushort)Convert.ToInt32(dataFromFile[4]);
                    ushort level = (ushort)Convert.ToInt32(dataFromFile[5]);
                    ushort durability = (ushort)Convert.ToInt32(dataFromFile[6]);
                    ushort cost = (ushort)Convert.ToInt32(dataFromFile[7]);
                    ushort spell = (ushort)Convert.ToInt32(dataFromFile[8]);
                    ushort status = (ushort)Convert.ToInt32(dataFromFile[9]);

                    Item item = new Item(id, name, cost, value, type, status, durability, spell, chance, level);
                    AddItem(item);
                }
            }
        }

        /// <summary>
        /// Поиск по заданному параметру и возвращение индексов найденных элементов
        /// Вернет -1, если элементы не найдены
        /// </summary>
        public List<int> SearchItem(string query)
        {
            List<int> count = new List<int>();
            ushort numQuery;
            if (ushort.TryParse(query, out numQuery))
            {
                for (int i = 0; i < itemList.Count; i++)
                {
                    Item item = (Item)itemList[i];
                    if (item.ItemID == numQuery) count.Add(i);
                }
                if (count.Count == 0)
                    count.Add(-1);
                return count;
            }

            query = query.ToLower(); // перевод в нижний регистр
            query = query.Replace(" ", "");
            for (int i = 0; i < itemList.Count; i++)
            {
                Item item = (Item)itemList[i];
                if (item.Name.ToLower().Replace(" ", "").Contains(query))
                    count.Add(i);
            }
            if (count.Count == 0)
                count.Add(-1);
            return count;
        }

        /// <summary>
        /// Сортировка по заданному параметру
        /// </summary>
        public void Sort(SortDirection direction, int n)
        {
            switch (n)
            {
                case 0:
                    itemList.Sort(new IDComparer(direction));
                    break;
                case 1:
                    itemList.Sort(new TypeComparer(direction));
                    break;
                case 2:
                    itemList.Sort(new LevelComparer(direction));
                    break;
                case 3:
                    itemList.Sort(new ValueComparer(direction));
                    break;
                case 4:
                    itemList.Sort(new StatusComparer(direction));
                    break;
                case 5:
                    itemList.Sort(new SpellComparer(direction));
                    break;
            }
            
        }
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }

    public class LevelComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public LevelComparer() : base() { }

        public LevelComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.Level.CompareTo(item2.Level) :
                item2.Level.CompareTo(item1.Level);
        }
    }

    public class TypeComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public TypeComparer() : base() { }

        public TypeComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.Type.CompareTo(item2.Type) :
                item2.Type.CompareTo(item1.Type);
        }
    }

    public class IDComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public IDComparer() : base() { }

        public IDComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.ItemID.CompareTo(item2.ItemID) :
                item2.ItemID.CompareTo(item1.ItemID);
        }
    }

    public class ValueComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public ValueComparer() : base() { }

        public ValueComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.Value.CompareTo(item2.Value) :
                item2.Value.CompareTo(item1.Value);
        }
    }
    public class SpellComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public SpellComparer() : base() { }

        public SpellComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.Spell.CompareTo(item2.Spell) :
                item2.Spell.CompareTo(item1.Spell);
        }
    }

    public class StatusComparer : IComparer
    {
        private SortDirection m_direction = SortDirection.Ascending;

        public StatusComparer() : base() { }

        public StatusComparer(SortDirection direction)
        {
            this.m_direction = direction;
        }

        int IComparer.Compare(object x, object y)
        {
            Item item1 = (Item)x;
            Item item2 = (Item)y;

            return (this.m_direction == SortDirection.Ascending) ?
                item1.Status.CompareTo(item2.Status) :
                item2.Status.CompareTo(item1.Status);
        }
    }

}
