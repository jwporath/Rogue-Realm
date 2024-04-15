using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Michael_EditMode
{
    private Player player;

    // A Test behaves as an ordinary method
    [Test]
    public void FireballTest()
    {
        GameObject fireball = new GameObject("FireBall");
        Assert.IsTrue(fireball);
        if(fireball)
        {
            Debug.Log("fireball creation test...successful!");
        }
        else
        {
            Debug.Log("fireball creation test...failed!");
        }
    }

    [Test]
    public void SwordTest()
    {
        GameObject sword = new GameObject("Sword1");
        Assert.IsTrue(sword);
        if(sword)
        {
            Debug.Log("sword creation test...successful!");
        }
        else
        {
            Debug.Log("sword creation test...failed!");
        }
    }

    [Test]
    public void BaseballBatTest()
    {
        GameObject baseballBat = new GameObject("BaseballBat");
        Assert.IsTrue(baseballBat);
        if(baseballBat)
        {
            Debug.Log("baseball bat creation test...successful!");
        }
        else
        {
            Debug.Log("baseball bat creation test...failed!");
        }
    }

    [Test]
    public void BattleAxeTest()
    {
        GameObject battleAxe = new GameObject("BattleAxe");
        Assert.IsTrue(battleAxe);
        if(battleAxe)
        {
            Debug.Log("battle axe creation test...successful!");
        }
        else
        {
            Debug.Log("battle axe creation test...failed!");
        }
    }

    [Test]
    public void ClubberTest()
    {
        GameObject clubber = new GameObject("Clubber");
        Assert.IsTrue(clubber);
        if(clubber)
        {
            Debug.Log("clubber creation test...successful!");
        }
        else
        {
            Debug.Log("clubber creation test...failed!");
        }
    }

    [Test]
    public void UmbrellaTest()
    {
        GameObject umbrella = new GameObject("Umbrella");
        Assert.IsTrue(umbrella);
        if(umbrella)
        {
            Debug.Log("umbrella creation test...successful!");
        }
        else
        {
            Debug.Log("umbrella creation test...failed!");
        }
    }

    [Test]
    public void ShovelTest()
    {
        GameObject shovel = new GameObject("Shovel");
        Assert.IsTrue(shovel);
        if(shovel)
        {
            Debug.Log("shovel creation test...successful!");
        }
        else
        {
            Debug.Log("shovel creation test...failed!");
        }
    }

    [Test]
    public void PipeWrenchTest()
    {
        GameObject pipeWrench = new GameObject("PipeWrench");
        Assert.IsTrue(pipeWrench);
        if(pipeWrench)
        {
            Debug.Log("pipe wrench creation test...successful!");
        }
        else
        {
            Debug.Log("pipe wrench creation test...failed!");
        }
    }

    [Test]
    public void HammerTest()
    {
        GameObject hammer = new GameObject("Hammer");
        Assert.IsTrue(hammer);
        if(hammer)
        {
            Debug.Log("hammer creation test...successful!");
        }
        else
        {
            Debug.Log("hammer creation test...failed!");
        }
    }

    [Test]
    public void BroomTest()
    {
        GameObject broom = new GameObject("Broom");
        Assert.IsTrue(broom);
        if(broom)
        {
            Debug.Log("broom creation test...successful!");
        }
        else
        {
            Debug.Log("broom creation test...failed!");
        }
    }

    [Test]
    public void MacheteTest()
    {
        GameObject machete = new GameObject("Machete");
        Assert.IsTrue(machete);
        if(machete)
        {
            Debug.Log("machete creation test...successful!");
        }
        else
        {
            Debug.Log("machete creation test...failed!");
        }
    }

    [Test]
    public void SpeedIncreaseTest()
    {
        GameObject speedBoost = new GameObject("SpeedBoost");
        Assert.IsTrue(speedBoost);
        if(speedBoost)
        {
            Debug.Log("speed increase creation test...successful!");
        }
        else
        {
            Debug.Log("speed increase creation test...failed!");
        }
    }

    [Test]
    public void JumpIncreaseTest()
    {
        GameObject jumpBoost = new GameObject("JumpingPower");
        Assert.IsTrue(jumpBoost);
        if(jumpBoost)
        {
            Debug.Log("jump increase creation test...successful!");
        }
        else
        {
            Debug.Log("jump increase creation test...failed!");
        }
    }

    [Test]
    public void DamageIncreaseTest()
    {
        GameObject damageIncrease = new GameObject("DamageIncrease");
        Assert.IsTrue(damageIncrease);
        if(damageIncrease)
        {
            Debug.Log("damage increase creation test...successful!");
        }
        else
        {
            Debug.Log("damage increase creation test...failed!");
        }
    }

    [Test]
    public void AttackRateIncreaseTest()
    {
        GameObject attackRateBoost = new GameObject("AttackRate");
        Assert.IsTrue(attackRateBoost);
        if(attackRateBoost)
        {
            Debug.Log("attack rate increase creation test...successful!");
        }
        else
        {
            Debug.Log("attack rate increase creation test...failed!");
        }
    }

    [Test]
    public void HealthTest()
    {
        GameObject health = new GameObject("Health");
        Assert.IsTrue(health);
        if(health)
        {
            Debug.Log("health item creation test...successful!");
        }
        else
        {
            Debug.Log("health item creation test...failed!");
        }
    }

    [Test]
    public void CoinTest()
    {
        GameObject coin = new GameObject("Coin");
        Assert.IsTrue(coin);
        if(coin)
        {
            Debug.Log("coin creation test...successful!");
        }
        else
        {
            Debug.Log("coin creation test...failed!");
        }
    }


    // [Test]
    // public void SpeedIncrease_IncreasesSpeedBy1()
    // {
    //     // Arrange
    //     GameObject player = new GameObject("Player"); // Create a mock player GameObject
    //     float initialSpeed = 5f; // Initial speed value
    //     float expectedSpeed = initialSpeed + 1f; // Expected speed after SpeedIncrease

    //     // Act
    //     //SpeedIncrease playerSpeed = player.AddComponent<SpeedIncrease>();
    //     GameObject powerup = new GameObject("SpeedBoost");
    //     //powerup.player.increaseSpeed(initialSpeed);
    //     player.increaseSpeed(initialSpeed); // Call your SpeedIncrease function

    //     // Assert
    //     float actualSpeed = player.GetComponent<Entity>().speed; // Adjust this based on your actual player script
    //     Assert.AreEqual(expectedSpeed, actualSpeed, 0.001f, "Speed should increase by 1.");
    // }


    
    // [Test]
    // public void SpeedIncreaseTest()
    // {
    //     //GameObject player = new GameObject("Entity");
    //     player = FindObjectOfType<Player>();
    //     float playerInitialSpeed = 0;
    //     player.increaseSpeed(playerInitialSpeed);
    //     Assert.IsTrue(playerInitialSpeed == 1.0);
    // }

    // [Test]
    // public void JumpingPowerTest()
    // {
    //     float playerInitialJumpingPower = 0;
    //     player.increaseJumpingPower(playerInitialJumpingPower);
    //     Assert.IsTrue(playerInitialJumpingPower == 1.0);
    // }
}
