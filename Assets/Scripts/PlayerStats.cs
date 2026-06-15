using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Base Values")]
    public float baseHealth = 100f;
    public float baseMana = 100f;
    public float baseDamage = 10f;
    public float baseSpeed = 5f;

    [Header("Current Values (readonly)")]
    public float maxHealth;
    public float maxMana;
    public float damage;
    public float speed;

    private float healthMod = 0f;
    private float manaMod = 0f;
    private float damageMod = 0f;
    private float speedMod = 0f;

    void Start()
    {
        Recalculate();
    }

    public void AddModifier(string stat, float value)
    {
        switch (stat)
        {
            case "Health":
                healthMod += value;
                break;
            case "Mana":
                manaMod += value;
                break;
            case "Damage":
                damageMod += value;
                break;
            case "Speed":
                speedMod += value;
                break;
            default:
                Debug.LogWarning("Unknown stat: " + stat);
                break;
        }
        Recalculate();
    }

    private void Recalculate()
    {
        maxHealth = baseHealth + healthMod;
        maxMana = baseMana + manaMod;
        damage = baseDamage + damageMod;
        speed = baseSpeed + speedMod;
    }
}
