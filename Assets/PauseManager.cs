using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Перевірка натискання клавіші "P" для паузи
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    [SerializeField]
    public void TogglePause()
    {
        // Зміна стану паузи
        isPaused = !isPaused;

        // Зупинка чи відновлення гри в залежності від стану паузи
        if (isPaused)
        {
            Time.timeScale = 0f; // Зупиняємо час в грі
        }
        else
        {
            Time.timeScale = 1f; // Відновлюємо час в грі
        }
    }

}
