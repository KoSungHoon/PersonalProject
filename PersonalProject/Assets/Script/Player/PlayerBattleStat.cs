using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct BattleStat 
{
    public float AP;//AttackPower 전투력
    public float DP;//DefensePower 방어력
    public float PP;//PlainHitPower 평타 공격력
    public float SP;//SkillPower 스킬 공격력
    public float MaxHp;
}

[System.Serializable]
public struct Info 
{
    public BattleStat myBattleStat;
    public int Gold;
    public int Ruby;
}

public class PlayerBattleStat : MoveMent
{
    public Info myInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
