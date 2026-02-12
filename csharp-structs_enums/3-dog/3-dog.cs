using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString()
    {
        string article = (rating == Rating.Excellent) ? "an" : "a";
        return $"My name is {name} and I am {age}. I am {article} {rating} dog. :)";
    }
}
