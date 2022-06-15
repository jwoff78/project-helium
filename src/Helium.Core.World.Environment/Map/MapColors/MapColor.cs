namespace Helium.Core.World.Environment.Map.MapColors;

using System;

public record MapColor
{
	public UInt16 Id { get; init; }
	public UInt32 Color { get; init; }
}
