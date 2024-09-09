using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public CharacterControll character;
    public GameObject world;

    public GameObject quiz;
    public GameObject puzzle;

    public void ToGame()
    {
        world.SetActive(true);
        quiz.SetActive(false);
        character.inainte = 0.25f;
    }

    public void ToQuiz()
    {
        world.SetActive(false);
        quiz.SetActive(true);
    }

    
    public void PuzzleToGame()
    {
        puzzle.SetActive(false);
        world.SetActive(true);
        character.inainte = 0.25f;
    }
}
