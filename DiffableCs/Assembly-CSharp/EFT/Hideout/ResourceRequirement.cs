namespace EFT.Hideout;

public sealed class ResourceRequirement : Requirement
{
	[JsonProperty("templateId")]
	public string TemplateId; //Field offset: 0x38
	[JsonProperty("resource")]
	public int Resource; //Field offset: 0x40

	public virtual ERequirementType Type
	{
		 get { } //Length: 6
	}

	public ResourceRequirement() { }

	public virtual ERequirementType get_Type() { }

}

