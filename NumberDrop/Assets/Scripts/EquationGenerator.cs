using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquationGenerator : MonoBehaviour
{
    public EquationGenerator instance;
    public enum GameMode {ZEN, CLASSIC, BASIC, MULTIONLY}

    public GameMode gameMode;
    public static int numberOne;
    public static int numberTwo;
    public int correctAnswer;
    public Text equationText;
    public Text wrongAnsText;
    public Text rightAnsText;
    public bool addition = true;

    public List<int> wrongAnswer;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GenerateRandomEquation();
        if (addition == true)
            equationText.text = numberOne.ToString() + "+" + numberTwo.ToString() + "=";
        else
            equationText.text = numberOne.ToString() + "x" + numberTwo.ToString() + "=";
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GenerateRandomEquation();
            if (addition == true)
                equationText.text = numberOne.ToString() + "+" + numberTwo.ToString() + "=";
            else
                equationText.text = numberOne.ToString() + "x" + numberTwo.ToString() + "=";

            GenerateWrongAnswer();
        }
        
    }



    void GenerateRandomEquation()
    {

        if (gameMode == GameMode.CLASSIC || gameMode == GameMode.ZEN)
        {
            int rnd = Random.Range(1, 100);
            if (rnd <= 75)
            {
                GenerateAddition();
                addition = true;
            }
            else
            {
                GenerateMultiplication();
                addition = false;
            }
        }

        if (gameMode == GameMode.MULTIONLY)
        {
            GenerateMultiplication();
            addition = false;
        }

        if (gameMode == GameMode.BASIC)
        {
            GenerateAddition();
        }


    }



    void GenerateMultiplication()
    {
        numberOne = Random.Range(0, 13);
        numberTwo = Random.Range(1, 13);
        correctAnswer = numberOne * numberTwo;

        Debug.Log(numberOne + "x" + numberTwo + "=" + correctAnswer); 

    }



    void GenerateAddition()
    {
        numberOne = Random.Range(0, 20);
        numberTwo = Random.Range(1, 20);
        correctAnswer = numberOne + numberTwo;

        Debug.Log(numberOne + "+" + numberTwo + "=" + correctAnswer);
       
    }
    

    /// <summary>
    /// Makes wrong answers within a range, ignoring correctAnswer
    /// </summary>
    void GenerateWrongAnswer()
    {
        for (int i = 0; i < wrongAnswer.Count; i++)
        {
            int dummy;
            do
            {
                dummy = Random.Range(correctAnswer - 5, correctAnswer + 5);
            }
            while (dummy == correctAnswer || wrongAnswer.Contains(dummy));
            wrongAnswer[i] = dummy;
            Debug.Log("Wrong Answer: " + wrongAnswer[i]);
        }
    }
}
