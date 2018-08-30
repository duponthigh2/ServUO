
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class FrostedBathTableAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FrostedBathTableAddonDeed();
			}
		}

		[ Constructable ]
		public FrostedBathTableAddon()
		{



			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 12, 1150, -1, "frosted glass", 1);// 1
			AddComplexComponent( (BaseAddon) this, 6420, 0, 0, 12, 283, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 8, 0, -1, "shelves", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 8, 0, -1, "shelves", 1);// 4
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 8, 1150, -1, "frosted glass", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 4, 0, -1, "shelves", 1);// 6
			AddComplexComponent( (BaseAddon) this, 6420, 0, 0, 7, 1150, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 6420, 0, 0, 4, 31, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2815, 0, 0, 0, 0, -1, "shelves", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 0, 0, -1, "shelves", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2813, 0, 0, 4, 0, -1, "shelves", 1);// 11
			AddComplexComponent( (BaseAddon) this, 7386, 0, 0, 4, 1150, -1, "frosted glass", 1);// 12

		}

		public FrostedBathTableAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
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

	public class FrostedBathTableAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FrostedBathTableAddon();
			}
		}

		[Constructable]
		public FrostedBathTableAddonDeed()
		{
			Name = "FrostedBathTable";
		}

		public FrostedBathTableAddonDeed( Serial serial ) : base( serial )
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