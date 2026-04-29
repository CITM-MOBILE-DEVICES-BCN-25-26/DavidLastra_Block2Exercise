using System;

public interface IClickable
{
    void Click();
}

public interface IHoverable
{
    void Hover();
}

public interface IDraggable
{
    void Drag();
}

public class InventoryButton : IClickable, IHoverable
{
    public void Click()
    {
        Console.WriteLine("Inventory Button Clicked!");
    }
    public void Hover()
    {
        Console.WriteLine("Hovering over Inventory Button.");
    }
}

public class InventoryItemSlot: IHoverable, IDraggable
{
    public void Hover()
    {
        Console.WriteLine("Hovering over Inventory Item Slot.");
    }
    public void Drag()
    {
        Console.WriteLine("Dragging Inventory Item Slot.");
    }
}