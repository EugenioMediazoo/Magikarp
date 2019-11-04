using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceManager : MonoBehaviour
{
    //questions array
    private GameObject[] Questions;
    
    //value to skip
    public GameObject QuestionToSkip;
    private string Skip;

    public int I = 0;

    void Awake()
    {
        Questions = GameObject.FindGameObjectsWithTag("Question");

        
        Skip = QuestionToSkip.name;

        foreach (GameObject question in Questions)
        {
            if (question.name == Skip)
                continue;

            question.SetActive(false);
            Debug.Log("Q Number is named " + question.name);
        }

    }

    public void ActivateNext()
    {
        I = I + 1;

        for (int i=I; i < Questions.Length; i++)
        {
            
        }
    }

    void Update()
    {
        
    }

    public void ActivateNext(float IncreaseQ)
    {
        IncreaseQ = 1;
    }
}
