//Type is in global namespace

public class SyncModule
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__1_3; //Field offset: 0x10
		public static Func <>9__1_1; //Field offset: 0x18
		public static Func <>9__1_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal ulong <.ctor>b__1_0(ISyncAble so) { }

		internal ulong <.ctor>b__1_1(ISyncAble target) { }

		internal ISyncAble <.ctor>b__1_2(ISyncAble target) { }

		internal string <.ctor>b__1_3(ISyncAble gr) { }

	}

	private Dictionary _syncObjects; //Field offset: 0x10

	public SyncModule() { }

	public void Deserialize(IBitReaderStream readerStream) { }

	public void Serialize(IBitWriterStream writerStream) { }

}

