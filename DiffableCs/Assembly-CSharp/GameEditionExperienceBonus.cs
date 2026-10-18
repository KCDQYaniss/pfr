//Type is in global namespace

[GenerateBinarySerialization]
public sealed class GameEditionExperienceBonus
{
	[JsonProperty("GameEdition")]
	public string GameEdition; //Field offset: 0x10
	[JsonProperty("ExperienceBonus")]
	public float ExperienceBonus; //Field offset: 0x18

	public GameEditionExperienceBonus() { }

	public GameEditionExperienceBonus(string gameEdition, float experienceBonus) { }

	public virtual string ToString() { }

}

