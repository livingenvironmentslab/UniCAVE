﻿/*
 * This class represents the toolManager object and keeps track of the different tool interfaces and shuffles between them as desired.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolManager2 : MonoBehaviour
{
    //Initialize member variables
    public List<ITool> list;
    public GameObject holder;
    public GameObject wandObject;
    public int toolNumber = 0;
    public Text tool;
    public GameObject canvas;

    /// <summary>
    /// Creates the toolManager object which holds a list of all ITOOL interfaces
    /// </summary>
    /// <param name="wandObject_"></param>
    /// <param name="holder_"></param>
    public ToolManager2(GameObject wandObject_, GameObject holder_)
    {
        holder = holder_;
        wandObject = wandObject_;
        list = new List<ITool>();

        //WarpTool warpObject = new WarpTool(wandObject_, holder_);
        //GrabberTool grabberObject = new GrabberTool(wandObject_, holder_);
        wandObject.AddComponent<GrabberTool>();
        wandObject.AddComponent<WarpTool>();
        wandObject.AddComponent<ButtonTool>();

        //fill the list with all the tool interfaces 
        list.Add(wandObject.GetComponent<WarpTool>());
        list.Add(wandObject.GetComponent<GrabberTool>());
        list.Add(wandObject.GetComponent<ButtonTool>());
    }

    /// <summary>
    /// Increments the tool number 
    /// </summary>
    public void NextTool()
    {
        list[toolNumber].shutDown();
        if (toolNumber + 1 >= list.Count)
        {
            toolNumber = 0;
        }
        else
        {
            toolNumber++;
        }
    }

    /// <summary>
    /// Decreases the tool number
    /// </summary>
    public void PreviousTool()
    {
        list[toolNumber].shutDown();
        if (toolNumber - 1 < 0)
        {
            toolNumber = list.Count -1;
        }
        else
        {
            toolNumber--;
        }

    }
}
