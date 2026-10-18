namespace System.IO.Enumeration;

public class FileSystemEnumerable`1 : IEnumerable, IEnumerable
{
	private sealed class DelegateEnumerator : FileSystemEnumerator
	{
		private readonly FileSystemEnumerable _enumerable; //Field offset: 0x0

		public DelegateEnumerator(FileSystemEnumerable enumerable) { }

		protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }

		protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }

		protected virtual TResult TransformEntry(ref FileSystemEntry entry) { }

	}

	internal sealed class FindPredicate : MulticastDelegate
	{

		public FindPredicate(object object, IntPtr method) { }

		public override bool Invoke(ref FileSystemEntry entry) { }

	}

	internal sealed class FindTransform : MulticastDelegate
	{

		public FindTransform(object object, IntPtr method) { }

		public override TResult Invoke(ref FileSystemEntry entry) { }

	}

	private DelegateEnumerator _enumerator; //Field offset: 0x0
	private readonly FindTransform _transform; //Field offset: 0x0
	private readonly EnumerationOptions _options; //Field offset: 0x0
	private readonly string _directory; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate <ShouldIncludePredicate>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private FindPredicate <ShouldRecursePredicate>k__BackingField; //Field offset: 0x0

	public FindPredicate ShouldIncludePredicate
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public FindPredicate ShouldRecursePredicate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public FileSystemEnumerable`1(string directory, FindTransform transform, EnumerationOptions options = null) { }

	[CompilerGenerated]
	public FindPredicate get_ShouldIncludePredicate() { }

	[CompilerGenerated]
	public FindPredicate get_ShouldRecursePredicate() { }

	public override IEnumerator GetEnumerator() { }

	[CompilerGenerated]
	public void set_ShouldIncludePredicate(FindPredicate value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

