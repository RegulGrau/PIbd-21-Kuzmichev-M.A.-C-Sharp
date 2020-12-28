using System;
using NLog;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FormTyeplovoz
{
    public partial class FormDepot : Form
    {
        private readonly DepotCollection depotCollection;
        private readonly Logger logger;

        public FormDepot()
        {
            InitializeComponent();
            depotCollection = new DepotCollection(pictureBoxDepot.Width, pictureBoxDepot.Height);
            logger = LogManager.GetCurrentClassLogger();
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
                try
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
                catch (DepotOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }
                catch (Exception ex)
                {
                   MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");
                }

            }
            return null;
        }
        private void listBoxDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли к депо { listBoxDepot.SelectedItem.ToString()}");
            Draw();
        }
        private void buttonAddDepot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDepotName.Text))
            {
                MessageBox.Show("Введите название депо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logger.Info($"Добавили депо {textBoxDepotName.Text}");
            depotCollection.AddDepot(textBoxDepotName.Text);
            ReloadLevels();

        }
        private void buttonDeleteDepot_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить депо {textBoxDepotName.Text}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили депо { (listBoxDepot.SelectedIndex+1).ToString()}");

                    depotCollection.DelDepot(textBoxDepotName.Text);
                    ReloadLevels();
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxDepot.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {

                    var train = depotCollection[listBoxDepot.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (train != null)
                    {
                        FormTyeplovoz form = new FormTyeplovoz();
                        form.SetLocomotive(train);
                        form.ShowDialog();
                        logger.Info($"Изъят поезд {train} с места { maskedTextBox.Text}");

                    }
                    Draw();
                }
                catch (DepotNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn("Поезда не найдено");


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка");

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depotCollection.SaveData(saveFileDialog.FileName);
                    {
                        MessageBox.Show("Successfully saved", "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при сохранении файла",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка при сохранении файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении файла");
                }
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    depotCollection.LoadData(openFileDialog.FileName);
                    {
                        MessageBox.Show("Loaded", "Result", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                        logger.Info("Загружено из файла " + openFileDialog.FileName);
                        ReloadLevels();
                        Draw();
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при загрузке из файла",
                       
                   MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                    logger.Warn("Ошибка при загрузке из файла");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при загрузке из файла");
                }
            }

        }
    }
    
}