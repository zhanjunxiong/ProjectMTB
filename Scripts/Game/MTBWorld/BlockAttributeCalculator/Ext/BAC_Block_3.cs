using System;
namespace MTB
{
	public class BAC_Block_3 : BlockAttributeCalculator
	{
		#region implemented abstract members of BlockAttributeCalculator

		public override BlockType BlockType {
			get {
				return BlockType.Block_3;
			}
		}

		#endregion

		public BAC_Block_3 ()
		{
		}
	}
}

