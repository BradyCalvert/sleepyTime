using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaslLineExample : MonoBehaviour {

    public string heroNamne;

    public int armorAmt;
    public int healtghAmt;
    public int manaPool;

    public struct Spell
    {
        public string spellName;
        public int namaCostl;
        public bool isDamaging;
        public int totalAmount;

    }

   // public spell mySpell;
    public Spell mySpell;
    public WeaponClass myWeapon;

    void Start ()
    {


    }

    void Update()
    {

    }
}
