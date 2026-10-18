namespace UnityEngine.UIElements;

public struct StylePropertyNameCollection : IEnumerable, IEnumerable
{
	internal struct Enumerator : IEnumerator, IEnumerator, IDisposable
	{
		private Enumerator m_Enumerator; //Field offset: 0x0

		public override StylePropertyName Current
		{
			 get { } //Length: 70
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 107
		}

		internal Enumerator(Enumerator enumerator) { }

		public override void Dispose() { }

		public override StylePropertyName get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	internal List propertiesList; //Field offset: 0x0

	internal StylePropertyNameCollection(List list) { }

	public Enumerator GetEnumerator() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

