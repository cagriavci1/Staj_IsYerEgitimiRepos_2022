using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColculatorScript : MonoBehaviour
{
    [SerializeField]
    Text inputField;

    string inputString;
    int[] number = new int[2];
    string operatorSembol;
    int i = 0;
    int result;
    bool displayResult = false;

    public void buttonPress()
    {
        if (displayResult == true)
        {
            inputField.text = "";
            inputString = "";
            displayResult = false;
        }

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;

        int arg;
        if(int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i++;
        }
        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSembol = buttonValue;
                    break;
                case "-":
                    operatorSembol = buttonValue;
                    break;
                case "*":
                    operatorSembol = buttonValue;
                    break;
                case "/":
                    operatorSembol = buttonValue;
                    break;
                case "=":
                    switch (operatorSembol)
                    {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                        case "*":
                            result = number[0] * number[1];
                            break;
                        case "/":
                            result = number[0] / number[1];
                            break;
                    }
                    displayResult = true;
                    inputString = result.ToString() ;
                    number = new int[2];
                    break;
                default:
                    Debug.Log("Hattali islem");
                    break;
                
            }
        }
        
        
        
        inputString =
        inputField.text = inputString;
    }
}
