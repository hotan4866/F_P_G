using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class IdleMonsterState : IState
{
    private Monster _monster;
    private MonsterState _monsterState;

    public IdleMonsterState(Monster monster, MonsterState monsterState)
    {
        _monster = monster;
        _monsterState = monsterState;
    }

    public void EnterState()
    {
        Debug.Log("EnterState IdleMonsterState");
    }

    public void ExitState()
    {
        Debug.Log("ExitState IdleMonsterState");
    }

    public void UpdateState()
    {
        Debug.Log("UpdateState IdleMonsterState");

        if (_monster.isRun)
        {
            _monsterState.Transition(_monster.runState);
        }
    }
}
