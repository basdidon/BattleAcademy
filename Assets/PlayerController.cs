using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public InputActions controls;

    public Camera cam;
    public NavMeshAgent agent;
    public NavMeshPath path;

    public Animator animator;

    private void Awake()
    {
        controls = new InputActions();

        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Start()
    {
        controls.PlayerAction.leftMosuseClick.performed += _ => ShowInfo();
        controls.PlayerAction.RightMouseClick.performed += _ => Move();
    }

    private void Move()
    {
        animator.SetBool("IsMoving", true);
        RaycastHit hit;
        Vector3 screenPoint = controls.PlayerAction.mousePosition.ReadValue<Vector2>();
        Physics.Raycast(cam.ScreenPointToRay(screenPoint), out hit,20f);
        Debug.Log("onScreen : "+screenPoint+"   onWorld : "+hit.point);
        Debug.DrawRay(cam.ScreenToWorldPoint(screenPoint), cam.ScreenPointToRay(screenPoint).direction * 20, Color.red, 0.5f);
        agent.SetDestination(hit.point);
    }

    private void ShowInfo()
    {
        Debug.Log("ShowInfo "+controls.PlayerAction.mousePosition.ReadValue<Vector2>());
    }

    private void Update()
    {
        if (agent.velocity==Vector3.zero)
        {
            animator.SetBool("IsMoving", false);
        }
    }
}