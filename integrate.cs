using System;


	class Program
	{
		static void Main(string[] args)
		{
			
//////////////выделение памяти//////////////
			
			int a = 0, b = 1, N;
			double h = 0.001;
			double c = (b-a)/h;
			N = (int)(c + 1);
			
//////////////метод прямоугольников//////////////
			
			double xp = 0;
			double summp = 0;
			for (int i = 1; i < N; i++) 
			{	
				summp += (xp - h/2)*(xp - h/2);
				xp = xp + h;

			}

//////////////метод трапеций//////////////		
			
			double xt = 0;
			double summt = (a*a + b*b)/2;			
			for (int i = 1; i < N-1; i++) 
			{
				summt += xt*xt;
				xt = xt + h;
			}
			
//////////////вывод//////////////	
			Console.WriteLine("Интегрирование функции f(x) = x*x на отрезке [0,1] с шагом  h = 0.001");	
			Console.WriteLine("Метод прямоугольников: " + h*summp);		
			Console.WriteLine("Метод трапеций: " + h*summt);
			
			Console.ReadKey();
		}
	}

