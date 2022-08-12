using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : BaseEnemy
{
    private int _spaceShipPoints = 100;
    private void Start()
    {
        _speed = 3f;
        _lifeTime = 15f;

        StartCoroutine(LifeTimeCoroutine(_lifeTime));
    }

    private void Update()
    {
        FollowPlayer();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }

    protected override void GetDamage()
    {
        OnGetDamage?.Invoke(_spaceShipPoints);
        Destroy(gameObject);
    }
}
