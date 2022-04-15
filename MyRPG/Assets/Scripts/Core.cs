using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    public enum AilmentType
    {
        Bleed,
        Poison,
        Burn
    }
    public enum DamageType
    {
        Fire, // Elemental damage
        Cold, // Elemental damage
        Lightning, // Elemental damage
        Physical,
        Arcane
    }
    public enum WeaponType
    {
        One Hand Sword,
        Two Hand Sword,
        One Hand Axe,
        Two Hand Axe,
        One Hand Mace,
        Two Hand Mace,
        Sceptre, // 1H
        Polearm, // 2H
        Bow,
        Crossbow,
        Hand Crossbow,
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
        Body Armor,
        Glove,
        Belt,
        Boot
    }

    public enum JewelryType
    {
        Ring,
        Amulet,
    }
}
