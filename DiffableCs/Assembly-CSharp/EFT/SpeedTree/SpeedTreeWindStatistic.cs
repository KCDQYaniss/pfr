namespace EFT.SpeedTree;

public class SpeedTreeWindStatistic : MonoBehaviour
{
	[CompilerGenerated]
	private BaseTreeData <BaseMinWindData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private BaseTreeData <BaseMaxWindData>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private FactorTreeData <MinWindData>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private FactorTreeData <MaxWindData>k__BackingField; //Field offset: 0x270
	private List _ST_WindVector; //Field offset: 0x300
	private List _ST_WindGlobal; //Field offset: 0x308
	private List _ST_WindBranch; //Field offset: 0x310
	private List _ST_WindBranchTwitch; //Field offset: 0x318
	private List _ST_WindBranchWhip; //Field offset: 0x320
	private List _ST_WindBranchAnchor; //Field offset: 0x328
	private List _ST_WindBranchAdherences; //Field offset: 0x330
	private List _ST_WindTurbulences; //Field offset: 0x338
	private List _ST_WindLeaf1Ripple; //Field offset: 0x340
	private List _ST_WindLeaf1Tumble; //Field offset: 0x348
	private List _ST_WindLeaf1Twitch; //Field offset: 0x350
	private List _ST_WindLeaf2Ripple; //Field offset: 0x358
	private List _ST_WindLeaf2Tumble; //Field offset: 0x360
	private List _ST_WindLeaf2Twitch; //Field offset: 0x368
	private List _ST_WindFrondRipple; //Field offset: 0x370
	private List Times; //Field offset: 0x378
	private MaterialPropertyBlock mpb; //Field offset: 0x380
	private Renderer render; //Field offset: 0x388

	public private BaseTreeData BaseMaxWindData
	{
		[CompilerGenerated]
		 get { } //Length: 130
		[CompilerGenerated]
		private set { } //Length: 124
	}

	public private BaseTreeData BaseMinWindData
	{
		[CompilerGenerated]
		 get { } //Length: 133
		[CompilerGenerated]
		private set { } //Length: 124
	}

	public private FactorTreeData MaxWindData
	{
		[CompilerGenerated]
		 get { } //Length: 105
		[CompilerGenerated]
		private set { } //Length: 102
	}

	public private FactorTreeData MinWindData
	{
		[CompilerGenerated]
		 get { } //Length: 105
		[CompilerGenerated]
		private set { } //Length: 102
	}

	public SpeedTreeWindStatistic() { }

	public void ClearStatisticData() { }

	public void ExportToFile(string path) { }

	private void ExtractParamsTick() { }

	private void FixNanData() { }

	private Vector4 FixNanVector(Vector4 vec) { }

	[CompilerGenerated]
	public BaseTreeData get_BaseMaxWindData() { }

	[CompilerGenerated]
	public BaseTreeData get_BaseMinWindData() { }

	[CompilerGenerated]
	public FactorTreeData get_MaxWindData() { }

	[CompilerGenerated]
	public FactorTreeData get_MinWindData() { }

	private BaseTreeData GetBaseTreeData() { }

	private FactorTreeData GetDynamicWindData() { }

	public void RecordTick() { }

	public void SaveAsMaxWindData() { }

	public void SaveAsMinWindData() { }

	[CompilerGenerated]
	private void set_BaseMaxWindData(BaseTreeData value) { }

	[CompilerGenerated]
	private void set_BaseMinWindData(BaseTreeData value) { }

	[CompilerGenerated]
	private void set_MaxWindData(FactorTreeData value) { }

	[CompilerGenerated]
	private void set_MinWindData(FactorTreeData value) { }

	private void WriteData(StreamWriter writer, List data, string varName) { }

}

