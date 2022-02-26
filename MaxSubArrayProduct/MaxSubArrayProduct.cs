using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSubArrayProduct
{
    internal class MaxSubArrayProduct
    {
        public static int FindMaxSubArrayProductArrayLength(int[] arr)
        {
            // int[] arr = new int[] { 1, -1, -1, -1, 1, 1 }; // o/p 4 (2,5)
            int maxLength = arr.Length > 0 ? arr[0] : 0;
            List<IndicesValueModel> indicesValueModelList = new List<IndicesValueModel>();
            if (arr.Length > 0)
            {
                int mult = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    mult = arr[i];
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        mult = mult * arr[j];
                        if (mult == 1)
                        {
                            indicesValueModelList.Add(new IndicesValueModel()
                            {
                                Indicies = Convert.ToString(i + "," + j),
                                CalculatedLength = (j - i) + 1
                            });
                        }
                    }
                }
            }
            if (indicesValueModelList?.Count > 0)
                maxLength = indicesValueModelList.Max(x => x.CalculatedLength);

            return maxLength;
        }
    }
}
