using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "Ally", menuName = "AllyInfo")]
public class AllyData : ScriptableObject {
    public string AllyName;
    public int Health = 10;
    int maxHealth;
    public float speed = 5f;
    public GameObject AllyModel; 

}