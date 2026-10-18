namespace EFT.InventoryLogic;

public class ThrowWeap : Item, IExplosiveItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_2; //Field offset: 0x8
		public static Func <>9__38_5; //Field offset: 0x10
		public static Func <>9__38_8; //Field offset: 0x18
		public static Func <>9__38_11; //Field offset: 0x20
		public static Func <>9__38_14; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal EItemAttributeDisplayType <.ctor>b__38_11() { }

		internal EItemAttributeDisplayType <.ctor>b__38_14() { }

		internal EItemAttributeDisplayType <.ctor>b__38_2() { }

		internal EItemAttributeDisplayType <.ctor>b__38_5() { }

		internal EItemAttributeDisplayType <.ctor>b__38_8() { }

	}


	public override Vector3 ArmorDistanceDistanceDamage
	{
		 get { } //Length: 109
	}

	public override Vector3 Blindness
	{
		 get { } //Length: 109
	}

	public bool CanBeHiddenDuringThrow
	{
		 get { } //Length: 80
	}

	public bool CanPlantOnGround
	{
		 get { } //Length: 80
	}

	public override Vector3 Contusion
	{
		 get { } //Length: 109
	}

	public float EmitTime
	{
		 get { } //Length: 84
	}

	public string ExplosionEffectType
	{
		 get { } //Length: 80
	}

	public override int FragmentsCount
	{
		 get { } //Length: 79
	}

	public string FragmentType
	{
		 get { } //Length: 80
	}

	public float GetExplDelay
	{
		 get { } //Length: 81
	}

	public override float GetStrength
	{
		 get { } //Length: 81
	}

	public override bool IsDummy
	{
		 get { } //Length: 246
	}

	public override float MaxExplosionDistance
	{
		 get { } //Length: 81
	}

	public float MaxFragmentDamage
	{
		 get { } //Length: 81
	}

	public override float MinExplosionDistance
	{
		 get { } //Length: 81
	}

	public float MinFragmentDamage
	{
		 get { } //Length: 81
	}

	public float MinTimeToContactExplode
	{
		 get { } //Length: 81
	}

	public bool PlayFuzeSound
	{
		 get { } //Length: 80
	}

	public ThrowWeapType ThrowType
	{
		 get { } //Length: 79
	}

	public ThrowWeap(string id, ThrowWeapTemplate template) { }

	[CompilerGenerated]
	private float <.ctor>b__38_0() { }

	[CompilerGenerated]
	private string <.ctor>b__38_1() { }

	[CompilerGenerated]
	private string <.ctor>b__38_10() { }

	[CompilerGenerated]
	private float <.ctor>b__38_12() { }

	[CompilerGenerated]
	private string <.ctor>b__38_13() { }

	[CompilerGenerated]
	private float <.ctor>b__38_3() { }

	[CompilerGenerated]
	private string <.ctor>b__38_4() { }

	[CompilerGenerated]
	private float <.ctor>b__38_6() { }

	[CompilerGenerated]
	private string <.ctor>b__38_7() { }

	[CompilerGenerated]
	private float <.ctor>b__38_9() { }

	public override Ammo CreateFragment() { }

	public override Vector3 get_ArmorDistanceDistanceDamage() { }

	public override Vector3 get_Blindness() { }

	public bool get_CanBeHiddenDuringThrow() { }

	public bool get_CanPlantOnGround() { }

	public override Vector3 get_Contusion() { }

	public float get_EmitTime() { }

	public string get_ExplosionEffectType() { }

	public override int get_FragmentsCount() { }

	public string get_FragmentType() { }

	public float get_GetExplDelay() { }

	public override float get_GetStrength() { }

	public override bool get_IsDummy() { }

	public override float get_MaxExplosionDistance() { }

	public float get_MaxFragmentDamage() { }

	public override float get_MinExplosionDistance() { }

	public float get_MinFragmentDamage() { }

	public float get_MinTimeToContactExplode() { }

	public bool get_PlayFuzeSound() { }

	public ThrowWeapType get_ThrowType() { }

	public Item GetItem() { }

}

