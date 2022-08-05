using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    public Text statement;
    public Text alternativeA;
    public Text alternativeB;
    public Text alternativeC;
    public Text alternativeD;
    public Text infoQuestion;

    public string[] statements;
    public string[] alternativesA;
    public string[] alternativesB;
    public string[] alternativesC;
    public string[] alternativesD;
    public string[] correctAnswers;

    private int questionId;

    private float correctQuestions;
    private float questions;
    private float average;
    private int finalGrade;

    public void InitializeQuestion()
    {
        statement.text = statements[questionId];
        alternativeA.text = alternativesA[questionId];
        alternativeB.text = alternativesB[questionId];
        alternativeC.text = alternativesC[questionId];
        alternativeD.text = alternativesD[questionId];
        infoQuestion.text = "Respondendo " + (questionId+1) + " de " + questions.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        questionId = 0;
        questions = statements.Length;
        InitializeQuestion();
    }

    public void Answer(string alternative)
    {
        if (alternative == "A") 
        {
            if (alternativesA[questionId] == correctAnswers[questionId])
            {
                correctQuestions += 1;
            }
        }
        else if (alternative == "B") 
        {
            if (alternativesB[questionId] == correctAnswers[questionId])
            {
                correctQuestions += 1;
            }
        }
        else if (alternative == "C") 
        {
            if (alternativesC[questionId] == correctAnswers[questionId])
            {
                correctQuestions += 1;
            }
        }
        else if (alternative == "D") 
        {
            if (alternativesD[questionId] == correctAnswers[questionId])
            {
                correctQuestions += 1;
            }
        }
        NextQuestion();
    }

    public void NextQuestion()
    {
        questionId += 1;
        if (questionId <= (questions-1))
        {
            InitializeQuestion();
        }
        else
        {
            average = 10 * (correctQuestions / questions);
            finalGrade = Mathf.RoundToInt(average);
        
            PlayerPrefs.SetInt("finalGradeTemp", finalGrade);
            PlayerPrefs.SetInt("correctQuestionsTemp", (int)correctQuestions);
            SceneManager.LoadScene("FinalGrade");
        }
    }
}
