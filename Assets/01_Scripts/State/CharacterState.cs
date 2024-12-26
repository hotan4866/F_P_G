using UnityEngine;

public class CharacterState
{
    // ���� ���� ����
    public IState CurrentState { get; set; }

    // ��ȭ ����
    public void Transition(IState state)
    {
        if (state == null) // ��ó��
        {
            Debug.Log("state�� Null�Դϴ�.");
            return;
        }

        if (CurrentState == state) // 
        {
            Debug.Log("�̹� �ش�Ǵ� �����Դϴ�");
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
