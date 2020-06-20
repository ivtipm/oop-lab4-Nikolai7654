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
        public void ChangeValue(ushort volume, int index)
        {
            Item it = (Item)itemList[index];
            if (volume < 0)
                throw new Exception("value >= 0 ");
            it.Volume = (ushort)volume;
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
        /// 
      
            /* public void ChangeStatus(ushort status, int index)
        {
            Item it = (Item)itemList[index];
            if ((status < 0)||(status > 3))
                throw new Exception("(status >= 0)or(status <=3)");
            it.Status = status;
        }
        */

     
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
                  
                    ushort volume = (ushort)Convert.ToInt32(dataFromFile[3]);
                    ushort type = (ushort)Convert.ToInt32(dataFromFile[4]);
                   
                    ushort cost = (ushort)Convert.ToInt32(dataFromFile[7]);
                   
                    //ushort status = (ushort)Convert.ToInt32(dataFromFile[9]);

                    Item item = new Item(id, name, cost, volume, type);
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
                    itemList.Sort(new ValueComparer(direction));
                    break;
               /* case 3:
                    itemList.Sort(new StatusComparer(direction));
                    break;*/
               
            }
            
        }
    }

    public enum SortDirection
    {
        Ascending,
        Descending
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
                item1.Volume.CompareTo(item2.Volume) :
                item2.Volume.CompareTo(item1.Volume);
        }
    }
   

  /*  public class StatusComparer : IComparer
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
    }*/

}
