namespace Helium.Network.Api.Vanilla.V15.Packets.Clientbound.Login;

using Helium.Api.Mojang;

/// <summary>
/// Login-C0x03: Clientbound set compression packet. Wholly unused by Helium networking.
/// </summary>
public struct SetCompressionPacket : IPacket
{
	public VarInt Id => 0x03;

	/// <summary>
	/// Compression limit
	/// </summary>
	public VarInt CompressionSize { get; set; } = 0;

	public void Read(PacketStream stream)
	{
		_ = stream.ReadVarInt(); // we void anything sent here
	}

	public void Write(PacketStream stream)
	{
		stream.WriteVarInt(Id.Length + 1);
		stream.WriteVarInt(Id);
		stream.WriteVarInt(0x00);
	}

	/*
	 * For reference, I am having to put a constuctor here because you can se a field initial initializer without creating a constructor
	 */
	public SetCompressionPacket() { }

}
