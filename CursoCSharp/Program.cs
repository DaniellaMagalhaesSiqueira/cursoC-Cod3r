using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentario.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},


                {"Conversões - Estrutura de Controle", EstruturaIf.Executar},

                {"Membros - Classes E Métodos", Membros.Executar},
                {"Construtores - Classes E Métodos", Construtores.Executar},
                {"Desafio Atributo - Classes E Métodos", DesafioAtributo.Executar},
                {"Parâmetros Variáveis - Classes E Métodos", ParametrosVariaveis.Executar},
                {"Parâmetros Nomeados - Classes E Métodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes E Métodos", Props.Executar},
                {"Atributos Read Only - Classes E Métodos", ReadOnly.Executar},
                {"Exemplo de Enum - Classes E Métodos", ExemploEnum.Executar},
                {"Struct - Classes E Métodos", ExemploStruct.Executar},
                {"Struct Vs Classe - Classes E Métodos", StructVsClasse.Executar},
                {"Parâmetros por Refrência - Classes E Métodos", ParametrosReferencia.Executar},


                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Conjunto - Coleções", ColecoesSet.Executar},
                {"Queue - Fila -Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Pilha (Contrário de Fila - FILO) - Coleções", ColecoesStack.Executar},
                {"Dicionario (Dictionary) - Coleções", ColecoesDicionario.Executar},
                
                
                
                {"Herença - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar},
                {"Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientação a Objetos", Abstract.Executar},
                {"Interface - Orientação a Objetos", Interface.Executar},
                {"Sealed Classe Estéril - Orientação a Objetos", Sealed.Executar},


                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas como Delegate - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate como funcções anônimas - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegate como parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},


                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},


                {"Primeiro Arquivo usando API - API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos usando API - API", LendoArquivos.Executar},
                {"Exemplo FileInfo usando API - API", ExemploFileInfo.Executar},
                {"Diretórios usando API - API", Diretorios.Executar},
                {"Exemplo de DirectoryInfo usando API - API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path usando API - API", ExemploPath.Executar},
                {"Exemplo DateTime usando API - API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan usando API - API", ExemploTimeSpan.Executar},


                {"LINQ1 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}