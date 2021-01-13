using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wolf_Movement : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    Transform patrol1;
    [SerializeField]
    Transform patrol2;
    [SerializeField]
    Transform patrol3;
    [SerializeField]
    Transform patrol4;
    [SerializeField]
    Transform patrol5;
    [SerializeField]
    Transform patrol6;

    NavMeshAgent Wolf;

    public bool patrolling;
    public bool creeping;
    public bool attacking;

    public Animator wolf_anim;

    public int dice;

    public float timer;

    void Start()
    {
        patrolling = true;
        creeping = false;
        attacking = false;

        SetDestination();
    }

    void Update()
    {
        Wolf = this.GetComponent<NavMeshAgent>();

        if (patrolling == true)
        {
            wolf_anim.SetBool("attacking", false);
            wolf_anim.SetBool("creep", false);
            wolf_anim.SetBool("patrol", true);
            Wolf.speed = 5;
            if (timer > 30)
            {
                timer = 0;
                SetDestination();
            }
            if (timer < 30)
            {
                timer += 1 * Time.deltaTime;
            }
        }

        if (dice == 1)
        {
            GoTo1();
        }
        if (dice == 2)
        {
            GoTo2();
        }
        if (dice == 3)
        {
            GoTo3();
        }
        if (dice == 4)
        {
            GoTo4();
        }
        if (dice == 5)
        {
            GoTo5();
        }
        if (dice == 6)
        {
            GoTo6();
        }

        if(creeping == true)
        {
            wolf_anim.SetBool("attacking", false);
            wolf_anim.SetBool("creep", true);
            wolf_anim.SetBool("patrol", false);
            Vector3 targetVector = player.transform.position;
            Wolf.SetDestination(targetVector);
            Wolf.speed = 8;
        }
        if (attacking == true)
        {
            wolf_anim.SetBool("attacking", true);
            wolf_anim.SetBool("creep", false);
            wolf_anim.SetBool("patrol", false);
            Vector3 targetVector = player.transform.position;
            Wolf.SetDestination(targetVector);
            Wolf.speed = 13;
        }
    }

    void SetDestination()
    {
        if (patrolling == true)
        {
            dice = Random.Range(1, 7);
            Debug.Log(dice);
        }

    }
    void GoTo1()
    {
        Vector3 targetVector = patrol1.transform.position;
        Wolf.SetDestination(targetVector);
    }
    void GoTo2()
    {
        Vector3 targetVector = patrol2.transform.position;
        Wolf.SetDestination(targetVector);
    }
    void GoTo3()
    {
        Vector3 targetVector = patrol3.transform.position;
        Wolf.SetDestination(targetVector);
    }
    void GoTo4()
    {
        Vector3 targetVector = patrol4.transform.position;
        Wolf.SetDestination(targetVector);
    }
    void GoTo5()
    {
        Vector3 targetVector = patrol5.transform.position;
        Wolf.SetDestination(targetVector);
    }
    void GoTo6()
    {
        Vector3 targetVector = patrol6.transform.position;
        Wolf.SetDestination(targetVector);
    }
}