using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Camera cam;
    public GameObject playerObj;

    public GameObject idle;
    public GameObject walk;

    public Animator player_anim;

    public bool IsWalking;

    Vector3 Ver;
    Vector3 Hor;

    // Use this for initialization
    void Start()
    {
        Ver = new Vector3(0, 0, 10);
        Hor = new Vector3(10, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        if (playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            playerObj.transform.rotation = Quaternion.Slerp(playerObj.transform.rotation, targetRotation, 7f * Time.deltaTime);
            if (Input.GetKey(KeyCode.W))
            {
                walk.SetActive(true);
                idle.SetActive(false);
                transform.position = Vector3.MoveTowards(transform.position, targetPoint, 0.15f);
                player_anim.SetBool("Walking", true);
                IsWalking = true;
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                player_anim.SetBool("Walking", false);
                walk.SetActive(false);
                idle.SetActive(true);
                IsWalking = false;
            }
            //transform.position += Ver * Input.GetAxis("Vertical") * Time.deltaTime;
            //transform.position += Hor * Input.GetAxis("Horizontal") * Time.deltaTime;

        }
    }
}
