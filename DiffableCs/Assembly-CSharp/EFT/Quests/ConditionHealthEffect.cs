namespace EFT.Quests;

[Obfuscation(Exclude = True)]
public sealed class ConditionHealthEffect : Condition
{
	public ConditionComparer time; //Field offset: 0xE0
	public ConditionComparer hydration; //Field offset: 0xE8
	public ConditionComparer energy; //Field offset: 0xF0
	public BodyPartsWithEffects[] bodyPartsWithEffects; //Field offset: 0xF8

	public ConditionHealthEffect() { }

}

