using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YkWeaponBall : IWeapon
{

    public override void Init()
    {
        attackSpeed = 0.1f;
        base.Init();
    }


    //射击方法，需要重写
    public override void Fire()
    {
        
        BarrageGame.Instance.getBarrageUtil().StartCoroutine(YkBall());
        
     
    }

    IEnumerator YkBall()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 vec = new Vector3(0, 0, 1);
            for (int j = -8; j < 10; j++)
            {
                GameObject bullet = BulletUtil.LoadBullet(shooter.GetBulletName());

                bullet.transform.position = shooter.GetPos();
                bullet.transform.forward = Quaternion.AngleAxis(20 * j, Vector3.up) * vec;
                bullet.GetComponent<IBullet>().shooter = shooter;
                bullet.GetComponent<IBullet>().Fire();

            }
            yield return new WaitForSeconds(0.1f);
        }
    }

 

  
}
