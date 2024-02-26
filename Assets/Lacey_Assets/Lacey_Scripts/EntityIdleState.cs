using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class EntityIdleState : EntityState
{
    public override void EnterState(Entity entity){

    }
    public override void UpdateState(Entity entity){
        if(entity.horizontal!=0) {
            entity.currentState=entity.runState;
            entity.currentState.EnterState(entity);
        }
    }
    public override void FixedUpdateState(Entity entity){
        entity.rBody.velocity=new Vector2(entity.horizontal*entity.speed, entity.rBody.velocity.y);
    }
    public override void OnCollisionEnter(Entity entity){
        
    }
}
