// using System.Numerics;

// // enum DayOfWeek {
// //     Monday,
// //     Tuesday,
// //     Wednesday,
// //     Thursday,
// //     Friday,
// //     Saturday,
// //     Sunday
// // }

// namespace Program {
//     class Program {
//         static void Main(string[] args) {
//             DateTime date = DateTime.Now;
//             if(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday || (date.DayOfWeek == DayOfWeek.Monday && date.Hour < 9) || (date.DayOfWeek == DayOfWeek.Friday && date.Hour > 18)) {
//                 AfficherWeekEnd();
//             } else {
//                 if(date.Hour >= 9 && date.Hour < 15) { 
//                     Bonjour();
//                 } else {
//                     Bonsoir();
//                 }
//             }
//         }

//         static void AfficherWeekEnd() {
//             Console.WriteLine($"Bon Week-End {Environment.UserName}");
//         }

//         static void Bonjour() {
//             Console.WriteLine($"Bonjour {Environment.UserName}");
//         }

//         static void Bonsoir() {
//             Console.WriteLine($"Bonsoir {Environment.UserName}");
//         }
//     }
// }

namespace Program {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine(CalculEntiers(1, 100));
      List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6};
      Console.WriteLine(CalculMoyenne(liste));
      Console.WriteLine(SommeMultiple());
    }
    
    static int CalculEntiers(int min, int max) {
      int sum = 0;
      for(int value = min; value <= max; value++) {
        sum += value;
      }
      return sum;
    }

    static double CalculMoyenne(List<double> list) {
      double mean;
      double total = 0;
      foreach(double value in list) {
        total += value;
      }
      mean = total / list.Count();
      return mean;
    }

    static int SommeMultiple() {
      List<int> trois = new List<int>();
      List<int> cinq = new List<int>();
      int total = 0;
      for(int i = 1; i <= 100; i++) {
        if(i % 3 == 0) trois.Add(i);
        if(i % 5 == 0) cinq.Add(i);
      }
      foreach(int t in trois) {
        foreach(int c in cinq) {
          if(t == c) total += t;
        }
      }
      return total;
    }
  }
}