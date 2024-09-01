using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory")]
public class Inventory : ScriptableObject
{
    [Header("Items")]
    public List<Key> keys;
  

}
