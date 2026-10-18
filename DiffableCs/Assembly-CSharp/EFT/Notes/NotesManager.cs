namespace EFT.Notes;

public sealed class NotesManager : ILockable
{
	[GenerateBinarySerialization]
	internal sealed class NotesDescriptor
	{
		[JsonProperty("Notes")]
		public Note[] Notes; //Field offset: 0x10

		public NotesDescriptor() { }

		public NotesDescriptor(NotesManager notes) { }

	}

	private readonly List _notes; //Field offset: 0x10
	private readonly BindableState _transactionInProcess; //Field offset: 0x18

	private override BindableState CommonAssets.Scripts.Utilities.ILockable.Locked
	{
		private get { } //Length: 5
	}

	public IReadOnlyList Notes
	{
		 get { } //Length: 5
	}

	public IBindable TransactionInProcess
	{
		 get { } //Length: 5
	}

	public NotesManager(NotesDescriptor descriptor) { }

	public OperationResult AddNote(Note note, bool simulate) { }

	private override BindableState CommonAssets.Scripts.Utilities.ILockable.get_Locked() { }

	public OperationResult DeleteNote(int index, bool simulate) { }

	public OperationResult EditNote(int index, Note note, bool simulate) { }

	public IReadOnlyList get_Notes() { }

	public IBindable get_TransactionInProcess() { }

	public void InsertNote(int index, Note note) { }

	public void RemoveNote(Note note) { }

}

