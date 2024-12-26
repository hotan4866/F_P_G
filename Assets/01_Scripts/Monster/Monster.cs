using UnityEngine;

public class Monster : MonoBehaviour
{
    private MonsterState _monsterState;

    public Animator _animator;


    public IState idleState;
    public IState runState;

    public bool isRun;
    public bool isReady;

    public float AttackRange = 1f;
    public float AttackSpeed = 1f;

    private void Start()
    {
        _monsterState = new MonsterState();
        idleState = new IdleMonsterState(this, _monsterState);
        runState = new RunMonsterState(this, _monsterState);

        _animator = GetComponentInChildren<Animator>();

        _monsterState.CurrentState = idleState;
    }

    private void Update()
    {
        _monsterState.CurrentState.UpdateState();

        if (isReady)
        {

        }
        else
        {
            isRun = true;
        }
    }
}
