using UnityEngine;

// Базовий клас Шлях
public class Path
{
    public void Stone()
    {
        Debug.Log("Path made of Stone() method");
    }
}


// Клас Плити, похідний від Шлях
public class Plate : Path
{
    new public void Stone()
    {
        Debug.Log("Plates made of Stone() method");
    }
}

// Клас Огорожа, похідний від Шлях
public class Border : Path
{
    new public void Stone()
    {
        Debug.Log("Fence made of Stone() method");
    }
}

// Приклад класу Сцена
public class SceneExample : MonoBehaviour
{
    void Start()
    {
        // Створюємо об'єкти різних класів
        Path path = new Path();
        Path plate = new Plate();
        Path border = new Border();

        path.Stone();
        plate.Stone();
        border.Stone();
    }
}
