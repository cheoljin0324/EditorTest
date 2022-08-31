using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ImgResourceManager : EditorWindow
{
    Vector2 scrollPos = Vector2.zero;
    string labelSet = "Hello World";
    string labelButton = "";
    private Object SetObject = null;

    ImgResourceManager resourceManager;
    [MenuItem("SetEditor/ImgManager")]
    static void Init()
    {
        ImgResourceManager resourceManager = GetWindow<ImgResourceManager>();
        resourceManager.minSize = new Vector2(900, 900);
        resourceManager.maxSize = new Vector2(900, 900);
        resourceManager.Show();
    }

    private void OnGUI()
    {
        GUILayout.Label(labelSet, EditorStyles.boldLabel);
        GUILayout.BeginHorizontal(GUILayout.Height(200));
        labelButton = EditorGUILayout.TextField("Title", labelButton);

        if (GUILayout.Button("ShotButton", GUILayout.Width(100), GUILayout.Height(100)))
        {
            labelSet = "Default";
        }

        if (GUILayout.Button("SetTitle", GUILayout.Width(100), GUILayout.Height(100)))
        {
            labelSet = labelButton;
        }
        GUILayout.EndHorizontal();

       
        SetObject = EditorGUILayout.ObjectField("오브젝트", SetObject, typeof(Sprite), true);
    }

}
