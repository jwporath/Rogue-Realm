using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class EntityRunState : EntityState
{
    //private PlayerSounds sound;
    public override void EnterState(Entity entity){
        //sound = findObjectOfType<playerSounds>();
        //sound.moveSound();
    }
    public override void UpdateState(Entity entity){
        if(entity.horizontal==0f) {
            entity.currentState=entity.idleState;
            entity.currentState.EnterState(entity);
        }
    }
    public override void FixedUpdateState(Entity entity){
        entity.rBody.velocity=new Vector2(entity.horizontal*entity.speed, entity.rBody.velocity.y);
    }
    public override void OnCollisionEnter(Entity entity){

    }
}
