using UnityEngine;

public interface IState
{
    // ���� ����
    public void EnterState();

    // ���� ó����
    public void UpdateState();

    // ���� ����ħ
    public void ExitState();
}
