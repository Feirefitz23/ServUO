using System;

namespace Server.Items
{
    public class CoagulatedLegs : PeerlessKey
    {
        [Constructable]
        public CoagulatedLegs()
            : base(0x1CDF)
        {
            this.Weight = 1;
        }

        public CoagulatedLegs(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get
            {
                return 1074327;
            }
        }// coagulated legs
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
			
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
			
            int version = reader.ReadInt();
        }
    }
}