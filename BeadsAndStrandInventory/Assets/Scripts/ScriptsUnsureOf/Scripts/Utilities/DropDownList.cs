using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DropDownList : MonoBehaviour
{

}

//    //public Material myMaterial;
//    //public List<string> colorPropertyNames;
//    //public string selectedColorPropertyName;

//    //[ContextMenu("Test")]
//    //void Test()
//    //{
//        //colorPropertyNames = new List<string>();

//        int propertyCount = ShaderUtil.GetPropertyCount(myMaterial.shader);

//        for (int i = 0; i < propertyCount; i++)
//        {
//            string propertyName = ShaderUtil.GetPropertyName(myMaterial.shader, i);
//            ShaderUtil.ShaderPropertyType propertyType = ShaderUtil.GetPropertyType(myMaterial.shader, i);

//            if (propertyType == ShaderUtil.ShaderPropertyType.Color)
//            {
//                colorPropertyNames.Add(propertyName);
//            }
//        }

//        foreach (string colorPropertyName in colorPropertyNames)
//        {
//            Debug.Log("Color Property Name: " + colorPropertyName);
//        }
//    }
//}

//[CustomEditor(typeof(testScript))]
//public class TestScriptEditor : Editor
//{
//    private SerializedProperty myMaterialProperty;
//    private SerializedProperty colorPropertyNamesProperty;
//    private SerializedProperty selectedColorPropertyNameProperty;

//    private void OnEnable()
//    {
//        myMaterialProperty = serializedObject.FindProperty("myMaterial");
//        colorPropertyNamesProperty = serializedObject.FindProperty("colorPropertyNames");
//        selectedColorPropertyNameProperty = serializedObject.FindProperty("selectedColorPropertyName");
//    }

//    public override void OnInspectorGUI()
//    {
//        serializedObject.Update();

//        EditorGUILayout.PropertyField(myMaterialProperty);

//        // Get the list of color property names
//        var colorPropertyNames = new string[colorPropertyNamesProperty.arraySize];
//        for (int i = 0; i < colorPropertyNamesProperty.arraySize; i++)
//        {
//            colorPropertyNames[i] = colorPropertyNamesProperty.GetArrayElementAtIndex(i).stringValue;
//        }

//        // Get the selected color property index
//        int selectedColorIndex = Mathf.Max(0,
//            System.Array.IndexOf(colorPropertyNames, selectedColorPropertyNameProperty.stringValue));

//        // Display the dropdown menu
//        selectedColorIndex = EditorGUILayout.Popup("Color Property", selectedColorIndex, colorPropertyNames);

//        // Update the selected color property name
//        if (selectedColorIndex >= 0 && selectedColorIndex < colorPropertyNames.Length)
//        {
//            selectedColorPropertyNameProperty.stringValue = colorPropertyNames[selectedColorIndex];
//        }

//        serializedObject.ApplyModifiedProperties();
//    }
//}
