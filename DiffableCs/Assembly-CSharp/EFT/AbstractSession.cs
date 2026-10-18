namespace EFT;

public abstract class AbstractSession : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Action listener; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <AddMessageListener>b__0(NetworkChannel <p0>, short <p1>, byte[] <p2>, int <p3>, int <p4>) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Action listener; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <AddMessageListener>b__0(NetworkChannel channel, short type, byte[] buffer, int bufferOffset, int bufferCount) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Action listener; //Field offset: 0x10
		public AbstractSession <>4__this; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal void <AddMessageListener>b__0(NetworkChannel channel, short type, byte[] buffer, int bufferOffset, int bufferCount) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Action listener; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal void <AddMessageListener>b__0(NetworkChannel channel, short type, byte[] buffer, int bufferOffset, int bufferCount) { }

	}

	[CompilerGenerated]
	private EMemberCategory <MemberCategory>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <ProfileId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Token>k__BackingField; //Field offset: 0x30
	private readonly Dictionary _listeners; //Field offset: 0x38
	private NetworkConnection _connection; //Field offset: 0x40

	public override NetworkConnection Connection
	{
		 get { } //Length: 5
		 set { } //Length: 818
	}

	public EMemberCategory MemberCategory
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private string ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private string Token
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected AbstractSession() { }

	public override void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public override void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public override void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	public override void AddMessageListener(NetworkMessageType messageType, Action listener) { }

	private void AddMessageListenerWithOffset(NetworkMessageType messageType, Action listener) { }

	protected void ClearMessageListeners() { }

	protected static T CreateSession(Transform parent, string name, string profileId, string token) { }

	public override NetworkConnection get_Connection() { }

	[CompilerGenerated]
	public EMemberCategory get_MemberCategory() { }

	[CompilerGenerated]
	public string get_ProfileId() { }

	[CompilerGenerated]
	public string get_Token() { }

	protected override void OnDestroy() { }

	private void OnMessage(NetworkChannel channel, short messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

	public override void ProfileResourcesLoadProgress(int id, float progress) { }

	public override void RemoveMessageListener(NetworkMessageType messageType) { }

	public override void Send(NetworkChannel channel, NetworkMessageType messageType, byte[] buffer, int bufferOffset, int bufferCount) { }

	public override void Send(NetworkChannel channel, NetworkMessageType messageType) { }

	public override void Send(NetworkChannel channel, NetworkMessageType messageType, ISerializableMessage message) { }

	public override void Send(NetworkChannel channel, NetworkMessageType messageType, ArraySegment buffer) { }

	public void set_Connection(NetworkConnection value) { }

	[CompilerGenerated]
	protected void set_MemberCategory(EMemberCategory value) { }

	[CompilerGenerated]
	private void set_ProfileId(string value) { }

	[CompilerGenerated]
	private void set_Token(string value) { }

}

