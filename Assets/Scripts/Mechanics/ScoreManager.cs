using UnityEngine;
using TMPro; // Підключаємо TextMeshPro

public class ScoreManager : MonoBehaviour
{
    // Поле, яке з'явиться в Inspector. Сюди потрібно перетягнути ваш об'єкт "Score".
    public TextMeshProUGUI scoreText;

    private int score = 0;
    private const string scorePrefix = "SCORE: "; // Те, що буде перед числом

    void Start()
    {
        // Перевірка, чи встановлено посилання на Text
        if (scoreText == null)
        {
            Debug.LogError("Score Text не призначено у ScoreManager!");
        }

        // Встановлюємо початкове значення
        UpdateScoreDisplay();
    }

    // Публічна функція, яку ви будете викликати з інших скриптів
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
        Debug.Log("New Score: " + score); // Для перевірки в консолі
    }

    // Оновлення тексту на екрані
    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = scorePrefix + score.ToString();
        }
    }
}