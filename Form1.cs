using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Database
{
    public partial class Form1 : Form
    {
        WorkBD data = new WorkBD();
        string oldValue = "";
        string filename = "";

        public Form1()
        {
            InitializeComponent();
          
            comboBoxSort.Text = comboBoxSort.Items[0].ToString();
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.SaveToFile(filename);
            timerSave.Enabled = true;
            timerLabel.Start();
        }

       
        public ushort generateID()
        {
            ushort max = 0;
            for (int i = 0; i < data.ItemList.Count; i++)
            {
                Item item = (Item)data.ItemList[i];
                if (max < item.ItemID)
                {
                    max = item.ItemID;
                }
                
            }
            return (ushort)(max + 1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textName.Text;
                int cost = Convert.ToInt32(textCost.Text);
                ushort volume = (ushort)Convert.ToUInt32(textVolume.Text);
                ushort type = (ushort)Convert.ToUInt32(textType.Text);
                
                textName.Text = "";
                textCost.Text = "";
                textVolume.Text="";
                textType.Text = "";
                

                Item item = new Item(generateID(), name, cost, volume, type);
                data.AddItem(item);
                int n = data.ItemList.Count;

                table.Rows.Add(item.ItemID, name,  volume, type,  cost);
                int count = table.Rows.Count - 2;

                if ((!timerSave.Enabled) && (filename != ""))
                {
                    timerSave.Enabled = true;
                    timerSave.Start();
                }

              /*  switch (status)
                {
                    case 1:
                        table.Rows[count].Cells[9].Style.BackColor = Color.Gold;
                        break;
                    case 2:
                        table.Rows[count].Cells[9].Style.BackColor = Color.Violet;
                        break;
                    case 3:
                        table.Rows[count].Cells[9].Style.BackColor = Color.Gray;
                        break;
                }*/

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка: {exception.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = table.Rows.Count;
            foreach (DataGridViewRow row in table.SelectedRows)
            {
                int index = row.Index; // индекс выбранной строки
                if (index == count - 1) return;
                data.DeleteItem(index);
                table.Rows.RemoveAt(index);
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            if (data.ItemList.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите удалить все элементы?", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    data.DeleteItemList();
                    table.Rows.Clear();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if ((data.ItemList.Count == 0) || (textSearch.Text == ""))
                return;
            table.ClearSelection();
            List<int> foundElements = data.SearchItem(textSearch.Text);
            if (foundElements[0] == -1)
            {
                MessageBox.Show("Ничего не удалось найти!");
                return;
            }
            table.CurrentCell = table[0, foundElements[0]];
            for (int i = 0; i < foundElements.Count; i++)
            {
                table.Rows[foundElements[i]].Selected = true;
            }
        }


        private void table_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                oldValue = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int indRow = table.Rows[e.RowIndex].Index;
            int indColumn = table.Columns[e.ColumnIndex].Index;
            object value = table.Rows[indRow].Cells[indColumn].Value;
            // Если значение не было введено, то оставляем старое
            if (value is null)
            {
                MessageBox.Show("Вы не ввели значение.");
                table.Rows[indRow].Cells[indColumn].Value = oldValue;
                return;
            }

            switch(indColumn)
            {
                case 1:
                    data.ChangeName((string)value, indRow);
                    break;
             
                case 2:
                    try
                    {
                        data.ChangeValue((ushort)Convert.ToUInt32(value), indRow);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        table.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                    break;
                case 3:
                    try
                    {
                        data.ChangeType((ushort)Convert.ToUInt32(value), indRow);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        table.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                    break;
             
                case 4:
                    try
                    {
                        data.ChangeCost(Convert.ToInt32(value), indRow);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        table.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                    break;
                
               /* case 9:
                    try
                    {
                        data.ChangeStatus((ushort)Convert.ToInt32(value), indRow);
                        switch (Convert.ToInt32(value))
                        {
                            case 1:
                                table.Rows[indRow].Cells[9].Style.BackColor = Color.Gold;
                                break;
                            case 2:
                                table.Rows[indRow].Cells[9].Style.BackColor = Color.Violet;
                                break;
                            case 3:
                                table.Rows[indRow].Cells[9].Style.BackColor = Color.Gray;
                                break;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show($"Ошибка: {exception.Message}");
                        table.Rows[indRow].Cells[indColumn].Value = oldValue;
                    }
                    break;*/
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filename = saveFileDialog1.FileName;
                this.Text = filename + " - База данных предметов";
            }
            // Если сохранение произошло первый раз, то запускаем 
            // таймер для автосохранения
            if (!timerSave.Enabled)
            {
                timerSave.Enabled = true;
                timerSave.Start();
            }
            // При каждом сохранении будет появляться надпись "Сохранение..."
           
            timerLabel.Enabled = true;
            timerLabel.Start();
            data.SaveToFile(filename);
        }

        private void WriteToDataGrid()
        {
            for (int i = 0; i < data.ItemList.Count; i++)
            {
                Item item = (Item)data.ItemList[i];
                table.Rows.Add(item.ItemID, item.Name, item.Volume, item.Type,  item.Cost );
               /* switch (item.Status)
                {
                    case 1:
                        table.Rows[i].Cells[9].Style.BackColor = Color.Gold;
                        break;
                    case 2:
                        table.Rows[i].Cells[9].Style.BackColor = Color.Violet;
                        break;
                    case 3:
                        table.Rows[i].Cells[9].Style.BackColor = Color.Gray;
                        break;
                }*/
            }
            // последнюю строку запрещаем редактировать
            table.Rows[data.ItemList.Count].ReadOnly = true;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;
            this.Text = filename + " - База данных предметов";
            table.Rows.Clear();
            data.OpenFile(filename);
            WriteToDataGrid();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            if (comboBoxDirection.SelectedIndex == 0)
                data.Sort(SortDirection.Ascending, comboBoxSort.SelectedIndex);
            else
                data.Sort(SortDirection.Descending, comboBoxSort.SelectedIndex);
            WriteToDataGrid();
        }*/

        private void aboutTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Info = "item database, version 1.0" + "\n\n" +
                "creator: Gukov Ivan" + "\n\n" +
                "2020 г.";
            MessageBox.Show(Info, "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((data.ItemList.Count != 0) || (filename != ""))
            {
                DialogResult dialogResult = MessageBox.Show("Уверены," +
                    "что хотите создать новый файл?" + "\r\n" +
                    "Изменения в текущем не сохранятся!", "Подтверждение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Text = "База данных предметов";
                    filename = "";
                    data.DeleteItemList();
                    table.Rows.Clear();
                    timerSave.Stop();
                    timerSave.Enabled = false;
                    timerLabel.Stop();
                    timerLabel.Enabled = false;
                }
            }
        }

      
    }
}
