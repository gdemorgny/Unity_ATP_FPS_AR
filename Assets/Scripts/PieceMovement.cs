using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PieceMovement : MonoBehaviour
{
    // pour toutes les pièces
    [SerializeField] private ChessGameDatas _gameData; 
    // lié au type de pièce
    public PieceMovementDatas MovementData;
    // Uniquement lié à la pièce
    private Animator _animator;
    private float _timerAnimation = 0f;
    private bool _isMoving = false;
    [SerializeField] private int _posX = 0;
    [SerializeField] private int _posZ = 0;
    [SerializeField] private int _actualPosX = 0;
    [SerializeField] private int _actualPosZ = 0;

    private void Start()
    {
        _animator = GetComponent<Animator>(); 
    }

    private void FixedUpdate()
    {
        if (_isMoving)
        {
            _timerAnimation += Time.fixedDeltaTime;
            if(_timerAnimation >= _gameData._animationDuration)
            {
                transform.localPosition = new Vector3(_posX * _gameData._step, 0f, _posZ * _gameData._step);
                _actualPosX = _posX;
                _actualPosZ = _posZ;
                _isMoving = false;
                _timerAnimation = 0f;
            }
            else
            {
                transform.localPosition = Vector3.Lerp(new Vector3(_actualPosX * _gameData._step, 0f, _actualPosZ * _gameData._step),
                                        new Vector3(_posX * _gameData._step, 0f, _posZ * _gameData._step),
                                        _timerAnimation/ _gameData._animationDuration);
            }
        }
    }

    public void MoveForward(bool direction = true)
    {
        if (!_isMoving)
        {
            if (direction )
            {
                if (MovementData.CanGoForward &&  _posX < _gameData._stepNumber)
                {
                    _posX++;
                    MovePiece();
                }
            }
            else 
            {
                if (MovementData.CanGoBackWard && _posX > 0 )
                {
                    _posX--;
                    MovePiece();
                }
            }
        }
    }
    public void MoveRight(bool direction = true)
    {
        if (!_isMoving)
        {
            if (direction)
            {
                if (MovementData.CanGoRight && _posZ > 0)
                {
                    _posZ--;
                    MovePiece();
                }
            }
            else 
            {
                if (MovementData.CanGoLeft && _posZ < _gameData._stepNumber)
                {
                    _posZ++;
                    MovePiece();
                }
            }
        }
    }

    private void MovePiece()
    {
        _isMoving = true;
        _animator.SetTrigger("StartMovement");
    }
}
