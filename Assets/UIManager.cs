using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// This script is used to control user interface of the game suach as game panel, animation, user input and warning
/// </summary>

public class UIManager : MonoBehaviour
{
    public GameData gameData;

   

    [Header("This area is for all hint and puzzle panel")]
    public Animator clue1;
    public Animator clue2;
    public Animator clue3;
    public Animator clue4;

    [Header("This area is for symbol")]
    public Animator symbol;


    [Header("This area is for all correct panel")]
    public Animator correct1;
    public Animator correct2;
    public Animator correct3;
    public Animator correct4;

    [Header("This area is for the puzzle input")]
    public InputField puzzleInput;
    public Text notificationDisplay;
    public InputField puzzleInput2;
    public Text notificationDisplay2;
    public InputField puzzleInput3;
    public Text notificationDisplay3;
    public InputField puzzleInput4;
    public Text notificationDisplay4;

    [Header("This part is for the puzzle answer, make sure you add the answer for your puzzle")]
    public string puzzleAnswer;
    public string puzzleAnswer2;
    public string puzzleAnswer3;
    public string puzzleAnswer4;

    [Header("Check this variable if this is the last puzzle room in the game")]
    public bool lastRoom = false;

    // Start is called before the first frame update
    void Start()
    {
        // Find game data object in the begining of the scene
        gameData = GameObject.FindGameObjectWithTag("data").GetComponent<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This is a fungtion to check puzzle 1 answer, if correct a new clue will be open and player can advance to the new map
    public void CheckingAnswer1(bool canAdvance)
    {
        if(puzzleInput.text == puzzleAnswer)
        {
            AnswerCorrect(canAdvance);
            SwitchCorrect1(true);
        }
        else
        {
            StartCoroutine(AnswerFalse());
        }
    }

    // This is a fungtion to check puzzle 2 answer, if correct a new clue will be open and player can advance to the new map
    public void CheckingAnswer2(bool canAdvance)
    {
        if (puzzleInput2.text == puzzleAnswer2)
        {
            AnswerCorrect(canAdvance);
            SwitchCorrect2(true);
        }
        else
        {
            StartCoroutine(AnswerFalse2());
        }
    }

    public void CheckingAnswer3(bool canAdvance)
    {
        if (puzzleInput3.text == puzzleAnswer3)
        {
            AnswerCorrect(canAdvance);
            SwitchCorrect3(true);
        }
        else
        {
            StartCoroutine(AnswerFalse3());
        }
    }

    public void CheckingAnswer4(bool canAdvance)
    {
        if (puzzleInput4.text == puzzleAnswer4)
        {
            AnswerCorrect(canAdvance);
            SwitchCorrect4(true);
        }
        else
        {
            StartCoroutine(AnswerFalse4());
        }
    }

    // This is a fungtion to activate a clue window 1
    public void SwitchClue1(bool isActive)
    {
        if (isActive)
        {
            clue1.Play("Window Enter");
        }
        else
        {
            clue1.Play("Window Exit");
        }
    }

    // This is a fungtion to activate a clue window 2
    public void SwitchClue2(bool isActive)
    {
        if (isActive)
        {
            clue2.Play("Window Enter");
        }
        else
        {
            clue2.Play("Window Exit");
        }
    }

    // This is a fungtion to activate a clue window 3
    public void SwitchClue3(bool isActive)
    {
        if (isActive)
        {
            clue3.Play("Window Enter");
        }
        else
        {
            clue3.Play("Window Exit");
        }
    }

    // This is a fungtion to activate a clue window 4
    public void SwitchClue4(bool isActive)
    {
        if (isActive)
        {
            clue4.Play("Window Enter");
        }
        else
        {
            clue4.Play("Window Exit");
        }
    }

    //This function is used to increase the game progression data and close all clue window the is open.
    //It is also serve to check if the last puzzle already solve or not, if yes then the game finish time will be calculated
    public void AnswerCorrect(bool continueMap)
    {
        if (continueMap && !lastRoom)
        {
            gameData.gamePhase++;
        }

       
        
        clue1.Play("Window Exit");
        clue2.Play("Window Exit");
        clue3.Play("Window Exit");
        clue4.Play("Window Exit");
    }

    public void CalculateFinishTime()
    {
        if (lastRoom)
        {
            gameData.CalculateFinishTime();
        }
    }

    //This coroutine is used to add a message for the player when player put a wrong answer in puzzle 1 input
    IEnumerator AnswerFalse()
    {
        string prev = notificationDisplay.text;

        notificationDisplay.text = "Nothing happen";
        notificationDisplay.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay.text = prev;
        notificationDisplay.color = Color.black;
    }

    //This coroutine is used to add a message for the player when player put a wrong answer in puzzle 2 input
    IEnumerator AnswerFalse2()
    {
        string prev = notificationDisplay2.text;

        notificationDisplay2.text = "Nothing happen";
        notificationDisplay2.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay2.text = prev;
        notificationDisplay2.color = Color.black;
    }

    IEnumerator AnswerFalse3()
    {
        string prev = notificationDisplay3.text;

        notificationDisplay3.text = "Nothing happen";
        notificationDisplay3.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay3.text = prev;
        notificationDisplay3.color = Color.black;
    }

    IEnumerator AnswerFalse4()
    {
        string prev = notificationDisplay4.text;

        notificationDisplay4.text = "Nothing happen";
        notificationDisplay4.color = Color.red;

        yield return new WaitForSeconds(1);
        notificationDisplay4.text = prev;
        notificationDisplay4.color = Color.black;
    }

    // This function is used to activate a clue when puzzle 1 answer is correct
    public void SwitchCorrect1(bool isActive)
    {
        if (isActive)
        {
            correct1.Play("Window Enter");
        }
        else
        {
            correct1.Play("Window Exit");
        }
    }

    // This function is used to activate a clue when puzzle 2 answer is correct
    public void SwitchCorrect2(bool isActive)
    {
        if (isActive)
        {
            correct2.Play("Window Enter");
        }
        else
        {
            correct2.Play("Window Exit");
        }
    }

    // This function is used to activate a clue when puzzle 3 answer is correct
    public void SwitchCorrect3(bool isActive)
    {
        if (isActive)
        {
            correct3.Play("Window Enter");
        }
        else
        {
            correct3.Play("Window Exit");
        }
    }

    // This function is used to activate a clue when puzzle 4 answer is correct
    public void SwitchCorrect4(bool isActive)
    {
        if (isActive)
        {
            correct4.Play("Window Enter");
        }
        else
        {
            correct4.Play("Window Exit");
        }
    }

    public void SwitchSymbol(bool isActive)
    {
        if (isActive)
        {
            symbol.Play("Window Enter");
        }
        else
        {
            symbol.Play("Window Exit");
        }
    }

}
