using System;
using System.Drawing;
using System.Windows.Forms;
namespace FormTyeplovoz
{
    public partial class FormDepot : Form
    {
        private readonly DepotCollection depotCollection;
        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width, pictureBoxDepot.Height);
        }
        private void ReloadLevels()
        {
            int index = listBoxDepot.SelectedIndex;
            listBoxDepot.Items.Clear();
            for (int i = 0; i < depotCollection.Keys.Count; i++)
            {
                listBoxDepot.Items.Add(depotCollection.Keys[i]);
            }
            if (listBoxDepot.Items.Count > 0 && (index == -1 || index >= listBoxDepot.Items.Count))
            {
                listBoxDepot.SelectedIndex = 0;
            }
            else if (listBoxDepot.Items.Count > 0 && index > -1 && index < listBoxDepot.Items.Count)
            {
                listBoxDepot.SelectedIndex = index;
            }
        }
        private void Draw()
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depotCollection[listBoxDepot.SelectedItem.ToString()].Draw(gr);
                pictureBoxDepot.Image = bmp;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formLokomotiveConfig = new FormLokomotiveConfig();
            formLokomotiveConfig.AddEvent(AddTrain);
            formLokomotiveConfig.Show();
        }

        private Locomotive AddTrain(Locomotive train)
        {
            if (train != null && listBoxDepot.SelectedIndex > -1)
            {
                if ((depotCollection[listBoxDepot.SelectedItem.ToString()]) + train)
                {
                    
                    Draw();
                    return train;
                }
                else
                {
                    MessageBox.Show("Поезд не удалось поставить");
                }
            }
            return null;
        }
        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDepotName.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            depotCollection.AddDepot(textBoxDepotName.Text);
            ReloadLevels();

        }
        private void buttonDeleteDepot_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо {textBoxDepotName.Text}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    depotCollection.DelDepot(textBoxDepotName.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (train != null)
                {
                    FormTyeplovoz form = new FormTyeplovoz();
                    form.SetLocomotive(train);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depotCollection.SaveData(saveFileDialog.FileName))
                {
                   MessageBox.Show("Successfully saved", "Result",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Saving error", "Result",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (depotCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Loaded", "Result", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Loading error", "Result", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}