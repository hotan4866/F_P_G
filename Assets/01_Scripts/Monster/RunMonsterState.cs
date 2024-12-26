using UnityEngine;

public class RunMonsterState : IState
{
    private Monster _monster;
    private MonsterState _monsterState;

    public RunMonsterState(Monster monster, MonsterState monsterState)
    {
        _monster = monster;
        _monsterState = monsterState;
    }

    public void EnterState()
    {
        Debug.Log("EnterState RunMonsterState");
    }

    public void ExitState()
    {
        Debug.Log("ExitState RunMonsterState");
    }

    public void UpdateState()
    {
        Debug.Log("UpdateState RunMonsterState");
    }
}
