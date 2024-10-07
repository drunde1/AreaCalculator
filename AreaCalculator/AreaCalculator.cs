namespace AreaCalculator
{
    public static class AreaCalculator
    {
        private static IFigure? figure;
        public static double GetArea(double[] args)
        {
            double area = -1;
            switch (args.Length)
            {
                case 1:
                    figure = new Circle(args[0]);
                    area = figure.GetArea(); 
                    break;
                case 3:
                    figure = new Triangle(args[0], args[1], args[2]); 
                    area = figure.GetArea();  
                    break;
            }
            return area;
        }

        public static bool IsTriangleRightAngeled(double[] args)
        {
            if (args.Length == 3)
            {
                var triangle = new Triangle(args[0], args[1], args[2]);
                return triangle.IsRightAngeled();
            }
            else return false;
        }
    }
}
