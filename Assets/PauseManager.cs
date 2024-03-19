using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // �������� ���������� ������ "P" ��� �����
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    [SerializeField]
    public void TogglePause()
    {
        // ���� ����� �����
        isPaused = !isPaused;

        // ������� �� ���������� ��� � ��������� �� ����� �����
        if (isPaused)
        {
            Time.timeScale = 0f; // ��������� ��� � ��
        }
        else
        {
            Time.timeScale = 1f; // ³��������� ��� � ��
        }
    }

}
