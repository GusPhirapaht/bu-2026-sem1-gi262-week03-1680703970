using UnityEngine;

namespace Assignment.StudentSolution.LCT04
{
    public class Animal
    {
        public string name = "";
        protected string specie = "";
        private int health = 10;

        public void Feed(int food)
        {
            health += food;
            Debug.Log($"{name} got {food} food");
        }

        public void MakeSound()
        {
            if (health > 50)
            {
                Debug.Log($"{name} happy!");
            }
            else
            {
                Debug.Log($"{name} weak!");
            }
        }
    }

    public class Dog : Animal
    {
        public Dog(string name)
        {
            // protected → Dog สามารถเข้าถึงได้
            specie = "Dog";

            // public → Dog สามารถเข้าถึงได้
            this.name = name;

            // private → Dog เข้าถึงไม่ได้
            // health = 100; // ERROR
        }
    }

    public class LCT04AccessModifier
    {
        public void Start()
        {
            Dog dog = new Dog("Buddy");

            // public → เข้าถึงจากภายนอก class ได้
            Debug.Log($"my name is {dog.name}");

            dog.MakeSound();

            dog.Feed(50);

            dog.MakeSound();
        }
    }
}