using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.ShortcutManagement;
using System.Reflection;

namespace null11
{
    public class TodoWindow : EditorWindow, IHasCustomMenu
    {
        [MenuItem("TodoWindow/Open")]
        static void Open()
        {
            GetWindow<TodoWindow>().Show();
        }
        public void AddItemsToMenu(GenericMenu menu)
        {

        }

        private TodoAsset todoAsset;


        private void OnGUI()
        {
            if (todoAsset == null)
            {
                todoAsset = FindObjectOfType<TodoAsset>();
            }

            //EditorGUILayout.ObjectField(todoAsset.Todos[0], typeof(Todo));

            //tt = GUILayout.Toggle(tt, new GUIContent("xxxx"), );
            //return;
            //GUILayout.BeginHorizontal();
            //{
            //    tt = GUILayout.Toggle(tt, new GUIContent("xxxx"), "box");

            //    //GUILayout.Box("xxxxx");

            //    GUILayout.FlexibleSpace();
            //}

            //GUILayout.EndHorizontal();
        }
    }
}