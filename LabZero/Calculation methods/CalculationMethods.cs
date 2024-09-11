namespace LabZero
{
    public class TubeCalculationMethods
    {
        public static (double, double) GetTube(double lenghtTube, double internalRadius, double externalRadius, double density)
        {
            double V, m;

            if (internalRadius >= externalRadius || internalRadius <= 0 || externalRadius <= 0)
            {
                throw new Exception("Внутренний радиус должен быть меньше чем внешний, и радиусы не могут быть равны 0");
            }

            V = lenghtTube * Math.PI * (Math.Pow(externalRadius, 2) - Math.Pow(internalRadius, 2)); //Получаем объём трубы
            m = V * density; //Получаем массу трубы

            return (V, m);
        }

        public static double GetMetr(double number, LengthUnits lengthUnits)
        {
            switch (lengthUnits)
            {
                case LengthUnits.Millimeter:
                    {
                        return number / 1000;
                    }
                case LengthUnits.Centimetre:
                    {
                        return number / 100;
                    }
                case LengthUnits.Metre:
                    {
                        return number;
                    }
                case LengthUnits.Kilometer:
                    {
                        return number * 1000;
                    }
                default:
                    {
                        throw new Exception("Unknown units");
                    }
            }
        }

        public static Dictionary<string, LengthUnits> StringLenghtUnits = new Dictionary<string, LengthUnits>
        {
            ["Мм."] = LengthUnits.Millimeter,
            ["См."] = LengthUnits.Centimetre,
            ["Метр."] = LengthUnits.Metre,
            ["Километр."] = LengthUnits.Kilometer
        };
    }

    public enum LengthUnits
    {
        Millimeter,
        Centimetre,
        Metre,
        Kilometer
    }
}
