using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptablePool", menuName = "ObjectPool")]
public class ScriptablePool : ScriptableObject
{
    [SerializeField] private int s_amount;
    [SerializeField] private GameObject s_objectPrefab;
    [SerializeField] private string s_name;
    public List<GameObject> s_pooledObjects;
    public int s_updatedAmount;


    public int S_amount { get { return s_amount; } }
    public int S_updatedAmount { get { return s_updatedAmount; } }
    public GameObject S_objectPrefab { get { return s_objectPrefab; } }
    public string S_name { get { return s_name; } }
    public List<GameObject> S_pooledObjects { get { return s_pooledObjects; } }


}
