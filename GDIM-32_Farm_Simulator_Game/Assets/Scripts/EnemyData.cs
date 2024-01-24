using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemyInfo")]
public class EnemyData : ScriptableObject {
    public string EnemyName;
    public int Health = 15;
    public float speed = 7f;
    public GameObject EnemyModel;

}