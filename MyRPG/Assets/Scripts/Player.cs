using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float health { get; set; }
    public string fullname { get; set; }

    private List<Core.Ailment> ailmentStack = new List<Core.Ailment>();
    private int ailmentCap = 50;

    #region Attributes
    private int strength = 0;
    private int dexterity = 0;
    private int intelligence = 0;
    #endregion

    #region Resistances
    private int fireResistance = 0;
    private int coldResistance = 0;
    private int lightningResistance = 0;
    private int armor = 0;
    #endregion

    #region Recoveries
    private float lifeRegen = 0;
    private float manaRegen = 0;
    private float lifeLeech = 0;
    private float manaLeech = 0;
    #endregion

    void TakeDamage(float damageAmount, Core.DamageType damageType, bool isMelee)
    {
        switch (damageType)
        {
            case Core.DamageType.Fire:

            case Core.DamageType.Cold:

            case Core.DamageType.Lightning:

            case Core.DamageType.Physical:

            case Core.DamageType.Arcane:

            default:
                break;
        }
    }

    void TakeAilmentDamage(Core.Ailment ailment) // adds ailment damage to the ailment stack
    {
        if (ailmentStack.Count! > ailmentCap)
        {
            ailmentStack.Add(ailment);
        }
    }

    void CalculateAttributes() // calculates attributes by reading the equipment and passive tree
    {
        // calculate defence attributes
        // calculate recovery attributes
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
