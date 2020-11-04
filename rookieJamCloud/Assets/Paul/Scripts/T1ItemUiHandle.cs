using UnityEngine;
using System.Collections;

public class arrayDisplay : MonoBehaviour
{

    public int[] displayHolder;
    public int[] tempArray;
    public int counter;

    void Start()
    {

        for (int i = 0; i < 3; i++)
        {
            tempArray[i] = displayHolder[i];     
        }
        StartCoroutine(arrayDisplayer());

    }

    IEnumerator arrayDisplayer()
    {
        Debug.Log("tempArray" + tempArray[0]);
        Debug.Log("tempArray" + tempArray[1]);
        Debug.Log("tempArray" + tempArray[2]);
        yield return new WaitForSeconds(1);

        if (counter >= 9)
            counter = 0;
        else
            counter++;
        tempArray[0] = displayHolder[counter];    
        if (counter >= 9)
            counter = 0;
        else
            counter++;
        tempArray[1] = displayHolder[counter];    
        if (counter >= 9)
            counter = 0;
        else
            counter++;
        tempArray[2] = displayHolder[counter];   

        StartCoroutine(arrayDisplayer());
    }
}