using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{

    private int selectionIndex = 0;

    public List<GameObject> characters;


    // Use this for initialization
    void Start()
    {
        characters = new List<GameObject>();
        foreach (Transform t in transform)
        {
            characters.Add(t.gameObject);
        }

        foreach (GameObject ship in characters)
        {
            ship.SetActive(false);
        }
        nextShip();
    }

    public void nextShip()
    {
        characters[selectionIndex].SetActive(false);
        selectionIndex++;

        if (selectionIndex >= characters.Count)
        {
            selectionIndex = 0;
        }
        characters[selectionIndex].SetActive(true);

        //GameControl.instance.setShip(characters[selectionIndex]);
    }

    public void previousShip()
    {
        characters[selectionIndex].SetActive(false);
        selectionIndex--;
        if (selectionIndex < 0)
        {
            selectionIndex = characters.Count - 1;
        }

        characters[selectionIndex].SetActive(true);

        //GameControl.instance.setShip(characters[selectionIndex]);
    }
}
