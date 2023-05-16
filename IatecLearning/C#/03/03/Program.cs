using Projeto;


Cartao cartao = new Cartao("Matheus", "123456789", 5, 1000M, 1500M, true, DateTime.Now.AddYears(5));

cartao.AlterarNomeProprietario("Victor");
cartao.Debitar(100M);