using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{


    // スコア関連
    public Text scoreText;
    private int score;
    public int currentScore;
    public int clearScore = 1500;

    // 今回の追加
    // タイマー関連
    public Text timerText;

    public float gameTime = 60f;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {

        Initialize();

    }

    // Update is called once per frame
    void Update()
    {
        TimeManagement();

    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // スコアを0に戻す
        score = 0;

    }

    // 今回の追加
    public void TimeManagement()
    {

        gameTime -= Time.deltaTime;
        seconds = (int)gameTime;
        timerText.text = seconds.ToString();

        if (seconds == 0)
        {
            Debug.Log("TimeOut");
            GameOver();
        }

    }

    // スコアの追加
    public void AddScore()
    {
        score += 100;
        currentScore += score;
        scoreText.text = "Score: " + currentScore.ToString();

        Debug.Log(currentScore);

        if (currentScore >= clearScore)
        {
            GameClear();
            //Debug.Log(clearScore);
        }

    }

    // GameOverしたときの処理
    public void GameOver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // GameClearした時の処理
    public void GameClear()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}