namespace Dissonance;

[DefaultMember("Item")]
public sealed class Rooms
{
	private static readonly Log Log; //Field offset: 0x0
	private static readonly RoomMembershipComparer Comparer; //Field offset: 0x8
	private readonly List _rooms; //Field offset: 0x10
	private readonly List _roomNames; //Field offset: 0x18
	private readonly ReadOnlyCollection _roomNamesReadonly; //Field offset: 0x20
	[CompilerGenerated]
	private Action JoinedRoom; //Field offset: 0x28
	[CompilerGenerated]
	private Action LeftRoom; //Field offset: 0x30

	public event Action JoinedRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action LeftRoom
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public int Count
	{
		 get { } //Length: 65
	}

	internal RoomMembership Item
	{
		internal get { } //Length: 137
	}

	internal ReadOnlyCollection Memberships
	{
		internal get { } //Length: 5
	}

	private static Rooms() { }

	internal Rooms() { }

	[CompilerGenerated]
	public void add_JoinedRoom(Action value) { }

	[CompilerGenerated]
	public void add_LeftRoom(Action value) { }

	public bool Contains(string roomName) { }

	private Nullable FindById(ushort id) { }

	public int get_Count() { }

	internal RoomMembership get_Item(int i) { }

	internal ReadOnlyCollection get_Memberships() { }

	public RoomMembership Join(string roomName) { }

	public bool Leave(RoomMembership membership) { }

	[CanBeNull]
	internal string Name(ushort roomId) { }

	private void OnJoinedRoom(RoomMembership membership) { }

	private void OnLeftRoom(RoomMembership membership) { }

	[CompilerGenerated]
	public void remove_JoinedRoom(Action value) { }

	[CompilerGenerated]
	public void remove_LeftRoom(Action value) { }

}

