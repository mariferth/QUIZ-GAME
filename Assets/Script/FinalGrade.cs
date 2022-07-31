using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalGrade : MonoBehaviour
{
    public Text txtGrade;
    public Text txtInfo;

    private int grade;
    private int correctQuestions;

    // Start is called before the first frame update
    void Start()
    {
        grade = PlayerPrefs.GetInt("finalGradeTemp");
        correctQuestions = PlayerPrefs.GetInt("correctQuestionsTemp");

        txtGrade.text = grade.ToString() + " pts";
        txtInfo.text = "Você acertou " + correctQuestions.ToString() + " de 5 perguntas";

    }
}
