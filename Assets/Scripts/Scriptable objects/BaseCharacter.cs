using UnityEngine;
// template script of sorts for all characters to inherit from
[CreateAssetMenu(menuName = "Scriptable objects/BaseCharacter")]
public class BaseCharacter : ScriptableObject
{
    // defining all character attributes and making accessors for the relevant ones
    [SerializeField]private int _speed;
    public int Speed {get{return _speed;}}
    private int _hitPoints;
    public int HitPoints {get{return _hitPoints;}}
    [SerializeField]private int _maxHP;
    [SerializeField]private int _defense;
    [SerializeField]private int _mind;
    private int _maxSanity {get; set;}
    private int _insanity {get; set;}
    private int _sanity {get; set;}
    [SerializeField]private int _accuracy;

// it is standard to make a separate method for changing the value of a private variable
    public int Damage(int hit)
    {
        var def = _defense / 100;
        var defmult = 100 - def;
        var damage = hit * defmult;
        return _hitPoints -= damage;;
    }

    public int Heal(int heal)
    {
        heal = heal / 100;
        return _hitPoints += _hitPoints * heal;
    }
}
