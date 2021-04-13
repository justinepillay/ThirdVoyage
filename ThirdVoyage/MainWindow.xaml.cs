using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ThirdVoyage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Main window for UI but also the orginator

        CareTaker careTaker = new CareTaker();
        private string state;


        public MainWindow()
        {
            InitializeComponent();
            state = txbContent.Text;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            
            saveToMemento();
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            //gets the last state
            Memento m = careTaker.getMemento();
            getStateFromMemento(m);
           
        }

        public Memento saveToMemento()
        {
            state = txbContent.Text;
            careTaker.add(new Memento(state));
            return new Memento(state);
        }

        public void getStateFromMemento(Memento memento)
        {
            //gets the state and populates the text box
            state = memento.getState();
            txbContent.Text = state;
        }



    }
}
