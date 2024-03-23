//Zenithval w/Copilot
//2022 moved copy transforms to a new menu item. This adds back 2019 behavior.

#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public class CopyTransforms
{
    [MenuItem("CONTEXT/Transform/Copy Component", priority = 5000)]
    //adds to clipboard
    public static void copyTransforms(MenuCommand command)
    {
        Transform t = (Transform)command.context;
        string s = t.localPosition.x + "," + t.localPosition.y + "," + t.localPosition.z + "," + t.localRotation.x + "," + t.localRotation.y + "," + t.localRotation.z + "," + t.localRotation.w + "," + t.localScale.x + "," + t.localScale.y + "," + t.localScale.z;
        EditorGUIUtility.systemCopyBuffer = s;
    }

    [MenuItem("CONTEXT/Transform/Paste Component Values", priority = 5010)]
    //pastes from clipboard, should be greyed out if clipboard is empty
    public static void pasteTransforms(MenuCommand command)
    {
        Transform t = (Transform)command.context;
        string s = EditorGUIUtility.systemCopyBuffer;
        string[] values = s.Split(',');
        t.localPosition = new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2]));
        t.localRotation = new Quaternion(float.Parse(values[3]), float.Parse(values[4]), float.Parse(values[5]), float.Parse(values[6]));
        t.localScale = new Vector3(float.Parse(values[7]), float.Parse(values[8]), float.Parse(values[9]));
    }
}
#endif