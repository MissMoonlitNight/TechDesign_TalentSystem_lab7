using UnityEngine;

// Этот класс будет виден в инспекторе как раскрывающийся список
[System.Serializable]
public class TalentModifier
{
    public string statName; // "Health", "Damage", "Speed", "Mana"
    public float value;
}

[CreateAssetMenu(fileName = "NewTalent", menuName = "Talents/TalentData")]
public class TalentData : ScriptableObject
{
    public string displayName;
    public Sprite icon;

    [TextArea(2, 3)]
    public string description;

    public TalentModifier[] modifiers;
    public TalentData[] prerequisites; // какие таланты нужно изучить перед этим
    public int talentPointCost = 1; // стоимость в очках талантов
}