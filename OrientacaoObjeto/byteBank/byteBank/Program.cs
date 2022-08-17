using System;
using byteBank;

Console.WriteLine("Boas-vindas ao banco ByteBank\n");

ContaCorrente conta1 = new ContaCorrente();
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.conta = "10106-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);


//Console.WriteLine("Saldo da Amanda pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André  pré- Transferência: " + conta1.saldo);
//conta1.Transferir(50, conta2);
//Console.WriteLine("Saldo da Amanda pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do André pós-transferência: " + conta1.saldo);

Cliente cliente = new Cliente();
cliente.nome = "Andre Silva";
cliente.cpf = "10253541263";
cliente.profissao = "Programador C#";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente;



