using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyOneBehaviour : AllyBehaviour
{
    protected override void OnStart()
    {
        float[] range = new float[] { 5f, 7.5f, 10f };
        float[] damage = new float[] { 1f, 2f, 3f };
        float[] damageInstances = new float[] { 1f, 1f, 1f };
        float[] attackCooldown = new float[] { 1f, 0.9f, 0.8f };
        float[] skillDamage = new float[] { 3f, 4f, 5f };
        float[] skillDamageInstances = new float[] { 1f, 1f, 1f };
        float[] skillCooldown = new float[] { 10f, 7.5f, 5f};
        enemiesInRange = new List<GameObject>();
    }

    protected override void OnUpdate()
    {
        attackTimer += Time.deltaTime;
        skillTimer += Time.deltaTime;
        transform.Rotate(1, 1, 1);
    }

    public override void UseSkill()
    {
        if (skillTimer > skillCooldown[level]) {
            // Cast skill
            skillTimer = 0f;
        }
    }

    protected override void Attack()
    {
        if (attackTimer > attackCooldown[level] && enemiesInRange.Count > 0)
        {
            // Attack
            //enemiesInRange[0].Damage(damage[level]);
            attackTimer = 0f;
        }
    }
}
