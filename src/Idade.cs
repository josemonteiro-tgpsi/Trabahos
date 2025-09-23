using System;

namespace Program {
  class Program {
      int Dn, Mn, An, Da, Ma, Aa, Idade;
    
      Console.WriteLine("Dia (hoje): ");  
      Da = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("MÊs (hoje): ");  
      Ma = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Ano (hoje): ");  
      Aa = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Dia (nascimento): ");
      Dn = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Mês (nascimento): ");
      Mn = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Ano (nascimento): ");
      An = Convert.ToInt16(Console.ReadLine());


      if (Mn < Ma) {
        Console.WriteLine($"A idade é {Aa - An}");
      }

    
      if (Mn == Ma) {
        if (Dn <= Da) Console.Write($"A idade é {Aa - An});
      }

      else if (Mn >= Ma) {
          // ----------
        
      } 
    }
  }
}
