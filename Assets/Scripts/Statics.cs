using UnityEngine;

public class Tile
{
    // Static змінні спільні для всіх екземплярів класу
    public static int tileCount = 0;

    public Tile()
    {
        // Збільшуємо значення статичної змінної для відстеження кількості створених об'єктів
        tileCount++;
    }
}

public class Column : Tile
{
    // Конструктор класу Column, який також викликає конструктор базового класу Tile
    public Column() : base()
    {
        // Додатковий код для конструктора класу Column, якщо потрібно
    }
}

public class Game1 : MonoBehaviour
{
    void Start()
    {
        // Створюємо декілька об'єктів класу Tile та Column
        Tile tile1 = new Tile();
        Tile tile2 = new Tile();
        Column column1 = new Column();

        // Кількість об'єктів класу Tile та Column зараз доступна через їхні статичні змінні
        int numberOfTiles = Tile.tileCount;
        int numberOfColumns = Column.tileCount;
    }
}

// Клас Utilities з статичним методом
public static class Utilities
{
    // Статичний метод, який можна викликати без створення екземпляра класу
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}

// Клас Example, який використовує статичний метод з Utilities
public class UtilitiesExample : MonoBehaviour
{
    void Start()
    {
        // Можна викликати статичний метод Add без створення об'єкта класу Utilities
        int result = Utilities.Add(8, 5);
    }
}
