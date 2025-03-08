// Console.WriteLine("Digite um numero: ");
// double num = Convert.ToDouble(Console.ReadLine());

// double quadrado = Math.Pow(num, 2);

// Console.Write("Quadrado de " + num + " é " + quadrado);
// Console.ReadKey();

// Console.WriteLine("Digite um numero: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// double raiz =  Math.Sqrt(num1);

// Console.Write("Raiz de " + num1 + " é " + raiz);
// Console.ReadKey();

// Console.Write("Digite seu nome: ");
// string nome = Console.ReadLine();
// string nome_Ma = nome.ToUpper();
// Console.WriteLine("Nome maiusculo: " + nome_Ma);

// string nome_mi = nome.ToLower();
// Console.WriteLine("Nome minusculo: " + nome_mi);

// int pos = nome.IndexOf("A");
// Console.WriteLine("Posicao do 'A': " + pos);

// string nome_cort = nome.Substring(5, 5);
// Console.WriteLine("Nome com corte: " + nome_cort);
// string nome_troca = nome.Replace("a", "e");
// Console.WriteLine("Nome trocado: ");

// Console.ReadKey();

// 1-
// Console.WriteLine("---------Calcule a área do circulo---------");

// Console.Write("Digite um número: ");
// double A;
// double r = Convert.ToDouble(Console.ReadLine());
// r = Math.Pow(r, 2) ;

// A = r * Math.PI;

// Console.ReadKey();

// Console.WriteLine("---------Calcule o diâmetro do circulo---------");

// Console.Write("Digite um número: ");
// double R = Convert.ToDouble(Console.ReadLine());

// double D = 2 * R;

// Console.WriteLine("---------Calcule o perímetro do círculo---------");
// Console.Write("Digite um número: ");

// double P;
// double RR = Convert.ToDouble(Console.ReadLine());
// P = 2 * Math.PI * RR;

// Console.WriteLine("");

// Console.WriteLine("Seu diâmetro é de: " + D);
// Console.WriteLine("Seu perímetro é de: " + P);
// Console.WriteLine("Sua área é de: " + A);

// 2-
// Console.WriteLine("----------Calcúlo da formula de bhaskara----------");
// Console.Write("");

// Console.Write("Digite o um número para a letra A: ");
// double a = Convert.ToDouble(Console.ReadLine());

// Console.Write("Digite o um número para a letra B: ");
// double b = Convert.ToDouble(Console.ReadLine());

// Console.Write("Digite o um número para a letra C: ");
// double c = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("");

// b = Math.Pow(b, 2);

// double Delta = b -4 * a * c;

// Console.WriteLine("Resultado de Delta: " + Delta);
// Console.WriteLine("");

// //Para zerar a variavel b
// b = default;

// Console.Write("Digite o numero da letra b novamente: ");
// b = Convert.ToDouble(Console.ReadLine());

// double x1 = (-b + Delta) / 2 * a;
// double x2 = (-b - Delta) / (2 * a);

// Console.WriteLine("Seu resultado de X1 foi: " + x1);
// Console.ReadKey();

// Console.WriteLine("Seu resultado de X2 foi: " + x2);

// 3-
// Console.Write("Digite seu nome completo: ");

// string nome = Console.ReadLine();
// double pos = nome.IndexOf("a");
// Console.WriteLine("Posicao do 'a': " + pos);
// Console.WriteLine("");

// string qt_caracter = nome.Substring(5, 11);
// Console.WriteLine("Caracteres do 5 ao 10: " + qt_caracter);
// Console.WriteLine("");

// double qt_letras = nome.Length;
// Console.WriteLine("Quantas letras tem o seu nome: " + qt_letras + " Letras");
// Console.WriteLine("");

// string letra_troca = nome.Replace("a", "o");
// Console.WriteLine("Letras trocadas: " + letra_troca);

// 4-
// Console.WriteLine("Gerador de email da fatec: ");
// Console.WriteLine("Digite seu nome: ");
// string nome = Console.ReadLine();

// Random random = new Random();

// int aleatorio1 = random.Next(1, 9);
// string ale1 = aleatorio1.ToString();

// int aleatorio2 = random.Next(1, 9);
// string ale2 = aleatorio1.ToString();

// int aleatorio3 = random.Next(1, 9);
// string ale3 = aleatorio1.ToString();

// string result = ale1 + ale2 + ale3;

// Console.WriteLine("Seu email é: " + nome + result + "@fatec.sp.gov.br");

// 5- Com gerador de senha também
// Console.WriteLine("Gerador de email da fatec: ");
// Console.Write("Digite seu nome completo: ");

// string nome = Console.ReadLine();
// nome = nome.ToLower();

// Random random = new Random();

// int aleatorio1 = random.Next(1, 9);
// string ale1 = aleatorio1.ToString();

// int aleatorio2 = random.Next(1, 9);
// string ale2 = aleatorio2.ToString();

// int aleatorio3 = random.Next(1, 9);
// string ale3 = aleatorio3.ToString();

// string result = ale1 + ale2 + ale3;

// string[] partes = nome.Split(' ');
// Console.WriteLine("");

// Console.WriteLine($"Seu email é: " + partes[0] + "." + partes[4] + result + "@fatec.sp.gov.br");
// Console.ReadKey();

// Random senha = new Random();

// int n1 = random.Next(1,20); 
// string num1 = n1.ToString(); 

// int n2 = random.Next(1,20); 
// string num2 = n2.ToString();

// int n3 = random.Next(1,20); 
// string num3 = n3.ToString();

// int n4 = random.Next(1,20); 
// string num4 = n4.ToString();

// string resultado = num1 + num2 + num3 + num4;

// Console.WriteLine("Senha provisória: " + resultado);
// Console.ReadKey();