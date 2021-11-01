using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CSVScript : MonoBehaviour
{
    public TextAsset CSV;

    //CSVから分解した問題クラスを代入する配列
    public Question[]　questions = new Question[500];

    // Start is called before the first frame update
    void Start()
    {
        //CSVを各行で区切る
        string[] csv = CSV.text.Split('\n');
        Debug.Log(csv.Length);

        //全ての行の数だけループする（１行目から開始）
        for(int i = 1; i < csv.Length; i++)
        {
            //各行の要素を,で区切る
            string[] values = csv[i].Split(',');

            //０番目：カテゴリ
            string category = values[0];

            //１番目：レベル
            int level = 0;
            if (values[1] == "初級")
            {
                level = 1;
            }
            else if (values[1] == "中級")
            {
                level = 2;
            }
            else if (values[1] == "上級")
            {
                level = 3;
            }
            else
            {
                //初級、中級、上級以外の文字が入力されていたら、エラーを出す
                Debug.LogError(values[1] + "に初級、中級、上級の文字が入っている");
            }

            //２番目：問題文
            string questionText = values[2];

            //3~5番目：選択肢　配列でまとめる
            //values[3]A values[4]B values[5]C
            string[] answers = { values[3], values[4], values[5] };

            //６番目：正解の配列番号　Aが0、Bが1、Cが2
            int answerIndex = 0;
            if(values[6] == "A")
            {
                answerIndex = 0;
            }
            else if(values[6] == "B")
            {
                answerIndex = 1;
            }
            else
            {
                answerIndex = 2;
            }

            //７番目：解説
            string comment = values[7];

            Question q = new Question(category, level, questionText, answers, answerIndex, comment);

            //作成したquestionクラスを配列に入れる
            questions[i] = q;

            //全ての行の処理が終わればquestions配列に問題文が格納
            //最初の問題をみたい場合
            questions[1].ShowLog();

            GetComponent<Text>().text = questions[1].question;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
