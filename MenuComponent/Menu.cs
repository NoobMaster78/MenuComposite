using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuComponent
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        String name;
        String description;

        public Menu(String name, String destription)
        {
            this.name = name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return menuComponents.ElementAt(i);
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }

        public override void print()
        {
            Console.WriteLine("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent menuComponent in menuComponents)
            {
                menuComponent.print();
            }

        } 
    }
}
