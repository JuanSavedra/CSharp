using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryListsArrays {
    class Calculator {
        public static int Sum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }

            return sum;
        }

        public static int TripleRef(ref int x) {
            return x = x * 3;
        }

        public static int TripleOut(int origin, out int result) { /* Nesse caso passamos o valor inicial
                                                                  e o valor para referência */
            return result = origin * 3; 
        }
    }
}
