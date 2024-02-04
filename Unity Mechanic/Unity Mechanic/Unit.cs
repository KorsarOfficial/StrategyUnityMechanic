using UnityEngine;
// Befestigen Sie dies an aktiven Collidern AKA-Objekten AKA-Charakteren AKA-NPCs
public class Unit : MonoBehaviour
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
