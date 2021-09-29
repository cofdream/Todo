using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TodoStateType : byte
{
    ToDo = 0,
    Doing,
    Done,
}

[System.Serializable]
public class Todo /*: UnityEngine.Object*/
{
    public TodoStateType StateType;
    public string Content;
    public DateTime dateTime;
}