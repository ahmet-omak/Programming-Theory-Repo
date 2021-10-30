using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Animal { Bee, Bird, Cat, Dog }

    public Animal animal;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (animal == Animal.Bee)
            {
                Bee bee = new Bee();
                bee.Execute();
            }
            else if (animal == Animal.Bird)
            {
                Bird bird = new Bird();
                bird.Execute();
            }
            else if (animal == Animal.Cat)
            {
                Cat cat = new Cat();
                cat.Execute();
            }
            else if(animal == Animal.Dog)
            {
                Dog dog = new Dog();
                dog.Execute();
            }
        }
    }
}
