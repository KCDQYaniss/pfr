namespace System.Reflection.Emit;

public class ILGenerator
{

	public override int ILOffset
	{
		 get { } //Length: 62
	}

	public override Label BeginExceptionBlock() { }

	public override void BeginFinallyBlock() { }

	public override LocalBuilder DeclareLocal(Type localType) { }

	public override Label DefineLabel() { }

	public override void Emit(OpCode opcode) { }

	public override void Emit(OpCode opcode, int arg) { }

	public override void Emit(OpCode opcode, ConstructorInfo con) { }

	public override void Emit(OpCode opcode, Label label) { }

	public override void Emit(OpCode opcode, LocalBuilder local) { }

	public override void Emit(OpCode opcode, FieldInfo field) { }

	public override void Emit(OpCode opcode, MethodInfo meth) { }

	public override void Emit(OpCode opcode, string str) { }

	public override void Emit(OpCode opcode, Type cls) { }

	public override void EndExceptionBlock() { }

	public override int get_ILOffset() { }

	public override void MarkLabel(Label loc) { }

}

