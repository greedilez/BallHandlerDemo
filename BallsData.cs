using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsData : MonoBehaviour
{
    [SerializeField] private int _maximumBallsCount = 9;

    public int MaximumBallsCount{ get => _maximumBallsCount; }

    [HideInInspector] public List<GameObject> BallsAtScene = new List<GameObject>();

    public List<Transform> BallsPositions = new List<Transform>();

    public int BallsCountAtScene{ get => BallsAtScene.Count; }

    public static BallsData Instance = null;

    private void Awake() => Initalize();

    private int _targetBallPositionIndex = 0;

    private void Initalize() => Instance = this;

    public Vector3 GetPositionForNewBall() {
        _targetBallPositionIndex = (_targetBallPositionIndex < (_maximumBallsCount - 1)) ? _targetBallPositionIndex : (_maximumBallsCount - 1);
        return BallsPositions[_targetBallPositionIndex].position;
    }

    public void SetTargetBallPositionIndexValue(int value = 1) => _targetBallPositionIndex += value;
}
