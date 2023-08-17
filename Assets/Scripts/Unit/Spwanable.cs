using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum spwanType
{ 
    undefined,
    skill,
    unit
}

public class Spwanable : MonoBehaviour
{
    public spwanType type;    
    public int price; // 생산에 필요한 가격
    public float spwanCooltime; // 최소 생산 간격(초)
    public GameObject buttonPrefab;
}
