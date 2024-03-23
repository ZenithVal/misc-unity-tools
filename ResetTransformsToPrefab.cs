//Euan

#if UNITY_EDITOR
using UnityEditor;

public class ResetTransformsToPrefab
{
    [MenuItem("CONTEXT/Transform/Revert Selected To Prefab", priority = 4999)]
    public static void ResetTransforms()
    {
        foreach (var obj in Selection.gameObjects)
            PrefabUtility.RevertObjectOverride(obj.transform, InteractionMode.UserAction);
    }
}
#endif