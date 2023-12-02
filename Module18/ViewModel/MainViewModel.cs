using Module18.Model;
using Module18.Savers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Module18.ViewModel
{

    //ToDo
    //Задание 1
//    Что нужно сделать
//    По аналогии с разработанной в уроке 19.2 программой напишите программу, которая будет выводить данные по животным и
//    в которую можно добавлять новых животных.Реализуйте интерфейс с общими параметрами и опишите класс для создания списка животных по типам:

//млекопитающие;
//птицы;
//земноводные.
//Необходимо предусмотреть возможность добавления неизвестного типа животного.

//Советы и рекомендации
//Программа должна быть реализована в графическом интерфейсе.Определите самостоятельно общие параметры в интерфейсе.

//Что оценивается
//Применение паттерна «Фабрика».
//Использование интерфейса.
//Реализация графического интерфейса.
//Как отправить задание на проверку
//Сдайте работу в одном из этих форматов:

//Проект в архиве ZIP или RAR со всеми файлами.
//Ссылка на архив на Google Диске (или аналогах).
//Ссылка на репозиторий GitHub с исходным кодом домашнего задания.


//Задание 2
//Что нужно сделать
//Расширим программу из задания 1. Реализуйте классы для сохранения данных в разные форматы. 

//Советы и рекомендации
//Программа должна быть реализована в графическом интерфейсе. Выберите сами, в каком формате хранить данные.

//Что оценивается
//Применение паттерна “Фабрика”.
//Использование интерфейса.
//Реализация графического интерфейса.
//Использование внедрения зависимостей.
//Реализация графического интерфейса.
//Как отправить задание на проверку
//Сдайте работу в одном из этих форматов:

//Проект в архиве ZIP или RAR со всеми файлами.
//Ссылка на архив на Google Диске (или аналогах).
//Ссылка на репозиторий GitHub с исходным кодом домашнего задания.


//Задание 3
//Что нужно сделать
//Необходимо улучшить задачу из прошлого задания, используя паттерн MVP.Разделите логику и интерфейс. Программа должна уметь добавлять, удалять, изменять и сохранять данные.

//Советы и рекомендации
//Программа должна иметь графический интерфейс. Решите сами, где и как будут храниться данные.

//Что оценивается
//Реализован паттерн MVP.
//Выполняются операции добавления, удаления, изменения и сохранения записи.
    class MainViewModel: INotifyPropertyChanged
    {
        #region ПОЛЯ

        public event PropertyChangedEventHandler? PropertyChanged;

        private ObservableCollection<ICreature>? creatures;
        public ObservableCollection<ICreature>? Creatures
        {
            get { return creatures; }
            set { creatures = value;}
        }

        public string FileName { get; set; } = "listOfAnimals";


        private string animalClass = "Млекопитающие";

        public string AnimalClass
        {
            get { return animalClass; }
            set { animalClass = value;
                switch (value)
                {
                    case "Млекопитающие":
                        {
                            Name = "Тигр";
                            Description = "Полосатый хищник";
                            Age = 22;
                            break;
                        }
                    case "Земноводные":
                        {
                            Name = "Игуана";
                            Description = "Ящерицеобразное существо";
                            Age = 99;
                            break;
                        }
                    
                    default:
                        {
                            Name = "Страус";
                            Description = "Огромная птица, не умеет летать";
                            Age = 12;
                            break;
                        }
                }

            }
        }

       // public string AnimalClass { get; set; } = "Млекопитающие";

        public string SaveType { get; set; } = ".txt";

        private string animalsList;

        public string AnimalsList
        {
            get { return animalsList; }
            set { animalsList = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged(); }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; NotifyPropertyChanged(); }
        }
        private uint age;

        public uint Age
        {
            get { return age; }
            set { age = value;
                NotifyPropertyChanged();
            }
        }
        //public string Name { get; set; }
        //public string? Description { get; set; }
        //public uint Age { get; set; }
        #endregion

        #region КОМАНДЫ
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        AddToCollection(AnimalClass,Name,Description,Age);
                    }));
            }
        }
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                    (saveCommand = new RelayCommand(obj =>
                    {
                        MakeAListString();

                        ISaver converter;
                        switch (SaveType)
                        {
                            case ".json": 
                                {
                                    converter =new SaverToJson(FileName);
                                    break; 
                                }
                            case ".xmls":
                                {
                                    converter = new SaverToXmls(FileName);
                                    
                                    break; 
                                }
                            default:
                                {
                                    converter = new SaverToTxt(FileName);
                                    
                                    break;
                                }
                        }

                        ListSaver listSaver = new(converter);
                        listSaver.Save(AnimalsList);


                    }));
            }
        }
        #endregion

        #region МЕТОДЫ

        void MakeAListString()
        {
            AnimalsList = "Список животных:\n";
            foreach (var item in Creatures)
            {
                AnimalsList += $"{item.AnimalClass} {item.Name} : {item.Description}, возраст {item.Age} лет\n";

            }
        }
        void FillCollection()
        {
            Creatures.Add(CreatureFactory.CreateACreature("Млекопитающие", "Кошка", "Кошка обыкновенная", 2));
            Creatures.Add(CreatureFactory.CreateACreature("Млекопитающие", "Мышь", "Мышь обыкновенная", 7));
            Creatures.Add(CreatureFactory.CreateACreature("Земноводные", "Аллигатор", "Аллигатор обыкновенный", 55));
            Creatures.Add(CreatureFactory.CreateACreature("Птицы", "Снегирь", "Снегирь обыкновенный", 1));
            Creatures.Add(CreatureFactory.CreateACreature("Земноводные", "Ящерица", "Ящерица обыкновенная", 8));
            Creatures.Add(CreatureFactory.CreateACreature("Птицы", "Синица", "Синица обыкновенная", 3));
            Creatures.Add(CreatureFactory.CreateACreature("Рыбы", "Камбала", "Камбала морская", 3));
        }

        void AddToCollection(string animalClass, string name, string desc, uint age)
        {
            Creatures.Add(CreatureFactory.CreateACreature(animalClass, name, desc, age));
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public MainViewModel()
        {
            Creatures = new ObservableCollection<ICreature>();
            FillCollection();
            AnimalClass = "Млекопитающие";
        }        
    }
}
