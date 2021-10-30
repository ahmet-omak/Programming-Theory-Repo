using UnityEngine;

public class Cat : Animal
{
    public Cat()
    {
        InitAnimal();
    }

    protected override void InitAnimal()
    {
        Name = "Kitty";
        Age = 5;
        Color = "Grey-ish";
    }

    protected override void Jump()
    {
        Debug.Log($"{Name} is jumping");
    }

    protected override void Run()
    {
        Debug.Log($"{Name} is running");
    }

    protected override void Scream()
    {
        Debug.Log($"{Name} says: Mrrrrrr!");
    }

    protected override void Walk()
    {
        Debug.Log($"{Name} is walking");
    }
}
