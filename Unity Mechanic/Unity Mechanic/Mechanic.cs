using UnityEngine;

public class Mechanic : MonoBehaviour
{
    void Start()
    {
        UnitSelections.Instance.unitList.Add(this.gameObject);
    }
    void OnDestroy()
    {
        UnitSelections.Instance.unitList.Remove(this.gameObject);
    }
}
