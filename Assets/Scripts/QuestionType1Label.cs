using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionType1Label : MonoBehaviour
{
    public Image correctionMark;
    public Image uncorrentionMark;
    public ToggleMark correctToggle;
    public List<ToggleMark> toggleMarks = new List<ToggleMark>();


    public void MarkIt(int index)
    {
        for (int i = 0; i < toggleMarks.Count; i++)
        {
            if (toggleMarks[i].index != index)
            {
                toggleMarks[i].isMarked = false;
                toggleMarks[i].checkMark.enabled = false;
            }
            else
            {
                toggleMarks[i].isMarked = true;
                toggleMarks[i].checkMark.enabled = true;
            }
        }
    }
    public void CheckAnswers()
    {
        for (int i = 0; i < toggleMarks.Count; i++)
        {
            if (toggleMarks[i].isMarked && toggleMarks[i] == correctToggle)
            {
                correctionMark.enabled = true;
                uncorrentionMark.enabled = false;
                break;
            }
            else if(toggleMarks[i].isMarked && toggleMarks[i] != correctToggle)
            {
                correctionMark.enabled = false;
                uncorrentionMark.enabled = true;
                break;
            }
            else
            {
                correctionMark.enabled = false;
                uncorrentionMark.enabled = false;
            }

        }
    }

    public void Clear()
    {
        correctionMark.enabled = false;
        uncorrentionMark.enabled = false;
        
        for (int i = 0; i < toggleMarks.Count; i++)
        {
            toggleMarks[i].checkMark.enabled = false;
            if (toggleMarks[i].isMarked)
                toggleMarks[i].isMarked = false;
        }
    }

    public void ShowHideAnswer(bool show)
    {
        if (show)
        {
            Clear();
            correctToggle.checkMark.enabled = true;
        }
        else
            Clear();
    }
}

