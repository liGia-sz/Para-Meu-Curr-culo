using System;
					
public class Program
{
	public static void Main()
	{
// Cabeçalho:
       Console.ForegroundColor = ConsoleColor.DarkYellow;
	Console.WriteLine("=".PadLeft(50, '='));
	Console.WriteLine("CARDÁPIO CARVÃO GRILL");
	Console.WriteLine("=".PadLeft(50,'='));
	Console.ResetColor();

// Variáveis:		
          decimal valorlan = 0 ,valorpor = 0 , valorbeb = 0 , total = 0;

// Inputs: 
       Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("MENU DE LANCHES:\n(1) X-BURGUER : R$20,90 \t  (2) X-TUDO : R$31,20\t\n(3) X-BACON : R$22,30\t\t (4) X-SALADA : R$25,00\t\n(5) X-FRANGO : R$21,50\t\t(6) X-CALABRESA : R$21,50\t\n(7) MISTO QUENTE : R$15,20\t(8) PÃO COM OVO : R$10,00\t\n\nEscolha o Número de seu lanche: ");
             int lanch3s = int.Parse (Console.ReadLine());
          Console.WriteLine("Quantidade de lanches:");
            int quantlanche = int.Parse (Console.ReadLine());

          Console.WriteLine("\nMENU DE PORÇÕES:\n(1) BATATA FRITA P : R$12,00\t\t  (2) BATATA FRITA M : R$14,00\t\n(3) BATATA COM BACON : R$18,00\t\t(4)SALADA COMPLETA : R$18,60\t\n(5)PASTEL FRITO : R$11,50\t\t     (6)COXINHAS : R$8,70\t\n\nO que vai pedir? ");
           int porc0es = int.Parse(Console.ReadLine());
          Console.WriteLine ("Quantidade de porções:");
           int quantporc = int.Parse(Console.ReadLine());

          Console.WriteLine ("\nMENU DE BEBIDAS:\n(1)SUCO DE FRUTA : R$10,50\t\t    (2)ÁGUA MINERAL : R$2,00\t\n(3)REFRIGERANTE LATA : R$10,30\t\t(4)REFRIGERANTE 1L : R$12,90\t\n(5)REFRIGERANTE 2L : R$16,50\t\t  (6)LIMONADA : R$8,5O\t\n\nEscolha sua bebida: ");
          int b3bidas = int.Parse(Console.ReadLine());
          Console.WriteLine("Quantidade de bebidas: ");
          int quantbebi = int.Parse(Console.ReadLine());

         Console.WriteLine("\n-SEU PEDIDO-\n");
       Console.ResetColor();
		
// Condicionais para os lanches:
switch (lanch3s) 
{
case 1: 
       Console.WriteLine($" - {quantlanche} X-Burguer R$20,90");
        valorlan = quantlanche * 20.9m;
break;
case 2: 
        Console.WriteLine($"- {quantlanche} X-Tudo R$31,90");
        valorlan = quantlanche * 31.2m;
break;
case 3: 
         Console.WriteLine($"- {quantlanche} X-Bacon R$22,30");
         valorlan = quantlanche * 22.3m;
break;
case 4:
      Console.WriteLine($"- {quantlanche} X-Salada R$25,00");
       valorlan = quantlanche * 25m;
break;
case 5:
       Console.WriteLine($"- {quantlanche} X-Frango R$21,50");
       valorlan = quantlanche * 21.5m;
break;
case 6:
       Console.WriteLine ($"- {quantlanche} X-Calabresa R$21,50");
       valorlan = quantlanche * 21.5m;
break;
case 7: 
       Console.WriteLine($"- {quantlanche} Misto Quente R$15,20");
					   valorlan= quantlanche * 15.2m;
break;
case 8:
       Console.WriteLine($"- {quantlanche} Pão com Ovo R$10,00");
        valorlan = quantlanche * 10m;
break;
default:
       Console.WriteLine("- Lanche ", lanch3s, " não incluso no nosso cardápio!"); 
break;
   }

// Condicionais para porções:
switch (porc0es)
    {
case 1:
       Console.WriteLine($"- {quantporc} Batata Frita P R$12,00\t");
       valorpor = quantporc * 12m;
break;
case 2:
        Console.WriteLine($"- {quantporc} Batata Frita M R$14,00\t");
        valorpor = quantporc * 14m;
break;
case 3:
       Console.WriteLine($"- {quantporc} Batata com Bacon R$18,00\t");
       valorpor = quantporc * 18m;
break;
case 4:
       Console.WriteLine($"- {quantporc} Salada Completa R$18,60\t");
        valorpor = quantporc * 18.6m;
break;
case 5:
       Console.WriteLine($"- {quantporc} Pastel Frito R$11,50\t");
        valorpor = quantporc * 11.5m;
break;
case 6:
       Console.WriteLine($"- {quantporc} Coxinhas R$8,70\t");
        valorpor = quantporc * 8.7m;
break;

// Caso cliente não escolha uma porção
default: 
       if (quantporc != 1 ||quantporc != 2 || quantporc !=  3 || quantporc != 4 ||quantporc != 5 || quantporc != 6)
{
       valorpor = 0;
       Console.WriteLine("- Sem Porção 00,00");
}
break;
}

switch(b3bidas)
 {
case 1:
       Console.WriteLine($"- {quantbebi} Suco de Fruta R$10,50");
        valorbeb = quantbebi * 10.5m;
break;
case 2: 
       Console.WriteLine($"- {quantbebi} Água Mineral R$2,00");
        valorbeb = quantbebi * 2m;
break;
case 3: 
	Console.WriteLine ($"- {quantbebi} Refrigerante Lata R$10,30");
	 valorbeb = quantbebi * 10.3m;
break;
case 4:
	 Console.WriteLine ($"- {quantbebi} Refrigerante 1L R$12,90");
	  valorbeb = quantbebi * 12.9m;
break;
case 5: 
	Console.WriteLine ($"- {quantbebi} Refrigerante 2L R$16,50");
	 valorbeb = quantbebi * 16.5m;
break;
case 6:
       Console.WriteLine ($"- {quantbebi} Limonada R$8,50");
	 valorbeb = quantbebi * 8.5m;
break;
default:
	if (quantbebi != 1 || quantbebi != 2 || quantbebi != 3 || quantbebi != 4 || quantbebi != 5 || quantbebi != 6)
	 valorbeb = 0;
         Console.WriteLine ("- Sem Bebida 00,00");
break;
}
total = valorlan + valorpor + valorbeb;
Console.WriteLine($"\nTOTAL A PAGAR: R${total:F2}\n");  
	}
}
