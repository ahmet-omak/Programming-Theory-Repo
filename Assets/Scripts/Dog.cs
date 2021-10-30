using UnityEngine;

public class Dog : Animal
{
    public Dog()
    {
        InitAnimal();
    }

    protected override void InitAnimal()
    {
        Name = "Doggy";
        Age = 10;
        Color = "White-ish";
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
        Debug.Log($"{Name} says: Woof!");
    }

    protected override void Walk()
    {
        Debug.Log($"{Name} is walking");
    }

    public override void Execute()
    {
        Walk();
        Scream();
        Run();
        Jump();
    }
}
