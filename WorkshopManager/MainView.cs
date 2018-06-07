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

            if (listViewCars.SelectedItems.Count<=0 || listViewCars.SelectedItems[0].Tag == null) return; //nic nei jest zaznaczone
            Car selectedCar = listViewCars.SelectedItems[0].Tag as Car;
            DisplaySingleCarData(selectedCar);

        }

        private void DisplaySingleCarData(Car c)
        {
            comboBoxCarBrand.SelectedItem = c.Brand;
            tbCarEngine.Text = c.Engine;
            tbCarModel.Text = c.Model;
            numericUpDownCarYear.Value = c.Year;
        }
    }
}
