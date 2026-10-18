namespace EFT;

public sealed class ShellExtractionData : MonoBehaviour
{
	internal struct ExtractionSettings
	{
		public Vector2 ShellsForceXRange; //Field offset: 0x0
		public Vector2 ShellsForceYRange; //Field offset: 0x8
		public Vector2 ShellsForceZRange; //Field offset: 0x10
		public Vector2 ShellsRotationRangeX; //Field offset: 0x18
		public Vector2 ShellsRotationRangeY; //Field offset: 0x20
		public Vector2 ShellsRotationRangeZ; //Field offset: 0x28
		public float ShellForceMultiplier; //Field offset: 0x30

		public Vector3 GetRandomForce() { }

		public Vector3 GetRandomRotation() { }

	}

	public ExtractionSettings ShotSettings; //Field offset: 0x20
	public ExtractionSettings MisfireSettings; //Field offset: 0x54
	public ExtractionSettings JamSettings; //Field offset: 0x88
	public ExtractionSettings PatronExtractionSettings; //Field offset: 0xBC

	public ShellExtractionData() { }

	public Vector3 GetJamAdditionalForce() { }

	public Vector3 GetJamRotationVector() { }

	public float GetJamShellForceMultiplier() { }

	public Vector3 GetMisfireAdditionalForce() { }

	public Vector3 GetMisfireRotationVector() { }

	public float GetMisfireShellForceMultiplier() { }

	public Vector3 GetShotAdditionalForce() { }

	public Vector3 GetShotRotationVector() { }

	public float GetShotShellForceMultiplier() { }

	public Vector3 PatronExtractionAdditionalForce() { }

	public float PatronExtractionForceMultiplier() { }

	public Vector3 PatronExtractionVector() { }

}

