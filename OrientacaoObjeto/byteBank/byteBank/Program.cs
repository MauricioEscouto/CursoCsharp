using System;
using byteBank;

Console.WriteLine("Boas-vindas ao banco ByteBank\n");

contaCorrente conta1 = new contaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

contaCorrente conta2 = new contaCorrente();
conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-X";
conta2.numero_agencia = 321;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome da Agencia: " + conta1.nome_agencia);
Console.WriteLine("Saldo: " + conta1.saldo);



