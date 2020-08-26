using System.Collections.Generic;
using System.Linq;

namespace CalculationLibrary
{
    public class CalculationService
    {
        public static Device[] devices = { new Device1(), new Device2(), new Device3(), new Device4() };

        public static List<int> CalculateR(List<List<int>> parameters)
        {
            List<int> arrayR = new List<int>();

            foreach (var item in parameters)
            {
                var indexOfDevice = item[0];
                var parametersWithoutDeviceType = item.Skip(1).ToList();
                var res = devices[indexOfDevice - 1].CalculateR(parametersWithoutDeviceType);
                arrayR.Add(res);
            }

            return arrayR;
        }

        public static float CalculateMediana(List<int> arrayR)
        {
            var wValues = (from a in arrayR
                           where a % 2 != 0 && a > 3 && a < 1000001
                           select a).OrderBy(x => x).ToList();

            float mediana = 0;

            if (wValues.Count() % 2 == 0)
            {
                mediana = (float)(wValues[(wValues.Count() / 2 - 1)] + wValues[(wValues.Count() / 2)]) / 2;
            }
            else
            {
                mediana = wValues[(wValues.Count() / 2)];
            }

            return mediana;
        }
    }
}
