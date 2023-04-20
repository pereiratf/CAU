using System;
					
public class c1
{
	public static void Main()
	{
		int valor;
		int dez, cinco, um;
		Console.WriteLine("Informe o valor que deseja sacar: ");
		valor = int.Parse(Console.ReadLine());
		dez = valor/10; //divide por 10 para saber quantas notas de 10 dar
		valor = valor%10; //o resto da divisão vai retornar um valor menor que 10 (já separamos as notas de 10)
		cinco = valor/5; //o que não foi dado em notas de 10 será distribuído no que precisar de notas de 5
		um = valor%5; //sobra final é a unidade
		
		Console.WriteLine("Devem ser dadas: "+dez+" notas de 10, "+cinco+" notas de 5 e "+um+" notas de um.");
		
		
	}
}