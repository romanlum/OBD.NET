﻿using OBD.NET.DataTypes;

namespace OBD.NET.OBDData
{
    public class EngineCoolantTemperature : AbstractOBDData
    {
        #region Properties & Fields

        public DegreeCelsius Temperature => new DegreeCelsius(A - 40, -40, 215);

        #endregion

        #region Constructors

        public EngineCoolantTemperature()
            : base(0x05, 1)
        { }

        #endregion
    }
}
