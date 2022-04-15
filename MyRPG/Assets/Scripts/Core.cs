using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    #region Ailments

    public enum AilmentType
    {
        Bleed,
        Poison,
        Burn
    }

    public class Ailment
    {
        AilmentType ailmentType;
        int duration;
        float damagePerSecond;

        public Ailment(AilmentType ailmentType, int duration, float damagePerSecond)
        {
            this.ailmentType = ailmentType;
            this.duration = duration;
            this.damagePerSecond = damagePerSecond;
        }
    }

    #endregion

    #region Item Types

    public enum WeaponType
    {
        OneHandSword,
        TwoHandSword,
        OneHandAxe,
        TwoHandAxe,
        OneHandMace,
        TwoHandMace,
        Sceptre, // 1H
        Polearm, // 2H
        Bow,
        Crossbow,
        HandCrossbow,
        Dagger, //1H
        Staff, // 2H
        Wand //1H
    }

    public enum OffHandType
    {
        Quiver,
        Orb,
        Shield
    }

    public enum ArmorType
    {
        Helmet,
        BodyArmor,
        Glove,
        Belt,
        Boot
    }

    public enum JewelryType
    {
        Ring,
        Amulet
    }

    #endregion

    public enum DamageType
    {
        Fire, // Elemental damage
        Cold, // Elemental damage
        Lightning, // Elemental damage
        Physical,
        Arcane
    }


}
