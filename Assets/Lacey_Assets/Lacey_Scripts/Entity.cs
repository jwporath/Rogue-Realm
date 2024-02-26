using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] public float horizontal;
    [SerializeField] public Rigidbody2D rBody;
    [SerializeField] public float speed, jumpingPower;

    public EntityState currentState;
    public EntityIdleState idleState=new EntityIdleState();
    public EntityRunState runState=new EntityRunState();
    public EntityJumpingState jumpingState=new EntityJumpingState();
    public EntityDeadState deadState=new EntityDeadState();

    void Start()
    {
        currentState=idleState;
        currentState.EnterState(this);
    }

}
