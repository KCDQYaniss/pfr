namespace Koenigz.PerfectCulling;

public abstract class PerfectCullingBakeData : ScriptableObject
{
	[SerializeField]
	public int bakeDataVersion; //Field offset: 0x18
	[SerializeField]
	public bool bakeCompleted; //Field offset: 0x1C
	[SerializeField]
	public int bakeHash; //Field offset: 0x20
	[SerializeField]
	public string strBakeDate; //Field offset: 0x28
	[SerializeField]
	public long bakeDurationMilliseconds; //Field offset: 0x30

	protected PerfectCullingBakeData() { }

	public override void CompleteBake() { }

	public override void DrawInspectorGUI() { }

	public override ushort[] GetRawData(int index) { }

	public override void PrepareForBake(PerfectCullingBakingBehaviour bakingBehaviour) { }

	public override void SampleAtIndex(int index, List indices) { }

	public override void SetRawData(int index, BakedIndexBuffer indices) { }

	public override void SetRawData(int index, ushort[] indices) { }

	public override void SetRawDataMT(int index, int* buffer, int count) { }

}

