using System;

public class GameEntity
{
    
}
public interface IMovebable
{
    void Move();
}

public class  Player: GameEntity, IMovebable
{
    public void Move()
    {
        Console.WriteLine("Player moving");
    }
}

public class Wall : GameEntity
{

}

public class MovementSystem
{
    public void MoveEntity(IMovebable entity)
    {
        entity.Move();
    }
}

