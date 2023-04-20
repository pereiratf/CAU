using System;
					
public class c1
{
	public static void Main()
	{
		int dia, mes, ano;
		Console.WriteLine("Informe respectivamente dia, mes e ano: ");
		dia = int.Parse(Console.ReadLine());
		mes = int.Parse(Console.ReadLine());
		ano = int.Parse(Console.ReadLine());
		
		if (ano>=0){
			switch(mes) {
				case 1: case 3: case 5: case 7: case 8: case 10: case 12: 
					if (dia>0 && dia<32) {
						Console.WriteLine("Data válida!");
					} else {
						Console.WriteLine("Data inválida!");
					}
					break;
				case 4: case 6: case 9: case 11:
					if (dia>0 && dia<31) {
						Console.WriteLine("Data válida!");
					} else {
						Console.WriteLine("Data inválida!");
					}
					break;
				case 2: 
					if( (ano%4==0 && ano%100!=0) || ano%400==0) {
						if (dia>0 && dia<30) {
							Console.WriteLine("Data válida!");
						} else {
							Console.WriteLine("Data inválida!");
						}
					} else {
						if (dia>0 && dia<28) {
							Console.WriteLine("Data válida!");
						} else {
							Console.WriteLine("Data inválida!");
						}
					}
				break;

			};
		} else {
			Console.WriteLine("Data inválida!");
		}
	}
}