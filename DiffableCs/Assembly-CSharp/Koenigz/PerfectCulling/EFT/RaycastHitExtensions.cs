namespace Koenigz.PerfectCulling.EFT;

[Extension]
public static class RaycastHitExtensions
{
	private sealed class ReflectionData
	{
		private const string COLLIDER_ID_FIELDNAME = "m_Collider"; //Field offset: 0x0
		private int _fieldOffset; //Field offset: 0x10

		public ReflectionData() { }

		public int GetColliderID(ref RaycastHit hit) { }

	}

	private static readonly ReflectionData _reflectionData; //Field offset: 0x0

	private static RaycastHitExtensions() { }

	[Extension]
	public static int GetColliderID(RaycastHit hit) { }

}

