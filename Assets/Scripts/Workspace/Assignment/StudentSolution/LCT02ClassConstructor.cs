using UnityEngine;

// SKIP Lecture ...
namespace Assignment.StudentSolution.LCT02
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;

        // Constructor
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        public void Bark()
        {
            Debug.Log(name + " is barking");
        }

        public void WagTail()
        {
            Debug.Log(name + " is wagging tail");
        }

        public void StopBarking()
        {
            Debug.Log(name + " stopped barking");
        }
    }

    public class LCT02ClassConstructor
    {
        Dog dog1;

        public void Start()
        {
            // สร้าง object โดยใช้ Constructor
            dog1 = new Dog("Buddy", "Golden Retriever", 3);

            // เรียกใช้ method
            dog1.Bark();
            dog1.WagTail();
            dog1.StopBarking();
        }
    }
}