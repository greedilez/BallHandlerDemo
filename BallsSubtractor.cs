using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSubtractor : MonoBehaviour
{
    public void SubtractLastBall() {
        List<GameObject> ballsAtScene = BallsData.Instance.BallsAtScene;
        if(ballsAtScene.Count > 0) {
            int lastBallIndex = (ballsAtScene.Count - 1);
            GameObject lastBall = ballsAtScene[lastBallIndex];
            RemoveTargetBallFromList(lastBallIndex, ballsAtScene);
            DestoyTargetBall(lastBall);
            BallsData.Instance.SetTargetBallPositionIndexValue(-1);
        }
    }

    public void RemoveTargetBallFromList(int targetBallIndex, List<GameObject> currentBallsAtScene) => currentBallsAtScene.RemoveAt(targetBallIndex);

    public void DestoyTargetBall(GameObject targetBall) => Destroy(targetBall);
}
