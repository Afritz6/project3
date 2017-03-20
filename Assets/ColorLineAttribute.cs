using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ColorLineAttribute : PropertyAttribute
{
   
    public ColorLineAttribute()
    {

    }
}

[CustomPropertyDrawer(typeof(ColorLineAttribute))]

public class ColorLineDrawer : DecoratorDrawer
{
    float color1;
    float color2;
    float color3;

    Color myColor;
    public override float GetHeight()
    {
        return base.GetHeight() * 2;
    }

    public override void OnGUI(Rect position)
    {
        Rect size;
        //myColor = new Vector3(color1, color2, color3);
        //myColor = EditorGUILayout.ColorField("New Color", myColor);
        //GUI.Label(size(10, 10, 10, 10), myColor);
    }
}
