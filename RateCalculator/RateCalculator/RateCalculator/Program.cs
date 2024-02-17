
//RUH é elegível se dentro da diferença das datas de check in e criação - a diferença de 0 (hoje) a 6 dias


Console.WriteLine("## Vamos calcular o valor das Reservas ##\n");
Console.WriteLine(" * Menu de Opções * \n");
Console.WriteLine("Digite 1 -> Reservas Padrão");
Console.WriteLine("Digite 2 ->  Preencher os dados");

string opcao = Console.ReadLine();

double descontoDDE4 = 0.95;
double descontoDDE7 = 0.90;
double descontoDDE10 = 0.85;
double descontoRUH = 0.90;
double tarifaEvento = 0;
int noitesEvento = 0;

if (opcao == "2")
{
    Console.WriteLine("\nDigite a porcentagem do desconto para DDE 4 noites: %");
    descontoDDE4 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a porcentagem do desconto para DDE 7 noites: %");
    descontoDDE7 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a porcentagem do desconto para DDE 10 noites: %");
    descontoDDE10 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a porcentagem do desconto para RUH: %");
    descontoRUH = double.Parse(Console.ReadLine());
}

Console.WriteLine("\n-> Tem diárias de eventos? \nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
string temEvento = Console.ReadLine();
if (temEvento == "1")
{
    Console.WriteLine("Digite o número de noites do pacote evento: ");
    noitesEvento = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a tarifa do Evento: R$");
    tarifaEvento = double.Parse(Console.ReadLine());
}

double totalEvento = tarifaEvento * noitesEvento;

Console.WriteLine("Digite a quantidade de noites durante a semana: ");
int noitesSemana = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da Diária Durante a Semana: R$");
double diariaSemana = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de noites de fim de semana: ");
int noitesFimSemana = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da Diária Fim de Semana: R$");
double diariaFimSemana = double.Parse(Console.ReadLine());

double valorBruto = (noitesSemana * diariaSemana) + (noitesFimSemana * diariaFimSemana);


int totalNoites = noitesSemana + noitesFimSemana + noitesEvento;


Console.WriteLine($"\n Total de Noites: {totalNoites}");
Console.WriteLine($"\n Total atual: R$ {valorBruto + totalEvento}\n");

if (totalNoites >= 4 && totalNoites < 7)
{
    Console.WriteLine("-> Tem DDE de 4 noites? \nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
    string temDDE4 = Console.ReadLine();
    if (temDDE4 == "1") valorBruto *= descontoDDE4;
}
else if (totalNoites >= 7 && totalNoites < 10)
{
    Console.WriteLine("-> Tem DDE de 7 noites? \nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
    string temDDE7 = Console.ReadLine();
    if (temDDE7 == "1") valorBruto *= descontoDDE7;
}
else if (totalNoites >= 10)
{
    Console.WriteLine("-> Tem DDE de 10 noites? \nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
    string temDDE10 = Console.ReadLine();
    if (temDDE10 == "1") valorBruto *= descontoDDE10;
}


valorBruto += totalEvento;


Console.WriteLine("-> Tem RUH? \nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
string temRUH = Console.ReadLine();
if (temRUH == "1") valorBruto *= descontoRUH;


Console.WriteLine($"\n -> VALOR BRUTO DA RESERVA: R$ {valorBruto}\n");

Console.WriteLine("Deseja Calcular o Valor Líquido da Reserva?\nDigite 1 - Para SIM ou Qualquer tecla para NÃO");
string calcularLiquido = Console.ReadLine();

if (calcularLiquido == "1")
{
    Console.WriteLine("Digite a porcentagem de comissão: %");
    double comissao = double.Parse(Console.ReadLine());
    double valorLiquido = valorBruto - (valorBruto * (comissao / 100));
    Console.WriteLine($"\n -> VALOR LÍQUIDO DA RESERVA: R$ {valorLiquido}\n");
}


