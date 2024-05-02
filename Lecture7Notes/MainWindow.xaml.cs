using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lecture7Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Joshua Saetern
    /// 05.01.2024
    /// Computer Programming II
    /// Lecture 7 Notes
    public partial class MainWindow : Window
    {
        List<String> listItems = new List<String> { "Charles", "Mimic", "Longsword", "Dylan", "Will", "Rafael" };

        List<String> dndList = new List<String> {
                "Healing Potion",
                "Longsword",
                "Chain Mail",
                "Dwarven Throwing Axe",
                "Spellbook",
                "Rope (50 ft.)",
                "Tinderbox",
                "Backpack",
                "Bedroll",
                "Flask of Alchemist's Fire"
            };

        List<String> cranes = new List<String>
            {
                "RT655",
                "RT865BXL",
                "GMK7450",
                "GMK5350",
                "RT635C"
            };
        List<List<String>> lists = new List<List<String>>();

        List<Person> people = new List<Person>();


        public MainWindow()
        {
            InitializeComponent();

            lists.Add(dndList);
            lists.Add(cranes);
            lists.Add(listItems);

            people.Add(new Person("Rafael", "Banderas", dndList));
            people.Add(new Person("Charles", "Conan", cranes));
            people.Add(new Person("Will", "Calvera", listItems));


            comboBox1.ItemsSource = people;
            comboBox1.SelectedIndex = 0;

            

            //ComboBox

            //Adding items to a ComboBox in code
            //comboBox1.Items.Add("Rafael");

            //Using the ItemsSource property
            //List<String> comboItems = new List<String> { "Rafael" };
            //comboBox1.ItemsSource = comboItems;

            //In XAML:
            //<ComboBox ItemsSource="{Binding MyItemsCollection}" />

            //ListBox

            /*
            Adding items to a ListBox in code
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            listBox1.Items.Add("Item 3");
            */

            //Using the ItemsSource 
            //listBox1.ItemsSource = listItems;

            //In XAML:
            //<ListBox ItemsSource="{Binding MyItemsCollection}" />

            //PopulateListBox(dndList, comboBox1.Items);
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Sets lblIndex and lblName to the current selected item in the listBox
            if (listBox1.SelectedIndex != null)
            {
                lblComboIndex.Content = listBox1.SelectedIndex;
                lblComboName.Content = listBox1.SelectedItem;
            }
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedComboIndex = comboBox1.SelectedIndex;

            listBox1.ItemsSource = people[selectedComboIndex].PersonaList;

            
        }
        
        public void PopulateListBox(List<String> items, ItemCollection icc)
        {
            icc.Clear();
            foreach (String item in items)
            {
                icc.Add(item);
            }
        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            //Grab the selected index from combobox
            int selectedFromCombo = comboBox1.SelectedIndex;

            //Grab the String from the text box
            String userValue = txtBox1.Text;

            //Access the selected persons list
            List<String> userList = people[selectedFromCombo].PersonaList;

            //Add the string to the selected persons list
            userList.Add(userValue);

            //Refresh the list box
            listBox1.Items.Refresh();

        }
    }
}