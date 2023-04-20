using System;
					
public class c1
{
	public static void Main()
	{
		int n; //numero digitado pelo usuário
		int u,d,c,m, dm; //digitos
				//Laço de repetição do tipo do~while
		do {
			Console.WriteLine("Informe UM número de 5 digitos: ");
			n = Convert.ToInt32(Console.ReadLine());
		} while (n<=9999 || n>99999);
		//repete a pergunta acima, até que digite um número válido
			u = n%10; //divide n por 10 e pega o resto da divisão
			n = n/10; //coloca o resultado da divisão inteira
		//as duas linhas funcionam como se eu tivesse tirado o bit da unidade do número
			d = n%10; //divide n por 10 e pega o resto da divisão
			n = n/10; //coloca o resultado da divisão inteira
		
			c = n%10; //divide n por 10 e pega o resto da divisão
			n = n/10; //coloca o resultado da divisão inteira
		
			m = n%10; //divide n por 10 e pega o resto da divisão
			dm = n/10; //coloca o resultado da divisão inteira
		
			Console.WriteLine("Número invertido: "+u+d+c+m+dm);
		
	}
}