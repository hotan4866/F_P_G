using UnityEngine;

public class CharacterState
{
    // 현재 상태 저장
    public IState CurrentState { get; set; }

    // 변화 상태
    public void Transition(IState state)
    {
        if (state == null) // 널처리
        {
            Debug.Log("state가 Null입니다.");
            return;
        }

        if (CurrentState == state) // 
        {
            Debug.Log("이미 해당되는 상태입니다");
            return;
        }

        if (CurrentState != null)
        {
            CurrentState.ExitState();
        }

        CurrentState = state;

        CurrentState.EnterState();
    }
}
