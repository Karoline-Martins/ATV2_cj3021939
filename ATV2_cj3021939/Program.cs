float salario;

//Leitura do salario
Console.WriteLine("Entre com seu salário:");
salario = float.Parse( Console.ReadLine() );

salario = salario + (float) (25.0f / 100.0f) * salario;


Console.WriteLine("o novo salário é R$ {0} ", salario);
    

