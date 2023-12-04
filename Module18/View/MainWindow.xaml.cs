using System.Collections.ObjectModel;
using System.Security.AccessControl;
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
using Module18.Model;
using Module18.Presenter;
using Module18.Savers;
using Module18.View;

/// ToDo Реализоваиь изменение животного!

namespace Module18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        public ObservableCollection<ICreature> Creatures { get ; set; }
        MainPresenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            dgAnimals.ItemsSource = Creatures;
            delBtn.Click += (s,e)=>presenter.DeleteAnimal(dgAnimals.SelectedItem as ICreature);            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ICreature animal;
            switch (cbType.SelectedItem)
            {
                case "Млекопитающие": { animal = new Mammal(); break; }
                case "Земноводные": { animal = new Amphibian(); break; }
                case "Птицы": { animal = new Bird(); break; }

                default:
                    { animal = new NullCreature(); break; }

            }
            int age;
            animal.Name = tbName.Text;
            animal.Description = tbDesc.Text;
            Int32.TryParse(tbAge.Text,out age);
            animal.Age = (uint)age;

            presenter.AddAnimal(animal);
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            ISaver converter;
            switch (cbFileFormat.SelectedItem)
            {
                case ".json":
                    {
                        converter = new SaverToJson(tbFileName.Text);
                        break;
                    }
                case ".xmls":
                    {
                        converter = new SaverToXmls(tbFileName.Text);

                        break;
                    }
                default:
                    {
                        converter = new SaverToTxt(tbFileName.Text);

                        break;
                    }
            }
            presenter.SaveToFile(converter);
        }
    }
}