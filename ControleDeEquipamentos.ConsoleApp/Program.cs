using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEquipamentos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Requisitos Do Sistema
            /*1.Controle de Equipamentos
             * Requisito 1.1: Como funcionário, Junior quer ter a possibilidade registrar equipamentos 
             * Deve ter um nome com no mínimo 6 caracteres;  
             * Deve ter um preço de aquisição;  
             * Deve ter um número de série; 
             * Deve ter uma data de fabricação; 
             * Deve ter uma fabricante;*/
            #endregion
            string opcao = "";
          
            const int CAPACIDADE_REGISTROS = 100;

            int[] numerosEquipamento = new int[CAPACIDADE_REGISTROS];

            string[] nomesEquipamento = new string[CAPACIDADE_REGISTROS];

            double[] precosEquipamento = new double[CAPACIDADE_REGISTROS];

            int [] numeroDeSerieEquipamento = new int[CAPACIDADE_REGISTROS];

            DateTime[] datasFabricacaoEquipamento = new DateTime[CAPACIDADE_REGISTROS];

            string[] FabricantesEquipamento = new string[CAPACIDADE_REGISTROS];

            while (true)
            {
                Console.WriteLine("---------Controle De Equipamentos---------");

                Console.WriteLine("                                         +");

                Console.WriteLine("1 - Cadastrar Novo Equipamento           +");

                Console.WriteLine("2 - Mostrar Equipamentos Cadastrados     +");

                Console.WriteLine("3- Editar Equipamento Cadastrado         +");

                Console.WriteLine("4 - Deletar Equipamento Cadastrado       +");

                Console.WriteLine("5 - Opções de chamado de manutenção      +");

                Console.WriteLine("S - para sair                            +");

                Console.WriteLine("------------------------------------------");

                opcao = Console.ReadLine();

                if (opcao != "1" && opcao != "2" && opcao != "3"
                    && opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s")
                {
                  Console.WriteLine("Opção Inválida! Tente novamente.");
                  Console.ReadLine();
                  Console.Clear();
                  continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

              
                switch (opcao)
                {
                    case "1":
                        
                        bool nomeInvalido = false;
                        string nome;
                        int contadorEquipamentos = 0;

                        int numero = 0;
                        do
                        {
                            Console.Write("Digite o nome do equipamento: ");
                            nome = Console.ReadLine();
                            if (nome.Length < 6)
                            {
                                nomeInvalido = true;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Nome invalido. No minimo 6 caracteres");
                                Console.ResetColor(); ;
                            }
                        } while (nomeInvalido);

                        Console.Write("Digite o preço do equipamento: ");
                        double preco = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Digite o numero de série equipamento: ");
                        int numSerie = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Digite a data de fabricação do equipamento:  ");
                        DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                        Console.Write("Digite o fabricante do equipamento: ");
                        string fabricante = Console.ReadLine();

                        numerosEquipamento[contadorEquipamentos] = numero;
                        nomesEquipamento[contadorEquipamentos] = nome;
                        precosEquipamento[contadorEquipamentos] = preco;
                        numeroDeSerieEquipamento[contadorEquipamentos] = numSerie;
                        datasFabricacaoEquipamento[contadorEquipamentos] = dataFabricacao;
                        FabricantesEquipamento[contadorEquipamentos] = fabricante;

                        contadorEquipamentos = contadorEquipamentos + 1;
                        numero = numero + 1;
                        break;

                    case "2":
                        
                        Console.WriteLine("Equipamentos já registrados no sistema...");
                        
                        for (contadorEquipamentos = 0; contadorEquipamentos < CAPACIDADE_REGISTROS; contadorEquipamentos++)
                        {
                           
                            Console.WriteLine();
                            Console.WriteLine("Numero do equipamento:", numerosEquipamento[contadorEquipamentos] );
                            Console.WriteLine("Nome do equipamento:", nomesEquipamento[contadorEquipamentos]);
                            Console.WriteLine("Preço equipamento:", precosEquipamento[contadorEquipamentos]);
                            Console.WriteLine("Numero de série equipamento:", numeroDeSerieEquipamento[contadorEquipamentos]);
                            Console.WriteLine("Data de fabricação:", datasFabricacaoEquipamento[contadorEquipamentos]);
                            Console.WriteLine("Preço equipamento:", FabricantesEquipamento[contadorEquipamentos]);
                            Console.WriteLine();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Editando equipamentos...\n");

                        //VisualizarEquipamentos();

                        Console.Write("Digite o número de equipamento que deseja alterar: ");

                        int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < CAPACIDADE_REGISTROS; i++)
                        {
                            if (nomesEquipamento[i] != null && numerosEquipamento[i] == numerosEquipamento)
                            {
                                RegistrarEquipamento(i, numeroSelecionado);
                            }
                        }
                        Console.WriteLine("Equipamento editado com sucesso!! \n");
                        break;
                   
                    case "4":
                        Console.WriteLine("Excluindo equipamentos...\n");

                        VisualizarEquipamentos();

                        Console.Write("Digite o número do equipamento que deseja excluir: ");

                        int numeroSelecionado = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < CAPACIDADE_REGISTROS; i++)
                        {
                            if (nomesEquipamento[i] != null && numerosEquipamento[i] == numeroSelecionado)
                            {
                                numerosEquipamento[i] = 0;
                                nomesEquipamento[i] = null;
                                precosEquipamento[i] = 0;
                                datasFabricacaoEquipamento[i] = DateTime.MinValue;
                                FabricantesEquipamento[i] = null;
                            }
                        }
                        Console.WriteLine("Equipamento excluido com sucesso!! \n");
                        break;

                    default:
                        break;
                }


            }


/*-------------------------------------------------------------------------------*/
        }
    }
}
