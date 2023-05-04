using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "New PieceMovementData")]
public class PieceMovementDatas : ScriptableObject
{
    public string Name;
    public bool CanGoForward = true;
    public bool CanGoBackWard = true;
    public bool CanGoRight = true;
    public bool CanGoLeft = true;
    [TextArea]
    public string Description;
}
