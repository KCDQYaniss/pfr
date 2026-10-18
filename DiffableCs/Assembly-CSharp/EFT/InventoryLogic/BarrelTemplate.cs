namespace EFT.InventoryLogic;

public class BarrelTemplate : MasterModTemplate, IBarrelComponentTemplate
{
	[CompilerGenerated]
	private static float <MaxCenterOfImpact>k__BackingField; //Field offset: 0x0
	public bool IsSilencer; //Field offset: 0x1A0
	public float DurabilityBurnModificator; //Field offset: 0x1A4
	public float HeatFactor; //Field offset: 0x1A8
	public float CoolFactor; //Field offset: 0x1AC
	public float CenterOfImpact; //Field offset: 0x1B0
	public float ShotgunDispersion; //Field offset: 0x1B4
	public float DeviationMax; //Field offset: 0x1B8
	public float DeviationCurve; //Field offset: 0x1BC

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.CenterOfImpact
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.DeviationCurve
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.DeviationMax
	{
		private get { } //Length: 9
	}

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.ShotgunDispersion
	{
		private get { } //Length: 9
	}

	public private static float MaxCenterOfImpact
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 73
	}

	public BarrelTemplate() { }

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.get_CenterOfImpact() { }

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.get_DeviationCurve() { }

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.get_DeviationMax() { }

	private override float EFT.InventoryLogic.IBarrelComponentTemplate.get_ShotgunDispersion() { }

	[CompilerGenerated]
	public static float get_MaxCenterOfImpact() { }

	public virtual void OnInit() { }

	[CompilerGenerated]
	private static void set_MaxCenterOfImpact(float value) { }

}

