/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AG_ShowerEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AG_ShowerEastAddonDeed();
			}
		}

		[ Constructable ]
		public AG_ShowerEastAddon()
		{
			AddComponent( new AddonComponent( 1293 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 263 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 1293 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 262 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 262 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 1293 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 4833 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 1293 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2919 ), 0, -1, 11 );
			AddComponent( new AddonComponent( 3842 ), 0, -1, 12 );
			AddComponent( new AddonComponent( 5154 ), 0, -1, 12 );
			AddComponent( new AddonComponent( 1293 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 5534 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 4844 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 1293 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 1293 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 6194 ), -1, 0, 15 );
			AddComponent( new AddonComponent( 14138 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 1293 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 1293 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 262 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 263 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 261 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 261 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 261 ), 1, -2, 0 );
			AddonComponent ac;
			ac = new AddonComponent( 261 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 261 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 261 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 263 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1293 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 262 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 262 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 262 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 263 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 4844 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 4833 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 6194 );
            ac.Name = "Massage-O-Matic";
			AddComponent( ac, -1, 0, 15 );
			ac = new AddonComponent( 14138 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2919 );
			ac.Hue = 2101;
			AddComponent( ac, 0, -1, 11 );
			ac = new AddonComponent( 3842 );
			ac.Name = "Shampoo";
			AddComponent( ac, 0, -1, 12 );
			ac = new AddonComponent( 5154 );
			ac.Name = "Soap";
			AddComponent( ac, 0, -1, 12 );

		}

		public AG_ShowerEastAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class AG_ShowerEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AG_ShowerEastAddon();
			}
		}

		[Constructable]
		public AG_ShowerEastAddonDeed()
		{
			Name = "AG_ShowerEast";
		}

		public AG_ShowerEastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}