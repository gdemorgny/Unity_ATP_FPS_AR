using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New ChessGameData")]
public class ChessGameDatas : ScriptableObject
{
    public float _step = 0.06f;
    public float _animationDuration = 1f;
    public int _stepNumber = 7;

}
