using UnityEngine;
using System;

public abstract class Animal
{
    private new string name;
    private int age;
    private string color;

    protected string Name { get => name; set => name = value; }
    protected string Color { get => color; set => color = value; }
    protected int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 1)
            {
                age = 1;
            }
        }
    }

    protected abstract void InitAnimal();

    protected virtual void Jump()
    {
        throw new NotImplementedException();
    }

    protected virtual void Walk()
    {
        throw new NotImplementedException();
    }

    protected virtual void Scream()
    {
        throw new NotImplementedException();
    }

    protected virtual void Run()
    {
        throw new NotImplementedException();
    }

    public virtual void Execute()
    {
        Jump();
        Run();
        Walk();
        Scream();
    }
}
