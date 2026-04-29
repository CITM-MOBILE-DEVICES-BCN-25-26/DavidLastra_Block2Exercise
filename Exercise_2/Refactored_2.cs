using System.Data;

public interface ISkill
{
    int ApplyDamage(int basedamage);
}

public class  FireSkill: ISkill
{
    int ISkill.ApplyDamage(int basedamage)
    {
        return basedamage + 10;
    }
}

public class IceSkill : ISkill
{
    int ISkill.ApplyDamage(int basedamage)
    {
        return basedamage + 5;
    }
}

public class PoisonSkill : ISkill
{
    int ISkill.ApplyDamage(int basedamage)
    {
        return basedamage + 2;
    }
}

public class SkillSystem
{
    public int ApplySkill(ISkill skill, int basedamage)
    {
        return skill.ApplyDamage(basedamage);
    }   
}