using UnityEngine;

public interface IState
{
    // 상태 진입
    public void EnterState();

    // 상태 처리중
    public void UpdateState();

    // 상태 끝마침
    public void ExitState();
}
