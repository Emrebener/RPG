using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    public float health { get; set; }
    public string fullname { get; set; }
    private List<Core.AilmentType> ailmentStack;

    #region Defence Attributes
    private int fireResistance = 0;
    private int coldResistance = 0;
    private int lightningResistance = 0;
    private int armor = 0;
    #endregion

    void TakeDamage(float damageAmount, Core.DamageType damageType, bool isMelee)
    {

    }

    void TakeAilmentDamage()
    {

    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
