using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScriptableBullet", menuName = "Bullet")]
public class ScriptableBullet : ScriptableObject
{
    [SerializeField] private int s_damage;
    [SerializeField] private int s_speed;
    [SerializeField] private string s_name;
    [SerializeField] private float s_coolDown;

    public int S_speed { get { return s_speed; } }

    public int S_damage { get { return s_damage; } }

    public float S_coolDown { get { return s_coolDown; } }

    public string S_name { get { return s_name; } }
}
