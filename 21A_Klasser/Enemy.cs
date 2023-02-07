using System;

public class Enemy
{
  public string name;
  public int hp = 100;

  public int Attack()
  {
    Console.WriteLine("Pow!");
    Random generator = new();
    return generator.Next(20);
  }
}
