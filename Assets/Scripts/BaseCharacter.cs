using UnityEngine;
// template script of sorts for all characters to inherit from
public abstract class ICharacter : MonoBehaviour
{
    // defining all character attributes and making accessors for the relevant ones
    private int _speed { get; set; }
    public int Speed {get{return _speed;}}
    private int _hitPoints { get; set; }
    public int HitPoints {get{return _hitPoints;}}
    private int _maxHP {get; set;}
    private int _defense { get; set; }
    private int _mind {get; set;}
    private int _maxSanity {get; set;}
    private int _insanity {get; set;}
    private int _sanity {get; set;}
    private int _accuracy {get; set;}

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
