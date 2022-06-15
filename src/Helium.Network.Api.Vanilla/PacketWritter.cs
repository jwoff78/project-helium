namespace Helium.Network.Api.Vanilla;
using System;
using System.IO.Pipelines;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public ref struct PacketWritter
{
	private PipeWriter Buffer { get; set; }

	public PacketWritter(PipeWriter buffer)
	{
		this.Buffer = buffer;
	}
}
