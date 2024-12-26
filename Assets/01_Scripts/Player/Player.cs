using NUnit.Framework.Interfaces;
using UnityEngine;

public class Player : MonoBehaviour 
{
    private PlayerState _playerState;
    
    public Animator _animator;
    
    public IState idleState;
    public IState runState;

    public bool isRun;
    public bool isReady;

    public float AttackRange = 1f;
    public float AttackSpeed = 1f;

    private void Start()
    {
        _playerState = new PlayerState();
        idleState = new IdlePlayerState(this, _playerState);
        runState = new RunPlayerState(this, _playerState);

        _animator = GetComponentInChildren<Animator>();

        _playerState.CurrentState = idleState;
    }

    private void Update()
    {
        _playerState.CurrentState.UpdateState();

        if (isReady)
        {

        }
        else 
        {
            isRun = true;
        }
    }
}
