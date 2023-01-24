using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola1
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;

        //Estrutura para criar um caminho relativo no Banco de dados
        // O caminho relativo "System.Evironment.CurrentDirecto" leva até bin/debug
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_de_dados_escola.db";
        public static string caminhoBanco = caminho + "\\banco\\" + nomeBanco;

    }
}
