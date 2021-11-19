using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour
{


    // �X�R�A�֘A
    public Text scoreText;
    private int score;
    public int currentScore;
    public int clearScore = 1500;

    // ����̒ǉ�
    // �^�C�}�[�֘A
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

    // �Q�[���J�n�O�̏�Ԃɖ߂�
    private void Initialize()
    {
        // �X�R�A��0�ɖ߂�
        score = 0;

    }

    // ����̒ǉ�
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

    // �X�R�A�̒ǉ�
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

    // GameOver�����Ƃ��̏���
    public void GameOver()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // GameClear�������̏���
    public void GameClear()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}