﻿using UnityEngine;

[CreateAssetMenu(fileName = "Attack Configuration", menuName = "ScriptableObject/Attack Configuration")]
public class AttackScriptableObject : ScriptableObject
{
    public bool IsRanged = false;
    public int Damage = 5;
    public float AttackRadius = 1.5f;
    public float AttackDelay = 1.5f;

    // Ranged Configs
    public Bullet BulletPrefab;
    public Vector3 BulletSpawnOffset = new Vector3(0, 1, 0);
    public LayerMask LineOfSightLayers;

    public void SetupEnemy(Enemy enemy)
    {
        (enemy.AttackRadius.Collider == null ? enemy.AttackRadius.GetComponent<SphereCollider>() : enemy.AttackRadius.Collider).radius = AttackRadius;
        enemy.AttackRadius.AttackDelay = AttackDelay;
        enemy.AttackRadius.Damage = Damage;

        if (IsRanged)
        {
            RangedAttackRadius rangedAttackRadius = enemy.AttackRadius.GetComponent<RangedAttackRadius>();

            rangedAttackRadius.BulletPrefab = BulletPrefab;
            rangedAttackRadius.BulletSpawnOffset = BulletSpawnOffset;
            rangedAttackRadius.Mask = LineOfSightLayers;

            rangedAttackRadius.CreateBulletPool();
        }
    }
}
