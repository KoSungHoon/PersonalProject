using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct BattleStat 
{
    public float AP;//AttackPower ������
    public float DP;//DefensePower ����
    public float PP;//PlainHitPower ��Ÿ ���ݷ�
    public float SP;//SkillPower ��ų ���ݷ�
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
