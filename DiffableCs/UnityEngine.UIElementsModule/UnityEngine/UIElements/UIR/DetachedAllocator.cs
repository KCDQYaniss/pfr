namespace UnityEngine.UIElements.UIR;

internal class DetachedAllocator
{
	private TempAllocator m_VertsPool; //Field offset: 0x10
	private TempAllocator m_IndexPool; //Field offset: 0x18
	private List m_MeshWriteDataPool; //Field offset: 0x20
	private int m_MeshWriteDataCount; //Field offset: 0x28
	private bool m_Disposed; //Field offset: 0x2C

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

}

