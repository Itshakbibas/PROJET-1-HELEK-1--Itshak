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
using BE;
using BL;

namespace PLWPF
{
    /// <summary>
    /// Logique d'interaction pour AddRequestWindow.xaml
    /// </summary>
    public partial class AddRequestWindow : Window
    {
        public GuestRequest currentRequest { get; set; }
        IBL bl;
        ComboBox area = TypeAreaOfTheCountry;


        public AddRequestWindow()
        {
            InitializeComponent();
            currentRequest = new GuestRequest();
            bl = FactoryBL.getBL();


            myCalendar = CreateCalendar();
            EntryDateCalendar.Child = null;
            EntryDateCalendar.Child = myCalendar;
            SetBlackOutDates();
        }

        private Calendar myCalendar;

        private Calendar CreateCalendar()
        {
            Calendar MonthlyCalendar = new Calendar();
            MonthlyCalendar.Name = "MonthlyCalendar";
            MonthlyCalendar.DisplayMode = CalendarMode.Month;
            MonthlyCalendar.SelectionMode = CalendarSelectionMode.SingleRange;
            MonthlyCalendar.IsTodayHighlighted = true;
            return MonthlyCalendar;
        }

        private void SetBlackOutDates()
        {
         //   foreach (DateTime date in C)
        }

        private void buttonRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                currentRequest.familyName = familyTextBox.Text;
                currentRequest.privateName = privateTextBox.Text;
                currentRequest.mailAddress = mailTextBox.Text;
                currentRequest.registrationDate = DateTime.Now;
                currentRequest.entryDate = familyTextBox.Text;
                currentRequest.releaseDate = familyTextBox.Text;
                currentRequest.adults= int.Parse(AdultsTextBox.Text);
                currentRequest.children = int.Parse(ChildrenTextBox.Text);
                currentRequest.typeArea = AreaComboBow.SelectedItem.;
                currentRequest.jacuzzi = JacuzziCheckBox.IsThreeState ? Options.optional : JacuzziCheckBox.IsChecked==true ? Options.yes : Options.no;
                currentRequest.pool = PoolCheckBox.IsThreeState ? Options.optional : PoolCheckBox.IsChecked == true ? Options.yes : Options.no;
                currentRequest.garden = GardenCheckBox.IsThreeState ? Options.optional : GardenCheckBox.IsChecked == true ? Options.yes : Options.no;
                currentRequest.childrenAttractions = ChildrenAttractionsCheckBox.IsThreeState ? Options.optional : ChildrenAttractionsCheckBox.IsChecked == true ? Options.yes : Options.no;
            }
            catch ()
            {

            }
        }
    }
}
