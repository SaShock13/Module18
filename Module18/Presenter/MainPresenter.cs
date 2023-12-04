using Module18.Model;
using Module18.Savers;
using Module18.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Module18.Presenter
{
    class MainPresenter
    {
        IView View { get; set; }
        IModel rep;

        public MainPresenter(IView view)
        {
                this.View = view;
            rep = new Repository();
            View.Creatures = rep.Creatures;
        }
        public void DeleteAnimal(ICreature animal)
        {
            if (animal != null)
            {
                rep.Creatures.Remove(animal);
            } 
        }

        public void AddAnimal(ICreature animal)
        {
            rep.Creatures.Add(animal);
            
        }
        public void SaveToFile(ISaver converter)
        {
            rep.AnimalsList = "Список животных : \n";
            
            foreach (var item in rep.Creatures)
            {
                rep.AnimalsList += $"{item.AnimalClass} {item.Name} : {item.Description}, возраст {item.Age} лет\n";
            }
            

            ListSaver listSaver = new(converter);
            listSaver.Save(rep.AnimalsList);


        }
    }
}
