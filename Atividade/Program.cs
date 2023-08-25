using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informe o Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe o Endereço: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine(@"Informe o Tipo:
            
            1 - Pessoa Física (PF)
            2 - Pessoa Jurídica (PJ)

            ");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "1") //PF
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informe o CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informe o Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("--------- Pessoa Física ---------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereco);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar  :" + pf.total.ToString("C"));
            }
            if(var_tipo == "2") //PJ
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe o IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);

                Console.WriteLine("--------- Pessoa Jurídica ---------");
                Console.WriteLine("Nome ..........: " + pj.nome);
                Console.WriteLine("Endereço ......: " + pj.endereco);
                Console.WriteLine("CNPJ ..........: " + pj.cnpj);
                Console.WriteLine("IE ............: " + pj.ie);
                Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar  : " + pj.total.ToString("C"));
            }
        }
    }
}