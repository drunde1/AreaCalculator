namespace AreaCalculator
{
    public class Triangle : IFigure
    {
        private double _aSide = 0, _bSide = 0, _cSide = 0;
        public Triangle(double a, double b, double c)
        {
            _aSide = a;
            _bSide = b;
            _cSide = c;
        }
        public double GetArea()
        {
            var p = (_aSide + _bSide + _cSide) / 2;

            return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));
        }

        public bool IsRightAngeled()
        {
            if ((_aSide * _aSide == _bSide * _bSide + _cSide * _cSide ||
                _bSide * _bSide == _aSide * _aSide + _cSide * _cSide ||
                _cSide * _cSide == _aSide * _aSide + _bSide * _bSide)
                && _aSide != 0 && _bSide != 0 && _cSide != 0)

                return true;

            return false;
        }
    }
}
