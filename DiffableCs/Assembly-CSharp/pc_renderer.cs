//Type is in global namespace

public static class pc_renderer
{
	internal struct NativeMeshData
	{
		public int vertCount; //Field offset: 0x0
		public Vector3[] verts; //Field offset: 0x8
		public int indCount; //Field offset: 0x10
		public int[] indices; //Field offset: 0x18
		public int colorCount; //Field offset: 0x20
		public Color[] colors; //Field offset: 0x28

		public Hash128 ComputeHash() { }

		public virtual string ToString() { }

	}

	internal struct NativeMeshRenderers
	{
		internal enum NativeMeshRenderMode
		{
			TriangleFill = 0,
			Wireframe = 1,
		}

		public NativeMeshData meshData; //Field offset: 0x0
		public int transformationCount; //Field offset: 0x30
		public NativeRendererTransformation[] transformations; //Field offset: 0x38
		public int renderMode; //Field offset: 0x40

		public Hash128 ComputeHash() { }

	}

	internal struct NativeRendererTransformation
	{
		public Vector3 boundsCenter; //Field offset: 0x0
		public Vector3 boundsSize; //Field offset: 0xC
		public Matrix4x4 mat4x4; //Field offset: 0x18

	}

	internal class pc_renderer_settings
	{
		public string NativeLibPath; //Field offset: 0x10
		public Vector3[] SamplingPositions; //Field offset: 0x18
		public NativeMeshRenderers[] NativeMeshRenderers; //Field offset: 0x20

		public pc_renderer_settings() { }

	}


}

