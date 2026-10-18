namespace Sirenix.Serialization;

public abstract class BaseDataReaderWriter
{
	private NodeInfo[] nodes; //Field offset: 0x10
	private int nodesLength; //Field offset: 0x18

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use the Binder member on the writer's SerializationContext/DeserializationContext instead.", False)]
	public override TwoWaySerializationBinder Binder
	{
		 get { } //Length: 309
		 set { } //Length: 441
	}

	protected NodeInfo CurrentNode
	{
		 get { } //Length: 190
	}

	public override bool IsInArrayNode
	{
		 get { } //Length: 63
	}

	protected int NodeDepth
	{
		 get { } //Length: 4
	}

	protected NodeInfo[] NodesArray
	{
		 get { } //Length: 5
	}

	protected BaseDataReaderWriter() { }

	protected void ClearNodes() { }

	private void ExpandNodes() { }

	public override TwoWaySerializationBinder get_Binder() { }

	protected NodeInfo get_CurrentNode() { }

	public override bool get_IsInArrayNode() { }

	protected int get_NodeDepth() { }

	protected NodeInfo[] get_NodesArray() { }

	protected void PopArray() { }

	protected void PopNode(string name) { }

	protected void PushArray() { }

	protected void PushNode(NodeInfo node) { }

	protected void PushNode(string name, int id, Type type) { }

	public override void set_Binder(TwoWaySerializationBinder value) { }

}

