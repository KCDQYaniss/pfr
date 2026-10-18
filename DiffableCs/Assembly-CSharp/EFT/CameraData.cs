namespace EFT;

public struct CameraData
{
	public Matrix4x4 WorldToClipPos; //Field offset: 0x0
	public Vector3 PosWs; //Field offset: 0x40
	public float MinDistance; //Field offset: 0x4C

	public CameraData(Camera camera, float minDistance) { }

}

