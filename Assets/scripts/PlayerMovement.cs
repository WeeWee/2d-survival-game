using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    public float BeginningSpeed;
    float time = 0;
    bool cooldownSprint = false;
    public float MaxTime;
    public float MinTime;
    public float Cooldown;
    public float SprintSpeedPerSecond;
    public float MaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        BeginningSpeed = Speed;
    }
    
    // Update is called once per frame
    void Update()
    {
        Forward();
        Backwards();
        Left();
        Right();
        Run();
    }
    void Forward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime, Space.World);
        }
    }
    void Backwards()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime, Space.World);
        }
    }
    void Left()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime, Space.World);
        }
    }
    void Right()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime, Space.World);
        }
    }
    private void Run()
    {
        if (cooldownSprint == false)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed += SprintSpeedPerSecond;
                time = time + Time.deltaTime;
                if (Speed >= MaxSpeed)
                {
                    Speed = MaxSpeed;
                }
                if (time == MaxTime || time > MaxTime)
                {
                    Speed = BeginningSpeed;
                    time = MaxTime;
                }
            }
            else
            {
                time -= Time.deltaTime;
            }
            
            if (time <= MinTime)
            {
                time = MinTime;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = BeginningSpeed;
            }
            if (time >= Cooldown)
            {
                cooldownSprint = true;
            }
        }
        else
        {
            time -= Time.deltaTime;
            if (time <= MinTime)
            {
                cooldownSprint = false;
            }
        }
           
        
    }

}
