using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VectorScaleAttribute : PropertyAttribute
{
    public VectorScaleAttribute()
    {

    }
}
[CustomPropertyDrawer(typeof(VectorScaleAttribute))]
public class VectorScaleDrawer : PropertyDrawer
{
    public const int row = 17;
    float x = 0;
    float y = 0;
    float z = 0;

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) * 3.5f;
    }

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GameObject myObj = (GameObject)property.objectReferenceValue;
        Rect sliderPosition = position;
        sliderPosition.height = row;

        EditorGUI.LabelField(position, "Vector 3");

        float x = myObj.transform.localScale.x;
        float y = myObj.transform.localScale.y;
        float z = myObj.transform.localScale.z;

        x = EditorGUI.Slider(sliderPosition, x, 1f, 10f);
        y = EditorGUI.Slider(sliderPosition, y, 1f, 10f);
        z = EditorGUI.Slider(sliderPosition, z, 1f, 10f);

        myObj.transform.localScale = new Vector3(x, y, z);
    }

}
