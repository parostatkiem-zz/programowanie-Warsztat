using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkshopManager
{
    class Presenter
    {
        ImainView view;
        Model model;
        
        public Presenter(Model model, ImainView view)
        {
            this.model = model;
            this.view = view;
            view.loadData += _loadData;
            view.getAllCars += _getAllCars;
        }

        private void _loadData(bool obj)
        {
            try
            { model.LoadDataFromFiles(); }
            catch { MessageBox.Show("Nie udało się wczytać danych z pliku"); }
        }

        private List<Car> _getAllCars()
        {
            return model.Cars;
        }
    }
}
