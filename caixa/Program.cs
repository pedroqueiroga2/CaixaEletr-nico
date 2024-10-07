StreamWriter blocoN = new StreamWriter("C:\\Users\\Alunos\\Downloads\\caixa\\histórico.txt");

Random x = new Random();
int y = x.Next(1, 10000);
int saldo = y;
float total = 0;
Console.Clear();

Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine().ToLower();

Console.WriteLine("Qual o tipo da sua conta?");
string conta = Console.ReadLine().ToLower();


Console.WriteLine("deseja verificar o saldo?");
string vsaldo = Console.ReadLine().ToLower();

if (vsaldo == "sim" || vsaldo == "s")
{
    Console.WriteLine($"seu saldo é de R$ {saldo}");
    Console.WriteLine($"deseja prosseguir ou cancelar?");
    string deseja = Console.ReadLine().ToLower();
    if (deseja == "cancelar")
    {
        Console.WriteLine($"operação encerrada.");
    }
}
else
{ }
string extrato = "";

r:


continua:
Console.WriteLine("deseja sacar ou depositar?");
string sd = Console.ReadLine().ToLower();

if (sd == "sacar")
{
    Console.WriteLine($"Quanto você deseja sacar?\n (seu saldo é de {saldo})");
    int.TryParse(Console.ReadLine(), out int valor);
    {
        if (valor <= saldo)
        {
            total = saldo - valor;
            Console.WriteLine($"valor de R$ {valor} foi debitado da sua conta.\nSeu saldo agora é de {total}");
            extrato += $"==========\n-{valor}\nsaldo atual = {total}\n==========\n";
            
            Console.WriteLine("Deseja realizar mais alguma transferência? (s/n)");
            string verif = Console.ReadLine().ToLower();
            if (verif == "s")
            {   
                Console.WriteLine("deseja sacar ou depositar?");
                sd = Console.ReadLine().ToLower();
                if (sd == "sacar")
                {   
                     outrovalor:
                    Console.WriteLine($"Quanto você deseja sacar?\n (seu saldo é de {total})");
                    int.TryParse(Console.ReadLine(), out valor);
                    if (valor <= total)
                    {
                        total -= valor;
                        Console.WriteLine($"valor de R$ {valor} foi debitado da sua conta.\nSeu saldo agora é de {total}");
                        extrato += $"==========\n-{valor}\nsaldo atual = {total}\n==========\n";
                        Console.WriteLine("Deseja realizar mais alguma transferência? (s/n)");
                         verif = Console.ReadLine().ToLower();
                        if (verif == "s")
                        {
                            goto continua;
                        }
                        else
                        {
                            Console.WriteLine("Operação encerrada.");
                            
                        }
                        
                    }
                    else
                        {
                           Console.WriteLine("Saldo insuficiente, informe outro valor");
                           goto outrovalor; 
                        }

                }
                else
                {
                    
                }
            }
            else
            {
                Console.WriteLine($"Você não pode debitar esse valor, pois o saldo é insuficiente.");
            }
        }
    }
}
else if (sd == "depositar")
    {
        
        Console.WriteLine($"Quanto você deseja depositar?\n (seu saldo atual é de {saldo})");
        int.TryParse(Console.ReadLine(), out int valor);
        {
            total = valor + saldo;
            Console.WriteLine($"Valor de R$ {valor} creditado na sua conta.\n (seu saldo atual é de {total}");
            extrato += $"==========\n+{valor}\nsaldo atual = {total}\n==========\n";
            
            Console.WriteLine($"Deseja realizar outra operação?");
            string verif = Console.ReadLine().ToLower();
            if (verif == "s")
            {   
                Console.WriteLine("deseja sacar ou depositar?");
                sd = Console.ReadLine().ToLower();
                if (sd == "depositar")
                {   
                     outrovalor:
                    Console.WriteLine($"Quanto você deseja depositar?\n (seu saldo é de {total})");
                    int.TryParse(Console.ReadLine(), out valor);
                    if (valor <= total)
                    {
                        total += valor;
                        Console.WriteLine($"valor de R$ {valor} foi debitado da sua conta.\nSeu saldo agora é de {total}");
                        extrato += $"==========\n+{valor}\nsaldo atual = {total}\n==========\n";
                        Console.WriteLine("Deseja realizar mais alguma transferência? (s/n)");
                         verif = Console.ReadLine().ToLower();
                        if (verif == "s")
                        {
                            goto continua;
                        }
                        else
                        {
                            Console.WriteLine("Operação encerrada.");
                            
                        }
                        
                    }
                    else
                        {
                           Console.WriteLine("Saldo insuficiente, informe outro valor");
                           goto outrovalor; 
                        }

                }
                else
                {
                    goto continua;
                }
            }
            else
            {
                Console.WriteLine($"Você não pode debitar esse valor, pois o saldo é insuficiente.");
            }
            
        }
    }
    else
    {
        Console.WriteLine("o sistema não compreendeu a sua resposta, informe-a novamente.");
        goto r;
    }
    Console.WriteLine(extrato);
    blocoN.WriteLine($"{nome}; {conta}; saldo: {saldo}; novo saldo: {total};");
    blocoN.Close();




