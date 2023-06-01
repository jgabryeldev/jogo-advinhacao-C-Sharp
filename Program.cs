Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
int contador = 0;
int chute = 0;
void jogo()
{
    Console.Write("Digite seu chute: ");
    chute = int.Parse(Console.ReadLine());
    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns você acertou!");
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("Seu chute foi menor que o número secreto");
        contador++;
    }
    else if (chute > numeroSecreto)
    {
        Console.WriteLine("Seu chute foi maior que o número secreto");
        contador++;
    }
}

Console.WriteLine("Escolha um nível de dificuldade - (1)Fácil (2)Dificil: ");
    int opcao = int.Parse(Console.ReadLine());
    switch(opcao)
    {
        case 1:
            
            
        do
        {
            jogo();
        } while (contador != 20 || chute==numeroSecreto);
        Console.WriteLine("Muito obrigado pela interação! Até a próxima!");
        break;
        case 2:
        do
        {
            jogo();
        }while(contador!=10 || chute==numeroSecreto);
        Console.WriteLine("Muito obrigado pela interação! Até a próxima!");
        break;
    }
   
   