using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Model
{
    class Repository:IModel
    {
        public ObservableCollection<ICreature> Creatures { get ; set; }
        public string AnimalsList { get; set; }

        public Repository()

        {
            Creatures = new ObservableCollection<ICreature>();
            FillCollection();
        }

        //void MakeAListString()
        //{
        //    AnimalsList = "Список животных:\n";
        //    foreach (var item in Creatures)
        //    {
        //        AnimalsList += $"{item.AnimalClass} {item.Name} : {item.Description}, возраст {item.Age} лет\n";

        //    }
        //}

        void FillCollection()
        {
            Creatures.Add(CreatureFactory.CreateACreature("Млекопитающие", "Кошка", "Кошка обыкновенная", 2));
            Creatures.Add(CreatureFactory.CreateACreature("Млекопитающие", "Мышь", "Мышь обыкновенная", 7));
            Creatures.Add(CreatureFactory.CreateACreature("Земноводные", "Аллигатор", "Аллигатор обыкновенный", 55));
            Creatures.Add(CreatureFactory.CreateACreature("Птицы", "Снегирь", "Снегирь обыкновенный", 1));
            Creatures.Add(CreatureFactory.CreateACreature("Земноводные", "Ящерица", "Ящерица обыкновенная", 8));
            Creatures.Add(CreatureFactory.CreateACreature("Птицы", "Синица", "Синица обыкновенная", 3));
            Creatures.Add(CreatureFactory.CreateACreature("Рыбы", "Камбала", "Камбала морская", 3));
            Creatures.Add(CreatureFactory.CreateACreature("Млекопитающие", "Слон", "Мамонтообразное животное с бивнями", 107));
            Creatures.Add(CreatureFactory.CreateACreature("Земноводные", "Варан", "Из разряда ящериц", 41));
            Creatures.Add(CreatureFactory.CreateACreature("Птицы", "Голубь", "Любит семки", 2));
        }

        //void AddToCollection(string animalClass, string name, string desc, uint age)
        //{
        //    Creatures.Add(CreatureFactory.CreateACreature(animalClass, name, desc, age));
        //}
        //private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }
}
