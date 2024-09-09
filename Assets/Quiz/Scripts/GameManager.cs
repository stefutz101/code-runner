using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
public class GameManager : MonoBehaviour
{
    public Button raspunsButton1;
    public Button raspunsButton2;
    public Button raspunsButton3;
    public Button raspunsButton4;

    public Text textButton1;
    public Text textButton2;
    public Text textButton3;
    public Text textButton4;


    public question[] questions;

    public static List<question> unansweredQuestions;

    private List<question> answeredQuestions = new List<question>(); // Track answered questions
    private int correctAnswersCount = 0; // Track number of correct answers



    private question currentQuestion;



    [SerializeField]

    private Text factText;



    [SerializeField]

    private float timeBetweenQuestions = 1.0f;



    [SerializeField]

    //private Text trueAnswerText, falseAnswerText;



    //[SerializeField]

    //private Animator animator;



    void Start()

    {


        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {

            unansweredQuestions = questions.ToList<question>();

        }



        SetCurrentQuestion();

    }



    void SetCurrentQuestion()

    {

        int randomQuestionsIndex = Random.Range(0, unansweredQuestions.Count);
        //Debug.Log(unansweredQuestions.Count);

        currentQuestion = questions[randomQuestionsIndex];
        textButton1.text = currentQuestion.raspuns1;
        textButton2.text = currentQuestion.raspuns2;
        textButton3.text = currentQuestion.raspuns3;
        textButton4.text = currentQuestion.raspuns4;


        /*if (currentQuestion.isTrue)
        {

            trueAnswerText.text = "CORRECT";

            falseAnswerText.text = "WRONG";

        }
        else
        {

            trueAnswerText.text = "WRONG";

            falseAnswerText.text = "CORRECT";

        }
    */


        factText.text = currentQuestion.fact;





    }



    IEnumerator TranstionToNextQuestion()

    {

        yield return new WaitForSeconds(1.0f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }



    public void userSelectTrue()
    {

        correctAnswersCount++;

        if (correctAnswersCount >= 2)
        {
            SceneManager.LoadScene(1);
        } 
        else
        {
            StartCoroutine(TranstionToNextQuestion());
        }
    }

    public void userSelectFalse()
    {
        StartCoroutine(TranstionToNextQuestion());
    }

    public void SelectAnswer(int ans)
    {
        if(ans == currentQuestion.raspunsCorrect)
        {
            userSelectTrue();
        }
        else
        {
            userSelectFalse();
        }
    }
}
