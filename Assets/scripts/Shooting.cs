using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public static bool FireSingle;
    public static bool FireAuto;
    public static bool Dontfire;
    public bool TimeBool;
    public bool ChangeToAuto;
    public float BulletForce = 20f;
    public float time;
    public bool FireModeText;
    public bool ChangeToShotgun;
    public Transform firePoint2;
    public bool ShotgunPurchase;
    public bool ShotgunText;
    public bool FireShotgun;
    public GameObject muzzle;
    public bool DontFire2 = false;
    // Update is called once per frame
    void Start()
    {
        ShotgunText = false;
        FireModeText = false;
        AmmoPackScript.currentammo = 20;
        ChangeToAuto = false;
        ChangeToShotgun = false;
        ShotgunPurchase = false;
    }
    void Update()
    {
            
        FireSingle = false;
        if (Dontfire == false && DontFire2 == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                FireModeText = !FireModeText;
                ChangeToAuto = !ChangeToAuto;
                if (ShotgunPurchase == true && ChangeToAuto == false)
                {
                    ChangeToShotgun = !ChangeToShotgun;
                    ShotgunText = !ShotgunText;
                }
                

                if (ShotgunText == true)
                {
                    FireMode.ShotgunBool = true;
                }
                if (ShotgunText == false)
                {
                    FireMode.ShotgunBool = false;
                }
                if (FireModeText == true)
                {
                    FireMode.FireModeBool = true;
                }
                if (FireModeText == false)
                {
                    FireMode.FireModeBool = false;
                }
            }
            if (ChangeToShotgun == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    FireShotgun = true;
                }
            }
            if (ChangeToAuto == false && ChangeToShotgun == false)
            {
                if (Input.GetKeyUp(KeyCode.Mouse0))
                {
                    FireShotgun = false;

                }
            }
            if (ChangeToAuto == false)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    FireSingle = true;
                    FireAuto = false;
                }
            }
            if (ChangeToAuto == true)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    FireAuto = true;
                    FireSingle = false;
                    
                }
            }
            if (ChangeToAuto == false)
            {
                if (Input.GetButtonUp("Fire1"))
                {
                    FireSingle = false;

                }
            }
            if (ChangeToAuto == true)
            {
                if (Input.GetKeyUp(KeyCode.Mouse0))
                {
                    FireAuto = false;

                }
            }
            
            if (FireSingle == true && AmmoPackScript.currentammo > 0)
            {
                
                Shoot();
            }
            if (FireAuto == true && AmmoPackScript.currentammo > 0)
            {
                Shoot();
                //ShootAuto();
            }
            if (FireShotgun == true && AmmoPackScript.currentammo >= 2)
            {
                Shoot2();
                Shotgun();
            }
            
        }
        
    }
    void Shoot()
    {
            AmmoPackScript.currentammo--;
            GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
       
    }
    void Shoot2()
    {
            AmmoPackScript.currentammo--;
            GameObject Bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
    }

    void Shotgun()
    {
        AmmoPackScript.currentammo--;
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * BulletForce, ForceMode2D.Impulse);
    }
    void Muzzle()
    {
        GameObject muzzleEffect = Instantiate(muzzle, firePoint.position, firePoint.rotation);
    }
    public void OnPointerEnter(BaseEventData bed)
    {
        DontFire2 = true;
    }
    public void OnpointerExit(BaseEventData bed)
    {
        DontFire2 = false;
    }
 
    
}
