using UnityEngine;
using UnityEngine.AI;
// sie binden die Bewegung an ein Objekt an (achten Sie nicht auf das Unity-Muster)
public class UnitMovement : MonoBehaviour
{
    Camera myCam;
    NavMeshAgent myAgent;
    public LayerMask ground;


    // Start wird vor der ersten Frame-Aktualisierung aufgerufen
    void Start()
    {
        myCam = Camera.main;
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, ground))
            {
                myAgent.SetDestination(hit.point);

            }
        }
    }
}
