using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Question 
{
    public string category;
    public int level;
    public string question;
    public string[] answers;
    public int answerIndex;
    public string comment;

    public Question(string category, int level, string question, string[]answers, int answerIndex, string comment)
    {
        this.category = category;
        this.level = level;
        this.question = question;
        this.answers = answers;
        this.answerIndex = answerIndex;
        this.comment = comment;
    }

    //確認用の関数
    public void ShowLog()
    {
        Debug.Log("カテゴリ:" + category + "難易度:" + level + "\n問題文:" + question + "\n選択肢A:" + answers[0] + "選択肢B:" + answers[1] + "選択肢C:" + answers[2] + "\n正解:" + answerIndex + "\n解説:" + comment);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
