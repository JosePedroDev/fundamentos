using fundamentos.Models;

ContaCorrente conta1 = new ContaCorrente(123, 1000);
conta1.ExibirSaldo();
conta1.Sacar(5000);
conta1.ExibirSaldo();

