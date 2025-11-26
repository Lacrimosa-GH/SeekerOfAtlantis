using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable objects/CombatData") ]
public class CombatData : ScriptableObject
{
    public int CurrentRound;
    public int enemyCount;
    public int playerCount;

    public bool winCondition;
    public bool loseCondition;
    
}
