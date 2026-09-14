using System.Globalization;
using UnityEngine;

namespace Assignment.StudentSolution.LCT03
{
    public class Animal
    {
        public string name;

        public void MakeSound()
        {
            Debug.Log($"Animal {name} is making sound");
        }
    }

    // class Dog inherits from Animal
    public class Dog : Animal
    {
        public void Walk()
        {
            Debug.Log($"Dog {name} is walking");
        }
    }

    // class Bird inherits from Animal
    public class Bird : Animal
    {
        public void Fly()
        {
            Debug.Log($"Bird {name} is flying");
        }
    }

    public class LCT03Inheritance
    {
        public void Start()
        {
            // Dog
            Dog dog = new Dog();
            dog.name = "Buddy";

            dog.MakeSound();
            dog.Walk();

            // Bird
            Bird bird = new Bird();
            bird.name = "Twitty";

            bird.MakeSound();
            bird.Fly();
        }
    }
}