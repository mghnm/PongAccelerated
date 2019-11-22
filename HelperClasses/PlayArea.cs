namespace PongAccelerated
{
    /// <summary>
    /// This class acts as a singleton where we need to define our play area once and from then on we should
    /// Access the paramters as if they were constants.
    /// To do this I allow initialization once through the singleton pattern
    /// And have no set property defined.
    /// The reason for a logical play area is that it will bound our components within its borders.
    /// The actual borders are slightly smaller than the form since the form size includes the bezels 
    /// A 1280 x 720 form has the actual play area of 1264 x 681 by my measurements
    /// </summary>
    public sealed class PlayArea
    {
        private static int _xMin;
        private static int _xMax;
        private static int _yMin;
        private static int _yMax;

        private static PlayArea instace = null;

        private PlayArea(int xMin, int xMax, int yMin, int yMax)
        {
            _xMin = xMin;
            _xMax = xMax;
            _yMin = yMin;
            _yMax = yMax;
        }

        public static int X_MAX
        {
            get => _xMax;
        }

        public static int X_MIN
        {
            get => _xMin;
        }

        public static int Y_MAX
        {
            get => _yMax;
        }

        public static int Y_MIN
        {
            get => _yMin;
        }

        public static int X_MID
        {
            get => _xMax / 2;
        }

        public static int Y_MID
        {
            get => _yMax / 2;
        }

        public static PlayArea GetInstance(int xMin, int xMax, int yMin, int yMax)
        {
            if (instace == null)
            {
                instace = new PlayArea(xMin, xMax, yMin, yMax);
                return instace;

            }
            else
            {
                return instace;
            }

        }

    }
}