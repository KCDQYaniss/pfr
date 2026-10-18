namespace EFT.Hideout;

public sealed class HideoutInteractionTrigger : InteractableObject, IHideoutAreaWrapper, IPhysicsTrigger
{
	[CompilerGenerated]
	private HideoutArea <Area>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; //Field offset: 0x50

	public private override HideoutArea Area
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string Description
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HideoutInteractionTrigger() { }

	[CompilerGenerated]
	public override HideoutArea get_Area() { }

	[CompilerGenerated]
	public override string get_Description() { }

	public void Init(HideoutArea area) { }

	private override bool IPhysicsTrigger.get_enabled() { }

	private override void IPhysicsTrigger.set_enabled(bool value) { }

	public override void OnTriggerEnter(Collider col) { }

	public override void OnTriggerExit(Collider col) { }

	[CompilerGenerated]
	private void set_Area(HideoutArea value) { }

}

