﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Packet;
using Common.Model;




namespace Game.Packet.Client
{


    public class RpShopClose : PacketReader
    {
        public override void Execute(User user)
        {

         
            byte opCode = ReadByte();
            byte sizeCode = ReadByte();
            byte headCode = ReadByte();
            
           
           
            return;
        }
    }
}
