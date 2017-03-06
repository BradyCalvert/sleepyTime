using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HaslLineExample))]
public class CustomHeroInspector : Editor {


    HaslLineExample myHero;
    public string[] myChoices = new string[] { "Damaging", "Healing" };
    public int mySpellChoice = 0;
    SerializedProperty myWeaponObj;
    private void OnEnable()
    {
        myHero = (HaslLineExample)target;
        myWeaponObj = serializedObject.FindProperty("myWeapon");
        mySpellChoice = myHero.mySpell.isDamaging ? 0 : 1;

    }
    public override void OnInspectorGUI()
    {
        DrawBaseInfo();
        DrawSpellInfo();
        DrawWeaponInfo();
       // base.OnInspectorGUI();
    }

    private void DrawBaseInfo()
    {
        EditorGUILayout.LabelField("Base Info", EditorStyles.boldLabel);
        EditorGUILayout.BeginVertical("Box");
        myHero.heroNamne = EditorGUILayout.TextField("Hero Name", myHero.heroNamne);

        myHero.healtghAmt = EditorGUILayout.IntSlider("Health: ", myHero.healtghAmt, 1, 100);
        Progressbar(myHero.healtghAmt / 100f, "Health");

        myHero.armorAmt = EditorGUILayout.IntSlider("Armor: ", myHero.armorAmt, 1, 60);
        Progressbar(myHero.armorAmt / 60f, "Health");

        myHero.manaPool = EditorGUILayout.IntSlider("Mana: ", myHero.manaPool, 1, 50);
        Progressbar(myHero.manaPool / 50f, "Health");
        EditorGUILayout.EndVertical();
    }

    private void DrawSpellInfo()
    {
        EditorGUILayout.LabelField("Spell Info", EditorStyles.boldLabel);
        EditorGUILayout.BeginVertical("Box");
        myHero.mySpell.spellName = EditorGUILayout.TextField("Spell name: ", myHero.mySpell.spellName);
        myHero.manaPool = EditorGUILayout.IntSlider("Mana cost: ,", myHero.manaPool, 1, 50);
        mySpellChoice = GUILayout.SelectionGrid(mySpellChoice, myChoices, 2);

        string s;
        if (mySpellChoice == 0)
            s = "Damage Amount. ";
        else
            s = "Healing Amount: ";
        myHero.mySpell.totalAmount = EditorGUILayout.IntSlider(s, myHero.mySpell.totalAmount, 1, 25);


        EditorGUILayout.EndVertical();
        myHero.mySpell.isDamaging = mySpellChoice == 0;
    }
    void DrawWeaponInfo()
    {
        EditorGUILayout.PropertyField(myWeaponObj);
    }

    void Progressbar(float value,string label)
    {
        Rect rect = GUILayoutUtility.GetRect(18,18,"TextField");
        EditorGUI.ProgressBar(rect, value, label);
    }

}
