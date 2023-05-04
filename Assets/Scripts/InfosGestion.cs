using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InfosGestion : MonoBehaviour
{
    [SerializeField] private PieceMovement _piece;
    [SerializeField] private TMP_Text _pieceName;
    [SerializeField] private TMP_Text _pieceForward;
    [SerializeField] private TMP_Text _pieceBackward;
    [SerializeField] private TMP_Text _pieceRight;
    [SerializeField] private TMP_Text _pieceLeft; 
    [SerializeField] private Button _pieceButtonForward;
    [SerializeField] private Button _pieceButtonBackward;
    [SerializeField] private Button _pieceButtonRight;
    [SerializeField] private Button _pieceButtonLeft;
    [SerializeField] private TMP_Text _pieceDescription;
    [SerializeField] private GameObject _buttonPanel;
    [SerializeField] private GameObject _infosPanel;

    public void ActivatePlayerUI(bool state)
    {
        UpdateInfos();
        _buttonPanel.SetActive(state);
        _infosPanel.SetActive(state);
    }

    public void UpdateInfos()
    {
        _pieceName.text = $"Type : {_piece.MovementData.Name}";
        _pieceForward.text = $"Le mouvement avant est {CheckMovement(_piece.MovementData.CanGoForward)}.";
        _pieceButtonForward.interactable = _piece.MovementData.CanGoForward;
        _pieceBackward.text = $"Le mouvement arrière est {CheckMovement(_piece.MovementData.CanGoBackWard)}.";
        _pieceButtonBackward.interactable = _piece.MovementData.CanGoBackWard;
        _pieceRight.text = $"Le mouvement vers la droite est {CheckMovement(_piece.MovementData.CanGoRight)}.";
        _pieceButtonRight.interactable = _piece.MovementData.CanGoRight;
        _pieceLeft.text = $"Le mouvement vers la gauche est {CheckMovement(_piece.MovementData.CanGoLeft)}.";
        _pieceButtonLeft.interactable = _piece.MovementData.CanGoLeft;
        _pieceDescription.text = $"Description : {_piece.MovementData.Description}";
    }

    private string CheckMovement(bool state)
    {
        if (state) 
        {
            return "possible";
        } else
        {
            return "impossible";
        }
    }
}
