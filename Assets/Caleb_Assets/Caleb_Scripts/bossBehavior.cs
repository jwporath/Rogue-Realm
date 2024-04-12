using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossBehavior : enemyBehavior
{
    public override void forSakeOfBinding()
    {
        Debug.Log("Boss spawned");
    }
}
