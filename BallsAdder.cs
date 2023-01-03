using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsAdder : MonoBehaviour
{
    [SerializeField] private GameObject _ballPrefab;

    [SerializeField] private Transform _newBallsParent;

    public void AddANewBall() {
        BallsData ballsData = BallsData.Instance;
        if(ballsData.BallsCountAtScene < ballsData.MaximumBallsCount) {
            GameObject newBall = Instantiate(_ballPrefab, ballsData.GetPositionForNewBall(), Quaternion.identity, _newBallsParent);
            ballsData.BallsAtScene.Add(newBall);
            ballsData.SetTargetBallPositionIndexValue();
        }
    }
}
