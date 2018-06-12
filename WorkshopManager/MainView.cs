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
    public enum CarEditorMode{Active, Done, New}
    public partial class MainView : Form,ImainView
    {
        #region EVENTS
        public event Func<List<Car>> getAllCars;
        public event Func<Car,bool> addNewCar;
        public event Func<Car,Car, bool> editCar;
        public event Action<bool> loadData;
        public event Action<bool> saveData;
        #endregion
        #region GENERATED_EVENTS
        private void MainView_Load(object sender, EventArgs e)
        {
           loadData(true);
           RefreshAllData();
           Mode = CarEditorMode.Active; //domyślnie pokazuj aktywne samochody do naprawy

        }

        private void listViewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCars.SelectedItems.Count <= 0) return;
            

            if (AreThereUnsavedChanges())
            {

                DialogResult dialogResult = MessageBox.Show("Wygląda na to, że rozpoczęto edycję danych. Czy na pewno chcesz je odrzucić?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (listViewCars.SelectedItems.Count <= 0 || listViewCars.SelectedItems[0].Tag == null) return; //nic nei jest zaznaczone
                    CurrentlySelectedCar = listViewCars.SelectedItems[0].Tag as Car;
                    currentlyEditedCar = currentlySelectedCar;
                    DisplaySingleCarData(currentlyEditedCar);
                }
            }
            else
            {
                if (listViewCars.SelectedItems.Count <= 0 || listViewCars.SelectedItems[0].Tag == null) return; //nic nei jest zaznaczone
                CurrentlySelectedCar = listViewCars.SelectedItems[0].Tag as Car;
                currentlyEditedCar = currentlySelectedCar;
                DisplaySingleCarData(currentlyEditedCar);
            }
              


        }



        private void btnCarAddNewProblem_Click(object sender, EventArgs e)
        {
            if (tbNewCarProblemText.TextLength <= 0) return; //ERROR
            currentlyEditedCar.problems.Add(new CarProblem(tbNewCarProblemText.Text));
            tbNewCarProblemText.Text = "";
            DisplaySingleCarData(currentlyEditedCar);
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData(true);
        }

        private void btnCarRemoveProblem_Click(object sender, EventArgs e)
        {

            if (listViewCarProblems.SelectedItems.Count <= 0 || listViewCarProblems.SelectedItems[0].Tag == null) return; //nic nei jest zaznaczone

            CarProblem p = listViewCarProblems.SelectedItems[0].Tag as CarProblem;
            try
            {
                currentlyEditedCar.problems.Remove(p);
            
            }
            catch { } //ERROR nie udalo sie usunąć problemu z listy
            DisplaySingleCarData(currentlyEditedCar);
        }

        private void comboBoxCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            //walidacja poprawnosci
            currentlyEditedCar.Brand = comboBoxCarBrand.SelectedItem.ToString();
        }

        private void tbCarModel_TextChanged(object sender, EventArgs e)
        {
            //walidacja poprawnosci
            currentlyEditedCar.Model = tbCarModel.Text;
        }

        private void tbCarEngine_TextChanged(object sender, EventArgs e)
        {
            //walidacja poprawnosci
            currentlyEditedCar.Engine = tbCarEngine.Text;
        }


        private void btnCarApplyChanges_Click(object sender, EventArgs e)
        {
            //jakaś walidacja czy coś
            Car tmp = CurrentlySelectedCar;
            tmp = currentlyEditedCar;
            RefreshAllData();
        }



        private void btnSwitchCarListMode_Click(object sender, EventArgs e)
        {
            if (Mode == CarEditorMode.Active)
            {
                Mode = CarEditorMode.Done;
                return;
            }
            if (Mode == CarEditorMode.Done)
                Mode = CarEditorMode.Active;
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            Mode = CarEditorMode.New;
        }

        private void comboBoxCarStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCarStatus.SelectedIndex == 0)
                currentlyEditedCar.IsDone = false;
            if (comboBoxCarStatus.SelectedIndex == 1)
                currentlyEditedCar.IsDone = true;
           // if(Mode!=CarEditorMode.New)
             //RefreshAllData();
        }
        #endregion
        #region PRIVATE
        private Car currentlyEditedCar = null;
        private void RefreshAllData()
        {
            Mode = Mode;
           
           // DisplaySingleCarData(CurrentlySelectedCar);
           

        }
        private void DisplaySingleCarData(Car c)
        {
           
            if (c == null)
            {
                groupBoxCarProperties.Visible = false;
                return;
            }
            else { groupBoxCarProperties.Visible = true; }
            currentlyEditedCar = c.Clone();

            comboBoxCarBrand.SelectedItem = c.Brand;
            tbCarEngine.Text = c.Engine;
            tbCarModel.Text = c.Model;
            numericUpDownCarYear.Value = c.Year;
            if (c.IsDone) comboBoxCarStatus.SelectedIndex = 1;
            else comboBoxCarStatus.SelectedIndex = 0;

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
            foreach (ListViewItem i in listViewCarProblems.Items)
            {
                if (i.Checked)
                    i.ForeColor = Color.DarkGray;
                else
                    i.ForeColor = Color.Black;
            }
        }

        private Car currentlySelectedCar;
        private Car CurrentlySelectedCar 
        {
            set
            {
                currentlySelectedCar=value;
            }
            get
            { 
               // if (Mode == CarEditorMode.New) return new Car();
                  return currentlySelectedCar;
            }

        }

        private bool AreThereUnsavedChanges()
        {
            Car original = CurrentlySelectedCar;
            if (original == null) return false;
            if (currentlyEditedCar != null && !currentlyEditedCar.Equals(original)) return true;
            return false;
        }
        private CarEditorMode _mode;
        private CarEditorMode Mode
        {
            get { return _mode; }
            set
            {
                if (AreThereUnsavedChanges())
                {
                    DialogResult dialogResult = MessageBox.Show("Wygląda na to, że rozpoczęto edycję danych. Czy na pewno chcesz je odrzucić?", "Potwierdzenie odrzucenia zmian", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                ListViewItem currentItem;
                switch (value)
                {
                    case CarEditorMode.Active:
                        lCarListHeader.Visible = true;
                        lCarListHeader.Text = "Lista samochdów do naprawy";
                        btnSwitchCarListMode.Text = "Przełącz na archiwum";
                        listViewCars.Visible = true;
                        btnAddNewCar.Visible = true;
                        btnCarApply.Visible = true;
                        btnSwitchCarListMode.Visible = true;
                        btnCarApply.Text = "Zapisz";
                        btnCarCancel.Visible = true;
                        listViewCars.Items.Clear();
                        ///List<Car> allCars = getAllCars();
                        foreach (Car c in getAllCars().Where(c => c!=null && !c.IsDone))
                        {
                            currentItem = new ListViewItem();
                            currentItem.Tag = c;
                            currentItem.Text = c.Brand;
                            currentItem.SubItems.AddRange(new string[] { c.Model, c.Year.ToString(), c.ProblemAmount().ToString() });
                            listViewCars.Items.Add(currentItem);
                        }
                        currentlyEditedCar = null;
                        DisplaySingleCarData(CurrentlySelectedCar);

                        break;
                    case CarEditorMode.Done:
                        lCarListHeader.Visible = true;
                        lCarListHeader.Text = "Lista naprawionych samochodów";
                        btnSwitchCarListMode.Text = "Przełącz na aktywne";
                        btnSwitchCarListMode.Visible = true;
                        listViewCars.Visible = true;
                        btnAddNewCar.Visible = true;
                        btnCarApply.Visible = false;
                        btnCarCancel.Visible = false;
                        listViewCars.Items.Clear();

                        foreach (Car c in getAllCars().Where(c => c.IsDone))
                        {
                            currentItem = new ListViewItem();
                            currentItem.Tag = c;
                            currentItem.Text = c.Brand;
                            currentItem.SubItems.AddRange(new string[] { c.Model, c.Year.ToString(), c.ProblemAmount().ToString() });
                            listViewCars.Items.Add(currentItem);
                        }
                        currentlyEditedCar = null;
                        DisplaySingleCarData(CurrentlySelectedCar);

                        break;
                    case CarEditorMode.New:
                        lCarListHeader.Visible = false;
                        btnSwitchCarListMode.Visible = false;
                        listViewCars.Visible = false;
                        btnAddNewCar.Visible = false;
                        btnCarApply.Visible = true;
                        btnCarApply.Text = "Dodaj";
                        btnCarCancel.Visible = true;
                        groupBoxCarProperties.Visible = true;
                        btnAddNewCar.Visible = false;

                        currentlySelectedCar = null;
                        currentlyEditedCar = new Car();
                        DisplaySingleCarData(currentlyEditedCar);

                        break;
                }
                  
                _mode = value;


            }
        }
        #endregion


        public MainView()
        {
            InitializeComponent();
        }

        private void btnCarApply_Click(object sender, EventArgs e)
        {

            //walidacja poprawności wprowadzonych danych
            if (Mode == CarEditorMode.New)
            {
                if (addNewCar(currentlyEditedCar))
                {
                    // RefreshAllData();
                    Mode = CarEditorMode.Active;
                }
            }
            if (Mode == CarEditorMode.Active)
            {
                //edycja samochodu
                // currentlySelectedCar = currentlyEditedCar;
                editCar(CurrentlySelectedCar, currentlyEditedCar);
                CurrentlySelectedCar = currentlyEditedCar;
                RefreshAllData();
            }
        }

        private void listViewCarProblems_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                var selectedItem = e.Item.Tag as CarProblem;
                if (selectedItem == null) return;

                selectedItem.IsFixed = e.Item.Checked;
            }
            catch { }

        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            currentlyEditedCar = currentlySelectedCar;
            DisplaySingleCarData(currentlySelectedCar);
        }
    }
}
