namespace EFT.Interactive;

public class ExfiltrationRequirement : IExfiltrationRequirement
{
	public ERequirementState Requirement; //Field offset: 0x10
	public string Id; //Field offset: 0x18
	public int Count; //Field offset: 0x20
	public EquipmentSlot RequiredSlot; //Field offset: 0x24
	public string RequirementTip; //Field offset: 0x28

	public string ShortName
	{
		 get { } //Length: 66
	}

	public ExfiltrationRequirement() { }

	[CanBeNull]
	public static IExfiltrationRequirement CreateRequirement(ERequirementState requirementState) { }

	public override void Enter(Player player, ExfiltrationPoint point) { }

	public override void Exit(Player player, ExfiltrationPoint point) { }

	public string get_ShortName() { }

	public override string GetLocalizedTip(string profileId) { }

	public override bool Met(Player player, ExfiltrationPoint point) { }

	public override void OnDestroy() { }

	public override void Start(ExfiltrationPoint point) { }

}

