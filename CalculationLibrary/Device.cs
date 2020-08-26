using System.Collections.Generic;
using System.Linq;

namespace CalculationLibrary
{
    public abstract class Device
    {
        public abstract int CalculateR(List<int> parameters);
    }
    class Device1 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Sum(x => x);

            if (res >= 255)
            {
                return res % 255;
            }
            else
            {
                return 0;
            }

        }
    }
    public class Device2 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Aggregate((x, y) => x * y);

            if (res >= 255)
            {
                return res % 255;
            }
            else
            {
                return 0;
            }
        }
    }

    public class Device3 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Max();
            return res;
        }
    }

    public class Device4 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Min();
            return res;
        }
    }
}
