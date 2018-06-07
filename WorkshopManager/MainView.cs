using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManager
{
    public partial class MainView : Form,ImainView
    {
        #region EVENTS
        public event Func<List<Car>> getAllCars;
        public event Action<bool> loadData;
        public event Action<bool> saveData;
        #endregion
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            loadData(true);
            listViewCars.Items.Clear();
            ListViewItem currentItem;
            foreach(Car c in getAllCars())
            {
                currentItem = new ListViewItem();
                currentItem.Tag = c;
                currentItem.Text = c.Brand;
                currentItem.SubItems.AddRange(new string[] { c.Model, c.Year.ToString(), c.ProblemAmount().ToString() });
                listViewCars.Items.Add(currentItem);
            }
        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentlySelectedCar() != null)
              DisplaySingleCarData(currentlySelectedCar());
        }

        private void DisplaySingleCarData(Car c)
        {
            comboBoxCarBrand.SelectedItem = c.Brand;
            tbCarEngine.Text = c.Engine;
            tbCarModel.Text = c.Model;
            numericUpDownCarYear.Value = c.Year;

            listViewCarProblems.Items.Clear();
            ListViewItem currentItem;
            foreach (CarProblem p in c.problems)
            {
                currentItem = new ListViewItem();
                currentItem.Tag = p;
                currentItem.Text = p.Name;

                currentItem.Checked = p.IsFixed;
                listViewCarProblems.Items.Add(currentItem);
            }
            ColorizeCarProblemList();

        }
        private void ColorizeCarProblemList()
        {
            foreach(ListViewItem i in listViewCarProblems.Items)
            {
                if (i.Checked)
                    i.ForeColor = Color.DarkGray;
                else
                    i.ForeColor = Color.Black;
            }
        }

        private Car currentlySelectedCar()
        {
            if (listViewCars.SelectedItems.Count <= 0 || listViewCars.SelectedItems[0].Tag == null) return null; //nic nei jest zaznaczone
            return listViewCars.SelectedItems[0].Tag as Car;

        }

        private void btnCarAddNewProblem_Click(object sender, EventArgs e)
        {
            if (tbNewCarProblemText.TextLength <= 0) return; //ERROR
            currentlySelectedCar().problems.Add(new CarProblem (tbNewCarProblemText.Text));
            tbNewCarProblemText.Text = "";
            DisplaySingleCarData(currentlySelectedCar());
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData(true);
        }
    }
}
