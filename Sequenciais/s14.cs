using System;
					
public class c1
{
	public static void Main()
	{
		int n; //numero digitado pelo usuário
		int u,d,c,m; //digitos
		int soma, multiplica, subtrai, dv; //operações
		//Laço de repetição do tipo do~while
		do {
			Console.WriteLine("Informe o número da sua conta (4 digitos): ");
			n = Convert.ToInt32(Console.ReadLine());
		} while (n<=999 || n>9999);
		//repete a pergunta acima, até que digite um número válido
		u = n%10; //divide n por 10 e pega o resto da divisão
		n = n/10; //coloca o resultado da divisão inteira
		//as duas linhas funcionam como se eu tivesse tirado o bit da unidade do número
		d = n%10; //divide n por 10 e pega o resto da divisão
		n = n/10; //coloca o resultado da divisão inteira
		
		c = n%10; //divide n por 10 e pega o resto da divisão
		m = n/10; //coloca o resultado da divisão inteira
		soma = u+d+c+m;
		multiplica = u*d*c*m;
		subtrai = multiplica - soma;
		dv = subtrai%9;
		Console.WriteLine("conta com digito verificador: "+m+c+d+u+" - "+dv);
		
	}
}