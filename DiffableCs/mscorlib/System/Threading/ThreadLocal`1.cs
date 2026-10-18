namespace System.Threading;

[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView`1))]
public class ThreadLocal`1 : IDisposable
{
	private class FinalizationHelper
	{
		internal LinkedSlotVolatile[] SlotArray; //Field offset: 0x0
		private bool m_trackAllValues; //Field offset: 0x0

		internal FinalizationHelper(LinkedSlotVolatile[] slotArray, bool trackAllValues) { }

		protected virtual void Finalize() { }

	}

	private class IdManager
	{
		private int m_nextIdToTry; //Field offset: 0x0
		private List m_freeIds; //Field offset: 0x0

		public IdManager() { }

		internal int GetId() { }

		internal void ReturnId(int id) { }

	}

	private sealed class LinkedSlot
	{
		internal LinkedSlot Next; //Field offset: 0x0
		internal LinkedSlot Previous; //Field offset: 0x0
		internal LinkedSlotVolatile[] SlotArray; //Field offset: 0x0
		internal T Value; //Field offset: 0x0

		internal LinkedSlot(LinkedSlotVolatile[] slotArray) { }

	}

	private struct LinkedSlotVolatile
	{
		internal LinkedSlot Value; //Field offset: 0x0

	}

	[ThreadStatic]
	private static LinkedSlotVolatile[] ts_slotArray; //Field offset: 0xFFFFFFFF
	[ThreadStatic]
	private static FinalizationHelper ts_finalizationHelper; //Field offset: 0xFFFFFFFF
	private static IdManager s_idManager; //Field offset: 0x0
	private Func m_valueFactory; //Field offset: 0x0
	private int m_idComplement; //Field offset: 0x0
	private bool m_initialized; //Field offset: 0x0
	private LinkedSlot m_linkedSlot; //Field offset: 0x0
	private bool m_trackAllValues; //Field offset: 0x0

	public bool IsValueCreated
	{
		 get { } //Length: 261
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	public T Value
	{
		 get { } //Length: 282
		 set { } //Length: 295
	}

	private static ThreadLocal`1() { }

	public ThreadLocal`1() { }

	private void CreateLinkedSlot(LinkedSlotVolatile[] slotArray, int id, T value) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public bool get_IsValueCreated() { }

	public T get_Value() { }

	private static int GetNewTableSize(int minSize) { }

	private T GetValueSlow() { }

	private void GrowTable(ref LinkedSlotVolatile[] table, int minLength) { }

	private void Initialize(Func valueFactory, bool trackAllValues) { }

	public void set_Value(T value) { }

	private void SetValueSlow(T value, LinkedSlotVolatile[] slotArray) { }

	public virtual string ToString() { }

}

