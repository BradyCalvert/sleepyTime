using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomObjectAttribute : PropertyAttribute {
    public CustomObjectAttribute()
    {

    }


}


[CustomPropertyDrawer(typeof(CustomObjectAttribute))]
public class CustomObjectDrawer : PropertyDrawer
{
    CustomObjectAttribute CusObj
    {
        get { return ((CustomObjectAttribute)attribute); }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label);
    }
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {

        GameObject myObject = (GameObject)property.objectReferenceValue;
        //Rect drawPosition = m
       // drawPosition.height = drawPosition.height / 5;

        //EditorGUI.PropertyField(drawPosition, Transform,property.)
        base.OnGUI(position, property, label);
        //if (myObject!= null)

        //float myFloat = myObje
    }


}