namespace EFT.SpeedTree;

public class TreeWind : MonoBehaviour
{
	internal struct BaseTreeData
	{
		public Vector4 _ST_WindGlobal; //Field offset: 0x0
		public Vector4 _ST_WindBranch; //Field offset: 0x10
		public Vector4 _ST_WindBranchTwitch; //Field offset: 0x20
		public Vector4 _ST_WindBranchWhip; //Field offset: 0x30
		public Vector4 _ST_WindBranchAnchor; //Field offset: 0x40
		public Vector4 _ST_WindBranchAdherences; //Field offset: 0x50
		public Vector4 _ST_WindTurbulences; //Field offset: 0x60
		public Vector4 _ST_WindLeaf1Ripple; //Field offset: 0x70
		public Vector4 _ST_WindLeaf1Tumble; //Field offset: 0x80
		public Vector4 _ST_WindLeaf1Twitch; //Field offset: 0x90
		public Vector4 _ST_WindLeaf2Ripple; //Field offset: 0xA0
		public Vector4 _ST_WindLeaf2Tumble; //Field offset: 0xB0
		public Vector4 _ST_WindLeaf2Twitch; //Field offset: 0xC0
		public Vector4 _ST_WindFrondRipple; //Field offset: 0xD0

		public bool Equals(BaseTreeData other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	internal struct FactorTreeData
	{
		public Vector4 _ST_WindGlobal_B; //Field offset: 0x0
		public Vector4 _ST_WindBranch_B; //Field offset: 0x10
		public Vector4 _ST_WindLeaf1Ripple_B; //Field offset: 0x20
		public Vector4 _ST_WindLeaf1Tumble_B; //Field offset: 0x30
		public Vector4 _ST_WindLeaf1Twitch_B; //Field offset: 0x40
		public Vector4 _ST_WindLeaf2Ripple_B; //Field offset: 0x50
		public Vector4 _ST_WindLeaf2Tumble_B; //Field offset: 0x60
		public Vector4 _ST_WindLeaf2Twitch_B; //Field offset: 0x70
		public Vector4 _ST_WindFrondRipple_B; //Field offset: 0x80

		public bool Equals(FactorTreeData other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

	}

	internal struct Settings
	{
		private sealed class SettingsEqualityComparer : IEqualityComparer
		{

			public SettingsEqualityComparer() { }

			public override bool Equals(Settings x, Settings y) { }

			public override int GetHashCode(Settings obj) { }

		}

		[CompilerGenerated]
		private static readonly IEqualityComparer <SettingsComparer>k__BackingField; //Field offset: 0x0
		public BaseTreeData BaseMinWindData; //Field offset: 0x0
		public BaseTreeData BaseMaxWindData; //Field offset: 0xE0
		public FactorTreeData MinWindData; //Field offset: 0x1C0
		public FactorTreeData MaxWindData; //Field offset: 0x250

		public static IEqualityComparer SettingsComparer
		{
			[CompilerGenerated]
			 get { } //Length: 83
		}

		private static Settings() { }

		[CompilerGenerated]
		public static IEqualityComparer get_SettingsComparer() { }

	}

	private static readonly int _propertyWindId; //Field offset: 0x0
	private static readonly int _propertyWindEnabled; //Field offset: 0x4
	private static readonly int _propertyWindGlobal; //Field offset: 0x8
	private static readonly int _propertyWindBranch; //Field offset: 0xC
	private static readonly int _propertyWindBranchTwitch; //Field offset: 0x10
	private static readonly int _propertyWindBranchWhip; //Field offset: 0x14
	private static readonly int _propertyWindBranchAnchor; //Field offset: 0x18
	private static readonly int _propertyWindBranchAdherences; //Field offset: 0x1C
	private static readonly int _propertyWindTurbulences; //Field offset: 0x20
	private static readonly int _propertyWindLeaf1Ripple; //Field offset: 0x24
	private static readonly int _propertyWindLeaf1Tumble; //Field offset: 0x28
	private static readonly int _propertyWindLeaf1Twitch; //Field offset: 0x2C
	private static readonly int _propertyWindLeaf2Ripple; //Field offset: 0x30
	private static readonly int _propertyWindLeaf2Tumble; //Field offset: 0x34
	private static readonly int _propertyWindLeaf2Twitch; //Field offset: 0x38
	private static readonly int _propertyWindFrondRipple; //Field offset: 0x3C
	private static readonly int _propertyWindGlobalA; //Field offset: 0x40
	private static readonly int _propertyWindBranchA; //Field offset: 0x44
	private static readonly int _propertyWindBranchTwitchA; //Field offset: 0x48
	private static readonly int _propertyWindBranchWhipA; //Field offset: 0x4C
	private static readonly int _propertyWindBranchAnchorA; //Field offset: 0x50
	private static readonly int _propertyWindBranchAdherencesA; //Field offset: 0x54
	private static readonly int _propertyWindTurbulencesA; //Field offset: 0x58
	private static readonly int _propertyWindLeaf1RippleA; //Field offset: 0x5C
	private static readonly int _propertyWindLeaf1TumbleA; //Field offset: 0x60
	private static readonly int _propertyWindLeaf1TwitchA; //Field offset: 0x64
	private static readonly int _propertyWindLeaf2RippleA; //Field offset: 0x68
	private static readonly int _propertyWindLeaf2TumbleA; //Field offset: 0x6C
	private static readonly int _propertyWindLeaf2TwitchA; //Field offset: 0x70
	private static readonly int _propertyWindFrondRippleA; //Field offset: 0x74
	private static readonly int _propertyWindGlobalB; //Field offset: 0x78
	private static readonly int _propertyWindBranchB; //Field offset: 0x7C
	private static readonly int _propertyWindLeaf1RippleB; //Field offset: 0x80
	private static readonly int _propertyWindLeaf1TumbleB; //Field offset: 0x84
	private static readonly int _propertyWindLeaf1TwitchB; //Field offset: 0x88
	private static readonly int _propertyWindLeaf2RippleB; //Field offset: 0x8C
	private static readonly int _propertyWindLeaf2TumbleB; //Field offset: 0x90
	private static readonly int _propertyWindLeaf2TwitchB; //Field offset: 0x94
	private static readonly int _propertyWindFrondRippleB; //Field offset: 0x98
	private static readonly int _propertyWindGlobalC; //Field offset: 0x9C
	private static readonly int _propertyWindBranchC; //Field offset: 0xA0
	private static readonly int _propertyWindLeaf1RippleC; //Field offset: 0xA4
	private static readonly int _propertyWindLeaf1TumbleC; //Field offset: 0xA8
	private static readonly int _propertyWindLeaf1TwitchC; //Field offset: 0xAC
	private static readonly int _propertyWindLeaf2RippleC; //Field offset: 0xB0
	private static readonly int _propertyWindLeaf2TumbleC; //Field offset: 0xB4
	private static readonly int _propertyWindLeaf2TwitchC; //Field offset: 0xB8
	private static readonly int _propertyWindFrondRippleC; //Field offset: 0xBC
	public BaseTreeData BaseMinWindData; //Field offset: 0x20
	public BaseTreeData BaseMaxWindData; //Field offset: 0x100
	public FactorTreeData MinWindData; //Field offset: 0x1E0
	public FactorTreeData MaxWindData; //Field offset: 0x270
	[HideInInspector]
	public Settings settings; //Field offset: 0x300
	private MaterialPropertyBlock _mpb; //Field offset: 0x5E0

	private static TreeWind() { }

	public TreeWind() { }

	public static MaterialPropertyBlock CreateMaterialPropertyBlock(BaseTreeData baseMinWindData, BaseTreeData baseMaxWindData, FactorTreeData minWindData, FactorTreeData maxWindData, int windId = 0) { }

	public void FillSettings() { }

	public void Init(MaterialPropertyBlock mpb) { }

	[ContextMenu("Clear Wind")]
	public void SetClearWind() { }

	public void SetDrawMotionVectors(bool isEnable) { }

	public void SetParams() { }

	public void SetParams(MaterialPropertyBlock mpb) { }

	[ContextMenu("SetParams")]
	public void SetParamsForce() { }

}

