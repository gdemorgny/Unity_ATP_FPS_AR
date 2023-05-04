using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDirection : MonoBehaviour
{
    [SerializeField] private PieceMovement _pieceMovement;
    public void MoveForward()
    {
        _pieceMovement.MoveForward();
    }
    public void MoveBackward()
    {
        _pieceMovement.MoveForward(false);
    }

    public void MoveRight()
    {
        _pieceMovement.MoveRight();
    }
    public void MoveLeft()
    {
        _pieceMovement.MoveRight(false);
    }


}
