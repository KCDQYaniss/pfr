namespace EFT.Impostors;

[Extension]
public static class ImpostorCameraExtension
{

	[Extension]
	public static Matrix4x4 LookAtImpostor(Camera camera) { }

	public static Matrix4x4 LookAtImpostor(in Vector3 position, Vector3 forward) { }

}

