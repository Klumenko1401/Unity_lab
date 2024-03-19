using System;

// Базовий клас Сцена
public class Scene
{
    public string Name { get; set; }

    // Конструктор класу
    public Scene(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {

    }
}

// Клас Плити, похідний від Сцена
public class Plates : Scene
{
    public int NumOfPlates { get; set; }

    // Конструктор класу
    public Plates(string name, int numOfPlates) : base(name)
    {
        NumOfPlates = numOfPlates;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
}

// Клас Огорожа, похідний від Плити
public class Fence : Plates
{
    public bool HasGate { get; set; }

    // Конструктор класу
    public Fence(string name, int numOfPlates, bool hasGate) : base(name, numOfPlates)
    {
        HasGate = hasGate;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
    }
}

// Клас Гра
public class Game
{
    public static void Main()
    {
        // Створюємо об'єкти різних класів
        Scene scene = new Scene("City Square");
        Plates plates = new Plates("Park", 20);
        Fence fence = new Fence("Backyard", 10, true);

        // Викликаємо метод DisplayInfo() для кожного об'єкта, використовуючи поліморфізм
        scene.DisplayInfo();

        plates.DisplayInfo();

        fence.DisplayInfo();
    }
}
