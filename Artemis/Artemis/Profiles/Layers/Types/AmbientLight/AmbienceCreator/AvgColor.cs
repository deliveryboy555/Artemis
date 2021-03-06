﻿namespace Artemis.Profiles.Layers.Types.AmbientLight.AmbienceCreator
{
    public class AvgColor
    {
        #region Properties & Fields

        private int _rCount;
        private int _r;
        private int _gCount;
        private int _g;
        private int _bCount;
        private int _b;

        public byte R => (byte) (_rCount > 0 ? _r/_rCount : 0);
        public byte G => (byte) (_gCount > 0 ? _g/_gCount : 0);
        public byte B => (byte) (_bCount > 0 ? _b/_bCount : 0);

        #endregion

        #region Methods

        public void AddR(byte r)
        {
            _r += r;
            _rCount++;
        }

        public void AddG(byte g)
        {
            _g += g;
            _gCount++;
        }

        public void AddB(byte b)
        {
            _b += b;
            _bCount++;
        }

        #endregion
    }
}