using System;

public interface IReward
{
    void GiveReward();
}

public class GiveCoins : IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Giving coins");
    }
}

public class GiveItems : IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Giving item");
    }
}

public class UnlockContent : IReward
{
    public void GiveReward()
    {
        Console.WriteLine("Unlocking content");
    }
}

public class  RewardSystem
{
    public void GiveReward(IReward reward)
    {
        reward.GiveReward();
    }
}