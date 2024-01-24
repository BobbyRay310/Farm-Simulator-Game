using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Ally", menuName = "AllyInfo")]
public class AllyData : ScriptableObject {
    public string AllyName;
    public int Health = 10;
    public float speed = 5f;
    public GameObject AllyModel; 
}

