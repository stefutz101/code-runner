using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


public class QuizManager : MonoBehaviour {
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private int money;
    [SerializeField]
    private Text moneyText;

     void Start() {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0) {
           Debug.Log("RESTARTED");
           unansweredQuestions = questions.ToList<Question> ();
          }
          setCurrentQuestion ();
          updateScore ();
     }

     void updateScore() {
        moneyText.text = "Bani: " + money;
     }
     public void AddScore (int amount) {
          money += amount;
          updateScore();
     }

     void setCurrentQuestion() {
      int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
      currentQuestion = unansweredQuestions[randomQuestionIndex];

      questionText.text = currentQuestion.question;

     }

     void Transition() {

          unansweredQuestions.Remove(currentQuestion);
          //Application.LoadLevel ("Game");
          Start ();
     }

     public void UserSelectTrue() {
        if (currentQuestion.isTrue)
        {
            Debug.Log("correct");
            AddScore(50);
        }
        else
        {
            Debug.Log("incorrect");
            AddScore(-50);
        }
        Transition();
     }
     public void UserSelectFalse() {
          if (!currentQuestion.isTrue) {
           Debug.Log ("correct");
           AddScore (50);
          }
          else
           Debug.Log ("incorrect");
           AddScore(-50);
        Transition();
         }

}