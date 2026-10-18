//Type is in global namespace

public class BotMedecine : BotData
{
	public static readonly EquipmentSlot[] secureSlots; //Field offset: 0x0
	public static readonly EquipmentSlot[] anySlots; //Field offset: 0x8
	public static readonly EquipmentSlot[] pockets; //Field offset: 0x10
	public static readonly EquipmentSlot[] allVisible; //Field offset: 0x18
	public BotFirstAid FirstAid; //Field offset: 0x18
	public BotStimulators Stimulators; //Field offset: 0x20
	public BotSurgicalKit SurgicalKit; //Field offset: 0x28
	private float _recheckPeriod; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Using>k__BackingField; //Field offset: 0x34

	public private bool Using
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static BotMedecine() { }

	public BotMedecine(BotOwner owner) { }

	public void Activate() { }

	private void AidCallback(bool obj) { }

	public void Dispose() { }

	[CompilerGenerated]
	public bool get_Using() { }

	public void GetDamaged() { }

	public void ManualUpdate() { }

	public void RefreshCurMeds() { }

	[CompilerGenerated]
	private void set_Using(bool value) { }

}

