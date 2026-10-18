namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : Object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}


	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public int blendShapeCount
	{
		[NativeMethod(Name = "GetBlendShapeChannelCount")]
		 get { } //Length: 78
	}

	public BoneWeight[] boneWeights
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public Bounds bounds
	{
		 get { } //Length: 108
		 set { } //Length: 93
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 78
	}

	public Color[] colors
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public Color32[] colors32
	{
		 get { } //Length: 85
		 set { } //Length: 142
	}

	public IndexFormat indexFormat
	{
		 set { } //Length: 91
	}

	public bool isReadable
	{
		[NativeMethod("GetIsReadable")]
		 get { } //Length: 78
	}

	public Vector3[] normals
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 78
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		 set { } //Length: 91
	}

	public Vector4[] tangents
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public int[] triangles
	{
		 get { } //Length: 216
		 set { } //Length: 221
	}

	public Vector2[] uv
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public Vector2[] uv2
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public Vector2[] uv3
	{
		 set { } //Length: 139
	}

	public Vector2[] uv4
	{
		 get { } //Length: 113
		 set { } //Length: 139
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 78
	}

	public Vector3[] vertices
	{
		 get { } //Length: 110
		 set { } //Length: 136
	}

	[RequiredByNativeCode]
	public Mesh() { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	public void Clear(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void Clear() { }

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	public Matrix4x4[] get_bindposes() { }

	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	public int get_blendShapeCount() { }

	public BoneWeight[] get_boneWeights() { }

	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	public Color[] get_colors() { }

	public Color32[] get_colors32() { }

	[NativeMethod("GetIsReadable")]
	public bool get_isReadable() { }

	public Vector3[] get_normals() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	public Vector4[] get_tangents() { }

	public int[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	public Vector2[] get_uv4() { }

	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	public Vector3[] get_vertices() { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	public uint GetBaseVertex(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	private uint GetBaseVertexImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = True, ThrowsException = True)]
	public int GetBlendShapeIndex(string blendShapeName) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = True, ThrowsException = True)]
	public string GetBlendShapeName(int shapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	private BoneWeight[] GetBoneWeightsImpl() { }

	public void GetColors(List colors) { }

	public uint GetIndexCount(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	private uint GetIndexCountImpl(int submesh) { }

	public uint GetIndexStart(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	private uint GetIndexStartImpl(int submesh) { }

	[ExcludeFromDocs]
	public void GetIndices(List indices, int submesh) { }

	public void GetIndices(List indices, int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	public int[] GetIndices(int submesh) { }

	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray", HasExplicitThis = True)]
	private void GetIndicesNonAllocImpl(out int[] values, int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List buffer, int capacity, VertexAttribute channel, int dim) { }

	private void GetListForChannel(List buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	public void GetNormals(List normals) { }

	public void GetTangents(List tangents) { }

	public MeshTopology GetTopology(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	private MeshTopology GetTopologyImpl(int submesh) { }

	public int[] GetTriangles(int submesh) { }

	public void GetTriangles(List triangles, int submesh, bool applyBaseVertex) { }

	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	public void GetTriangles(List triangles, int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = True)]
	private uint GetTrianglesCountImpl(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = True)]
	private void GetTrianglesNonAllocImpl(out int[] values, int submesh, bool applyBaseVertex) { }

	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	public void GetUVs(int channel, List uvs) { }

	private void GetUVsImpl(int uvIndex, List uvs, int dim) { }

	public void GetVertices(List vertices) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	public void MarkDynamic() { }

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl() { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateNormals() { }

	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	public void RecalculateTangents(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateTangents() { }

	[NativeMethod("RecalculateTangents")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	public void set_bindposes(Matrix4x4[] value) { }

	public void set_boneWeights(BoneWeight[] value) { }

	public void set_bounds(Bounds value) { }

	private void set_bounds_Injected(ref Bounds value) { }

	public void set_colors(Color[] value) { }

	public void set_colors32(Color32[] value) { }

	public void set_indexFormat(IndexFormat value) { }

	public void set_normals(Vector3[] value) { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	public void set_subMeshCount(int value) { }

	public void set_tangents(Vector4[] value) { }

	public void set_triangles(int[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_uv3(Vector2[] value) { }

	public void set_uv4(Vector2[] value) { }

	public void set_vertices(Vector3[] value) { }

	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	[ExcludeFromDocs]
	public void SetColors(List inColors, int start, int length) { }

	public void SetColors(List inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List inColors) { }

	[ExcludeFromDocs]
	public void SetColors(List inColors, int start, int length) { }

	public void SetColors(List inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List inColors) { }

	[ExcludeFromDocs]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	public void SetIndices(List indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List values, int start, int length, MeshUpdateFlags flags) { }

	private void SetListForChannel(VertexAttribute channel, List values, int start, int length, MeshUpdateFlags flags) { }

	public void SetNormals(List inNormals) { }

	public void SetNormals(List inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(List inNormals, int start, int length) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetTangents(List inTangents, int start, int length) { }

	public void SetTangents(List inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTangents(List inTangents) { }

	[ExcludeFromDocs]
	public void SetTriangles(int[] triangles, int submesh) { }

	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetTriangles(List triangles, int submesh) { }

	public void SetTriangles(List triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List uvs, int start, int length) { }

	public void SetUVs(int channel, List uvs) { }

	public void SetUVs(int channel, List uvs) { }

	public void SetUVs(int channel, List uvs) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List uvs, int start, int length) { }

	public void SetUVs(int channel, List uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetUVs(int channel, List uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetUVs(int channel, List uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List uvs, int start, int length) { }

	private void SetUvsImpl(int uvIndex, int dim, List uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertices(List inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(List inVertices, int start, int length) { }

	public void SetVertices(List inVertices) { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

}

