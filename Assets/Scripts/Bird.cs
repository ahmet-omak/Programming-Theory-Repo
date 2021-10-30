using UnityEngine;

public class Bird : Animal
{
    public Bird()
    {
        InitAnimal();
    }

    public override void Execute()
    {
        Jump();
        Run();
        Walk();
    }

    protected override void InitAnimal()
    {
        Name = "Bird";
        Age = 2;
        Color = "Green-ish";
    }

    protected override void Jump()
    {
        Debug.Log($"{Name} says: I am jumping!");
    }

    protected override void Run()
    {
        Debug.Log($"{Name} says: I am running!");
    }

    protected override void Scream()
    {
        Debug.Log($"{Name} says: I can't scream!");
    }

    protected override void Walk()
    {
        Debug.Log($"{Name} says: I am walking");
    }
}
