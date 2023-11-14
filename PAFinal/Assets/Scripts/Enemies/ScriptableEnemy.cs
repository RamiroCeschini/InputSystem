using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableEnemy", menuName = "Enemy")]
public class ScriptableEnemy : ScriptableObject
{
    [SerializeField] private string s_bulletType;
    [SerializeField] private float s_shootTime;
    [SerializeField] private float s_speed;
    [SerializeField] private int s_maxLife;

    public string S_bulletType { get { return s_bulletType; } }
    public float S_speed { get { return s_speed; } }
    public float S_shootTime { get { return s_shootTime; } }
    public int S_maxLife { get { return s_maxLife; } }
}
