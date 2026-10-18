namespace System.Diagnostics;

internal struct DiagEnumerator`1 : IEnumerator, IEnumerator, IDisposable
{
	private static readonly DiagNode s_Empty; //Field offset: 0x0
	private DiagNode _nextNode; //Field offset: 0x0
	private DiagNode _currentNode; //Field offset: 0x0

	public override T Current
	{
		 get { } //Length: 33
	}

	private override object System.Collections.IEnumerator.Current
	{
		private get { } //Length: 176
	}

	private static DiagEnumerator`1() { }

	public DiagEnumerator`1(DiagNode head) { }

	public override void Dispose() { }

	public override T get_Current() { }

	public override bool MoveNext() { }

	public override void Reset() { }

	private override object System.Collections.IEnumerator.get_Current() { }

}

