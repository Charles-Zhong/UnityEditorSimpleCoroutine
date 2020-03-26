using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TestEditorCoroutine {
    
    [MenuItem("Tools/test editor coroutine")]
    static void DoTest()
    {
        TestEditor.Init();
    }
}

public class TestEditor : EditorWindow
{
    private static TestEditor instance;
    private static bool is_toggle = false;
    public static void Init()
    {
        if (instance == null)
        {
            //instance = EditorWindow.GetWindow<EditorWindow>("test") as TestEditor;
            instance = (TestEditor)EditorWindow.GetWindow<TestEditor>("test");
        }
        instance.position = new Rect(400, 200, 600, 400);
        instance.Show();
    }

    void OnGUI()
    {
        is_toggle = EditorGUILayout.Toggle(is_toggle);
        if (is_toggle)
        {
            EditorCoroutineRunner.StartEditorCoroutine(test());
        }
    }

    IEnumerator test()
    {
        yield return null;
    }
}