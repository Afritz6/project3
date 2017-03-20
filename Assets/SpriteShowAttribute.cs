using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpriteShowAttribute : PropertyAttribute
{
    public SpriteShowAttribute()
    {

    }
}

[CustomPropertyDrawer(typeof(SpriteShowAttribute))]
public class SpriteShowDrawer : PropertyDrawer
{
    int myInt = 0;
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) * 3.5f;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUILayout.LabelField("Preview Size");
        myInt = EditorGUILayout.IntField(myInt);
        var sprite = property.objectReferenceValue as Sprite;
        if (sprite != null)
        {
            EditorGUI.DrawPreviewTexture(position, sprite.texture, null, ScaleMode.ScaleToFit, myInt);
        }
    }

}

