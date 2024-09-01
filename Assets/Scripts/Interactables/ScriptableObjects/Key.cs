using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Key", menuName = "Keys/Key")]
public class Key : ScriptableObject
{
    [Header("Info")]
    public string keyName;
    public GameObject key;
}
