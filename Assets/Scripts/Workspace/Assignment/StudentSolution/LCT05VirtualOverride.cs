using UnityEngine;

namespace Assignment.StudentSolution.LCT05
{
    public class Animal
    {
        // 0. virtual method
        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        // 1. override MakeSound()
        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
    }

    public class Cat : Animal
    {
        // 2. override MakeSound()
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
    }

    public class LCT05VirtualOverride
    {
        public void Start()
        {
            // 3. Dog
            Dog dog = new Dog();
            dog.MakeSound();

            // 4. Cat
            Cat cat = new Cat();
            cat.MakeSound();

            // 5. Animal
            Animal animal = new Animal();
            animal.MakeSound();
        }
    }
}