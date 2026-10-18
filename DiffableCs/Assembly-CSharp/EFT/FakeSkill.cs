namespace EFT;

public sealed class FakeSkill : Skill
{
	private readonly int _overrideLevel; //Field offset: 0x78

	public FakeSkill(Skill skill, int overrideLevel) { }

	protected virtual int GetLevelForValue(float value) { }

}

