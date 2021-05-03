using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class QuestionType1 : MonoBehaviour
{
    public List<QuestionType1Label> QuestionLabelList = new List<QuestionType1Label>();

    bool isAnswersShown = false;

    public void CheckAllAnswers()
    {
        foreach (var item in QuestionLabelList)
        {
            item.CheckAnswers();
        }
    }

    public void ClearAll()
    {
        foreach (var item in QuestionLabelList)
        {
            item.Clear();
        }
        isAnswersShown = false;
    }

    public void ShowHideAllAnswers()
    {
        foreach (var item in QuestionLabelList)
        {
            if (!isAnswersShown)
                item.ShowHideAnswer(true);

            else
                item.ShowHideAnswer(false);

        }

        if (!isAnswersShown)
            isAnswersShown = true;

        else
            isAnswersShown = false;
    }
}