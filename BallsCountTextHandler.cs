using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallsCountTextHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text _ballsCountText;

    private void FixedUpdate() => UpdateBallsCountText();

    private void UpdateBallsCountText() => _ballsCountText.text = $"Current balls count: {BallsData.Instance.BallsCountAtScene}";
}
