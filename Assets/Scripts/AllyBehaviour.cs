using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBehaviour : MonoBehaviour
{
    // Level
    protected int level = 1;

    // Attack
    protected float[] range;
    protected float[] damage;
    protected float[] damageInstances;
    protected float[] attackCooldown;
    protected float attackTimer = 0;

    // Skill
    protected bool autoCast = true;
    protected float[] skillDamage;
    protected float[] skillDamageInstances;
    protected float[] skillCooldown;
    protected float skillTimer = 0;

    // Targeting
    protected List<GameObject> enemiesInRange;

    private void Start()
    {
        OnStart();
    }

    protected virtual void OnStart()
    {
    }

    private void Update()
    {
        OnUpdate();
    }

    protected virtual void OnUpdate()
    {
    }

    public virtual void UseSkill()
    {
    }

    protected virtual void Attack()
    {
    }

    public void LevelUp()
    {
        if (level < Constants.MAX_LEVEL) {
            level++;
        }
    }

    public bool IsMaxLevel()
    {
        return (level >= Constants.MAX_LEVEL);
    }

    private void OnTriggerEnter(Collider other)
    {
        enemiesInRange.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        enemiesInRange.Remove(other.gameObject);
    }
}
