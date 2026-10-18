namespace Internal.Cryptography.Pal;

internal struct CertificateData
{
	[CompilerGenerated]
	private sealed class <ReadReverseRdns>d__21 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x28
		private X500DistinguishedName name; //Field offset: 0x30
		public X500DistinguishedName <>3__name; //Field offset: 0x38
		private Stack <rdnReaders>5__2; //Field offset: 0x40
		private DerSequenceReader <rdnReader>5__3; //Field offset: 0x48

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <ReadReverseRdns>d__21(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public struct AlgorithmIdentifier
	{
		internal string AlgorithmId; //Field offset: 0x0
		internal byte[] Parameters; //Field offset: 0x8

	}

	internal byte[] RawData; //Field offset: 0x0
	internal byte[] SubjectPublicKeyInfo; //Field offset: 0x8
	internal int Version; //Field offset: 0x10
	internal byte[] SerialNumber; //Field offset: 0x18
	internal AlgorithmIdentifier TbsSignature; //Field offset: 0x20
	internal X500DistinguishedName Issuer; //Field offset: 0x30
	internal DateTime NotBefore; //Field offset: 0x38
	internal DateTime NotAfter; //Field offset: 0x40
	internal X500DistinguishedName Subject; //Field offset: 0x48
	internal AlgorithmIdentifier PublicKeyAlgorithm; //Field offset: 0x50
	internal byte[] PublicKey; //Field offset: 0x60
	internal byte[] IssuerUniqueId; //Field offset: 0x68
	internal byte[] SubjectUniqueId; //Field offset: 0x70
	internal List Extensions; //Field offset: 0x78
	internal AlgorithmIdentifier SignatureAlgorithm; //Field offset: 0x80
	internal byte[] SignatureValue; //Field offset: 0x90

	internal CertificateData(byte[] rawData) { }

	private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	[IteratorStateMachine(typeof(<ReadReverseRdns>d__21))]
	private static IEnumerable ReadReverseRdns(X500DistinguishedName name) { }

}

