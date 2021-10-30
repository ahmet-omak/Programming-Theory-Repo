using UnityEngine;

public class Bee : Animal
{
    public Bee()
    {
        InitAnimal();
    }

    public override void Execute()
    {
        Walk();
    }

    protected override void InitAnimal()
    {
        Name = "Bee";
        Age = 1;
        Color = "Yellow-ish";
    }

    protected override void Jump()
    {
        Debug.Log($"{Name} says: I can't jump!");
    }

    protected override void Run()
    {
        Debug.Log($"{Name} says: I can't run!");
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
